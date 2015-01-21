' -----------------------------------------------------------------------
'    This file is part of TSGE.
'
'    TSGE is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    TSGE is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with TSGE.  If not, see <http://www.gnu.org/licenses/>.
' -----------------------------------------------------------------------

Imports TSGE.Classes
Imports TSGE.Comparers
Imports TSGE.Controls
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Xml.Linq

Public Partial Class frmMain
    Inherits Form
    ''' <summary>
    ''' Tooltip object to attach helpful text to controls.
    ''' </summary>
    Private ReadOnly m_Tooltip As ToolTip

    ''' <summary>
    ''' The current player object being edited.
    ''' </summary>
    Public Property Player() As Player
        Get
            Return m_Player
        End Get
        Set
            m_Player = Value
        End Set
    End Property
    Private m_Player As Player

    ''' <summary>
    ''' Internal list of all inventory item labels.
    ''' </summary>
    Private ReadOnly m_InventoryLabels As List(Of ItemLabel)

    ''' <summary>
    ''' Internal list of all equipment item labels.
    ''' </summary>
    Private ReadOnly m_EquipmentLabels As List(Of ItemLabel)

    ''' <summary>
    ''' Internal list of all bank and safe item labels.
    ''' </summary>
    Private ReadOnly m_BankSafeLabels As List(Of ItemLabel)

    ''' <summary>
    ''' The currently selected inventory item.
    ''' </summary>
    Public m_SelectedInventoryItem As Label

    ''' <summary>
    ''' The currently selected equipment item.
    ''' </summary>
    Public m_SelectedEquipmentItem As Label

    ''' <summary>
    ''' The currently selected bank/safe item.
    ''' </summary>
    Public m_SelectedBankSafeItem As Label

    ''' <summary>
    ''' Default Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        ' Set the default size..
        Me.Width = DpiHelper.ScaleAsDpi(628)
        Me.Height = DpiHelper.ScaleAsDpi(493)

        ' Initialize the Terraria class..
        Terraria.Instance.Initialize()

        ' Set data source to various lists..
        Me.lstBuffSelection.DataSource = Terraria.Instance.Buffs
        Me.lstInventoryItems.DataSource = Terraria.Instance.Items
        Me.lstBankSafeItems.DataSource = Terraria.Instance.Items
        Me.cboInventoryPrefix.DataSource = Terraria.Instance.Prefixes
        Me.cboEquipmentPrefix.DataSource = Terraria.Instance.Prefixes
        Me.cboBankSafePrefix.DataSource = Terraria.Instance.Prefixes

        ' Initialize tooltip object..
        Me.m_Tooltip = New ToolTip()

        ' Initialize internal item label lists..
        Me.m_InventoryLabels = New List(Of ItemLabel)()
        Me.m_EquipmentLabels = New List(Of ItemLabel)()
        Me.m_BankSafeLabels = New List(Of ItemLabel)()

        Dim nullItemIcon = New Bitmap(Application.StartupPath & "\Data\Items\item_0.png")
        Dim nullItemName = Terraria.Instance.Items.[Single](Function(i) i.NetID = 0).ToString()

        ' Prepare inventory item label list..
        For x As Int16 = 0 To 57
            ' Find the label..
            Dim label = DirectCast(Me.Controls.Find(String.Format("inventoryItem{0:d2}", x), True)(0), ItemLabel)
            Me.m_InventoryLabels.Add(label)

            ' Update the label defaults..
            label.Image = nullItemIcon
            label.Text = "0"
            label.Tag = x

            ' Set the default tooltip..
            Me.m_Tooltip.SetToolTip(label, nullItemName)
        Next

        ' Prepare equipment item label list..
        For x As Int16 = 0 To 23
            ' Find the label..
            Dim label = DirectCast(Me.Controls.Find(String.Format("equipmentItem{0:d2}", x), True)(0), ItemLabel)
            Me.m_EquipmentLabels.Add(label)

            ' Update the label defaults.
            label.ShowItemCount = False
            label.Image = nullItemIcon
            label.Text = ""
            label.Tag = x

            ' Set the default tooltip..
            Me.m_Tooltip.SetToolTip(label, nullItemName)
        Next

        ' Prepare the bank/safe label list..
        For x As Int16 = 0 To 79
            ' Find the label..
            Dim label = DirectCast(Me.Controls.Find(String.Format("bankSafeItem{0:d2}", x), True)(0), ItemLabel)
            Me.m_BankSafeLabels.Add(label)

            ' Update the label defaults..
            label.Image = nullItemIcon
            label.Text = "0"
            label.Tag = x

            ' Set the default tooltip..
            Me.m_Tooltip.SetToolTip(label, nullItemName)
        Next

        ' Initialize the default player object..
        Me.modelViewer.SuspendModelUpdates()
        Me.Player = New Player() 'With { _
        '    Key EyeColor = InlineAssignHelper(Me.pbEyesColor.BackColor, Color.FromArgb(255, 105, 90, 75)), _
        '    Key HairColor = InlineAssignHelper(Me.pbHairColor.BackColor, Color.FromArgb(255, 215, 90, 55)), _
        '    Key SkinColor = InlineAssignHelper(Me.pbSkinColor.BackColor, Color.FromArgb(255, 255, 125, 75)), _
        '    Key PantsColor = InlineAssignHelper(Me.pbPantsColor.BackColor, Color.FromArgb(255, 255, 230, 175)), _
        '    Key ShirtColor = InlineAssignHelper(Me.pbShirtColor.BackColor, Color.FromArgb(255, 175, 165, 140)), _
        '    Key ShoesColor = InlineAssignHelper(Me.pbShoesColor.BackColor, Color.FromArgb(255, 160, 106, 60)), _
        '    Key UndershirtColor = InlineAssignHelper(Me.pbUndershirtColor.BackColor, Color.FromArgb(255, 160, 180, 215)) _
        '}

        ' Set the binding object data source..
        playerBindingSource.DataSource = Me.Player
        Me.modelViewer.ResumeModelUpdates()
    End Sub

    ''' <summary>
    ''' Creates a filtered item list.
    ''' </summary>
    ''' <param name="nameFilter"></param>
    ''' <param name="categoryFilter"></param>
    ''' <returns></returns>
    Private Shared Function CreateFilteredItemList(nameFilter As String, categoryFilter As Integer) As IEnumerable(Of Item)
        ' Should we filter by name first..?
        Dim items = Terraria.Instance.Items
        If Not String.IsNullOrEmpty(nameFilter) Then
            items = items.Where(Function(i) i.Name.ToLower().Contains(nameFilter.ToLower()) OrElse i.NetID = 0).ToList()
        End If

        ' Next filter by category..
        Select Case categoryFilter
            Case 0
                ' All
                Exit Select
            Case 1
                ' Armor / Social Gear
                If True Then
                    items = items.Where(Function(i) i.WornArmor OrElse i.Social OrElse i.Vanity OrElse i.HeadSlot > -1 OrElse i.BodySlot > -1 OrElse i.LegSlot > -1 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 2
                ' Accessories
                If True Then
                    items = items.Where(Function(i) i.Accessory OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 3
                ' Ammunition
                If True Then
                    items = items.Where(Function(i) i.Ammo > 0 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 4
                ' Building Objects
                If True Then
                    items = items.Where(Function(i) i.HeadSlot <= 0 AndAlso i.BodySlot <= 0 AndAlso i.LegSlot <= 0 AndAlso i.Ammo <= 0 AndAlso i.Material OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 5
                ' Consumables
                If True Then
                    items = items.Where(Function(i) i.Consumable OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 6
                ' Money
                If True Then
                    items = items.Where(Function(i) i.Name.ToLower().Contains("coin") OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 7
                ' Tools
                If True Then
                    items = items.Where(Function(i) i.Axe > 0 OrElse i.Hammer > 0 OrElse i.Pick > 0 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            Case 8
                ' Weapons
                If True Then
                    items = items.Where(Function(i) i.HeadSlot <= 0 AndAlso i.BodySlot <= 0 AndAlso i.LegSlot <= 0 AndAlso i.Ammo <= 0 AndAlso Not i.WornArmor AndAlso Not i.Accessory AndAlso Not i.Social AndAlso Not i.Vanity AndAlso Not i.Consumable OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
        End Select

        ' Return the filtered list..
        Return items
    End Function

    ''' <summary>
    ''' Creates a filtered item prefix list.
    ''' </summary>
    ''' <param name="categoryFilter"></param>
    ''' <returns></returns>
    Private Shared Function CreateFilteredPrefixList(categoryFilter As Integer) As IEnumerable(Of ItemPrefix)
        ' Filter the prefix list..
        Dim items = Terraria.Instance.Prefixes
        Select Case categoryFilter
            Case 0
                ' All
                Exit Select
            Case 1
                ' Universal
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 0).ToList()
                Exit Select
            Case 2
                ' Common
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 1).ToList()
                Exit Select
            Case 3
                ' Melee
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 2).ToList()
                Exit Select
            Case 4
                ' Ranged
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 3).ToList()
                Exit Select
            Case 5
                ' Magic
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 4).ToList()
                Exit Select
            Case 6
                ' Accessories
                items = items.Where(Function(i) i.Category = -1 OrElse i.Category = 5).ToList()
                Exit Select
        End Select

        Return items
    End Function

    ''' <summary>
    ''' Updates the selected equipment label with the given item info.
    ''' </summary>
    ''' <param name="label"></param>
    ''' <param name="item"></param>
    Private Sub UpdateEquipmentLabel(label As ItemLabel, item As Item)
        label.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_Tooltip.SetToolTip(label, item.ToString())
    End Sub

    ''' <summary>
    ''' Refreshes the non-bound UI items.
    ''' </summary>
    Private Sub RefreshLoadedPlayer()
        ' Update the inventory..
        For Each label As Windows.Forms.Label In Me.m_InventoryLabels
            label.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, Me.Player.Inventory(CInt(label.Tag)).NetID))
            label.Text = Me.Player.Inventory(CInt(label.Tag)).Count.ToString()
            Me.m_Tooltip.SetToolTip(label, Me.Player.Inventory(CInt(label.Tag)).ToString())
        Next

        ' Update the equipment..
        UpdateEquipmentLabel(Me.m_EquipmentLabels(0), Me.Player.Armor(0))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(1), Me.Player.Armor(1))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(2), Me.Player.Armor(2))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(3), Me.Player.Vanity(0))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(4), Me.Player.Vanity(1))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(5), Me.Player.Vanity(2))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(6), Me.Player.Dye(0))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(7), Me.Player.Dye(1))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(8), Me.Player.Dye(2))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(9), Me.Player.Dye(3))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(10), Me.Player.Dye(4))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(11), Me.Player.Dye(5))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(12), Me.Player.Dye(6))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(13), Me.Player.Dye(7))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(14), Me.Player.Accessories(0))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(15), Me.Player.Accessories(1))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(16), Me.Player.Accessories(2))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(17), Me.Player.Accessories(3))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(18), Me.Player.Accessories(4))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(19), Me.Player.SocialAccessories(0))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(20), Me.Player.SocialAccessories(1))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(21), Me.Player.SocialAccessories(2))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(22), Me.Player.SocialAccessories(3))
        UpdateEquipmentLabel(Me.m_EquipmentLabels(23), Me.Player.SocialAccessories(4))

        ' Update the bank/safe..
        For x As Int16 = 0 To Me.m_BankSafeLabels.Count - 1
            ' Update the item label..
            Dim item = If((x < 40), Me.Player.Bank1(x), Me.Player.Bank2(x - 40))
            Me.m_BankSafeLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_BankSafeLabels(x).Text = Item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_BankSafeLabels(x), item.ToString())
        Next
    End Sub

    #Region "==> Menu Command Handlers"

    ''' <summary>
    ''' Fills the quick-select character box with known profiles.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tscboQuickSelect_DropDown(sender As Object, e As EventArgs)
        ' Clear the current items..
        Me.tscboQuickSelect.Items.Clear()

        ' Find all current profiles..
        Dim dir = New DirectoryInfo(Terraria.ProfilePath)
        Dim files = dir.GetFiles("*.plr").OrderBy(Function(f) f, New NaturalFileInfoNameComparer())

        ' Insert each file into the combobox..
        For Each f As Path In files
            Dim name = Terraria.Instance.GetProfileName(f.GetFullPath(f.ToString))
            If String.IsNullOrEmpty(name) Then
                name = f.GetFileNameWithoutExtension(f.ToString)
            End If
            Me.tscboQuickSelect.Items.Add(String.Format("{0} -- {1}", name, f.GetFileNameWithoutExtension(f.ToString)))
        Next
    End Sub

    ''' <summary>
    ''' Attempts to load the quick-selected character.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tscboQuickSelect_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Attempt to get the file name from the list..
        Dim selectedItem = Me.tscboQuickSelect.SelectedItem
        Dim PlayerFile = selectedItem.ToString().Split({" -- "}, StringSplitOptions.RemoveEmptyEntries)(1)

        If String.IsNullOrEmpty(PlayerFile) Then
            Return
        End If

        ' Attempt to load the profile..
        Me.Player = Terraria.Instance.LoadProfile(String.Format("{0}\{1}", Terraria.ProfilePath, PlayerFile))
        If Me.Player Is Nothing Then
            Me.Player = New Player()
            Me.playerBindingSource.DataSource = Me.Player
            Me.modelViewer.UpdateTextures()
            Return
        End If

        Me.Player.File = String.Format("{0}\{1}", Terraria.ProfilePath, PlayerFile)
        Me.playerBindingSource.DataSource = Me.Player
        Me.modelViewer.UpdateTextures()
        Me.RefreshLoadedPlayer()
    End Sub

    ''' <summary>
    ''' Creates a new player profile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub newCharacterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Player = New Player()
        Me.playerBindingSource.DataSource = Me.Player
        Me.RefreshLoadedPlayer()
    End Sub

    ''' <summary>
    ''' Opens an existing profile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub openToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using ofd = New OpenFileDialog()
            ofd.AddExtension = True
            ofd.CheckFileExists = True
            ofd.CheckPathExists = True
            ofd.DefaultExt = "plr"
            ofd.Filter = "Terraria Player Files (*.plr)|*.plr|All files (*.*)|*.*"
            ofd.InitialDirectory = Terraria.ProfilePath
            ofd.ValidateNames = True

            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            ' Load the profile..
            Me.Player = Terraria.Instance.LoadProfile(ofd.FileName)
            If Me.Player Is Nothing Then
                Me.Player = New Player()
                Me.playerBindingSource.DataSource = Me.Player
                Me.modelViewer.UpdateTextures()
                Return
            End If

            Me.Player.File = ofd.FileName
            Me.playerBindingSource.DataSource = Me.Player
            Me.modelViewer.UpdateTextures()
            Me.RefreshLoadedPlayer()
        End Using
    End Sub

    ''' <summary>
    ''' Saves a profile to its known location.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub saveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Execute save-as if we have no file..
        If String.IsNullOrEmpty(Me.Player.File) Then
            saveAsToolStripMenuItem_Click(sender, e)
            Return
        End If

        ' Save the profile..
        Terraria.Instance.SaveProfile(Me.Player, Me.Player.File)
    End Sub

    ''' <summary>
    ''' Saves a profile to the selected location.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub saveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using sfd = New SaveFileDialog()
            sfd.AddExtension = True
            sfd.CheckPathExists = True
            sfd.DefaultExt = "plr"
            sfd.Filter = "Terraria Player Files (*.plr)|*.plr|All files (*.*)|*.*"
            sfd.InitialDirectory = Terraria.ProfilePath
            sfd.ValidateNames = True

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            ' Save the profile..
            Me.Player.File = sfd.FileName
            Terraria.Instance.SaveProfile(Me.Player, Me.Player.File)
        End Using
    End Sub

    ''' <summary>
    ''' Exits this appliction.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Displays the about form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub aboutTSGEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using aboutForm = New frmAbout()
            aboutForm.ShowDialog()
        End Using
    End Sub

    #End Region

    #Region "==> Player Tab"

    ''' <summary>
    ''' Adjusts the hair color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbHairColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbHairColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.HairColor = InlineAssignHelper(Me.modelViewer.HairColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the skin color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbSkinColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbSkinColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.SkinColor = InlineAssignHelper(Me.modelViewer.HandsColor, InlineAssignHelper(Me.modelViewer.HeadColor, cdlg.Color))
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the eyes color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbEyesColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbEyesColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.EyeColor = InlineAssignHelper(Me.modelViewer.EyeColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the shirt color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbShirtColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbShirtColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.ShirtColor = InlineAssignHelper(Me.modelViewer.ShirtColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the undershirt color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbUndershirtColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbUndershirtColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.UndershirtColor = InlineAssignHelper(Me.modelViewer.UndershirtColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the pants color
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbPantsColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbPantsColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.PantsColor = InlineAssignHelper(Me.modelViewer.PantsColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Adjusts the shoes color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbShoesColor_Click(sender As Object, e As EventArgs)
        Using cdlg = New ColorDialog()
            cdlg.Color = Me.pbShoesColor.BackColor
            If cdlg.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Me.Player.ShoesColor = InlineAssignHelper(Me.modelViewer.ShoesColor, cdlg.Color)
        End Using
    End Sub

    ''' <summary>
    ''' Opens the hair selector.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectHair_Click(sender As Object, e As EventArgs)
        Dim frmHair = New frmHairSelection()
        
        If frmHair.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Me.Player.Hair = frmHair.HairId
        Me.modelViewer.HairId = frmHair.HairId
        Me.modelViewer.UpdateTextures()
    End Sub

    ''' <summary>
    ''' Selects a random hair file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRandomHair_Click(sender As Object, e As EventArgs)
        Dim rand = New Random(CInt(DateTime.Now.Ticks))
        Dim hair = rand.[Next](0, 50)

        Me.Player.Hair = hair
        Me.modelViewer.HairId = hair
        Me.modelViewer.UpdateTextures()
    End Sub

    ''' <summary>
    ''' Selects random colors.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRandomColors_Click(sender As Object, e As EventArgs)
        Dim rand = New Random(CInt(DateTime.Now.Ticks))
        Dim btColors = New Byte(20) {}
        rand.NextBytes(btColors)

        Me.modelViewer.SuspendModelUpdates()
        Me.Player.HairColor = InlineAssignHelper(Me.modelViewer.HairColor, Color.FromArgb(255, btColors(0), btColors(1), btColors(2)))
        Me.Player.SkinColor = InlineAssignHelper(Me.modelViewer.HandsColor, InlineAssignHelper(Me.modelViewer.HeadColor, Color.FromArgb(255, btColors(3), btColors(4), btColors(5))))
        Me.Player.EyeColor = InlineAssignHelper(Me.modelViewer.EyeColor, Color.FromArgb(255, btColors(6), btColors(7), btColors(8)))
        Me.Player.ShirtColor = InlineAssignHelper(Me.modelViewer.ShirtColor, Color.FromArgb(255, btColors(9), btColors(10), btColors(11)))
        Me.Player.UndershirtColor = InlineAssignHelper(Me.modelViewer.UndershirtColor, Color.FromArgb(255, btColors(12), btColors(13), btColors(14)))
        Me.Player.PantsColor = InlineAssignHelper(Me.modelViewer.PantsColor, Color.FromArgb(255, btColors(15), btColors(16), btColors(17)))
        Me.Player.ShoesColor = InlineAssignHelper(Me.modelViewer.ShoesColor, Color.FromArgb(255, btColors(18), btColors(19), btColors(20)))
        Me.modelViewer.ResumeModelUpdates()
    End Sub

    ''' <summary>
    ''' Exports the current players hair type and colors.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveColorHair_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog()
        
        sfd.AddExtension = True
        sfd.CheckPathExists = True
        sfd.DefaultExt = "xml"
        sfd.Filter = "TSGE Hair and Color Files (*.xml)|*.xml|All files (*.*)|*.*"
        sfd.InitialDirectory = Application.StartupPath
        sfd.ValidateNames = True

        Dim ret = sfd.ShowDialog()
        If ret <> DialogResult.OK Then
            If ret = DialogResult.Cancel OrElse ret = DialogResult.Abort Then
                Return
            End If
            MessageBox.Show("Failed to save hair and color!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("HairColor"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save hair and color!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Add the hair id element..
        xml.Root.Add(New XElement("hair", New Object() {New XAttribute("id", Me.Player.Hair)}))

        ' Add the color elements..
        xml.Root.Add(New XElement("HairColor", New Object() {New XAttribute("a", Me.Player.HairColor.A), New XAttribute("r", Me.Player.HairColor.R), New XAttribute("g", Me.Player.HairColor.G), New XAttribute("b", Me.Player.HairColor.B)}))
        xml.Root.Add(New XElement("SkinColor", New Object() {New XAttribute("a", Me.Player.SkinColor.A), New XAttribute("r", Me.Player.SkinColor.R), New XAttribute("g", Me.Player.SkinColor.G), New XAttribute("b", Me.Player.SkinColor.B)}))
        xml.Root.Add(New XElement("EyeColor", New Object() {New XAttribute("a", Me.Player.EyeColor.A), New XAttribute("r", Me.Player.EyeColor.R), New XAttribute("g", Me.Player.EyeColor.G), New XAttribute("b", Me.Player.EyeColor.B)}))
        xml.Root.Add(New XElement("ShirtColor", New Object() {New XAttribute("a", Me.Player.ShirtColor.A), New XAttribute("r", Me.Player.ShirtColor.R), New XAttribute("g", Me.Player.ShirtColor.G), New XAttribute("b", Me.Player.ShirtColor.B)}))
        xml.Root.Add(New XElement("UndershirtColor", New Object() {New XAttribute("a", Me.Player.UndershirtColor.A), New XAttribute("r", Me.Player.UndershirtColor.R), New XAttribute("g", Me.Player.UndershirtColor.G), New XAttribute("b", Me.Player.UndershirtColor.B)}))
        xml.Root.Add(New XElement("PantsColor", New Object() {New XAttribute("a", Me.Player.PantsColor.A), New XAttribute("r", Me.Player.PantsColor.R), New XAttribute("g", Me.Player.PantsColor.G), New XAttribute("b", Me.Player.PantsColor.B)}))
        xml.Root.Add(New XElement("ShoesColor", New Object() {New XAttribute("a", Me.Player.ShoesColor.A), New XAttribute("r", Me.Player.ShoesColor.R), New XAttribute("g", Me.Player.ShoesColor.G), New XAttribute("b", Me.Player.ShoesColor.B)}))

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a hair type and color profile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadColorHair_Click(sender As Object, e As EventArgs)

        ' Ask what to open..
        Dim ofd = New OpenFileDialog()
        
        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.DefaultExt = "xml"
        ofd.Filter = "TSGE Hair and Color Files (*.xml)|*.xml|All files (*.*)|*.*"
        ofd.InitialDirectory = Application.StartupPath
        ofd.ValidateNames = True

        Dim ret = ofd.ShowDialog()
        If ret <> DialogResult.OK Then
            If ret = DialogResult.Cancel OrElse ret = DialogResult.Abort Then
                Return
            End If
            MessageBox.Show("Failed to open hair and color file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If


        Try
            ' Load the hair and color dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("HairColor")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            Dim element = root.Element("hair")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim hairId = Integer.Parse(element.Attribute("id").Value)

            element = root.Element("HairColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim hairColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("SkinColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim skinColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("EyeColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim eyeColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("ShirtColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim shirtColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("UndershirtColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim undershirtColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("PantsColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim pantsColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            element = root.Element("ShoesColor")
            If element Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If
            Dim shoesColor = Color.FromArgb(Integer.Parse(element.Attribute("a").Value), Integer.Parse(element.Attribute("r").Value), Integer.Parse(element.Attribute("g").Value), Integer.Parse(element.Attribute("b").Value))

            ' Update the player..
            Me.modelViewer.SuspendModelUpdates()
            Me.Player.Hair = hairId
            Me.Player.HairColor = hairColor
            Me.Player.SkinColor = skinColor
            Me.Player.EyeColor = eyeColor
            Me.Player.ShirtColor = shirtColor
            Me.Player.UndershirtColor = undershirtColor
            Me.Player.PantsColor = pantsColor
            Me.Player.ShoesColor = shoesColor
            Me.modelViewer.ResumeModelUpdates()
        Catch
            MessageBox.Show("Failed to open hair and color file!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    #End Region

    #Region "==> Buffs Tab"

    ''' <summary>
    ''' Deletes the selected buff.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteBuff_Click(sender As Object, e As EventArgs)
        If Me.lstPlayerBuffs.SelectedIndex < 0 Then
            Return
        End If

        ' Delete the buff..
        Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).SetBuff(0)

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Maxes the selected buffs duration.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxBuffDuration_Click(sender As Object, e As EventArgs)
        If Me.lstPlayerBuffs.SelectedIndex < 0 AndAlso Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).Id <> 0 Then
            Return
        End If

        ' Max the buff duration..
        Dim buff = Terraria.Instance.Buffs.[Single](Function(b) b.Id = Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).Id)
        Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).Duration = buff.Duration

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Hacks the buffs duration.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHackBuffDuration_Click(sender As Object, e As EventArgs)
        If Me.lstPlayerBuffs.SelectedIndex < 0 AndAlso Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).Id <> 0 Then
            Return
        End If

        ' Hack the buff duration..
        Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).Duration = Integer.MaxValue

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Deletes all buffs.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteAllBuffs_Click(sender As Object, e As EventArgs)
        For Each buff As Buff In Me.Player.Buffs
            buff.SetBuff(0)
        Next

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Maxes all the buff durations.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxAllBuffDurations_Click(sender As Object, e As EventArgs)
        For Each buff As Buff In Me.Player.Buffs.Where(Function(b) b.Id > 0)
            Dim origBuff = Terraria.Instance.Buffs.[Single](Function(b) b.Id = buff.Id)
            buff.Duration = origBuff.Duration
        Next

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Hacks all the buff durations.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHackAllBuffDurations_Click(sender As Object, e As EventArgs)
        For Each buff As Buff In Me.Player.Buffs.Where(Function(b) b.Id > 0)
            buff.Duration = Integer.MaxValue
        Next

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Changes the players buff with the selected one.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstBuffSelection_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.lstBuffSelection.SelectedIndex < 0 OrElse Me.lstPlayerBuffs.SelectedIndex < 0 Then
            Return
        End If

        ' Set the new buff..
        Dim buff = Terraria.Instance.Buffs(Me.lstBuffSelection.SelectedIndex)
        Me.Player.Buffs(Me.lstPlayerBuffs.SelectedIndex).SetBuff(buff.Id)

        ' Update the buff list..
        Me.lstPlayerBuffs.Invalidate(True)
        Me.lstPlayerBuffs.Refresh()
    End Sub

    ''' <summary>
    ''' Saves the current buff list to an xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveBuffs_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog()
        
        sfd.AddExtension = True
        sfd.CheckPathExists = True
        sfd.DefaultExt = "xml"
        sfd.Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*"
        sfd.InitialDirectory = Application.StartupPath
        sfd.ValidateNames = True

        If sfd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to save buffs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("Buffs"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save buffs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Loop each buff in the players buff list..
        For Each b As Buff In Me.Player.Buffs
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("buff", New Object() {New XAttribute("id", b.Id), New XAttribute("duration", b.Duration)}))
        Next

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a saved buffs xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadBuffs_Click(sender As Object, e As EventArgs)
        ' Ask what to open..
        Dim ofd = New OpenFileDialog()
        
        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.DefaultExt = "xml"
        ofd.Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*"
        ofd.InitialDirectory = Application.StartupPath
        ofd.ValidateNames = True

        If ofd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to open buff list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            ' Load the buff list dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("Buffs")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Obtain the buff entries..
            Dim itemElements = root.Elements("buff")
            Dim items = If(TryCast(itemElements, IList(Of XElement)), itemElements.ToList())

            ' Update each item..
            For x As Int16 = 0 To items.Count - 1
                Dim buffId As Integer
                Dim buffDuration As Integer

                Integer.TryParse(items(x).Attribute("id").Value, buffId)
                Integer.TryParse(items(x).Attribute("duration").Value, buffDuration)

                Me.Player.Buffs(x).SetBuff(buffId)
                Me.Player.Buffs(x).Duration = buffDuration
            Next

            Me.RefreshLoadedPlayer()

            Me.lstPlayerBuffs.Invalidate(True)
            Me.lstPlayerBuffs.Refresh()
        Catch
            MessageBox.Show("Failed to open buff list!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    #End Region

    #Region "==> Inventory Tab"

    ''' <summary>
    ''' Filters the inventory items list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtInvItemFilter_TextChanged(sender As Object, e As EventArgs)
        RemoveHandler Me.lstInventoryItems.SelectedIndexChanged, AddressOf Me.lstInventoryItems_SelectedIndexChanged
        Dim items = CreateFilteredItemList(Me.txtInvItemFilter.Text, Me.cboInvItemFilter.SelectedIndex)
        Me.lstInventoryItems.DataSource = items.ToList()
        AddHandler Me.lstInventoryItems.SelectedIndexChanged, AddressOf Me.lstInventoryItems_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Filters the item list based on the given selected category.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboInvItemFilter_SelectedIndexChanged(sender As Object, e As EventArgs)
        RemoveHandler Me.lstInventoryItems.SelectedIndexChanged, AddressOf Me.lstInventoryItems_SelectedIndexChanged
        Dim items = CreateFilteredItemList(Me.txtInvItemFilter.Text, Me.cboInvItemFilter.SelectedIndex)
        Me.lstInventoryItems.DataSource = items.ToList()
        AddHandler Me.lstInventoryItems.SelectedIndexChanged, AddressOf Me.lstInventoryItems_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Filters the prefix list based on the given selected category.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboInventoryPrefixCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.cboInventoryPrefixCategory.SelectedItem Is Nothing Then
            Return
        End If

        RemoveHandler Me.cboInventoryPrefix.SelectedIndexChanged, AddressOf Me.cboInventoryPrefix_SelectedIndexChanged
        Dim item = CreateFilteredPrefixList(Me.cboInventoryPrefixCategory.SelectedIndex)
        Me.cboInventoryPrefix.DataSource = item.ToList()
        AddHandler Me.cboInventoryPrefix.SelectedIndexChanged, AddressOf Me.cboInventoryPrefix_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Selects the hovered inventory label.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub inventoryItem_Click(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.FromArgb(64, 127, 255, 0)

        Me.m_SelectedInventoryItem = lbl
        lbl.Focus()

        For Each label As Label In Me.m_InventoryLabels.Where(Function(label) label <> Me.m_SelectedInventoryItem)
            label.BackColor = Color.Transparent
        Next

        ' Attempt to update the lists with the selected items properties..
        Dim item = Me.Player.Inventory(CInt(lbl.Tag))
        If item IsNot Nothing AndAlso item.NetID <> 0 Then
            Me.cboInventoryPrefixCategory.SelectedIndex = 0
            If item.Prefix <> 0 Then
                For x As Int16 = 0 To Me.cboInventoryPrefix.Items.Count - 1
                    If DirectCast(Me.cboInventoryPrefix.Items(x), ItemPrefix).Id = item.Prefix Then
                        Me.cboInventoryPrefix.SelectedIndex = x
                        Return
                    End If
                Next
            Else
                Dim none = (From i In Me.cboInventoryPrefix.Items Where i.Prefix = "None").SingleOrDefault()
                If none IsNot Nothing Then
                    Me.cboInventoryPrefix.SelectedItem = none
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub inventoryItem_MouseEnter(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.LightSkyBlue
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub inventoryItem_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = If(lbl IsNot Me.m_SelectedInventoryItem, Color.Transparent, Color.FromArgb(64, 127, 255, 0))
    End Sub

    ''' <summary>
    ''' Updates the current item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstInventoryItems_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedInventoryItem Is Nothing Then
            Return
        End If

        ' Set the inventory item..
        Dim item = DirectCast(Me.lstInventoryItems.SelectedItem, Item)
        Dim slot = CInt(Me.m_SelectedInventoryItem.Tag)
        Me.Player.Inventory(slot).SetItem(item.NetID)
        Me.Player.Inventory(slot).Count = InlineAssignHelper(Me.Player.Inventory(slot).Stack, Me.Player.Inventory(slot).MaxStack)

        If item.NetID = 0 Then
            Me.Player.Inventory(slot).Count = InlineAssignHelper(Me.Player.Inventory(slot).Stack, 0)
        Else
            ' Add the selected prefix to the item..
            Me.Player.Inventory(slot).Prefix = CByte(DirectCast(Me.cboInventoryPrefix.SelectedItem, ItemPrefix).Id)
        End If

        ' Update the inventory label..
        Me.m_SelectedInventoryItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_SelectedInventoryItem.Text = Me.Player.Inventory(slot).Count.ToString()
        Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, Me.Player.Inventory(slot).ToString())
    End Sub

    ''' <summary>
    ''' Updates the current items prefix.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboInventoryPrefix_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedInventoryItem Is Nothing Then
            Return
        End If

        If Me.cboInventoryPrefix.SelectedItem Is Nothing Then
            Return
        End If

        ' Set the inventory item..
        Dim prefix = DirectCast(Me.cboInventoryPrefix.SelectedItem, ItemPrefix)
        Dim slot = CInt(Me.m_SelectedInventoryItem.Tag)

        ' Ensure the slot has an item..
        If Me.Player.Inventory(slot).NetID = 0 Then
            Return
        End If

        ' Update the prefix and tooltip..
        Me.Player.Inventory(slot).Prefix = CByte(prefix.Id)
        Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, Me.Player.Inventory(slot).ToString())
    End Sub

    ''' <summary>
    ''' Prevents the stack count from having non-numeric characters typed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtInventoryStackCount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Updates the current items stack count with the entered amount.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtInventoryStackCount_TextChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedInventoryItem Is Nothing Then
            Return
        End If

        ' Ensure the slot has an item..
        Dim slot = CInt(Me.m_SelectedInventoryItem.Tag)
        If Me.Player.Inventory(slot).NetID = 0 Then
            Return
        End If

        ' Attempt to parse the new count..
        Dim count As Integer
        If Not Integer.TryParse(Me.txtInventoryStackCount.Text, count) Then
            Return
        End If

        ' Update the stack count..
        Me.Player.Inventory(slot).Count = InlineAssignHelper(Me.Player.Inventory(slot).Stack, count)
        Me.m_SelectedInventoryItem.Text = count.ToString()
    End Sub

    ''' <summary>
    ''' Deletes the selected inventory item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInventoryDeleteItem_Click(sender As Object, e As EventArgs)
        If Me.m_SelectedInventoryItem Is Nothing Then
            Return
        End If

        ' Ensure the slot has an item..
        Dim slot = CInt(Me.m_SelectedInventoryItem.Tag)
        If Me.Player.Inventory(slot).NetID = 0 Then
            Return
        End If

        ' Update the inventory item..
        Me.Player.Inventory(slot).SetItem(0)
        Me.Player.Inventory(slot).Count = 0

        ' Update the inventory label..
        Me.m_SelectedInventoryItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, Me.Player.Inventory(slot).NetID))
        Me.m_SelectedInventoryItem.Text = "0"
        Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, Me.Player.Inventory(slot).ToString())
    End Sub

    ''' <summary>
    ''' Maxes all inventory item stacks.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInventoryMaxAllStacks_Click(sender As Object, e As EventArgs)
        For x As Int16 = 0 To Me.m_InventoryLabels.Count - 1
            ' Update the item..
            Dim item = Me.Player.Inventory(x)
            If item.Id <> 0 Then
                item.Count = InlineAssignHelper(item.Stack, item.MaxStack)
            End If

            ' Update the item label..
            Me.m_InventoryLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_InventoryLabels(x).Text = item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_InventoryLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Deletes all inventory items.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInventoryDeleteAllItems_Click(sender As Object, e As EventArgs)
        For x As Int16 = 0 To Me.m_InventoryLabels.Count - 1
            ' Update the item..
            Dim item = Me.Player.Inventory(x)
            item.SetItem(0)
            item.Count = 0

            ' Update the item label..
            Me.m_InventoryLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_InventoryLabels(x).Text = item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_InventoryLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Hacks all inventory item stacks.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInventoryHackAllStacks_Click(sender As Object, e As EventArgs)
        For x As Int16 = 0 To Me.m_InventoryLabels.Count - 1
            ' Update the item..
            Dim item = Me.Player.Inventory(x)
            If item.Id <> 0 AndAlso item.MaxStack > 1 Then
                item.Count = InlineAssignHelper(item.Stack, Integer.MaxValue)
            End If

            ' Update the item label..
            Me.m_InventoryLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_InventoryLabels(x).Text = item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_InventoryLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Saves the current inventory to an xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveInventory_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog()
        
        sfd.AddExtension = True
        sfd.CheckPathExists = True
        sfd.DefaultExt = "xml"
        sfd.Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*"
        sfd.InitialDirectory = Application.StartupPath
        sfd.ValidateNames = True

        If sfd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to save inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("Inventory"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Loop each item in the players inventory..
        For Each i As string In Me.Player.Inventory
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("item", New Object() {New XAttribute("id", i.NetID), New XAttribute("count", AddressOf i.Count), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a saved inventory xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadInventory_Click(sender As Object, e As EventArgs)
        ' Ask what to open..
        Dim ofd = New OpenFileDialog()
        
        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.DefaultExt = "xml"
        ofd.Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*"
        ofd.InitialDirectory = Application.StartupPath
        ofd.ValidateNames = True

        If ofd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to open inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            ' Load the inventory dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("Inventory")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Obtain the item entries..
            Dim itemElements = root.Elements("item")
            Dim items = If(TryCast(itemElements, IList(Of XElement)), itemElements.ToList())
            If items.Count <> 58 Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Update each item..
            For x As Int16 = 0 To items.Count - 1
                Dim itemId As Integer
                Dim itemCount As Integer
                Dim itemPrefix As Integer

                Integer.TryParse(items(x).Attribute("id").Value, itemId)
                Integer.TryParse(items(x).Attribute("count").Value, itemCount)
                Integer.TryParse(items(x).Attribute("prefix").Value, itemPrefix)

                Me.Player.Inventory(x).SetItem(itemId)
                Me.Player.Inventory(x).Count = itemCount
                Me.Player.Inventory(x).Prefix = CByte(itemPrefix)
            Next

            Me.RefreshLoadedPlayer()
        Catch
            MessageBox.Show("Failed to open inventory!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    #End Region

    #Region "==> Equipment Tab"

    ''' <summary>
    ''' Selects the hovered equipment label.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub equipmentItem_Click(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.FromArgb(64, 127, 255, 0)

        Me.m_SelectedEquipmentItem = lbl
        lbl.Focus()

        For Each label As Label In Me.m_EquipmentLabels.Where(label <> Me.m_SelectedEquipmentItem)
            label.BackColor = Color.Transparent
        Next
        For Each label As ItemLabel In Me.m_EquipmentLabels.Where(label <> Me.m_SelectedEquipmentItem)
            label.BackColor = Color.Transparent
        Next

        Me.SetEquipmentListContext()

        ' Attempt to set the selected items prefix..
        Dim slot = CInt(Me.m_SelectedEquipmentItem.Tag)
        Me.cboEquipmentPrefixCategory.SelectedIndex = 0

        Dim prefix = 0
        Select Case slot
            Case 0, 1, 2
                prefix = Me.Player.Armor(slot).Prefix
                Exit Select
            Case 3, 4, 5
                prefix = Me.Player.Vanity(slot - 3).Prefix
                Exit Select
            Case 6, 7, 8, 9, 10, 11, _
                12, 13
                prefix = Me.Player.Dye(slot - 6).Prefix
                Exit Select
            Case 14, 15, 16, 17, 18
                prefix = Me.Player.Accessories(slot - 14).Prefix
                Exit Select
            Case Else
                prefix = Me.Player.SocialAccessories(slot - 19).Prefix
                Exit Select
        End Select

        Dim prefixEntry = (From i In Me.cboEquipmentPrefix.Items Where i.Id = prefix).SingleOrDefault()
        If prefixEntry IsNot Nothing Then
            Me.cboEquipmentPrefix.SelectedItem = prefixEntry
        End If

        Me.cboEquipmentPrefix_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub equipmentItem_MouseEnter(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.LightSkyBlue
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub equipmentItem_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = If(lbl IsNot Me.m_SelectedEquipmentItem, Color.Transparent, Color.FromArgb(64, 127, 255, 0))
    End Sub

    ''' <summary>
    ''' Filters the equipment item list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtEquipmentFilter_TextChanged(sender As Object, e As EventArgs)
        Me.SetEquipmentListContext()
    End Sub

    ''' <summary>
    ''' Selects and sets the equipment item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstEquipmentItems_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedEquipmentItem Is Nothing OrElse Me.lstEquipmentItems.SelectedIndex < 0 Then
            Return
        End If

        Dim item = DirectCast(Me.lstEquipmentItems.SelectedItem, Item)
        Dim slot = CInt(Me.m_SelectedEquipmentItem.Tag)

        ' Equipment..
        If slot = 0 OrElse slot = 1 OrElse slot = 2 Then
            Me.Player.Armor(slot).SetItem(item.NetID)
            If item.NetID <> 0 Then
                Me.Player.Armor(slot).Prefix = CByte(DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix).Id)
            End If

            item = Me.Player.Armor(slot)

        ' Vanity..
        ElseIf slot = 3 OrElse slot = 4 OrElse slot = 5 Then
            Me.Player.Vanity(slot - 3).SetItem(item.NetID)
            If item.NetID <> 0 Then
                Me.Player.Vanity(slot - 3).Prefix = CByte(DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix).Id)
            End If

            item = Me.Player.Vanity(slot - 3)

        ' Dye..
        ElseIf slot >= 6 AndAlso slot <= 13 Then
            Me.Player.Dye(slot - 6).SetItem(item.NetID)
            If item.NetID <> 0 Then
                Me.Player.Dye(slot - 6).Prefix = CByte(DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix).Id)
            End If

            item = Me.Player.Dye(slot - 6)

        ' Accessories..
        ElseIf slot >= 14 AndAlso slot <= 18 Then
            Me.Player.Accessories(slot - 14).SetItem(item.NetID)
            If item.NetID <> 0 Then
                Me.Player.Accessories(slot - 14).Prefix = CByte(DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix).Id)
            End If

            item = Me.Player.Accessories(slot - 14)
        Else

            ' Social Accessories
            Me.Player.SocialAccessories(slot - 19).SetItem(item.NetID)
            If item.NetID <> 0 Then
                Me.Player.SocialAccessories(slot - 19).Prefix = CByte(DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix).Id)
            End If

            item = Me.Player.SocialAccessories(slot - 19)
        End If

        ' Update the inventory label..
        Me.m_SelectedEquipmentItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_SelectedEquipmentItem.Text = item.MaxStack.ToString()
        Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, item.ToString())
    End Sub

    ''' <summary>
    ''' Filters the equipment prefix list based on the selected category.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboEquipmentPrefixCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.cboEquipmentPrefixCategory.SelectedItem Is Nothing Then
            Return
        End If

        RemoveHandler Me.cboEquipmentPrefix.SelectedIndexChanged, AddressOf Me.cboEquipmentPrefix_SelectedIndexChanged
        Dim item = CreateFilteredPrefixList(Me.cboEquipmentPrefixCategory.SelectedIndex)
        Me.cboEquipmentPrefix.DataSource = item.ToList()
        AddHandler Me.cboEquipmentPrefix.SelectedIndexChanged, AddressOf Me.cboEquipmentPrefix_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Sets the equipment item prefix.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboEquipmentPrefix_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedEquipmentItem Is Nothing Then
            Return
        End If

        If Me.cboEquipmentPrefix.SelectedItem Is Nothing Then
            Return
        End If

        Dim prefix = DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix)
        Dim slot = CInt(Me.m_SelectedEquipmentItem.Tag)

        ' Equipment..
        If slot = 0 OrElse slot = 1 OrElse slot = 2 Then
            If Me.Player.Armor(slot).NetID = 0 Then
                Return
            End If
            Me.Player.Armor(slot).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, Me.Player.Armor(slot).ToString())

        ' Vanity..
        ElseIf slot = 3 OrElse slot = 4 OrElse slot = 5 Then
            If Me.Player.Vanity(slot - 3).NetID = 0 Then
                Return
            End If
            Me.Player.Vanity(slot - 3).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, Me.Player.Vanity(slot - 3).ToString())

        ' Dye..
        ElseIf slot >= 6 AndAlso slot <= 13 Then
            If Me.Player.Dye(slot - 6).NetID = 0 Then
                Return
            End If
            Me.Player.Dye(slot - 6).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, Me.Player.Dye(slot - 6).ToString())

        ' Accessories..
        ElseIf slot >= 14 AndAlso slot <= 18 Then
            If Me.Player.Accessories(slot - 14).NetID = 0 Then
                Return
            End If
            Me.Player.Accessories(slot - 14).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, Me.Player.Accessories(slot - 14).ToString())
        Else

            ' Social Accessories..
            If Me.Player.SocialAccessories(slot - 19).NetID = 0 Then
                Return
            End If
            Me.Player.SocialAccessories(slot - 19).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, Me.Player.SocialAccessories(slot - 19).ToString())
        End If
    End Sub

    ''' <summary>
    ''' Updates the equipment item list based on the selected slot and filter.
    ''' </summary>
    Private Sub SetEquipmentListContext()
        ' Do not set a source if no item is selected..
        If Me.m_SelectedEquipmentItem Is Nothing Then
            Me.lstEquipmentItems.DataSource = Nothing
            Return
        End If

        ' Remove the selection changed event while we update..
        RemoveHandler Me.lstEquipmentItems.SelectedIndexChanged, AddressOf Me.lstEquipmentItems_SelectedIndexChanged
        Me.lstEquipmentItems.SuspendLayout()

        ' Determine the slot type..
        Dim slot = CInt(Me.m_SelectedEquipmentItem.Tag)
        Select Case slot
            ' Armor (Head)
            Case 0, 3
                ' Vanity (Head)
                If True Then
                    Dim items = CreateFilteredItemList(Me.txtEquipmentFilter.Text, 1)
                    Me.lstEquipmentItems.DataSource = items.Where(Function(i) i.HeadSlot > -1 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If

            ' Armor (Body)
            Case 1, 4
                ' Vanity (Body)
                If True Then
                    Dim items = CreateFilteredItemList(Me.txtEquipmentFilter.Text, 1)
                    Me.lstEquipmentItems.DataSource = items.Where(Function(i) i.BodySlot > -1 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If

            ' Armor (Legs)
            Case 2, 5
                ' Vanity (Legs)
                If True Then
                    Dim items = CreateFilteredItemList(Me.txtEquipmentFilter.Text, 1)
                    Me.lstEquipmentItems.DataSource = items.Where(Function(i) i.LegSlot > -1 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If
            ' Dye
            ' Dye
            ' Dye
            ' Dye
            ' Dye
            ' Dye
            ' Dye
            Case 6, 7, 8, 9, 10, 11, _
                12, 13
                ' Dye
                If True Then
                    Dim items = CreateFilteredItemList(Me.txtEquipmentFilter.Text, 0)
                    Me.lstEquipmentItems.DataSource = items.Where(Function(i) i.Dye > 0 OrElse i.NetID = 0).ToList()
                    Exit Select
                End If

            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            ' Accessory
            Case 14, 15, 16, 17, 18, 19, _
                20, 21, 22, 23
                ' Accessory
                If True Then
                    Dim items = CreateFilteredItemList(Me.txtEquipmentFilter.Text, 2)
                    Me.lstEquipmentItems.DataSource = items.ToList()
                    Exit Select
                End If
        End Select

        ' Restore the listbox..
        Me.lstEquipmentItems.SelectedIndex = -1
        Me.lstEquipmentItems.ResumeLayout()
        AddHandler Me.lstEquipmentItems.SelectedIndexChanged, AddressOf Me.lstEquipmentItems_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Saves the current players gear to an xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveEquipmentSet_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Equipment Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If sfd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to save equipment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("Equipment"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save equipment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Loop each armor piece..
        For Each i As var In Me.Player.Armor
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("armor", New Object() {New XAttribute("id", i.NetID), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Loop each accessory piece..
        For Each i As var In Me.Player.Accessories
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("accessory", New Object() {New XAttribute("id", i.NetID), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Loop each vanity piece..
        For Each i As var In Me.Player.Vanity
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("vanity", New Object() {New XAttribute("id", i.NetID), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Loop each social accessory piece..
        For Each i As var In Me.Player.SocialAccessories
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("socialaccessory", New Object() {New XAttribute("id", i.NetID), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Loop each dye piece..
        For Each i As var In Me.Player.Dye
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("dye", New Object() {New XAttribute("id", i.NetID), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a saved equipment set.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadEquipmentSet_Click(sender As Object, e As EventArgs)
        ' Ask what to open..
        Dim ofd = New OpenFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckFileExists = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Equipment Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If ofd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to open equipment save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            ' Load the equipment dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("Equipment")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Obtain each categories items..
            Dim armorElements = root.Elements("armor")
            Dim accessoryElements = root.Elements("accessory")
            Dim vanityElements = root.Elements("vanity")
            Dim socialAccessoryElements = root.Elements("socialaccessory")
            Dim dyeElements = root.Elements("dye")

            ' Convert the items to lists..
            Dim armor = If(TryCast(armorElements, IList(Of XElement)), armorElements.ToList())
            Dim accessory = If(TryCast(accessoryElements, IList(Of XElement)), accessoryElements.ToList())
            Dim vanity = If(TryCast(vanityElements, IList(Of XElement)), vanityElements.ToList())
            Dim socialAccessory = If(TryCast(socialAccessoryElements, IList(Of XElement)), socialAccessoryElements.ToList())
            Dim dye = If(TryCast(dyeElements, IList(Of XElement)), dyeElements.ToList())

            ' Validate the data..
            If armor.Count <> 3 OrElse accessory.Count <> 5 OrElse vanity.Count <> 3 OrElse socialAccessory.Count <> 5 OrElse dye.Count <> 8 Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Update the armor..
            Me.Player.Armor(0).SetItem(Integer.Parse(armor(0).Attribute("id").Value))
            Me.Player.Armor(0).Prefix = CByte(Integer.Parse(armor(0).Attribute("prefix").Value))
            Me.Player.Armor(1).SetItem(Integer.Parse(armor(1).Attribute("id").Value))
            Me.Player.Armor(1).Prefix = CByte(Integer.Parse(armor(1).Attribute("prefix").Value))
            Me.Player.Armor(2).SetItem(Integer.Parse(armor(2).Attribute("id").Value))
            Me.Player.Armor(2).Prefix = CByte(Integer.Parse(armor(2).Attribute("prefix").Value))

            ' Update the accessories..
            Me.Player.Accessories(0).SetItem(Integer.Parse(accessory(0).Attribute("id").Value))
            Me.Player.Accessories(0).Prefix = CByte(Integer.Parse(accessory(0).Attribute("prefix").Value))
            Me.Player.Accessories(1).SetItem(Integer.Parse(accessory(1).Attribute("id").Value))
            Me.Player.Accessories(1).Prefix = CByte(Integer.Parse(accessory(1).Attribute("prefix").Value))
            Me.Player.Accessories(2).SetItem(Integer.Parse(accessory(2).Attribute("id").Value))
            Me.Player.Accessories(2).Prefix = CByte(Integer.Parse(accessory(2).Attribute("prefix").Value))
            Me.Player.Accessories(3).SetItem(Integer.Parse(accessory(3).Attribute("id").Value))
            Me.Player.Accessories(3).Prefix = CByte(Integer.Parse(accessory(3).Attribute("prefix").Value))
            Me.Player.Accessories(4).SetItem(Integer.Parse(accessory(4).Attribute("id").Value))
            Me.Player.Accessories(4).Prefix = CByte(Integer.Parse(accessory(4).Attribute("prefix").Value))

            ' Update the vanity..
            Me.Player.Vanity(0).SetItem(Integer.Parse(vanity(0).Attribute("id").Value))
            Me.Player.Vanity(0).Prefix = CByte(Integer.Parse(vanity(0).Attribute("prefix").Value))
            Me.Player.Vanity(1).SetItem(Integer.Parse(vanity(1).Attribute("id").Value))
            Me.Player.Vanity(1).Prefix = CByte(Integer.Parse(vanity(1).Attribute("prefix").Value))
            Me.Player.Vanity(2).SetItem(Integer.Parse(vanity(2).Attribute("id").Value))
            Me.Player.Vanity(2).Prefix = CByte(Integer.Parse(vanity(2).Attribute("prefix").Value))

            ' Update the accessories..
            Me.Player.SocialAccessories(0).SetItem(Integer.Parse(socialAccessory(0).Attribute("id").Value))
            Me.Player.SocialAccessories(0).Prefix = CByte(Integer.Parse(socialAccessory(0).Attribute("prefix").Value))
            Me.Player.SocialAccessories(1).SetItem(Integer.Parse(socialAccessory(1).Attribute("id").Value))
            Me.Player.SocialAccessories(1).Prefix = CByte(Integer.Parse(socialAccessory(1).Attribute("prefix").Value))
            Me.Player.SocialAccessories(2).SetItem(Integer.Parse(socialAccessory(2).Attribute("id").Value))
            Me.Player.SocialAccessories(2).Prefix = CByte(Integer.Parse(socialAccessory(2).Attribute("prefix").Value))
            Me.Player.SocialAccessories(3).SetItem(Integer.Parse(socialAccessory(3).Attribute("id").Value))
            Me.Player.SocialAccessories(3).Prefix = CByte(Integer.Parse(socialAccessory(3).Attribute("prefix").Value))
            Me.Player.SocialAccessories(4).SetItem(Integer.Parse(socialAccessory(4).Attribute("id").Value))
            Me.Player.SocialAccessories(4).Prefix = CByte(Integer.Parse(socialAccessory(4).Attribute("prefix").Value))

            ' Update the dye..
            For x As var = 0 To dye.Count - 1
                Me.Player.Dye(x).SetItem(Integer.Parse(dye(x).Attribute("id").Value))
                Me.Player.Dye(x).Prefix = CByte(Integer.Parse(dye(x).Attribute("prefix").Value))
            Next

            ' Refresh the player..
            Me.RefreshLoadedPlayer()
        Catch
            MessageBox.Show("Failed to open equipment file!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    #End Region

    #Region "==> Bank / Safe Tab"

    ''' <summary>
    ''' Filters the bank/safe items list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtBankSafeFilter_TextChanged(sender As Object, e As EventArgs)
        RemoveHandler Me.lstBankSafeItems.SelectedIndexChanged, AddressOf Me.lstBankSafeItems_SelectedIndexChanged
        Dim items = CreateFilteredItemList(Me.txtBankSafeFilter.Text, Me.cboBankSafeItemFilter.SelectedIndex)
        Me.lstBankSafeItems.DataSource = items.ToList()
        AddHandler Me.lstBankSafeItems.SelectedIndexChanged, AddressOf Me.lstBankSafeItems_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Filters the bank/safe items list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboBankSafeItemFilter_SelectedIndexChanged(sender As Object, e As EventArgs)
        RemoveHandler Me.lstBankSafeItems.SelectedIndexChanged, AddressOf Me.lstBankSafeItems_SelectedIndexChanged
        Dim items = CreateFilteredItemList(Me.txtBankSafeFilter.Text, Me.cboBankSafeItemFilter.SelectedIndex)
        Me.lstBankSafeItems.DataSource = items.ToList()
        AddHandler Me.lstBankSafeItems.SelectedIndexChanged, AddressOf Me.lstBankSafeItems_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Filters the bank/safe prefix list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboBankSafePrefixCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        RemoveHandler Me.cboBankSafePrefix.SelectedIndexChanged, AddressOf Me.cboBankSafePrefix_SelectedIndexChanged
        Dim item = CreateFilteredPrefixList(Me.cboBankSafePrefixCategory.SelectedIndex)
        Me.cboBankSafePrefix.DataSource = item.ToList()
        AddHandler Me.cboBankSafePrefix.SelectedIndexChanged, AddressOf Me.cboBankSafePrefix_SelectedIndexChanged
    End Sub

    ''' <summary>
    ''' Selects the hovered bank/safe label.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bankSafeItem_Click(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.FromArgb(64, 127, 255, 0)

        Me.m_SelectedBankSafeItem = lbl
        lbl.Focus()

        For Each label As var In Me.m_BankSafeLabels.Where(Function(label) label <> Me.m_SelectedBankSafeItem)
            label.BackColor = Color.Transparent
        Next

        Dim slot = CInt(Me.m_SelectedBankSafeItem.Tag)
        Dim item = If((slot <= 39), Me.Player.Bank1(slot), Me.Player.Bank2(slot - 40))
        If item IsNot Nothing AndAlso item.NetID <> 0 Then
            Me.cboBankSafePrefixCategory.SelectedIndex = 0
            If item.Prefix <> 0 Then
                For x As var = 0 To Me.cboBankSafePrefix.Items.Count - 1
                    If DirectCast(Me.cboBankSafePrefix.Items(x), ItemPrefix).Id = item.Prefix Then
                        Me.cboBankSafePrefix.SelectedIndex = x
                        Return
                    End If
                Next
            Else
                Dim none = (From i In Me.cboBankSafePrefix.Items Where i.Prefix = "None"i).SingleOrDefault()
                If none IsNot Nothing Then
                    Me.cboBankSafePrefix.SelectedItem = none
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bankSafeItem_MouseEnter(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = Color.LightSkyBlue
    End Sub

    ''' <summary>
    ''' Adjusts the hovered items background color.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bankSafeItem_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl = DirectCast(sender, Label)
        lbl.BackColor = If(lbl IsNot Me.m_SelectedBankSafeItem, Color.Transparent, Color.FromArgb(64, 127, 255, 0))
    End Sub

    ''' <summary>
    ''' Updates the current item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstBankSafeItems_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedBankSafeItem Is Nothing Then
            Return
        End If

        ' Set the inventory item..
        Dim item = DirectCast(Me.lstBankSafeItems.SelectedItem, Item)
        Dim slot = CInt(Me.m_SelectedBankSafeItem.Tag)
        Dim count As Integer

        If slot <= 39 Then
            Me.Player.Bank1(slot).SetItem(item.NetID)
            Me.Player.Bank1(slot).Count = InlineAssignHelper(Me.Player.Bank1(slot).Stack, Me.Player.Bank1(slot).MaxStack)

            If item.NetID = 0 Then
                Me.Player.Bank1(slot).Count = InlineAssignHelper(Me.Player.Bank1(slot).Stack, 0)
            Else
                ' Add the selected prefix to the item..
                Me.Player.Bank1(slot).Prefix = CByte(DirectCast(Me.cboBankSafePrefix.SelectedItem, ItemPrefix).Id)
            End If

            count = Me.Player.Bank1(slot).Count
        Else
            Me.Player.Bank2(slot - 40).SetItem(item.NetID)
            Me.Player.Bank2(slot - 40).Count = InlineAssignHelper(Me.Player.Bank2(slot - 40).Stack, Me.Player.Bank2(slot - 40).MaxStack)

            If item.NetID = 0 Then
                Me.Player.Bank2(slot - 40).Count = InlineAssignHelper(Me.Player.Bank2(slot - 40).Stack, 0)
            Else
                ' Add the selected prefix to the item..
                Me.Player.Bank2(slot - 40).Prefix = CByte(DirectCast(Me.cboBankSafePrefix.SelectedItem, ItemPrefix).Id)
            End If

            count = Me.Player.Bank2(slot - 40).Count
        End If

        ' Update the item label..
        Me.m_SelectedBankSafeItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_SelectedBankSafeItem.Text = count.ToString()
        Me.m_Tooltip.SetToolTip(Me.m_SelectedBankSafeItem, If((slot <= 39), Me.Player.Bank1(slot).ToString(), Me.Player.Bank2(slot - 40).ToString()))
    End Sub

    ''' <summary>
    ''' Updates the current items prefix.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboBankSafePrefix_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedBankSafeItem Is Nothing Then
            Return
        End If

        ' Set the bank/safe item..
        Dim prefix = DirectCast(Me.cboBankSafePrefix.SelectedItem, ItemPrefix)
        Dim slot = CInt(Me.m_SelectedBankSafeItem.Tag)

        If slot <= 39 Then
            If Me.Player.Bank1(slot).NetID = 0 Then
                Return
            End If
            Me.Player.Bank1(slot).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedBankSafeItem, Me.Player.Bank1(slot).ToString())
        Else
            If Me.Player.Bank2(slot - 40).NetID = 0 Then
                Return
            End If
            Me.Player.Bank2(slot - 40).Prefix = CByte(prefix.Id)
            Me.m_Tooltip.SetToolTip(Me.m_SelectedBankSafeItem, Me.Player.Bank2(slot - 40).ToString())
        End If
    End Sub

    ''' <summary>
    ''' Prevents the stack count from having non-numeric characters typed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtBankSafeStackCount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Updates the current items stack count with the entered amount.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtBankSafeStackCount_TextChanged(sender As Object, e As EventArgs)
        If Me.m_SelectedBankSafeItem Is Nothing Then
            Return
        End If

        ' Attempt to parse the new count..
        Dim count As Integer
        If Not Integer.TryParse(Me.txtBankSafeStackCount.Text, count) Then
            Return
        End If

        ' Ensure the slot has an item..
        Dim slot = CInt(Me.m_SelectedBankSafeItem.Tag)

        If slot <= 39 Then
            If Me.Player.Bank1(slot).NetID = 0 Then
                Return
            End If

            ' Update the item and label..
            Me.Player.Bank1(slot).Count = InlineAssignHelper(Me.Player.Bank1(slot).Stack, count)
            Me.m_SelectedBankSafeItem.Text = count.ToString()
        Else
            If Me.Player.Bank2(slot - 40).NetID = 0 Then
                Return
            End If

            ' Update the item and label..
            Me.Player.Bank2(slot - 40).Count = InlineAssignHelper(Me.Player.Bank2(slot - 40).Stack, count)
            Me.m_SelectedBankSafeItem.Text = count.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Deletes all items in the players bank.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteAllBankItems_Click(sender As Object, e As EventArgs)
        For x As var = 0 To 39
            ' Update the item..
            Dim item = Me.Player.Bank1(x)
            item.SetItem(0)
            AddressOf item.Count = 0

            ' Update the item label..
            Me.m_BankSafeLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_BankSafeLabels(x).Text = AddressOf item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_BankSafeLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Deletes all the items in the players safe.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteAllSafeItems_Click(sender As Object, e As EventArgs)
        For x As var = 0 To 39
            ' Update the item..
            Dim item = Me.Player.Bank2(x)
            item.SetItem(0)
            AddressOf item.Count = 0

            ' Update the item label..
            Me.m_BankSafeLabels(x + 40).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_BankSafeLabels(x + 40).Text = AddressOf item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_BankSafeLabels(x + 40), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Maxes all bank and safe stack counts.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxAllBankSafeStacks_Click(sender As Object, e As EventArgs)
        For x As var = 0 To Me.m_BankSafeLabels.Count - 1
            ' Update the item..
            Dim item = If((x < 40), Me.Player.Bank1(x), Me.Player.Bank2(x - 40))
            If item.Id <> 0 AndAlso item.MaxStack > 1 Then
                AddressOf item.Count = InlineAssignHelper(item.Stack, item.MaxStack)
            End If

            ' Update the item label..
            Me.m_BankSafeLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_BankSafeLabels(x).Text = AddressOf item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_BankSafeLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Hacks all the bank and safe item stack counts.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHackAllBankSafeStacks_Click(sender As Object, e As EventArgs)
        For x As var = 0 To Me.m_BankSafeLabels.Count - 1
            ' Update the item..
            Dim item = If((x < 40), Me.Player.Bank1(x), Me.Player.Bank2(x - 40))
            If item.Id <> 0 AndAlso item.MaxStack > 1 Then
                AddressOf item.Count = InlineAssignHelper(item.Stack, Integer.MaxValue)
            End If

            ' Update the item label..
            Me.m_BankSafeLabels(x).Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
            Me.m_BankSafeLabels(x).Text = AddressOf item.Count.ToString()
            Me.m_Tooltip.SetToolTip(Me.m_BankSafeLabels(x), item.ToString())
        Next
    End Sub

    ''' <summary>
    ''' Saves the players current bank items to an xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveBankItems_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Bank Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If sfd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to save bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("BankSafe"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Loop each item in the players bank..
        For Each i As var In Me.Player.Bank1
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("item", New Object() {New XAttribute("id", i.NetID), New XAttribute("count", AddressOf i.Count), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a bank save file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadBankItems_Click(sender As Object, e As EventArgs)
        ' Ask what to open..
        Dim ofd = New OpenFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckFileExists = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Bank Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If ofd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to open bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            ' Load the bank dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("BankSafe")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Obtain the item entries..
            Dim itemElements = root.Elements("item")
            Dim items = If(TryCast(itemElements, IList(Of XElement)), itemElements.ToList())
            If items.Count <> 40 Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Update each item..
            For x As var = 0 To items.Count - 1
                Dim itemId As Integer
                Dim itemCount As Integer
                Dim itemPrefix As Integer

                Integer.TryParse(items(x).Attribute("id").Value, itemId)
                Integer.TryParse(items(x).Attribute("count").Value, itemCount)
                Integer.TryParse(items(x).Attribute("prefix").Value, itemPrefix)

                Me.Player.Bank1(x).SetItem(itemId)
                Me.Player.Bank1(x).Count = itemCount
                Me.Player.Bank1(x).Prefix = CByte(itemPrefix)
            Next

            Me.RefreshLoadedPlayer()
        Catch
            MessageBox.Show("Failed to open bank!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    ''' <summary>
    ''' Saves the players current safe items into an xml file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveSafeItems_Click(sender As Object, e As EventArgs)
        ' Ask where to save to..
        Dim sfd = New SaveFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Safe Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If sfd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to save safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Create the new xml document..
        Dim xml = New XDocument(New XElement("BankSafe"))
        If xml.Root Is Nothing Then
            sfd.Dispose()
            MessageBox.Show("Failed to save safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        ' Loop each item in the players safe..
        For Each i As var In Me.Player.Bank2
            ' Add each item to the xml document..
            xml.Root.Add(New XElement("item", New Object() {New XAttribute("id", i.NetID), New XAttribute("count", AddressOf i.Count), New XAttribute("prefix", i.Prefix)}))
        Next

        ' Attempt to save the document..
        xml.Save(sfd.FileName)
        sfd.Dispose()
    End Sub

    ''' <summary>
    ''' Imports a safe save file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoadSafeItems_Click(sender As Object, e As EventArgs)
        ' Ask what to open..
        Dim ofd = New OpenFileDialog() With { _
            Key .AddExtension = True, _
            Key .CheckFileExists = True, _
            Key .CheckPathExists = True, _
            Key .DefaultExt = "xml", _
            Key .Filter = "TSGE Safe Files (*.xml)|*.xml|All files (*.*)|*.*", _
            Key .InitialDirectory = Application.StartupPath, _
            Key .ValidateNames = True _
        }

        If ofd.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Failed to open safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            ' Load the safe dump..
            Dim xml = XDocument.Load(ofd.FileName)

            ' Ensure the root element exists..
            Dim root = xml.Element("BankSafe")
            If root Is Nothing Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Obtain the item entries..
            Dim itemElements = root.Elements("item")
            Dim items = If(TryCast(itemElements, IList(Of XElement)), itemElements.ToList())
            If items.Count <> 40 Then
                Throw New InvalidDataException("File data is not valid.")
            End If

            ' Update each item..
            For x As var = 0 To items.Count - 1
                Dim itemId As Integer
                Dim itemCount As Integer
                Dim itemPrefix As Integer

                Integer.TryParse(items(x).Attribute("id").Value, itemId)
                Integer.TryParse(items(x).Attribute("count").Value, itemCount)
                Integer.TryParse(items(x).Attribute("prefix").Value, itemPrefix)

                Me.Player.Bank2(x).SetItem(itemId)
                Me.Player.Bank2(x).Count = itemCount
                Me.Player.Bank2(x).Prefix = CByte(itemPrefix)
            Next

            Me.RefreshLoadedPlayer()
        Catch
            MessageBox.Show("Failed to open safe!" & vbCr & vbLf & "The selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        ofd.Dispose()
    End Sub

    #End Region

    #Region "==> Hotkey Handlers"

    ''' <summary>
    ''' PreviewKeyDown event for inventory items to allow usage of hotkeys.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub inventoryItem_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        ' Ensure we have a selected item..
        If Me.m_SelectedInventoryItem Is Nothing Then
            Return
        End If

        ' Ensure the slot has a valid item..
        Dim slot = CInt(Me.m_SelectedInventoryItem.Tag)
        If Me.Player.Inventory(slot).NetID = 0 Then
            Return
        End If

        ' Handle the key accordingly..
        Select Case e.KeyCode
            Case Keys.D
                ' Delete current item.. 
                If True Then
                    ' Delete the item..
                    Me.Player.Inventory(slot).SetItem(0)
                    Me.Player.Inventory(slot).Count = 0

                    ' Update the inventory label..
                    Me.m_SelectedInventoryItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, Me.Player.Inventory(slot).NetID))
                    Me.m_SelectedInventoryItem.Text = "0"
                    Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, Me.Player.Inventory(slot).ToString())
                    Exit Select
                End If

            Case Keys.P
                ' Set prefix..
                If True Then
                    ' Update the prefix and tooltip..
                    Dim prefix = DirectCast(Me.cboInventoryPrefix.SelectedItem, ItemPrefix)
                    Me.Player.Inventory(slot).Prefix = CByte(prefix.Id)
                    Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, Me.Player.Inventory(slot).ToString())
                    Exit Select
                End If

            Case Keys.M
                ' Set max stack..
                If True Then
                    ' Update the stack count..
                    Dim item = Me.Player.Inventory(slot)
                    AddressOf item.Count = InlineAssignHelper(item.Stack, item.MaxStack)

                    ' Update the item label..
                    Me.m_SelectedInventoryItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
                    Me.m_SelectedInventoryItem.Text = AddressOf item.Count.ToString()
                    Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, item.ToString())
                    Exit Select
                End If

            Case Keys.H
                ' Set hacked stack..
                If True Then
                    ' Update the stack count..
                    Dim item = Me.Player.Inventory(slot)
                    If item.MaxStack > 1 Then
                        AddressOf item.Count = InlineAssignHelper(item.Stack, 999)
                    End If

                    ' Update the item label..
                    Me.m_SelectedInventoryItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
                    Me.m_SelectedInventoryItem.Text = AddressOf item.Count.ToString()
                    Me.m_Tooltip.SetToolTip(Me.m_SelectedInventoryItem, item.ToString())
                    Exit Select
                End If
            Case Keys.I
                ' Set item..
                If True Then
                    ' Ensure we have a selected item..
                    Dim item = DirectCast(Me.lstInventoryItems.SelectedItem, Item)
                    If item Is Nothing Then
                        Return
                    End If

                    ' Set the item..
                    Me.Player.Inventory(slot).SetItem(item.Id)
                    Me.Player.Inventory(slot).Count = InlineAssignHelper(Me.Player.Inventory(slot).Stack, Me.Player.Inventory(slot).MaxStack)
                    Exit Select
                End If
        End Select

    End Sub

    ''' <summary>
    ''' PreviewKeyDown event for equipment items to allow usage of hotkeys.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub equipmentItem_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        ' Ensure we have a selected item..
        If Me.m_SelectedEquipmentItem Is Nothing Then
            Return
        End If

        ' Ensure the slot has a valid item..
        Dim slot = CInt(Me.m_SelectedEquipmentItem.Tag)
        If (slot = 0 OrElse slot = 1 OrElse slot = 2) AndAlso Me.Player.Armor(slot).NetID = 0 Then
            Return
        End If
        If (slot = 3 OrElse slot = 4 OrElse slot = 5) AndAlso Me.Player.Vanity(slot - 3).NetID = 0 Then
            Return
        End If
        If (slot = 6 OrElse slot = 7 OrElse slot = 8) AndAlso Me.Player.Dye(slot - 6).NetID = 0 Then
            Return
        End If
        If slot >= 9 AndAlso Me.Player.Accessories(slot - 9).NetID = 0 Then
            Return
        End If

        ' Obtain the editing item.
        Dim item As Item = Nothing
        If slot = 0 OrElse slot = 1 OrElse slot = 2 Then
            item = Me.Player.Armor(slot)
        End If
        If slot = 3 OrElse slot = 4 OrElse slot = 5 Then
            item = Me.Player.Vanity(slot - 3)
        End If
        If slot = 6 OrElse slot = 7 OrElse slot = 8 Then
            item = Me.Player.Dye(slot - 6)
        End If
        If slot >= 9 Then
            item = Me.Player.Accessories(slot - 9)
        End If

        If item Is Nothing Then
            Return
        End If

        ' Handle the key accordingly..
        Select Case e.KeyCode
            Case Keys.D
                ' Delete current item.. 
                If True Then
                    item.SetItem(0)
                    item.Count = 0
                    Exit Select
                End If

            Case Keys.P
                ' Set prefix..
                If True Then
                    Dim prefix = DirectCast(Me.cboEquipmentPrefix.SelectedItem, ItemPrefix)
                    item.Prefix = CByte(prefix.Id)
                    Exit Select
                End If
        End Select

        ' Update the equipment label..
        Me.m_SelectedEquipmentItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_SelectedEquipmentItem.Text = item.MaxStack.ToString()
        Me.m_Tooltip.SetToolTip(Me.m_SelectedEquipmentItem, item.ToString())
    End Sub

    ''' <summary>
    ''' PreviewKeyDown event for bank and safe items to allow usage of hotkeys.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bankSafeItem_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        ' Ensure we have a selected item..
        If Me.m_SelectedBankSafeItem Is Nothing Then
            Return
        End If

        ' Ensure the slot has a valid item..
        Dim slot = CInt(Me.m_SelectedBankSafeItem.Tag)
        If ((slot <= 39 AndAlso Me.Player.Bank1(slot).NetID = 0) OrElse (slot > 39 AndAlso Me.Player.Bank2(slot - 40).NetID = 0)) AndAlso e.KeyCode <> Keys.I Then
            Return
        End If

        ' Obtain the editing item..
        Dim item = If(slot <= 39, Me.Player.Bank1(slot), Me.Player.Bank2(slot - 40))

        ' Handle the key accordingly..
        Select Case e.KeyCode
            Case Keys.D
                ' Delete current item.. 
                If True Then
                    item.SetItem(0)
                    AddressOf item.Count = 0
                    Exit Select
                End If
            Case Keys.P
                ' Set prefix..
                If True Then
                    Dim prefix = DirectCast(Me.cboBankSafePrefix.SelectedItem, ItemPrefix)
                    item.Prefix = CByte(prefix.Id)
                    Exit Select
                End If
            Case Keys.M
                ' Set max stack..
                If True Then
                    AddressOf item.Count = InlineAssignHelper(item.Stack, item.MaxStack)
                    Exit Select
                End If
            Case Keys.H
                ' Set hacked stack..
                If True Then
                    If item.MaxStack > 1 Then
                        AddressOf item.Count = InlineAssignHelper(item.Stack, 999)
                    End If
                    Exit Select
                End If
            Case Keys.I
                ' Set item..
                If True Then
                    ' Ensure we have a selected item..
                    Dim selItem = DirectCast(Me.lstBankSafeItems.SelectedItem, Item)
                    If selItem Is Nothing Then
                        Return
                    End If

                    ' Set the item..
                    item.SetItem(selItem.Id)
                    AddressOf item.Count = InlineAssignHelper(item.Stack, item.MaxStack)
                    Exit Select
                End If
        End Select

        ' Update the item label..
        Me.m_SelectedBankSafeItem.Image = New Bitmap(String.Format("{0}\Data\Items\item_{1}.png", Application.StartupPath, item.NetID))
        Me.m_SelectedBankSafeItem.Text = AddressOf item.Count.ToString()
        Me.m_Tooltip.SetToolTip(Me.m_SelectedBankSafeItem, item.ToString())
    End Sub

    #End Region

    ''' <summary>
    ''' Adjusts the form size for each tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tcMainTabControl_SelectedIndexChanged(sender As Object, e As EventArgs)
        Select Case Me.tcMainTabControl.SelectedIndex
            ' Main Player
            ' Buffs                
            Case 0, 1, 3
                ' Equipment
                If True Then
                    Me.Width = DpiHelper.ScaleAsDpi(628)
                    Me.Height = DpiHelper.ScaleAsDpi(493)
                    Exit Select
                End If
            Case 2
                ' Inventory
                If True Then
                    Me.Width = DpiHelper.ScaleAsDpi(810)
                    Me.Height = DpiHelper.ScaleAsDpi(493)
                    Exit Select
                End If
            Case 4
                ' Bank / Safe
                If True Then
                    Me.Width = DpiHelper.ScaleAsDpi(705)
                    Me.Height = DpiHelper.ScaleAsDpi(560)
                    Exit Select
                End If
        End Select
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
