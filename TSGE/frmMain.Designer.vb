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

Imports System.Windows.Forms

Partial Class frmMain
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.tcMainTabControl = New System.Windows.Forms.TabControl()
		Me.tpMainPlayer = New System.Windows.Forms.TabPage()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.btnLoadColorHair = New System.Windows.Forms.Button()
		Me.btnSaveColorHair = New System.Windows.Forms.Button()
		Me.btnRandomColors = New System.Windows.Forms.Button()
		Me.btnRandomHair = New System.Windows.Forms.Button()
		Me.btnSelectHair = New System.Windows.Forms.Button()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.pbShoesColor = New System.Windows.Forms.PictureBox()
		Me.playerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.pbPantsColor = New System.Windows.Forms.PictureBox()
		Me.pbUndershirtColor = New System.Windows.Forms.PictureBox()
		Me.pbShirtColor = New System.Windows.Forms.PictureBox()
		Me.pbEyesColor = New System.Windows.Forms.PictureBox()
		Me.pbSkinColor = New System.Windows.Forms.PictureBox()
		Me.pbHairColor = New System.Windows.Forms.PictureBox()
		Me.modelViewer = New TSGE.Controls.ModelViewer()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtMaxMana = New System.Windows.Forms.TextBox()
		Me.txtCurrentMana = New System.Windows.Forms.TextBox()
		Me.txtMaxHealth = New System.Windows.Forms.TextBox()
		Me.txtCurrentHealth = New System.Windows.Forms.TextBox()
		Me.pbPlayerMana = New System.Windows.Forms.ProgressBar()
		Me.pbPlayerHealth = New System.Windows.Forms.ProgressBar()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.label32 = New System.Windows.Forms.Label()
		Me.txtFishQuestsCompleted = New System.Windows.Forms.TextBox()
		Me.chkHideVisual = New System.Windows.Forms.CheckBox()
		Me.cboDifficulty = New System.Windows.Forms.ComboBox()
		Me.txtPlayerName = New System.Windows.Forms.TextBox()
		Me.chkHotbarLocked = New System.Windows.Forms.CheckBox()
		Me.chkIsMale = New System.Windows.Forms.CheckBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tpBuffs = New System.Windows.Forms.TabPage()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.btnLoadBuffs = New System.Windows.Forms.Button()
		Me.btnSaveBuffs = New System.Windows.Forms.Button()
		Me.btnHackAllBuffDurations = New System.Windows.Forms.Button()
		Me.btnMaxAllBuffDurations = New System.Windows.Forms.Button()
		Me.btnDeleteAllBuffs = New System.Windows.Forms.Button()
		Me.btnHackBuffDuration = New System.Windows.Forms.Button()
		Me.btnMaxBuffDuration = New System.Windows.Forms.Button()
		Me.btnDeleteBuff = New System.Windows.Forms.Button()
		Me.lstBuffSelection = New TSGE.Controls.BuffSelectionListBox()
		Me.lstPlayerBuffs = New TSGE.Controls.BuffListBox()
		Me.buffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.tpInventory = New System.Windows.Forms.TabPage()
		Me.groupBox11 = New System.Windows.Forms.GroupBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.txtInventoryStackCount = New System.Windows.Forms.TextBox()
		Me.label28 = New System.Windows.Forms.Label()
		Me.cboInventoryPrefixCategory = New System.Windows.Forms.ComboBox()
		Me.label16 = New System.Windows.Forms.Label()
		Me.cboInventoryPrefix = New System.Windows.Forms.ComboBox()
		Me.btnInventoryHackAllStacks = New System.Windows.Forms.Button()
		Me.btnInventoryDeleteAllItems = New System.Windows.Forms.Button()
		Me.btnInventoryMaxAllStacks = New System.Windows.Forms.Button()
		Me.btnInventoryDeleteItem = New System.Windows.Forms.Button()
		Me.btnLoadInventory = New System.Windows.Forms.Button()
		Me.btnSaveInventory = New System.Windows.Forms.Button()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.lstInventoryItems = New System.Windows.Forms.ListBox()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me.cboInvItemFilter = New System.Windows.Forms.ComboBox()
		Me.label15 = New System.Windows.Forms.Label()
		Me.txtInvItemFilter = New System.Windows.Forms.TextBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.inventoryItem54 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem53 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem57 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem52 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem56 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem51 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem55 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem50 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem40 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem41 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem42 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem43 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem44 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem45 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem46 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem47 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem48 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem49 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem30 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem31 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem32 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem33 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem34 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem35 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem36 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem37 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem38 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem39 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem20 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem21 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem22 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem23 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem24 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem25 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem26 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem27 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem28 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem29 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem10 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem11 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem12 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem13 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem14 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem15 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem16 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem17 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem18 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem19 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem09 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem08 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem07 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem06 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem05 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem04 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem03 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem02 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem01 = New TSGE.Controls.ItemLabel()
		Me.inventoryItem00 = New TSGE.Controls.ItemLabel()
		Me.tpEquipment = New System.Windows.Forms.TabPage()
		Me.equipmentItem23 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem22 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem21 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem20 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem19 = New TSGE.Controls.ItemLabel()
		Me.label31 = New System.Windows.Forms.Label()
		Me.equipmentItem18 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem17 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem16 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem15 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem14 = New TSGE.Controls.ItemLabel()
		Me.btnLoadEquipmentSet = New System.Windows.Forms.Button()
		Me.btnSaveEquipmentSet = New System.Windows.Forms.Button()
		Me.label23 = New System.Windows.Forms.Label()
		Me.label22 = New System.Windows.Forms.Label()
		Me.label21 = New System.Windows.Forms.Label()
		Me.label20 = New System.Windows.Forms.Label()
		Me.groupBox7 = New System.Windows.Forms.GroupBox()
		Me.label29 = New System.Windows.Forms.Label()
		Me.cboEquipmentPrefixCategory = New System.Windows.Forms.ComboBox()
		Me.label19 = New System.Windows.Forms.Label()
		Me.cboEquipmentPrefix = New System.Windows.Forms.ComboBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.txtEquipmentFilter = New System.Windows.Forms.TextBox()
		Me.lstEquipmentItems = New System.Windows.Forms.ListBox()
		Me.equipmentItem13 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem12 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem11 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem10 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem09 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem08 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem07 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem06 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem05 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem04 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem03 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem02 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem01 = New TSGE.Controls.ItemLabel()
		Me.equipmentItem00 = New TSGE.Controls.ItemLabel()
		Me.tpBankSafe = New System.Windows.Forms.TabPage()
		Me.btnLoadSafeItems = New System.Windows.Forms.Button()
		Me.btnSaveSafeItems = New System.Windows.Forms.Button()
		Me.btnLoadBankItems = New System.Windows.Forms.Button()
		Me.btnSaveBankItems = New System.Windows.Forms.Button()
		Me.groupBox8 = New System.Windows.Forms.GroupBox()
		Me.label30 = New System.Windows.Forms.Label()
		Me.cboBankSafePrefixCategory = New System.Windows.Forms.ComboBox()
		Me.btnHackAllBankSafeStacks = New System.Windows.Forms.Button()
		Me.btnMaxAllBankSafeStacks = New System.Windows.Forms.Button()
		Me.btnDeleteAllSafeItems = New System.Windows.Forms.Button()
		Me.btnDeleteAllBankItems = New System.Windows.Forms.Button()
		Me.label27 = New System.Windows.Forms.Label()
		Me.txtBankSafeStackCount = New System.Windows.Forms.TextBox()
		Me.label26 = New System.Windows.Forms.Label()
		Me.cboBankSafeItemFilter = New System.Windows.Forms.ComboBox()
		Me.label24 = New System.Windows.Forms.Label()
		Me.cboBankSafePrefix = New System.Windows.Forms.ComboBox()
		Me.label25 = New System.Windows.Forms.Label()
		Me.txtBankSafeFilter = New System.Windows.Forms.TextBox()
		Me.lstBankSafeItems = New System.Windows.Forms.ListBox()
		Me.groupBox9 = New System.Windows.Forms.GroupBox()
		Me.bankSafeItem02 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem01 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem03 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem04 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem05 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem06 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem07 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem08 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem16 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem15 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem14 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem13 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem12 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem11 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem10 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem09 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem24 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem23 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem22 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem21 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem20 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem19 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem18 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem17 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem32 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem31 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem30 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem29 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem28 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem27 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem26 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem25 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem39 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem38 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem37 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem36 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem35 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem34 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem33 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem00 = New TSGE.Controls.ItemLabel()
		Me.groupBox10 = New System.Windows.Forms.GroupBox()
		Me.bankSafeItem40 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem41 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem79 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem42 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem78 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem43 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem77 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem44 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem76 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem45 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem75 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem46 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem74 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem47 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem73 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem48 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem72 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem49 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem71 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem50 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem70 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem51 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem69 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem52 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem68 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem53 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem67 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem54 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem66 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem55 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem65 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem56 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem64 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem57 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem63 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem58 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem62 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem59 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem61 = New TSGE.Controls.ItemLabel()
		Me.bankSafeItem60 = New TSGE.Controls.ItemLabel()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.tscboQuickSelect = New System.Windows.Forms.ToolStripComboBox()
		Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.newCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutTSGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.checkForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.inventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.tcMainTabControl.SuspendLayout()
		Me.tpMainPlayer.SuspendLayout()
		Me.groupBox3.SuspendLayout()
		DirectCast(Me.pbShoesColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.playerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbPantsColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbUndershirtColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbShirtColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbEyesColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbSkinColor, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.pbHairColor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox2.SuspendLayout()
		Me.groupBox1.SuspendLayout()
		Me.tpBuffs.SuspendLayout()
		Me.groupBox4.SuspendLayout()
		DirectCast(Me.buffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpInventory.SuspendLayout()
		Me.groupBox11.SuspendLayout()
		Me.groupBox5.SuspendLayout()
		Me.groupBox6.SuspendLayout()
		Me.tpEquipment.SuspendLayout()
		Me.groupBox7.SuspendLayout()
		Me.tpBankSafe.SuspendLayout()
		Me.groupBox8.SuspendLayout()
		Me.groupBox9.SuspendLayout()
		Me.groupBox10.SuspendLayout()
		Me.menuStrip1.SuspendLayout()
		DirectCast(Me.inventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' tcMainTabControl
		' 
		Me.tcMainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tcMainTabControl.Controls.Add(Me.tpMainPlayer)
		Me.tcMainTabControl.Controls.Add(Me.tpBuffs)
		Me.tcMainTabControl.Controls.Add(Me.tpInventory)
		Me.tcMainTabControl.Controls.Add(Me.tpEquipment)
		Me.tcMainTabControl.Controls.Add(Me.tpBankSafe)
		Me.tcMainTabControl.Location = New System.Drawing.Point(0, 25)
		Me.tcMainTabControl.Name = "tcMainTabControl"
		Me.tcMainTabControl.Padding = New System.Drawing.Point(25, 3)
		Me.tcMainTabControl.SelectedIndex = 0
		Me.tcMainTabControl.Size = New System.Drawing.Size(620, 441)
		Me.tcMainTabControl.TabIndex = 1
		AddHandler Me.tcMainTabControl.SelectedIndexChanged, New System.EventHandler(AddressOf Me.tcMainTabControl_SelectedIndexChanged)
		' 
		' tpMainPlayer
		' 
		Me.tpMainPlayer.Controls.Add(Me.groupBox3)
		Me.tpMainPlayer.Controls.Add(Me.groupBox2)
		Me.tpMainPlayer.Controls.Add(Me.groupBox1)
		Me.tpMainPlayer.Location = New System.Drawing.Point(4, 22)
		Me.tpMainPlayer.Name = "tpMainPlayer"
		Me.tpMainPlayer.Padding = New System.Windows.Forms.Padding(3)
		Me.tpMainPlayer.Size = New System.Drawing.Size(612, 415)
		Me.tpMainPlayer.TabIndex = 0
		Me.tpMainPlayer.Text = "Player"
		Me.tpMainPlayer.UseVisualStyleBackColor = True
		' 
		' groupBox3
		' 
		Me.groupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox3.Controls.Add(Me.btnLoadColorHair)
		Me.groupBox3.Controls.Add(Me.btnSaveColorHair)
		Me.groupBox3.Controls.Add(Me.btnRandomColors)
		Me.groupBox3.Controls.Add(Me.btnRandomHair)
		Me.groupBox3.Controls.Add(Me.btnSelectHair)
		Me.groupBox3.Controls.Add(Me.label13)
		Me.groupBox3.Controls.Add(Me.label12)
		Me.groupBox3.Controls.Add(Me.label11)
		Me.groupBox3.Controls.Add(Me.label10)
		Me.groupBox3.Controls.Add(Me.label9)
		Me.groupBox3.Controls.Add(Me.label8)
		Me.groupBox3.Controls.Add(Me.label7)
		Me.groupBox3.Controls.Add(Me.pbShoesColor)
		Me.groupBox3.Controls.Add(Me.pbPantsColor)
		Me.groupBox3.Controls.Add(Me.pbUndershirtColor)
		Me.groupBox3.Controls.Add(Me.pbShirtColor)
		Me.groupBox3.Controls.Add(Me.pbEyesColor)
		Me.groupBox3.Controls.Add(Me.pbSkinColor)
		Me.groupBox3.Controls.Add(Me.pbHairColor)
		Me.groupBox3.Controls.Add(Me.modelViewer)
		Me.groupBox3.Location = New System.Drawing.Point(8, 145)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(588, 255)
		Me.groupBox3.TabIndex = 4
		Me.groupBox3.TabStop = False
		Me.groupBox3.Text = "Colors"
		' 
		' btnLoadColorHair
		' 
		Me.btnLoadColorHair.Location = New System.Drawing.Point(449, 213)
		Me.btnLoadColorHair.Name = "btnLoadColorHair"
		Me.btnLoadColorHair.Size = New System.Drawing.Size(120, 23)
		Me.btnLoadColorHair.TabIndex = 21
		Me.btnLoadColorHair.Text = "Load Color && Hair"
		Me.btnLoadColorHair.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadColorHair.Click, New System.EventHandler(AddressOf Me.btnLoadColorHair_Click)
		' 
		' btnSaveColorHair
		' 
		Me.btnSaveColorHair.Location = New System.Drawing.Point(449, 184)
		Me.btnSaveColorHair.Name = "btnSaveColorHair"
		Me.btnSaveColorHair.Size = New System.Drawing.Size(120, 23)
		Me.btnSaveColorHair.TabIndex = 20
		Me.btnSaveColorHair.Text = "Save Color && Hair"
		Me.btnSaveColorHair.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveColorHair.Click, New System.EventHandler(AddressOf Me.btnSaveColorHair_Click)
		' 
		' btnRandomColors
		' 
		Me.btnRandomColors.Location = New System.Drawing.Point(449, 83)
		Me.btnRandomColors.Name = "btnRandomColors"
		Me.btnRandomColors.Size = New System.Drawing.Size(120, 23)
		Me.btnRandomColors.TabIndex = 19
		Me.btnRandomColors.Text = "Random Colors"
		Me.btnRandomColors.UseVisualStyleBackColor = True
		AddHandler Me.btnRandomColors.Click, New System.EventHandler(AddressOf Me.btnRandomColors_Click)
		' 
		' btnRandomHair
		' 
		Me.btnRandomHair.Location = New System.Drawing.Point(449, 54)
		Me.btnRandomHair.Name = "btnRandomHair"
		Me.btnRandomHair.Size = New System.Drawing.Size(120, 23)
		Me.btnRandomHair.TabIndex = 18
		Me.btnRandomHair.Text = "Random Hair"
		Me.btnRandomHair.UseVisualStyleBackColor = True
		AddHandler Me.btnRandomHair.Click, New System.EventHandler(AddressOf Me.btnRandomHair_Click)
		' 
		' btnSelectHair
		' 
		Me.btnSelectHair.Location = New System.Drawing.Point(449, 19)
		Me.btnSelectHair.Name = "btnSelectHair"
		Me.btnSelectHair.Size = New System.Drawing.Size(120, 23)
		Me.btnSelectHair.TabIndex = 17
		Me.btnSelectHair.Text = "Select Hair"
		Me.btnSelectHair.UseVisualStyleBackColor = True
		AddHandler Me.btnSelectHair.Click, New System.EventHandler(AddressOf Me.btnSelectHair_Click)
		' 
		' label13
		' 
		Me.label13.AutoSize = True
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label13.Location = New System.Drawing.Point(29, 225)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(79, 13)
		Me.label13.TabIndex = 16
		Me.label13.Text = "Shoes Color:"
		' 
		' label12
		' 
		Me.label12.AutoSize = True
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label12.Location = New System.Drawing.Point(32, 192)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(76, 13)
		Me.label12.TabIndex = 15
		Me.label12.Text = "Pants Color:"
		' 
		' label11
		' 
		Me.label11.AutoSize = True
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label11.Location = New System.Drawing.Point(6, 159)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(102, 13)
		Me.label11.TabIndex = 14
		Me.label11.Text = "Undershirt Color:"
		' 
		' label10
		' 
		Me.label10.AutoSize = True
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label10.Location = New System.Drawing.Point(38, 126)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(70, 13)
		Me.label10.TabIndex = 13
		Me.label10.Text = "Shirt Color:"
		' 
		' label9
		' 
		Me.label9.AutoSize = True
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label9.Location = New System.Drawing.Point(37, 93)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(71, 13)
		Me.label9.TabIndex = 12
		Me.label9.Text = "Eyes Color:"
		' 
		' label8
		' 
		Me.label8.AutoSize = True
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label8.Location = New System.Drawing.Point(39, 60)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(69, 13)
		Me.label8.TabIndex = 11
		Me.label8.Text = "Skin Color:"
		' 
		' label7
		' 
		Me.label7.AutoSize = True
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label7.Location = New System.Drawing.Point(41, 27)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(67, 13)
		Me.label7.TabIndex = 10
		Me.label7.Text = "Hair Color:"
		' 
		' pbShoesColor
		' 
		Me.pbShoesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbShoesColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "ShoesColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbShoesColor.Location = New System.Drawing.Point(114, 217)
		Me.pbShoesColor.Name = "pbShoesColor"
		Me.pbShoesColor.Size = New System.Drawing.Size(80, 27)
		Me.pbShoesColor.TabIndex = 9
		Me.pbShoesColor.TabStop = False
		AddHandler Me.pbShoesColor.Click, New System.EventHandler(AddressOf Me.pbShoesColor_Click)
		' 
		' playerBindingSource
		' 
		Me.playerBindingSource.DataSource = GetType(TSGE.Classes.Player)
		' 
		' pbPantsColor
		' 
		Me.pbPantsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbPantsColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "PantsColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbPantsColor.Location = New System.Drawing.Point(114, 184)
		Me.pbPantsColor.Name = "pbPantsColor"
		Me.pbPantsColor.Size = New System.Drawing.Size(80, 27)
		Me.pbPantsColor.TabIndex = 8
		Me.pbPantsColor.TabStop = False
		AddHandler Me.pbPantsColor.Click, New System.EventHandler(AddressOf Me.pbPantsColor_Click)
		' 
		' pbUndershirtColor
		' 
		Me.pbUndershirtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbUndershirtColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "UndershirtColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbUndershirtColor.Location = New System.Drawing.Point(114, 151)
		Me.pbUndershirtColor.Name = "pbUndershirtColor"
		Me.pbUndershirtColor.Size = New System.Drawing.Size(80, 27)
		Me.pbUndershirtColor.TabIndex = 7
		Me.pbUndershirtColor.TabStop = False
		AddHandler Me.pbUndershirtColor.Click, New System.EventHandler(AddressOf Me.pbUndershirtColor_Click)
		' 
		' pbShirtColor
		' 
		Me.pbShirtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbShirtColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "ShirtColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbShirtColor.Location = New System.Drawing.Point(114, 118)
		Me.pbShirtColor.Name = "pbShirtColor"
		Me.pbShirtColor.Size = New System.Drawing.Size(80, 27)
		Me.pbShirtColor.TabIndex = 6
		Me.pbShirtColor.TabStop = False
		AddHandler Me.pbShirtColor.Click, New System.EventHandler(AddressOf Me.pbShirtColor_Click)
		' 
		' pbEyesColor
		' 
		Me.pbEyesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbEyesColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "EyeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbEyesColor.Location = New System.Drawing.Point(114, 85)
		Me.pbEyesColor.Name = "pbEyesColor"
		Me.pbEyesColor.Size = New System.Drawing.Size(80, 27)
		Me.pbEyesColor.TabIndex = 5
		Me.pbEyesColor.TabStop = False
		AddHandler Me.pbEyesColor.Click, New System.EventHandler(AddressOf Me.pbEyesColor_Click)
		' 
		' pbSkinColor
		' 
		Me.pbSkinColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbSkinColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "SkinColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbSkinColor.Location = New System.Drawing.Point(114, 52)
		Me.pbSkinColor.Name = "pbSkinColor"
		Me.pbSkinColor.Size = New System.Drawing.Size(80, 27)
		Me.pbSkinColor.TabIndex = 4
		Me.pbSkinColor.TabStop = False
		AddHandler Me.pbSkinColor.Click, New System.EventHandler(AddressOf Me.pbSkinColor_Click)
		' 
		' pbHairColor
		' 
		Me.pbHairColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbHairColor.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.playerBindingSource, "HairColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbHairColor.Location = New System.Drawing.Point(114, 19)
		Me.pbHairColor.Name = "pbHairColor"
		Me.pbHairColor.Size = New System.Drawing.Size(80, 27)
		Me.pbHairColor.TabIndex = 3
		Me.pbHairColor.TabStop = False
		AddHandler Me.pbHairColor.Click, New System.EventHandler(AddressOf Me.pbHairColor_Click)
		' 
		' modelViewer
		' 
		Me.modelViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("EyeColor", Me.playerBindingSource, "EyeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("HairColor", Me.playerBindingSource, "HairColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("HairId", Me.playerBindingSource, "Hair", True))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("HandsColor", Me.playerBindingSource, "SkinColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("HeadColor", Me.playerBindingSource, "SkinColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("PantsColor", Me.playerBindingSource, "PantsColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("ShirtColor", Me.playerBindingSource, "ShirtColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("ShoesColor", Me.playerBindingSource, "ShoesColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.DataBindings.Add(New System.Windows.Forms.Binding("UndershirtColor", Me.playerBindingSource, "UndershirtColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.modelViewer.EyeColor = System.Drawing.Color.FromArgb(CInt(CByte(105)), CInt(CByte(90)), CInt(CByte(75)))
		Me.modelViewer.EyeFile = "Data\Eyes\eyes.png"
		Me.modelViewer.EyeWhitesColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(255)))
		Me.modelViewer.EyeWhitesFile = "Data\Eyes\eye_whites.png"
		Me.modelViewer.HairColor = System.Drawing.Color.FromArgb(CInt(CByte(215)), CInt(CByte(90)), CInt(CByte(55)))
		Me.modelViewer.HairFile = "Data\Hair\hair_0.png"
		Me.modelViewer.HairId = 0
		Me.modelViewer.HandsColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(125)), CInt(CByte(75)))
		Me.modelViewer.HandsFile = "Data\Hands\hands.png"
		Me.modelViewer.HeadColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(125)), CInt(CByte(75)))
		Me.modelViewer.HeadFile = "Data\Heads\head.png"
		Me.modelViewer.LargestImageHeight = 0
		Me.modelViewer.LargestImageWidth = 0
		Me.modelViewer.Location = New System.Drawing.Point(200, 19)
		Me.modelViewer.Name = "modelViewer"
		Me.modelViewer.PantsColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(230)), CInt(CByte(175)))
		Me.modelViewer.PantsFile = "Data\Pants\pants.png"
		Me.modelViewer.ShirtColor = System.Drawing.Color.FromArgb(CInt(CByte(175)), CInt(CByte(165)), CInt(CByte(140)))
		Me.modelViewer.ShirtFile = "Data\Shirts\shirt.png"
		Me.modelViewer.ShoesColor = System.Drawing.Color.FromArgb(CInt(CByte(160)), CInt(CByte(106)), CInt(CByte(60)))
		Me.modelViewer.ShoesFile = "Data\Shoes\shoes.png"
		Me.modelViewer.Size = New System.Drawing.Size(150, 225)
		Me.modelViewer.Suspended = False
		Me.modelViewer.TabIndex = 2
		Me.modelViewer.UndershirtColor = System.Drawing.Color.FromArgb(CInt(CByte(160)), CInt(CByte(180)), CInt(CByte(215)))
		Me.modelViewer.UnderShirtFile = "Data\UnderShirts\undershirt.png"
		' 
		' groupBox2
		' 
		Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox2.Controls.Add(Me.txtMaxMana)
		Me.groupBox2.Controls.Add(Me.txtCurrentMana)
		Me.groupBox2.Controls.Add(Me.txtMaxHealth)
		Me.groupBox2.Controls.Add(Me.txtCurrentHealth)
		Me.groupBox2.Controls.Add(Me.pbPlayerMana)
		Me.groupBox2.Controls.Add(Me.pbPlayerHealth)
		Me.groupBox2.Controls.Add(Me.label4)
		Me.groupBox2.Controls.Add(Me.label3)
		Me.groupBox2.Location = New System.Drawing.Point(305, 6)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(291, 133)
		Me.groupBox2.TabIndex = 3
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "Health / Mana"
		' 
		' txtMaxMana
		' 
		Me.txtMaxMana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtMaxMana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "ManaMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtMaxMana.Location = New System.Drawing.Point(211, 68)
		Me.txtMaxMana.Name = "txtMaxMana"
		Me.txtMaxMana.Size = New System.Drawing.Size(61, 20)
		Me.txtMaxMana.TabIndex = 26
		' 
		' txtCurrentMana
		' 
		Me.txtCurrentMana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCurrentMana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "Mana", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtCurrentMana.Location = New System.Drawing.Point(144, 68)
		Me.txtCurrentMana.Name = "txtCurrentMana"
		Me.txtCurrentMana.Size = New System.Drawing.Size(61, 20)
		Me.txtCurrentMana.TabIndex = 25
		' 
		' txtMaxHealth
		' 
		Me.txtMaxHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtMaxHealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "HealthMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtMaxHealth.Location = New System.Drawing.Point(211, 17)
		Me.txtMaxHealth.Name = "txtMaxHealth"
		Me.txtMaxHealth.Size = New System.Drawing.Size(61, 20)
		Me.txtMaxHealth.TabIndex = 24
		' 
		' txtCurrentHealth
		' 
		Me.txtCurrentHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCurrentHealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "Health", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtCurrentHealth.Location = New System.Drawing.Point(144, 17)
		Me.txtCurrentHealth.Name = "txtCurrentHealth"
		Me.txtCurrentHealth.Size = New System.Drawing.Size(61, 20)
		Me.txtCurrentHealth.TabIndex = 23
		' 
		' pbPlayerMana
		' 
		Me.pbPlayerMana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbPlayerMana.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.playerBindingSource, "Mana", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbPlayerMana.DataBindings.Add(New System.Windows.Forms.Binding("Maximum", Me.playerBindingSource, "ManaMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbPlayerMana.ForeColor = System.Drawing.Color.DodgerBlue
		Me.pbPlayerMana.Location = New System.Drawing.Point(16, 94)
		Me.pbPlayerMana.Name = "pbPlayerMana"
		Me.pbPlayerMana.Size = New System.Drawing.Size(256, 23)
		Me.pbPlayerMana.TabIndex = 22
		Me.pbPlayerMana.Value = 100
		' 
		' pbPlayerHealth
		' 
		Me.pbPlayerHealth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbPlayerHealth.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.playerBindingSource, "Health", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbPlayerHealth.DataBindings.Add(New System.Windows.Forms.Binding("Maximum", Me.playerBindingSource, "HealthMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.pbPlayerHealth.ForeColor = System.Drawing.Color.Chartreuse
		Me.pbPlayerHealth.Location = New System.Drawing.Point(16, 43)
		Me.pbPlayerHealth.Name = "pbPlayerHealth"
		Me.pbPlayerHealth.Size = New System.Drawing.Size(256, 23)
		Me.pbPlayerHealth.TabIndex = 21
		Me.pbPlayerHealth.Value = 100
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label4.Location = New System.Drawing.Point(13, 78)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(42, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "Mana:"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label3.Location = New System.Drawing.Point(13, 27)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(48, 13)
		Me.label3.TabIndex = 0
		Me.label3.Text = "Health:"
		' 
		' groupBox1
		' 
		Me.groupBox1.Controls.Add(Me.label32)
		Me.groupBox1.Controls.Add(Me.txtFishQuestsCompleted)
		Me.groupBox1.Controls.Add(Me.chkHideVisual)
		Me.groupBox1.Controls.Add(Me.cboDifficulty)
		Me.groupBox1.Controls.Add(Me.txtPlayerName)
		Me.groupBox1.Controls.Add(Me.chkHotbarLocked)
		Me.groupBox1.Controls.Add(Me.chkIsMale)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.groupBox1.Location = New System.Drawing.Point(8, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(291, 133)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Player"
		' 
		' label32
		' 
		Me.label32.AutoSize = True
		Me.label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label32.Location = New System.Drawing.Point(21, 100)
		Me.label32.Name = "label32"
		Me.label32.Size = New System.Drawing.Size(77, 13)
		Me.label32.TabIndex = 25
		Me.label32.Text = "Fish Quests:"
		' 
		' txtFishQuestsCompleted
		' 
		Me.txtFishQuestsCompleted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "AnglerQuestsFinished", True))
		Me.txtFishQuestsCompleted.Location = New System.Drawing.Point(104, 97)
		Me.txtFishQuestsCompleted.Name = "txtFishQuestsCompleted"
		Me.txtFishQuestsCompleted.Size = New System.Drawing.Size(61, 20)
		Me.txtFishQuestsCompleted.TabIndex = 24
		' 
		' chkHideVisual
		' 
		Me.chkHideVisual.AutoSize = True
		Me.chkHideVisual.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.playerBindingSource, "HideVisual", True))
		Me.chkHideVisual.Location = New System.Drawing.Point(176, 100)
		Me.chkHideVisual.Name = "chkHideVisual"
		Me.chkHideVisual.Size = New System.Drawing.Size(85, 17)
		Me.chkHideVisual.TabIndex = 6
		Me.chkHideVisual.Text = "Hide Visual?"
		Me.chkHideVisual.UseVisualStyleBackColor = True
		' 
		' cboDifficulty
		' 
		Me.cboDifficulty.DataBindings.Add(New System.Windows.Forms.Binding("SelectedIndex", Me.playerBindingSource, "Difficulty", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cboDifficulty.FormattingEnabled = True
		Me.cboDifficulty.Items.AddRange(New Object() {"Softcore", "Mediumcore", "Hardcore"})
		Me.cboDifficulty.Location = New System.Drawing.Point(104, 50)
		Me.cboDifficulty.Name = "cboDifficulty"
		Me.cboDifficulty.Size = New System.Drawing.Size(168, 21)
		Me.cboDifficulty.TabIndex = 5
		' 
		' txtPlayerName
		' 
		Me.txtPlayerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.playerBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.txtPlayerName.Location = New System.Drawing.Point(104, 24)
		Me.txtPlayerName.Name = "txtPlayerName"
		Me.txtPlayerName.Size = New System.Drawing.Size(168, 20)
		Me.txtPlayerName.TabIndex = 4
		' 
		' chkHotbarLocked
		' 
		Me.chkHotbarLocked.AutoSize = True
		Me.chkHotbarLocked.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.playerBindingSource, "IsHotbarLocked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkHotbarLocked.Location = New System.Drawing.Point(176, 77)
		Me.chkHotbarLocked.Name = "chkHotbarLocked"
		Me.chkHotbarLocked.Size = New System.Drawing.Size(103, 17)
		Me.chkHotbarLocked.TabIndex = 3
		Me.chkHotbarLocked.Text = "Hotbar Locked?"
		Me.chkHotbarLocked.UseVisualStyleBackColor = True
		' 
		' chkIsMale
		' 
		Me.chkIsMale.AutoSize = True
		Me.chkIsMale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.playerBindingSource, "IsMale", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.chkIsMale.Location = New System.Drawing.Point(104, 77)
		Me.chkIsMale.Name = "chkIsMale"
		Me.chkIsMale.Size = New System.Drawing.Size(66, 17)
		Me.chkIsMale.TabIndex = 2
		Me.chkIsMale.Text = "Is Male?"
		Me.chkIsMale.UseVisualStyleBackColor = True
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(37, 53)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(61, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Difficulty:"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(16, 27)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(82, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Player Name:"
		' 
		' tpBuffs
		' 
		Me.tpBuffs.Controls.Add(Me.groupBox4)
		Me.tpBuffs.Controls.Add(Me.lstPlayerBuffs)
		Me.tpBuffs.Location = New System.Drawing.Point(4, 22)
		Me.tpBuffs.Name = "tpBuffs"
		Me.tpBuffs.Padding = New System.Windows.Forms.Padding(3)
		Me.tpBuffs.Size = New System.Drawing.Size(612, 415)
		Me.tpBuffs.TabIndex = 1
		Me.tpBuffs.Text = "Buffs"
		Me.tpBuffs.UseVisualStyleBackColor = True
		' 
		' groupBox4
		' 
		Me.groupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox4.Controls.Add(Me.btnLoadBuffs)
		Me.groupBox4.Controls.Add(Me.btnSaveBuffs)
		Me.groupBox4.Controls.Add(Me.btnHackAllBuffDurations)
		Me.groupBox4.Controls.Add(Me.btnMaxAllBuffDurations)
		Me.groupBox4.Controls.Add(Me.btnDeleteAllBuffs)
		Me.groupBox4.Controls.Add(Me.btnHackBuffDuration)
		Me.groupBox4.Controls.Add(Me.btnMaxBuffDuration)
		Me.groupBox4.Controls.Add(Me.btnDeleteBuff)
		Me.groupBox4.Controls.Add(Me.lstBuffSelection)
		Me.groupBox4.Location = New System.Drawing.Point(309, 6)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(295, 403)
		Me.groupBox4.TabIndex = 1
		Me.groupBox4.TabStop = False
		Me.groupBox4.Text = "Buff Editor"
		' 
		' btnLoadBuffs
		' 
		Me.btnLoadBuffs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnLoadBuffs.Location = New System.Drawing.Point(164, 374)
		Me.btnLoadBuffs.Name = "btnLoadBuffs"
		Me.btnLoadBuffs.Size = New System.Drawing.Size(125, 23)
		Me.btnLoadBuffs.TabIndex = 8
		Me.btnLoadBuffs.Text = "Load Buffs"
		Me.btnLoadBuffs.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadBuffs.Click, New System.EventHandler(AddressOf Me.btnLoadBuffs_Click)
		' 
		' btnSaveBuffs
		' 
		Me.btnSaveBuffs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnSaveBuffs.Location = New System.Drawing.Point(6, 374)
		Me.btnSaveBuffs.Name = "btnSaveBuffs"
		Me.btnSaveBuffs.Size = New System.Drawing.Size(125, 23)
		Me.btnSaveBuffs.TabIndex = 7
		Me.btnSaveBuffs.Text = "Save Buffs"
		Me.btnSaveBuffs.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveBuffs.Click, New System.EventHandler(AddressOf Me.btnSaveBuffs_Click)
		' 
		' btnHackAllBuffDurations
		' 
		Me.btnHackAllBuffDurations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnHackAllBuffDurations.Location = New System.Drawing.Point(164, 334)
		Me.btnHackAllBuffDurations.Name = "btnHackAllBuffDurations"
		Me.btnHackAllBuffDurations.Size = New System.Drawing.Size(125, 23)
		Me.btnHackAllBuffDurations.TabIndex = 6
		Me.btnHackAllBuffDurations.Text = "Hack All Durations"
		Me.btnHackAllBuffDurations.UseVisualStyleBackColor = True
		AddHandler Me.btnHackAllBuffDurations.Click, New System.EventHandler(AddressOf Me.btnHackAllBuffDurations_Click)
		' 
		' btnMaxAllBuffDurations
		' 
		Me.btnMaxAllBuffDurations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnMaxAllBuffDurations.Location = New System.Drawing.Point(164, 305)
		Me.btnMaxAllBuffDurations.Name = "btnMaxAllBuffDurations"
		Me.btnMaxAllBuffDurations.Size = New System.Drawing.Size(125, 23)
		Me.btnMaxAllBuffDurations.TabIndex = 5
		Me.btnMaxAllBuffDurations.Text = "Max All Durations"
		Me.btnMaxAllBuffDurations.UseVisualStyleBackColor = True
		AddHandler Me.btnMaxAllBuffDurations.Click, New System.EventHandler(AddressOf Me.btnMaxAllBuffDurations_Click)
		' 
		' btnDeleteAllBuffs
		' 
		Me.btnDeleteAllBuffs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnDeleteAllBuffs.Location = New System.Drawing.Point(164, 276)
		Me.btnDeleteAllBuffs.Name = "btnDeleteAllBuffs"
		Me.btnDeleteAllBuffs.Size = New System.Drawing.Size(125, 23)
		Me.btnDeleteAllBuffs.TabIndex = 4
		Me.btnDeleteAllBuffs.Text = "Delete All"
		Me.btnDeleteAllBuffs.UseVisualStyleBackColor = True
		AddHandler Me.btnDeleteAllBuffs.Click, New System.EventHandler(AddressOf Me.btnDeleteAllBuffs_Click)
		' 
		' btnHackBuffDuration
		' 
		Me.btnHackBuffDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnHackBuffDuration.Location = New System.Drawing.Point(6, 334)
		Me.btnHackBuffDuration.Name = "btnHackBuffDuration"
		Me.btnHackBuffDuration.Size = New System.Drawing.Size(125, 23)
		Me.btnHackBuffDuration.TabIndex = 3
		Me.btnHackBuffDuration.Text = "Hack Duration"
		Me.btnHackBuffDuration.UseVisualStyleBackColor = True
		AddHandler Me.btnHackBuffDuration.Click, New System.EventHandler(AddressOf Me.btnHackBuffDuration_Click)
		' 
		' btnMaxBuffDuration
		' 
		Me.btnMaxBuffDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnMaxBuffDuration.Location = New System.Drawing.Point(6, 305)
		Me.btnMaxBuffDuration.Name = "btnMaxBuffDuration"
		Me.btnMaxBuffDuration.Size = New System.Drawing.Size(125, 23)
		Me.btnMaxBuffDuration.TabIndex = 2
		Me.btnMaxBuffDuration.Text = "Max Duration"
		Me.btnMaxBuffDuration.UseVisualStyleBackColor = True
		AddHandler Me.btnMaxBuffDuration.Click, New System.EventHandler(AddressOf Me.btnMaxBuffDuration_Click)
		' 
		' btnDeleteBuff
		' 
		Me.btnDeleteBuff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnDeleteBuff.Location = New System.Drawing.Point(6, 276)
		Me.btnDeleteBuff.Name = "btnDeleteBuff"
		Me.btnDeleteBuff.Size = New System.Drawing.Size(125, 23)
		Me.btnDeleteBuff.TabIndex = 1
		Me.btnDeleteBuff.Text = "Delete"
		Me.btnDeleteBuff.UseVisualStyleBackColor = True
		AddHandler Me.btnDeleteBuff.Click, New System.EventHandler(AddressOf Me.btnDeleteBuff_Click)
		' 
		' lstBuffSelection
		' 
		Me.lstBuffSelection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstBuffSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
		Me.lstBuffSelection.FormattingEnabled = True
		Me.lstBuffSelection.ItemHeight = 38
		Me.lstBuffSelection.Location = New System.Drawing.Point(6, 19)
		Me.lstBuffSelection.Name = "lstBuffSelection"
		Me.lstBuffSelection.Size = New System.Drawing.Size(283, 251)
		Me.lstBuffSelection.TabIndex = 0
		AddHandler Me.lstBuffSelection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lstBuffSelection_SelectedIndexChanged)
		' 
		' lstPlayerBuffs
		' 
		Me.lstPlayerBuffs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstPlayerBuffs.DataSource = Me.buffsBindingSource
		Me.lstPlayerBuffs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
		Me.lstPlayerBuffs.FormattingEnabled = True
		Me.lstPlayerBuffs.IntegralHeight = False
		Me.lstPlayerBuffs.ItemHeight = 60
		Me.lstPlayerBuffs.Location = New System.Drawing.Point(8, 6)
		Me.lstPlayerBuffs.Name = "lstPlayerBuffs"
		Me.lstPlayerBuffs.Size = New System.Drawing.Size(295, 403)
		Me.lstPlayerBuffs.TabIndex = 0
		' 
		' buffsBindingSource
		' 
		Me.buffsBindingSource.DataMember = "Buffs"
		Me.buffsBindingSource.DataSource = Me.playerBindingSource
		' 
		' tpInventory
		' 
		Me.tpInventory.Controls.Add(Me.groupBox11)
		Me.tpInventory.Controls.Add(Me.btnInventoryHackAllStacks)
		Me.tpInventory.Controls.Add(Me.btnInventoryDeleteAllItems)
		Me.tpInventory.Controls.Add(Me.btnInventoryMaxAllStacks)
		Me.tpInventory.Controls.Add(Me.btnInventoryDeleteItem)
		Me.tpInventory.Controls.Add(Me.btnLoadInventory)
		Me.tpInventory.Controls.Add(Me.btnSaveInventory)
		Me.tpInventory.Controls.Add(Me.groupBox5)
		Me.tpInventory.Controls.Add(Me.label6)
		Me.tpInventory.Controls.Add(Me.label5)
		Me.tpInventory.Controls.Add(Me.inventoryItem54)
		Me.tpInventory.Controls.Add(Me.inventoryItem53)
		Me.tpInventory.Controls.Add(Me.inventoryItem57)
		Me.tpInventory.Controls.Add(Me.inventoryItem52)
		Me.tpInventory.Controls.Add(Me.inventoryItem56)
		Me.tpInventory.Controls.Add(Me.inventoryItem51)
		Me.tpInventory.Controls.Add(Me.inventoryItem55)
		Me.tpInventory.Controls.Add(Me.inventoryItem50)
		Me.tpInventory.Controls.Add(Me.inventoryItem40)
		Me.tpInventory.Controls.Add(Me.inventoryItem41)
		Me.tpInventory.Controls.Add(Me.inventoryItem42)
		Me.tpInventory.Controls.Add(Me.inventoryItem43)
		Me.tpInventory.Controls.Add(Me.inventoryItem44)
		Me.tpInventory.Controls.Add(Me.inventoryItem45)
		Me.tpInventory.Controls.Add(Me.inventoryItem46)
		Me.tpInventory.Controls.Add(Me.inventoryItem47)
		Me.tpInventory.Controls.Add(Me.inventoryItem48)
		Me.tpInventory.Controls.Add(Me.inventoryItem49)
		Me.tpInventory.Controls.Add(Me.inventoryItem30)
		Me.tpInventory.Controls.Add(Me.inventoryItem31)
		Me.tpInventory.Controls.Add(Me.inventoryItem32)
		Me.tpInventory.Controls.Add(Me.inventoryItem33)
		Me.tpInventory.Controls.Add(Me.inventoryItem34)
		Me.tpInventory.Controls.Add(Me.inventoryItem35)
		Me.tpInventory.Controls.Add(Me.inventoryItem36)
		Me.tpInventory.Controls.Add(Me.inventoryItem37)
		Me.tpInventory.Controls.Add(Me.inventoryItem38)
		Me.tpInventory.Controls.Add(Me.inventoryItem39)
		Me.tpInventory.Controls.Add(Me.inventoryItem20)
		Me.tpInventory.Controls.Add(Me.inventoryItem21)
		Me.tpInventory.Controls.Add(Me.inventoryItem22)
		Me.tpInventory.Controls.Add(Me.inventoryItem23)
		Me.tpInventory.Controls.Add(Me.inventoryItem24)
		Me.tpInventory.Controls.Add(Me.inventoryItem25)
		Me.tpInventory.Controls.Add(Me.inventoryItem26)
		Me.tpInventory.Controls.Add(Me.inventoryItem27)
		Me.tpInventory.Controls.Add(Me.inventoryItem28)
		Me.tpInventory.Controls.Add(Me.inventoryItem29)
		Me.tpInventory.Controls.Add(Me.inventoryItem10)
		Me.tpInventory.Controls.Add(Me.inventoryItem11)
		Me.tpInventory.Controls.Add(Me.inventoryItem12)
		Me.tpInventory.Controls.Add(Me.inventoryItem13)
		Me.tpInventory.Controls.Add(Me.inventoryItem14)
		Me.tpInventory.Controls.Add(Me.inventoryItem15)
		Me.tpInventory.Controls.Add(Me.inventoryItem16)
		Me.tpInventory.Controls.Add(Me.inventoryItem17)
		Me.tpInventory.Controls.Add(Me.inventoryItem18)
		Me.tpInventory.Controls.Add(Me.inventoryItem19)
		Me.tpInventory.Controls.Add(Me.inventoryItem09)
		Me.tpInventory.Controls.Add(Me.inventoryItem08)
		Me.tpInventory.Controls.Add(Me.inventoryItem07)
		Me.tpInventory.Controls.Add(Me.inventoryItem06)
		Me.tpInventory.Controls.Add(Me.inventoryItem05)
		Me.tpInventory.Controls.Add(Me.inventoryItem04)
		Me.tpInventory.Controls.Add(Me.inventoryItem03)
		Me.tpInventory.Controls.Add(Me.inventoryItem02)
		Me.tpInventory.Controls.Add(Me.inventoryItem01)
		Me.tpInventory.Controls.Add(Me.inventoryItem00)
		Me.tpInventory.Location = New System.Drawing.Point(4, 22)
		Me.tpInventory.Name = "tpInventory"
		Me.tpInventory.Size = New System.Drawing.Size(612, 415)
		Me.tpInventory.TabIndex = 2
		Me.tpInventory.Text = "Inventory"
		Me.tpInventory.UseVisualStyleBackColor = True
		' 
		' groupBox11
		' 
		Me.groupBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox11.Controls.Add(Me.label17)
		Me.groupBox11.Controls.Add(Me.txtInventoryStackCount)
		Me.groupBox11.Controls.Add(Me.label28)
		Me.groupBox11.Controls.Add(Me.cboInventoryPrefixCategory)
		Me.groupBox11.Controls.Add(Me.label16)
		Me.groupBox11.Controls.Add(Me.cboInventoryPrefix)
		Me.groupBox11.Location = New System.Drawing.Point(24, 242)
		Me.groupBox11.Name = "groupBox11"
		Me.groupBox11.Size = New System.Drawing.Size(234, 129)
		Me.groupBox11.TabIndex = 75
		Me.groupBox11.TabStop = False
		Me.groupBox11.Text = "Item Editor"
		' 
		' label17
		' 
		Me.label17.AutoSize = True
		Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label17.Location = New System.Drawing.Point(50, 103)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(72, 13)
		Me.label17.TabIndex = 74
		Me.label17.Text = "Item Stack:"
		' 
		' txtInventoryStackCount
		' 
		Me.txtInventoryStackCount.Location = New System.Drawing.Point(128, 100)
		Me.txtInventoryStackCount.Name = "txtInventoryStackCount"
		Me.txtInventoryStackCount.Size = New System.Drawing.Size(100, 20)
		Me.txtInventoryStackCount.TabIndex = 73
		AddHandler Me.txtInventoryStackCount.TextChanged, New System.EventHandler(AddressOf Me.txtInventoryStackCount_TextChanged)
		AddHandler Me.txtInventoryStackCount.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtInventoryStackCount_KeyPress)
		' 
		' label28
		' 
		Me.label28.AutoSize = True
		Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label28.Location = New System.Drawing.Point(6, 17)
		Me.label28.Name = "label28"
		Me.label28.Size = New System.Drawing.Size(97, 13)
		Me.label28.TabIndex = 72
		Me.label28.Text = "Prefix Category:"
		' 
		' cboInventoryPrefixCategory
		' 
		Me.cboInventoryPrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboInventoryPrefixCategory.Items.AddRange(New Object() {"All", "Universal", "Common", "Melee", "Ranged", "Magic", _
			"Accessories"})
		Me.cboInventoryPrefixCategory.Location = New System.Drawing.Point(6, 33)
		Me.cboInventoryPrefixCategory.Name = "cboInventoryPrefixCategory"
		Me.cboInventoryPrefixCategory.Size = New System.Drawing.Size(222, 21)
		Me.cboInventoryPrefixCategory.TabIndex = 71
		AddHandler Me.cboInventoryPrefixCategory.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboInventoryPrefixCategory_SelectedIndexChanged)
		' 
		' label16
		' 
		Me.label16.AutoSize = True
		Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label16.Location = New System.Drawing.Point(6, 57)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(71, 13)
		Me.label16.TabIndex = 70
		Me.label16.Text = "Item Prefix:"
		' 
		' cboInventoryPrefix
		' 
		Me.cboInventoryPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboInventoryPrefix.Location = New System.Drawing.Point(6, 73)
		Me.cboInventoryPrefix.Name = "cboInventoryPrefix"
		Me.cboInventoryPrefix.Size = New System.Drawing.Size(222, 21)
		Me.cboInventoryPrefix.TabIndex = 69
		AddHandler Me.cboInventoryPrefix.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboInventoryPrefix_SelectedIndexChanged)
		' 
		' btnInventoryHackAllStacks
		' 
		Me.btnInventoryHackAllStacks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnInventoryHackAllStacks.Location = New System.Drawing.Point(373, 276)
		Me.btnInventoryHackAllStacks.Name = "btnInventoryHackAllStacks"
		Me.btnInventoryHackAllStacks.Size = New System.Drawing.Size(100, 23)
		Me.btnInventoryHackAllStacks.TabIndex = 74
		Me.btnInventoryHackAllStacks.Text = "Hack Item Stacks"
		Me.btnInventoryHackAllStacks.UseVisualStyleBackColor = True
		AddHandler Me.btnInventoryHackAllStacks.Click, New System.EventHandler(AddressOf Me.btnInventoryHackAllStacks_Click)
		' 
		' btnInventoryDeleteAllItems
		' 
		Me.btnInventoryDeleteAllItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnInventoryDeleteAllItems.Location = New System.Drawing.Point(373, 247)
		Me.btnInventoryDeleteAllItems.Name = "btnInventoryDeleteAllItems"
		Me.btnInventoryDeleteAllItems.Size = New System.Drawing.Size(100, 23)
		Me.btnInventoryDeleteAllItems.TabIndex = 73
		Me.btnInventoryDeleteAllItems.Text = "Delete All Items"
		Me.btnInventoryDeleteAllItems.UseVisualStyleBackColor = True
		AddHandler Me.btnInventoryDeleteAllItems.Click, New System.EventHandler(AddressOf Me.btnInventoryDeleteAllItems_Click)
		' 
		' btnInventoryMaxAllStacks
		' 
		Me.btnInventoryMaxAllStacks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnInventoryMaxAllStacks.Location = New System.Drawing.Point(267, 275)
		Me.btnInventoryMaxAllStacks.Name = "btnInventoryMaxAllStacks"
		Me.btnInventoryMaxAllStacks.Size = New System.Drawing.Size(100, 23)
		Me.btnInventoryMaxAllStacks.TabIndex = 72
		Me.btnInventoryMaxAllStacks.Text = "Max Item Stacks"
		Me.btnInventoryMaxAllStacks.UseVisualStyleBackColor = True
		AddHandler Me.btnInventoryMaxAllStacks.Click, New System.EventHandler(AddressOf Me.btnInventoryMaxAllStacks_Click)
		' 
		' btnInventoryDeleteItem
		' 
		Me.btnInventoryDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnInventoryDeleteItem.Location = New System.Drawing.Point(267, 247)
		Me.btnInventoryDeleteItem.Name = "btnInventoryDeleteItem"
		Me.btnInventoryDeleteItem.Size = New System.Drawing.Size(100, 23)
		Me.btnInventoryDeleteItem.TabIndex = 71
		Me.btnInventoryDeleteItem.Text = "Delete Item"
		Me.btnInventoryDeleteItem.UseVisualStyleBackColor = True
		AddHandler Me.btnInventoryDeleteItem.Click, New System.EventHandler(AddressOf Me.btnInventoryDeleteItem_Click)
		' 
		' btnLoadInventory
		' 
		Me.btnLoadInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoadInventory.Location = New System.Drawing.Point(373, 348)
		Me.btnLoadInventory.Name = "btnLoadInventory"
		Me.btnLoadInventory.Size = New System.Drawing.Size(100, 23)
		Me.btnLoadInventory.TabIndex = 66
		Me.btnLoadInventory.Text = "Load Inventory"
		Me.btnLoadInventory.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadInventory.Click, New System.EventHandler(AddressOf Me.btnLoadInventory_Click)
		' 
		' btnSaveInventory
		' 
		Me.btnSaveInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveInventory.Location = New System.Drawing.Point(267, 348)
		Me.btnSaveInventory.Name = "btnSaveInventory"
		Me.btnSaveInventory.Size = New System.Drawing.Size(100, 23)
		Me.btnSaveInventory.TabIndex = 65
		Me.btnSaveInventory.Text = "Save Inventory"
		Me.btnSaveInventory.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveInventory.Click, New System.EventHandler(AddressOf Me.btnSaveInventory_Click)
		' 
		' groupBox5
		' 
		Me.groupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox5.Controls.Add(Me.lstInventoryItems)
		Me.groupBox5.Controls.Add(Me.groupBox6)
		Me.groupBox5.Location = New System.Drawing.Point(8, 3)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(10, 405)
		Me.groupBox5.TabIndex = 63
		Me.groupBox5.TabStop = False
		Me.groupBox5.Text = "Inventory Editor"
		' 
		' lstInventoryItems
		' 
		Me.lstInventoryItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstInventoryItems.FormattingEnabled = True
		Me.lstInventoryItems.IntegralHeight = False
		Me.lstInventoryItems.Location = New System.Drawing.Point(6, 19)
		Me.lstInventoryItems.Name = "lstInventoryItems"
		Me.lstInventoryItems.Size = New System.Drawing.Size(0, 270)
		Me.lstInventoryItems.TabIndex = 0
		AddHandler Me.lstInventoryItems.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lstInventoryItems_SelectedIndexChanged)
		' 
		' groupBox6
		' 
		Me.groupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox6.Controls.Add(Me.cboInvItemFilter)
		Me.groupBox6.Controls.Add(Me.label15)
		Me.groupBox6.Controls.Add(Me.txtInvItemFilter)
		Me.groupBox6.Controls.Add(Me.label14)
		Me.groupBox6.Location = New System.Drawing.Point(0, 294)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(10, 111)
		Me.groupBox6.TabIndex = 64
		Me.groupBox6.TabStop = False
		Me.groupBox6.Text = "Item Filter"
		' 
		' cboInvItemFilter
		' 
		Me.cboInvItemFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboInvItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboInvItemFilter.FormattingEnabled = True
		Me.cboInvItemFilter.Items.AddRange(New Object() {"All", "Armor / Social Gear", "Accessories", "Ammunition", "Building Objects", "Consumables", _
			"Money", "Tools", "Weapons"})
		Me.cboInvItemFilter.Location = New System.Drawing.Point(6, 84)
		Me.cboInvItemFilter.Name = "cboInvItemFilter"
		Me.cboInvItemFilter.Size = New System.Drawing.Size(0, 21)
		Me.cboInvItemFilter.TabIndex = 3
		AddHandler Me.cboInvItemFilter.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboInvItemFilter_SelectedIndexChanged)
		' 
		' label15
		' 
		Me.label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label15.AutoSize = True
		Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label15.Location = New System.Drawing.Point(3, 68)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(67, 13)
		Me.label15.TabIndex = 2
		Me.label15.Text = "Item Type:"
		' 
		' txtInvItemFilter
		' 
		Me.txtInvItemFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtInvItemFilter.Location = New System.Drawing.Point(6, 35)
		Me.txtInvItemFilter.Name = "txtInvItemFilter"
		Me.txtInvItemFilter.Size = New System.Drawing.Size(0, 20)
		Me.txtInvItemFilter.TabIndex = 1
		AddHandler Me.txtInvItemFilter.TextChanged, New System.EventHandler(AddressOf Me.txtInvItemFilter_TextChanged)
		' 
		' label14
		' 
		Me.label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label14.AutoSize = True
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label14.Location = New System.Drawing.Point(3, 19)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(71, 13)
		Me.label14.TabIndex = 0
		Me.label14.Text = "Item Name:"
		' 
		' label6
		' 
		Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(567, 197)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(36, 13)
		Me.label6.TabIndex = 62
		Me.label6.Text = "Ammo"
		' 
		' label5
		' 
		Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(521, 197)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(33, 13)
		Me.label5.TabIndex = 61
		Me.label5.Text = "Coins"
		' 
		' inventoryItem54
		' 
		Me.inventoryItem54.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem54.Location = New System.Drawing.Point(564, 9)
		Me.inventoryItem54.Name = "inventoryItem54"
		Me.inventoryItem54.ShowItemCount = True
		Me.inventoryItem54.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem54.TabIndex = 59
		Me.inventoryItem54.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem54.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem54.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem54.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem54.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem53
		' 
		Me.inventoryItem53.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem53.Location = New System.Drawing.Point(516, 150)
		Me.inventoryItem53.Name = "inventoryItem53"
		Me.inventoryItem53.ShowItemCount = True
		Me.inventoryItem53.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem53.TabIndex = 57
		Me.inventoryItem53.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem53.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem53.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem53.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem53.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem57
		' 
		Me.inventoryItem57.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem57.Location = New System.Drawing.Point(564, 150)
		Me.inventoryItem57.Name = "inventoryItem57"
		Me.inventoryItem57.ShowItemCount = True
		Me.inventoryItem57.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem57.TabIndex = 56
		Me.inventoryItem57.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem57.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem57.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem57.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem57.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem52
		' 
		Me.inventoryItem52.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem52.Location = New System.Drawing.Point(516, 103)
		Me.inventoryItem52.Name = "inventoryItem52"
		Me.inventoryItem52.ShowItemCount = True
		Me.inventoryItem52.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem52.TabIndex = 55
		Me.inventoryItem52.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem52.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem52.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem52.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem52.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem56
		' 
		Me.inventoryItem56.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem56.Location = New System.Drawing.Point(564, 103)
		Me.inventoryItem56.Name = "inventoryItem56"
		Me.inventoryItem56.ShowItemCount = True
		Me.inventoryItem56.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem56.TabIndex = 54
		Me.inventoryItem56.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem56.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem56.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem56.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem56.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem51
		' 
		Me.inventoryItem51.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem51.Location = New System.Drawing.Point(516, 56)
		Me.inventoryItem51.Name = "inventoryItem51"
		Me.inventoryItem51.ShowItemCount = True
		Me.inventoryItem51.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem51.TabIndex = 53
		Me.inventoryItem51.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem51.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem51.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem51.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem51.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem55
		' 
		Me.inventoryItem55.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem55.Location = New System.Drawing.Point(564, 56)
		Me.inventoryItem55.Name = "inventoryItem55"
		Me.inventoryItem55.ShowItemCount = True
		Me.inventoryItem55.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem55.TabIndex = 52
		Me.inventoryItem55.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem55.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem55.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem55.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem55.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem50
		' 
		Me.inventoryItem50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem50.Location = New System.Drawing.Point(516, 9)
		Me.inventoryItem50.Name = "inventoryItem50"
		Me.inventoryItem50.ShowItemCount = True
		Me.inventoryItem50.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem50.TabIndex = 51
		Me.inventoryItem50.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem50.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem50.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem50.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem50.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem40
		' 
		Me.inventoryItem40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem40.Location = New System.Drawing.Point(27, 197)
		Me.inventoryItem40.Name = "inventoryItem40"
		Me.inventoryItem40.ShowItemCount = True
		Me.inventoryItem40.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem40.TabIndex = 50
		Me.inventoryItem40.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem40.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem40.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem40.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem40.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem41
		' 
		Me.inventoryItem41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem41.Location = New System.Drawing.Point(75, 197)
		Me.inventoryItem41.Name = "inventoryItem41"
		Me.inventoryItem41.ShowItemCount = True
		Me.inventoryItem41.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem41.TabIndex = 49
		Me.inventoryItem41.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem41.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem41.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem41.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem41.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem42
		' 
		Me.inventoryItem42.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem42.Location = New System.Drawing.Point(123, 197)
		Me.inventoryItem42.Name = "inventoryItem42"
		Me.inventoryItem42.ShowItemCount = True
		Me.inventoryItem42.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem42.TabIndex = 48
		Me.inventoryItem42.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem42.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem42.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem42.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem42.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem43
		' 
		Me.inventoryItem43.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem43.Location = New System.Drawing.Point(171, 197)
		Me.inventoryItem43.Name = "inventoryItem43"
		Me.inventoryItem43.ShowItemCount = True
		Me.inventoryItem43.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem43.TabIndex = 47
		Me.inventoryItem43.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem43.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem43.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem43.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem43.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem44
		' 
		Me.inventoryItem44.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem44.Location = New System.Drawing.Point(219, 197)
		Me.inventoryItem44.Name = "inventoryItem44"
		Me.inventoryItem44.ShowItemCount = True
		Me.inventoryItem44.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem44.TabIndex = 46
		Me.inventoryItem44.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem44.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem44.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem44.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem44.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem45
		' 
		Me.inventoryItem45.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem45.Location = New System.Drawing.Point(267, 197)
		Me.inventoryItem45.Name = "inventoryItem45"
		Me.inventoryItem45.ShowItemCount = True
		Me.inventoryItem45.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem45.TabIndex = 45
		Me.inventoryItem45.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem45.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem45.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem45.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem45.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem46
		' 
		Me.inventoryItem46.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem46.Location = New System.Drawing.Point(315, 197)
		Me.inventoryItem46.Name = "inventoryItem46"
		Me.inventoryItem46.ShowItemCount = True
		Me.inventoryItem46.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem46.TabIndex = 44
		Me.inventoryItem46.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem46.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem46.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem46.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem46.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem47
		' 
		Me.inventoryItem47.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem47.Location = New System.Drawing.Point(363, 197)
		Me.inventoryItem47.Name = "inventoryItem47"
		Me.inventoryItem47.ShowItemCount = True
		Me.inventoryItem47.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem47.TabIndex = 43
		Me.inventoryItem47.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem47.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem47.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem47.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem47.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem48
		' 
		Me.inventoryItem48.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem48.Location = New System.Drawing.Point(411, 197)
		Me.inventoryItem48.Name = "inventoryItem48"
		Me.inventoryItem48.ShowItemCount = True
		Me.inventoryItem48.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem48.TabIndex = 42
		Me.inventoryItem48.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem48.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem48.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem48.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem48.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem49
		' 
		Me.inventoryItem49.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem49.Location = New System.Drawing.Point(459, 197)
		Me.inventoryItem49.Name = "inventoryItem49"
		Me.inventoryItem49.ShowItemCount = True
		Me.inventoryItem49.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem49.TabIndex = 41
		Me.inventoryItem49.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem49.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem49.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem49.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem49.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem30
		' 
		Me.inventoryItem30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem30.Location = New System.Drawing.Point(27, 150)
		Me.inventoryItem30.Name = "inventoryItem30"
		Me.inventoryItem30.ShowItemCount = True
		Me.inventoryItem30.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem30.TabIndex = 40
		Me.inventoryItem30.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem30.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem30.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem30.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem30.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem31
		' 
		Me.inventoryItem31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem31.Location = New System.Drawing.Point(75, 150)
		Me.inventoryItem31.Name = "inventoryItem31"
		Me.inventoryItem31.ShowItemCount = True
		Me.inventoryItem31.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem31.TabIndex = 39
		Me.inventoryItem31.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem31.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem31.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem31.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem31.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem32
		' 
		Me.inventoryItem32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem32.Location = New System.Drawing.Point(123, 150)
		Me.inventoryItem32.Name = "inventoryItem32"
		Me.inventoryItem32.ShowItemCount = True
		Me.inventoryItem32.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem32.TabIndex = 38
		Me.inventoryItem32.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem32.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem32.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem32.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem32.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem33
		' 
		Me.inventoryItem33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem33.Location = New System.Drawing.Point(171, 150)
		Me.inventoryItem33.Name = "inventoryItem33"
		Me.inventoryItem33.ShowItemCount = True
		Me.inventoryItem33.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem33.TabIndex = 37
		Me.inventoryItem33.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem33.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem33.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem33.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem33.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem34
		' 
		Me.inventoryItem34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem34.Location = New System.Drawing.Point(219, 150)
		Me.inventoryItem34.Name = "inventoryItem34"
		Me.inventoryItem34.ShowItemCount = True
		Me.inventoryItem34.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem34.TabIndex = 36
		Me.inventoryItem34.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem34.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem34.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem34.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem34.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem35
		' 
		Me.inventoryItem35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem35.Location = New System.Drawing.Point(267, 150)
		Me.inventoryItem35.Name = "inventoryItem35"
		Me.inventoryItem35.ShowItemCount = True
		Me.inventoryItem35.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem35.TabIndex = 35
		Me.inventoryItem35.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem35.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem35.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem35.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem35.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem36
		' 
		Me.inventoryItem36.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem36.Location = New System.Drawing.Point(315, 150)
		Me.inventoryItem36.Name = "inventoryItem36"
		Me.inventoryItem36.ShowItemCount = True
		Me.inventoryItem36.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem36.TabIndex = 34
		Me.inventoryItem36.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem36.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem36.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem36.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem36.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem37
		' 
		Me.inventoryItem37.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem37.Location = New System.Drawing.Point(363, 150)
		Me.inventoryItem37.Name = "inventoryItem37"
		Me.inventoryItem37.ShowItemCount = True
		Me.inventoryItem37.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem37.TabIndex = 33
		Me.inventoryItem37.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem37.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem37.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem37.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem37.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem38
		' 
		Me.inventoryItem38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem38.Location = New System.Drawing.Point(411, 150)
		Me.inventoryItem38.Name = "inventoryItem38"
		Me.inventoryItem38.ShowItemCount = True
		Me.inventoryItem38.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem38.TabIndex = 32
		Me.inventoryItem38.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem38.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem38.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem38.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem38.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem39
		' 
		Me.inventoryItem39.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem39.Location = New System.Drawing.Point(459, 150)
		Me.inventoryItem39.Name = "inventoryItem39"
		Me.inventoryItem39.ShowItemCount = True
		Me.inventoryItem39.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem39.TabIndex = 31
		Me.inventoryItem39.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem39.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem39.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem39.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem39.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem20
		' 
		Me.inventoryItem20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem20.Location = New System.Drawing.Point(27, 103)
		Me.inventoryItem20.Name = "inventoryItem20"
		Me.inventoryItem20.ShowItemCount = True
		Me.inventoryItem20.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem20.TabIndex = 30
		Me.inventoryItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem20.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem20.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem20.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem20.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem21
		' 
		Me.inventoryItem21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem21.Location = New System.Drawing.Point(75, 103)
		Me.inventoryItem21.Name = "inventoryItem21"
		Me.inventoryItem21.ShowItemCount = True
		Me.inventoryItem21.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem21.TabIndex = 29
		Me.inventoryItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem21.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem21.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem21.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem21.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem22
		' 
		Me.inventoryItem22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem22.Location = New System.Drawing.Point(123, 103)
		Me.inventoryItem22.Name = "inventoryItem22"
		Me.inventoryItem22.ShowItemCount = True
		Me.inventoryItem22.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem22.TabIndex = 28
		Me.inventoryItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem22.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem22.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem22.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem22.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem23
		' 
		Me.inventoryItem23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem23.Location = New System.Drawing.Point(171, 103)
		Me.inventoryItem23.Name = "inventoryItem23"
		Me.inventoryItem23.ShowItemCount = True
		Me.inventoryItem23.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem23.TabIndex = 27
		Me.inventoryItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem23.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem23.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem23.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem23.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem24
		' 
		Me.inventoryItem24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem24.Location = New System.Drawing.Point(219, 103)
		Me.inventoryItem24.Name = "inventoryItem24"
		Me.inventoryItem24.ShowItemCount = True
		Me.inventoryItem24.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem24.TabIndex = 26
		Me.inventoryItem24.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem24.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem24.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem24.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem24.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem25
		' 
		Me.inventoryItem25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem25.Location = New System.Drawing.Point(267, 103)
		Me.inventoryItem25.Name = "inventoryItem25"
		Me.inventoryItem25.ShowItemCount = True
		Me.inventoryItem25.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem25.TabIndex = 25
		Me.inventoryItem25.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem25.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem25.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem25.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem25.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem26
		' 
		Me.inventoryItem26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem26.Location = New System.Drawing.Point(315, 103)
		Me.inventoryItem26.Name = "inventoryItem26"
		Me.inventoryItem26.ShowItemCount = True
		Me.inventoryItem26.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem26.TabIndex = 24
		Me.inventoryItem26.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem26.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem26.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem26.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem26.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem27
		' 
		Me.inventoryItem27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem27.Location = New System.Drawing.Point(363, 103)
		Me.inventoryItem27.Name = "inventoryItem27"
		Me.inventoryItem27.ShowItemCount = True
		Me.inventoryItem27.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem27.TabIndex = 23
		Me.inventoryItem27.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem27.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem27.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem27.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem27.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem28
		' 
		Me.inventoryItem28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem28.Location = New System.Drawing.Point(411, 103)
		Me.inventoryItem28.Name = "inventoryItem28"
		Me.inventoryItem28.ShowItemCount = True
		Me.inventoryItem28.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem28.TabIndex = 22
		Me.inventoryItem28.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem28.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem28.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem28.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem28.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem29
		' 
		Me.inventoryItem29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem29.Location = New System.Drawing.Point(459, 103)
		Me.inventoryItem29.Name = "inventoryItem29"
		Me.inventoryItem29.ShowItemCount = True
		Me.inventoryItem29.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem29.TabIndex = 21
		Me.inventoryItem29.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem29.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem29.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem29.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem29.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem10
		' 
		Me.inventoryItem10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem10.Location = New System.Drawing.Point(27, 56)
		Me.inventoryItem10.Name = "inventoryItem10"
		Me.inventoryItem10.ShowItemCount = True
		Me.inventoryItem10.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem10.TabIndex = 20
		Me.inventoryItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem10.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem10.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem10.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem10.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem11
		' 
		Me.inventoryItem11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem11.Location = New System.Drawing.Point(75, 56)
		Me.inventoryItem11.Name = "inventoryItem11"
		Me.inventoryItem11.ShowItemCount = True
		Me.inventoryItem11.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem11.TabIndex = 19
		Me.inventoryItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem11.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem11.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem11.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem11.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem12
		' 
		Me.inventoryItem12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem12.Location = New System.Drawing.Point(123, 56)
		Me.inventoryItem12.Name = "inventoryItem12"
		Me.inventoryItem12.ShowItemCount = True
		Me.inventoryItem12.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem12.TabIndex = 18
		Me.inventoryItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem12.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem12.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem12.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem12.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem13
		' 
		Me.inventoryItem13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem13.Location = New System.Drawing.Point(171, 56)
		Me.inventoryItem13.Name = "inventoryItem13"
		Me.inventoryItem13.ShowItemCount = True
		Me.inventoryItem13.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem13.TabIndex = 17
		Me.inventoryItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem13.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem13.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem13.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem13.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem14
		' 
		Me.inventoryItem14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem14.Location = New System.Drawing.Point(219, 56)
		Me.inventoryItem14.Name = "inventoryItem14"
		Me.inventoryItem14.ShowItemCount = True
		Me.inventoryItem14.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem14.TabIndex = 16
		Me.inventoryItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem14.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem14.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem14.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem14.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem15
		' 
		Me.inventoryItem15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem15.Location = New System.Drawing.Point(267, 56)
		Me.inventoryItem15.Name = "inventoryItem15"
		Me.inventoryItem15.ShowItemCount = True
		Me.inventoryItem15.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem15.TabIndex = 15
		Me.inventoryItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem15.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem15.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem15.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem15.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem16
		' 
		Me.inventoryItem16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem16.Location = New System.Drawing.Point(315, 56)
		Me.inventoryItem16.Name = "inventoryItem16"
		Me.inventoryItem16.ShowItemCount = True
		Me.inventoryItem16.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem16.TabIndex = 14
		Me.inventoryItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem16.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem16.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem16.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem16.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem17
		' 
		Me.inventoryItem17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem17.Location = New System.Drawing.Point(363, 56)
		Me.inventoryItem17.Name = "inventoryItem17"
		Me.inventoryItem17.ShowItemCount = True
		Me.inventoryItem17.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem17.TabIndex = 13
		Me.inventoryItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem17.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem17.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem17.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem17.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem18
		' 
		Me.inventoryItem18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem18.Location = New System.Drawing.Point(411, 56)
		Me.inventoryItem18.Name = "inventoryItem18"
		Me.inventoryItem18.ShowItemCount = True
		Me.inventoryItem18.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem18.TabIndex = 12
		Me.inventoryItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem18.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem18.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem18.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem18.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem19
		' 
		Me.inventoryItem19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem19.Location = New System.Drawing.Point(459, 56)
		Me.inventoryItem19.Name = "inventoryItem19"
		Me.inventoryItem19.ShowItemCount = True
		Me.inventoryItem19.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem19.TabIndex = 11
		Me.inventoryItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem19.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem19.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem19.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem19.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem09
		' 
		Me.inventoryItem09.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem09.Location = New System.Drawing.Point(459, 9)
		Me.inventoryItem09.Name = "inventoryItem09"
		Me.inventoryItem09.ShowItemCount = True
		Me.inventoryItem09.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem09.TabIndex = 10
		Me.inventoryItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem09.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem09.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem09.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem09.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem08
		' 
		Me.inventoryItem08.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem08.Location = New System.Drawing.Point(411, 9)
		Me.inventoryItem08.Name = "inventoryItem08"
		Me.inventoryItem08.ShowItemCount = True
		Me.inventoryItem08.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem08.TabIndex = 9
		Me.inventoryItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem08.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem08.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem08.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem08.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem07
		' 
		Me.inventoryItem07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem07.Location = New System.Drawing.Point(363, 9)
		Me.inventoryItem07.Name = "inventoryItem07"
		Me.inventoryItem07.ShowItemCount = True
		Me.inventoryItem07.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem07.TabIndex = 8
		Me.inventoryItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem07.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem07.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem07.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem07.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem06
		' 
		Me.inventoryItem06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem06.Location = New System.Drawing.Point(315, 9)
		Me.inventoryItem06.Name = "inventoryItem06"
		Me.inventoryItem06.ShowItemCount = True
		Me.inventoryItem06.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem06.TabIndex = 7
		Me.inventoryItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem06.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem06.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem06.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem06.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem05
		' 
		Me.inventoryItem05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem05.Location = New System.Drawing.Point(267, 9)
		Me.inventoryItem05.Name = "inventoryItem05"
		Me.inventoryItem05.ShowItemCount = True
		Me.inventoryItem05.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem05.TabIndex = 6
		Me.inventoryItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem05.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem05.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem05.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem05.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem04
		' 
		Me.inventoryItem04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem04.Location = New System.Drawing.Point(219, 9)
		Me.inventoryItem04.Name = "inventoryItem04"
		Me.inventoryItem04.ShowItemCount = True
		Me.inventoryItem04.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem04.TabIndex = 5
		Me.inventoryItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem04.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem04.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem04.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem04.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem03
		' 
		Me.inventoryItem03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem03.Location = New System.Drawing.Point(171, 9)
		Me.inventoryItem03.Name = "inventoryItem03"
		Me.inventoryItem03.ShowItemCount = True
		Me.inventoryItem03.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem03.TabIndex = 4
		Me.inventoryItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem03.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem03.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem03.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem03.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem02
		' 
		Me.inventoryItem02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem02.Location = New System.Drawing.Point(123, 9)
		Me.inventoryItem02.Name = "inventoryItem02"
		Me.inventoryItem02.ShowItemCount = True
		Me.inventoryItem02.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem02.TabIndex = 3
		Me.inventoryItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem02.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem02.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem02.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem02.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem01
		' 
		Me.inventoryItem01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem01.Location = New System.Drawing.Point(75, 9)
		Me.inventoryItem01.Name = "inventoryItem01"
		Me.inventoryItem01.ShowItemCount = True
		Me.inventoryItem01.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem01.TabIndex = 1
		Me.inventoryItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem01.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem01.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem01.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem01.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' inventoryItem00
		' 
		Me.inventoryItem00.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.inventoryItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inventoryItem00.Location = New System.Drawing.Point(27, 9)
		Me.inventoryItem00.Name = "inventoryItem00"
		Me.inventoryItem00.ShowItemCount = True
		Me.inventoryItem00.Size = New System.Drawing.Size(42, 42)
		Me.inventoryItem00.TabIndex = 2
		Me.inventoryItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.inventoryItem00.Click, New System.EventHandler(AddressOf Me.inventoryItem_Click)
		AddHandler Me.inventoryItem00.MouseEnter, New System.EventHandler(AddressOf Me.inventoryItem_MouseEnter)
		AddHandler Me.inventoryItem00.MouseLeave, New System.EventHandler(AddressOf Me.inventoryItem_MouseLeave)
		AddHandler Me.inventoryItem00.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.inventoryItem_PreviewKeyDown)
		' 
		' tpEquipment
		' 
		Me.tpEquipment.Controls.Add(Me.equipmentItem23)
		Me.tpEquipment.Controls.Add(Me.equipmentItem22)
		Me.tpEquipment.Controls.Add(Me.equipmentItem21)
		Me.tpEquipment.Controls.Add(Me.equipmentItem20)
		Me.tpEquipment.Controls.Add(Me.equipmentItem19)
		Me.tpEquipment.Controls.Add(Me.label31)
		Me.tpEquipment.Controls.Add(Me.equipmentItem18)
		Me.tpEquipment.Controls.Add(Me.equipmentItem17)
		Me.tpEquipment.Controls.Add(Me.equipmentItem16)
		Me.tpEquipment.Controls.Add(Me.equipmentItem15)
		Me.tpEquipment.Controls.Add(Me.equipmentItem14)
		Me.tpEquipment.Controls.Add(Me.btnLoadEquipmentSet)
		Me.tpEquipment.Controls.Add(Me.btnSaveEquipmentSet)
		Me.tpEquipment.Controls.Add(Me.label23)
		Me.tpEquipment.Controls.Add(Me.label22)
		Me.tpEquipment.Controls.Add(Me.label21)
		Me.tpEquipment.Controls.Add(Me.label20)
		Me.tpEquipment.Controls.Add(Me.groupBox7)
		Me.tpEquipment.Controls.Add(Me.equipmentItem13)
		Me.tpEquipment.Controls.Add(Me.equipmentItem12)
		Me.tpEquipment.Controls.Add(Me.equipmentItem11)
		Me.tpEquipment.Controls.Add(Me.equipmentItem10)
		Me.tpEquipment.Controls.Add(Me.equipmentItem09)
		Me.tpEquipment.Controls.Add(Me.equipmentItem08)
		Me.tpEquipment.Controls.Add(Me.equipmentItem07)
		Me.tpEquipment.Controls.Add(Me.equipmentItem06)
		Me.tpEquipment.Controls.Add(Me.equipmentItem05)
		Me.tpEquipment.Controls.Add(Me.equipmentItem04)
		Me.tpEquipment.Controls.Add(Me.equipmentItem03)
		Me.tpEquipment.Controls.Add(Me.equipmentItem02)
		Me.tpEquipment.Controls.Add(Me.equipmentItem01)
		Me.tpEquipment.Controls.Add(Me.equipmentItem00)
		Me.tpEquipment.Location = New System.Drawing.Point(4, 22)
		Me.tpEquipment.Name = "tpEquipment"
		Me.tpEquipment.Size = New System.Drawing.Size(612, 415)
		Me.tpEquipment.TabIndex = 3
		Me.tpEquipment.Text = "Equipment"
		Me.tpEquipment.UseVisualStyleBackColor = True
		' 
		' equipmentItem23
		' 
		Me.equipmentItem23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem23.Location = New System.Drawing.Point(505, 355)
		Me.equipmentItem23.Name = "equipmentItem23"
		Me.equipmentItem23.ShowItemCount = True
		Me.equipmentItem23.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem23.TabIndex = 33
		Me.equipmentItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem23.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem23.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem23.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem22
		' 
		Me.equipmentItem22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem22.Location = New System.Drawing.Point(505, 308)
		Me.equipmentItem22.Name = "equipmentItem22"
		Me.equipmentItem22.ShowItemCount = True
		Me.equipmentItem22.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem22.TabIndex = 32
		Me.equipmentItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem22.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem22.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem22.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem21
		' 
		Me.equipmentItem21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem21.Location = New System.Drawing.Point(505, 261)
		Me.equipmentItem21.Name = "equipmentItem21"
		Me.equipmentItem21.ShowItemCount = True
		Me.equipmentItem21.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem21.TabIndex = 31
		Me.equipmentItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem21.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem21.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem21.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem20
		' 
		Me.equipmentItem20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem20.Location = New System.Drawing.Point(505, 214)
		Me.equipmentItem20.Name = "equipmentItem20"
		Me.equipmentItem20.ShowItemCount = True
		Me.equipmentItem20.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem20.TabIndex = 30
		Me.equipmentItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem20.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem20.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem20.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem19
		' 
		Me.equipmentItem19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem19.Location = New System.Drawing.Point(505, 167)
		Me.equipmentItem19.Name = "equipmentItem19"
		Me.equipmentItem19.ShowItemCount = True
		Me.equipmentItem19.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem19.TabIndex = 29
		Me.equipmentItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem19.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem19.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem19.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' label31
		' 
		Me.label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label31.Location = New System.Drawing.Point(488, 126)
		Me.label31.Name = "label31"
		Me.label31.Size = New System.Drawing.Size(78, 36)
		Me.label31.TabIndex = 28
		Me.label31.Text = "(Social)" & vbCr & vbLf & "Accessories"
		Me.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' equipmentItem18
		' 
		Me.equipmentItem18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem18.Location = New System.Drawing.Point(434, 355)
		Me.equipmentItem18.Name = "equipmentItem18"
		Me.equipmentItem18.ShowItemCount = True
		Me.equipmentItem18.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem18.TabIndex = 27
		Me.equipmentItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem18.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem18.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem18.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem17
		' 
		Me.equipmentItem17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem17.Location = New System.Drawing.Point(434, 308)
		Me.equipmentItem17.Name = "equipmentItem17"
		Me.equipmentItem17.ShowItemCount = True
		Me.equipmentItem17.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem17.TabIndex = 26
		Me.equipmentItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem17.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem17.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem17.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem16
		' 
		Me.equipmentItem16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem16.Location = New System.Drawing.Point(434, 261)
		Me.equipmentItem16.Name = "equipmentItem16"
		Me.equipmentItem16.ShowItemCount = True
		Me.equipmentItem16.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem16.TabIndex = 25
		Me.equipmentItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem16.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem16.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem16.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem15
		' 
		Me.equipmentItem15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem15.Location = New System.Drawing.Point(434, 214)
		Me.equipmentItem15.Name = "equipmentItem15"
		Me.equipmentItem15.ShowItemCount = True
		Me.equipmentItem15.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem15.TabIndex = 24
		Me.equipmentItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem15.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem15.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem15.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' equipmentItem14
		' 
		Me.equipmentItem14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem14.Location = New System.Drawing.Point(434, 167)
		Me.equipmentItem14.Name = "equipmentItem14"
		Me.equipmentItem14.ShowItemCount = True
		Me.equipmentItem14.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem14.TabIndex = 23
		Me.equipmentItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem14.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem14.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem14.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		' 
		' btnLoadEquipmentSet
		' 
		Me.btnLoadEquipmentSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoadEquipmentSet.Location = New System.Drawing.Point(214, 378)
		Me.btnLoadEquipmentSet.Name = "btnLoadEquipmentSet"
		Me.btnLoadEquipmentSet.Size = New System.Drawing.Size(120, 23)
		Me.btnLoadEquipmentSet.TabIndex = 22
		Me.btnLoadEquipmentSet.Text = "Load Equipment Set"
		Me.btnLoadEquipmentSet.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadEquipmentSet.Click, New System.EventHandler(AddressOf Me.btnLoadEquipmentSet_Click)
		' 
		' btnSaveEquipmentSet
		' 
		Me.btnSaveEquipmentSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveEquipmentSet.Location = New System.Drawing.Point(214, 349)
		Me.btnSaveEquipmentSet.Name = "btnSaveEquipmentSet"
		Me.btnSaveEquipmentSet.Size = New System.Drawing.Size(120, 23)
		Me.btnSaveEquipmentSet.TabIndex = 21
		Me.btnSaveEquipmentSet.Text = "Save Equipment Set"
		Me.btnSaveEquipmentSet.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveEquipmentSet.Click, New System.EventHandler(AddressOf Me.btnSaveEquipmentSet_Click)
		' 
		' label23
		' 
		Me.label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label23.Location = New System.Drawing.Point(415, 139)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(78, 23)
		Me.label23.TabIndex = 20
		Me.label23.Text = "Accessories"
		Me.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' label22
		' 
		Me.label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label22.Location = New System.Drawing.Point(347, 3)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(45, 23)
		Me.label22.TabIndex = 14
		Me.label22.Text = "Dye"
		Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' label21
		' 
		Me.label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label21.Location = New System.Drawing.Point(289, 3)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(45, 23)
		Me.label21.TabIndex = 10
		Me.label21.Text = "Vanity"
		Me.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' label20
		' 
		Me.label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label20.Location = New System.Drawing.Point(234, 3)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(42, 23)
		Me.label20.TabIndex = 9
		Me.label20.Text = "Armor"
		Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' groupBox7
		' 
		Me.groupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox7.Controls.Add(Me.label29)
		Me.groupBox7.Controls.Add(Me.cboEquipmentPrefixCategory)
		Me.groupBox7.Controls.Add(Me.label19)
		Me.groupBox7.Controls.Add(Me.cboEquipmentPrefix)
		Me.groupBox7.Controls.Add(Me.label18)
		Me.groupBox7.Controls.Add(Me.txtEquipmentFilter)
		Me.groupBox7.Controls.Add(Me.lstEquipmentItems)
		Me.groupBox7.Location = New System.Drawing.Point(8, 3)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(200, 404)
		Me.groupBox7.TabIndex = 0
		Me.groupBox7.TabStop = False
		Me.groupBox7.Text = "Item Editor"
		' 
		' label29
		' 
		Me.label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label29.AutoSize = True
		Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label29.Location = New System.Drawing.Point(6, 313)
		Me.label29.Name = "label29"
		Me.label29.Size = New System.Drawing.Size(97, 13)
		Me.label29.TabIndex = 6
		Me.label29.Text = "Prefix Category:"
		' 
		' cboEquipmentPrefixCategory
		' 
		Me.cboEquipmentPrefixCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboEquipmentPrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEquipmentPrefixCategory.FormattingEnabled = True
		Me.cboEquipmentPrefixCategory.Items.AddRange(New Object() {"All", "Universal", "Common", "Melee", "Ranged", "Magic", _
			"Accessories"})
		Me.cboEquipmentPrefixCategory.Location = New System.Drawing.Point(6, 329)
		Me.cboEquipmentPrefixCategory.Name = "cboEquipmentPrefixCategory"
		Me.cboEquipmentPrefixCategory.Size = New System.Drawing.Size(188, 21)
		Me.cboEquipmentPrefixCategory.TabIndex = 5
		AddHandler Me.cboEquipmentPrefixCategory.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboEquipmentPrefixCategory_SelectedIndexChanged)
		' 
		' label19
		' 
		Me.label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label19.AutoSize = True
		Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label19.Location = New System.Drawing.Point(6, 358)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(71, 13)
		Me.label19.TabIndex = 4
		Me.label19.Text = "Item Prefix:"
		' 
		' cboEquipmentPrefix
		' 
		Me.cboEquipmentPrefix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboEquipmentPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEquipmentPrefix.FormattingEnabled = True
		Me.cboEquipmentPrefix.Location = New System.Drawing.Point(6, 377)
		Me.cboEquipmentPrefix.Name = "cboEquipmentPrefix"
		Me.cboEquipmentPrefix.Size = New System.Drawing.Size(188, 21)
		Me.cboEquipmentPrefix.TabIndex = 3
		AddHandler Me.cboEquipmentPrefix.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboEquipmentPrefix_SelectedIndexChanged)
		' 
		' label18
		' 
		Me.label18.AutoSize = True
		Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label18.Location = New System.Drawing.Point(6, 22)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(67, 13)
		Me.label18.TabIndex = 2
		Me.label18.Text = "Item Filter:"
		' 
		' txtEquipmentFilter
		' 
		Me.txtEquipmentFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtEquipmentFilter.Location = New System.Drawing.Point(79, 19)
		Me.txtEquipmentFilter.Name = "txtEquipmentFilter"
		Me.txtEquipmentFilter.Size = New System.Drawing.Size(115, 20)
		Me.txtEquipmentFilter.TabIndex = 1
		AddHandler Me.txtEquipmentFilter.TextChanged, New System.EventHandler(AddressOf Me.txtEquipmentFilter_TextChanged)
		' 
		' lstEquipmentItems
		' 
		Me.lstEquipmentItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstEquipmentItems.FormattingEnabled = True
		Me.lstEquipmentItems.IntegralHeight = False
		Me.lstEquipmentItems.Location = New System.Drawing.Point(6, 45)
		Me.lstEquipmentItems.Name = "lstEquipmentItems"
		Me.lstEquipmentItems.Size = New System.Drawing.Size(188, 264)
		Me.lstEquipmentItems.TabIndex = 0
		AddHandler Me.lstEquipmentItems.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lstEquipmentItems_SelectedIndexChanged)
		' 
		' equipmentItem13
		' 
		Me.equipmentItem13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem13.Location = New System.Drawing.Point(350, 355)
		Me.equipmentItem13.Name = "equipmentItem13"
		Me.equipmentItem13.ShowItemCount = True
		Me.equipmentItem13.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem13.TabIndex = 19
		Me.equipmentItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem13.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem13.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem13.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem13.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem12
		' 
		Me.equipmentItem12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem12.Location = New System.Drawing.Point(350, 308)
		Me.equipmentItem12.Name = "equipmentItem12"
		Me.equipmentItem12.ShowItemCount = True
		Me.equipmentItem12.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem12.TabIndex = 18
		Me.equipmentItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem12.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem12.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem12.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem12.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem11
		' 
		Me.equipmentItem11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem11.Location = New System.Drawing.Point(350, 261)
		Me.equipmentItem11.Name = "equipmentItem11"
		Me.equipmentItem11.ShowItemCount = True
		Me.equipmentItem11.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem11.TabIndex = 17
		Me.equipmentItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem11.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem11.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem11.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem11.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem10
		' 
		Me.equipmentItem10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem10.Location = New System.Drawing.Point(350, 214)
		Me.equipmentItem10.Name = "equipmentItem10"
		Me.equipmentItem10.ShowItemCount = True
		Me.equipmentItem10.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem10.TabIndex = 16
		Me.equipmentItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem10.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem10.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem10.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem10.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem09
		' 
		Me.equipmentItem09.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem09.Location = New System.Drawing.Point(350, 167)
		Me.equipmentItem09.Name = "equipmentItem09"
		Me.equipmentItem09.ShowItemCount = True
		Me.equipmentItem09.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem09.TabIndex = 15
		Me.equipmentItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem09.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem09.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem09.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem09.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem08
		' 
		Me.equipmentItem08.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem08.Location = New System.Drawing.Point(350, 120)
		Me.equipmentItem08.Name = "equipmentItem08"
		Me.equipmentItem08.ShowItemCount = True
		Me.equipmentItem08.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem08.TabIndex = 13
		Me.equipmentItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem08.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem08.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem08.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem08.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem07
		' 
		Me.equipmentItem07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem07.Location = New System.Drawing.Point(350, 73)
		Me.equipmentItem07.Name = "equipmentItem07"
		Me.equipmentItem07.ShowItemCount = True
		Me.equipmentItem07.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem07.TabIndex = 12
		Me.equipmentItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem07.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem07.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem07.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem07.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem06
		' 
		Me.equipmentItem06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem06.Location = New System.Drawing.Point(350, 26)
		Me.equipmentItem06.Name = "equipmentItem06"
		Me.equipmentItem06.ShowItemCount = True
		Me.equipmentItem06.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem06.TabIndex = 11
		Me.equipmentItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem06.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem06.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem06.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem06.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem05
		' 
		Me.equipmentItem05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem05.Location = New System.Drawing.Point(292, 120)
		Me.equipmentItem05.Name = "equipmentItem05"
		Me.equipmentItem05.ShowItemCount = True
		Me.equipmentItem05.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem05.TabIndex = 8
		Me.equipmentItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem05.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem05.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem05.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem05.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem04
		' 
		Me.equipmentItem04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem04.Location = New System.Drawing.Point(292, 73)
		Me.equipmentItem04.Name = "equipmentItem04"
		Me.equipmentItem04.ShowItemCount = True
		Me.equipmentItem04.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem04.TabIndex = 7
		Me.equipmentItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem04.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem04.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem04.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem04.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem03
		' 
		Me.equipmentItem03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem03.Location = New System.Drawing.Point(292, 26)
		Me.equipmentItem03.Name = "equipmentItem03"
		Me.equipmentItem03.ShowItemCount = True
		Me.equipmentItem03.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem03.TabIndex = 6
		Me.equipmentItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem03.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem03.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem03.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem03.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem02
		' 
		Me.equipmentItem02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem02.Location = New System.Drawing.Point(234, 120)
		Me.equipmentItem02.Name = "equipmentItem02"
		Me.equipmentItem02.ShowItemCount = True
		Me.equipmentItem02.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem02.TabIndex = 5
		Me.equipmentItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem02.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem02.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem02.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem02.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem01
		' 
		Me.equipmentItem01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem01.Location = New System.Drawing.Point(234, 73)
		Me.equipmentItem01.Name = "equipmentItem01"
		Me.equipmentItem01.ShowItemCount = True
		Me.equipmentItem01.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem01.TabIndex = 4
		Me.equipmentItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem01.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem01.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem01.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem01.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' equipmentItem00
		' 
		Me.equipmentItem00.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.equipmentItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.equipmentItem00.Location = New System.Drawing.Point(234, 26)
		Me.equipmentItem00.Name = "equipmentItem00"
		Me.equipmentItem00.ShowItemCount = True
		Me.equipmentItem00.Size = New System.Drawing.Size(42, 42)
		Me.equipmentItem00.TabIndex = 3
		Me.equipmentItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.equipmentItem00.Click, New System.EventHandler(AddressOf Me.equipmentItem_Click)
		AddHandler Me.equipmentItem00.MouseEnter, New System.EventHandler(AddressOf Me.equipmentItem_MouseEnter)
		AddHandler Me.equipmentItem00.MouseLeave, New System.EventHandler(AddressOf Me.equipmentItem_MouseLeave)
		AddHandler Me.equipmentItem00.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.equipmentItem_PreviewKeyDown)
		' 
		' tpBankSafe
		' 
		Me.tpBankSafe.Controls.Add(Me.btnLoadSafeItems)
		Me.tpBankSafe.Controls.Add(Me.btnSaveSafeItems)
		Me.tpBankSafe.Controls.Add(Me.btnLoadBankItems)
		Me.tpBankSafe.Controls.Add(Me.btnSaveBankItems)
		Me.tpBankSafe.Controls.Add(Me.groupBox8)
		Me.tpBankSafe.Controls.Add(Me.groupBox9)
		Me.tpBankSafe.Controls.Add(Me.groupBox10)
		Me.tpBankSafe.Location = New System.Drawing.Point(4, 22)
		Me.tpBankSafe.Name = "tpBankSafe"
		Me.tpBankSafe.Size = New System.Drawing.Size(612, 415)
		Me.tpBankSafe.TabIndex = 4
		Me.tpBankSafe.Text = "Bank / Safe"
		Me.tpBankSafe.UseVisualStyleBackColor = True
		' 
		' btnLoadSafeItems
		' 
		Me.btnLoadSafeItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoadSafeItems.Location = New System.Drawing.Point(322, 383)
		Me.btnLoadSafeItems.Name = "btnLoadSafeItems"
		Me.btnLoadSafeItems.Size = New System.Drawing.Size(106, 23)
		Me.btnLoadSafeItems.TabIndex = 89
		Me.btnLoadSafeItems.Text = "Load Safe Items"
		Me.btnLoadSafeItems.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadSafeItems.Click, New System.EventHandler(AddressOf Me.btnLoadSafeItems_Click)
		' 
		' btnSaveSafeItems
		' 
		Me.btnSaveSafeItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveSafeItems.Location = New System.Drawing.Point(210, 383)
		Me.btnSaveSafeItems.Name = "btnSaveSafeItems"
		Me.btnSaveSafeItems.Size = New System.Drawing.Size(106, 23)
		Me.btnSaveSafeItems.TabIndex = 88
		Me.btnSaveSafeItems.Text = "Save Safe Items"
		Me.btnSaveSafeItems.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveSafeItems.Click, New System.EventHandler(AddressOf Me.btnSaveSafeItems_Click)
		' 
		' btnLoadBankItems
		' 
		Me.btnLoadBankItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoadBankItems.Location = New System.Drawing.Point(322, 173)
		Me.btnLoadBankItems.Name = "btnLoadBankItems"
		Me.btnLoadBankItems.Size = New System.Drawing.Size(106, 23)
		Me.btnLoadBankItems.TabIndex = 87
		Me.btnLoadBankItems.Text = "Load Bank Items"
		Me.btnLoadBankItems.UseVisualStyleBackColor = True
		AddHandler Me.btnLoadBankItems.Click, New System.EventHandler(AddressOf Me.btnLoadBankItems_Click)
		' 
		' btnSaveBankItems
		' 
		Me.btnSaveBankItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveBankItems.Location = New System.Drawing.Point(210, 173)
		Me.btnSaveBankItems.Name = "btnSaveBankItems"
		Me.btnSaveBankItems.Size = New System.Drawing.Size(106, 23)
		Me.btnSaveBankItems.TabIndex = 86
		Me.btnSaveBankItems.Text = "Save Bank Items"
		Me.btnSaveBankItems.UseVisualStyleBackColor = True
		AddHandler Me.btnSaveBankItems.Click, New System.EventHandler(AddressOf Me.btnSaveBankItems_Click)
		' 
		' groupBox8
		' 
		Me.groupBox8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox8.Controls.Add(Me.label30)
		Me.groupBox8.Controls.Add(Me.cboBankSafePrefixCategory)
		Me.groupBox8.Controls.Add(Me.btnHackAllBankSafeStacks)
		Me.groupBox8.Controls.Add(Me.btnMaxAllBankSafeStacks)
		Me.groupBox8.Controls.Add(Me.btnDeleteAllSafeItems)
		Me.groupBox8.Controls.Add(Me.btnDeleteAllBankItems)
		Me.groupBox8.Controls.Add(Me.label27)
		Me.groupBox8.Controls.Add(Me.txtBankSafeStackCount)
		Me.groupBox8.Controls.Add(Me.label26)
		Me.groupBox8.Controls.Add(Me.cboBankSafeItemFilter)
		Me.groupBox8.Controls.Add(Me.label24)
		Me.groupBox8.Controls.Add(Me.cboBankSafePrefix)
		Me.groupBox8.Controls.Add(Me.label25)
		Me.groupBox8.Controls.Add(Me.txtBankSafeFilter)
		Me.groupBox8.Controls.Add(Me.lstBankSafeItems)
		Me.groupBox8.Location = New System.Drawing.Point(8, 3)
		Me.groupBox8.Name = "groupBox8"
		Me.groupBox8.Size = New System.Drawing.Size(196, 403)
		Me.groupBox8.TabIndex = 83
		Me.groupBox8.TabStop = False
		Me.groupBox8.Text = "Item Editor"
		' 
		' label30
		' 
		Me.label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label30.AutoSize = True
		Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label30.Location = New System.Drawing.Point(6, 237)
		Me.label30.Name = "label30"
		Me.label30.Size = New System.Drawing.Size(97, 13)
		Me.label30.TabIndex = 14
		Me.label30.Text = "Prefix Category:"
		' 
		' cboBankSafePrefixCategory
		' 
		Me.cboBankSafePrefixCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboBankSafePrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBankSafePrefixCategory.FormattingEnabled = True
		Me.cboBankSafePrefixCategory.Items.AddRange(New Object() {"All", "Universal", "Common", "Melee", "Ranged", "Magic", _
			"Accessories"})
		Me.cboBankSafePrefixCategory.Location = New System.Drawing.Point(6, 253)
		Me.cboBankSafePrefixCategory.Name = "cboBankSafePrefixCategory"
		Me.cboBankSafePrefixCategory.Size = New System.Drawing.Size(184, 21)
		Me.cboBankSafePrefixCategory.TabIndex = 13
		AddHandler Me.cboBankSafePrefixCategory.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboBankSafePrefixCategory_SelectedIndexChanged)
		' 
		' btnHackAllBankSafeStacks
		' 
		Me.btnHackAllBankSafeStacks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnHackAllBankSafeStacks.Location = New System.Drawing.Point(101, 374)
		Me.btnHackAllBankSafeStacks.Name = "btnHackAllBankSafeStacks"
		Me.btnHackAllBankSafeStacks.Size = New System.Drawing.Size(125, 23)
		Me.btnHackAllBankSafeStacks.TabIndex = 12
		Me.btnHackAllBankSafeStacks.Text = "Hack All Item Stacks"
		Me.btnHackAllBankSafeStacks.UseVisualStyleBackColor = True
		AddHandler Me.btnHackAllBankSafeStacks.Click, New System.EventHandler(AddressOf Me.btnHackAllBankSafeStacks_Click)
		' 
		' btnMaxAllBankSafeStacks
		' 
		Me.btnMaxAllBankSafeStacks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnMaxAllBankSafeStacks.Location = New System.Drawing.Point(101, 345)
		Me.btnMaxAllBankSafeStacks.Name = "btnMaxAllBankSafeStacks"
		Me.btnMaxAllBankSafeStacks.Size = New System.Drawing.Size(125, 23)
		Me.btnMaxAllBankSafeStacks.TabIndex = 11
		Me.btnMaxAllBankSafeStacks.Text = "Max All Item Stacks"
		Me.btnMaxAllBankSafeStacks.UseVisualStyleBackColor = True
		AddHandler Me.btnMaxAllBankSafeStacks.Click, New System.EventHandler(AddressOf Me.btnMaxAllBankSafeStacks_Click)
		' 
		' btnDeleteAllSafeItems
		' 
		Me.btnDeleteAllSafeItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnDeleteAllSafeItems.Location = New System.Drawing.Point(-29, 374)
		Me.btnDeleteAllSafeItems.Name = "btnDeleteAllSafeItems"
		Me.btnDeleteAllSafeItems.Size = New System.Drawing.Size(125, 23)
		Me.btnDeleteAllSafeItems.TabIndex = 10
		Me.btnDeleteAllSafeItems.Text = "Delete All Safe"
		Me.btnDeleteAllSafeItems.UseVisualStyleBackColor = True
		AddHandler Me.btnDeleteAllSafeItems.Click, New System.EventHandler(AddressOf Me.btnDeleteAllSafeItems_Click)
		' 
		' btnDeleteAllBankItems
		' 
		Me.btnDeleteAllBankItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnDeleteAllBankItems.Location = New System.Drawing.Point(-29, 345)
		Me.btnDeleteAllBankItems.Name = "btnDeleteAllBankItems"
		Me.btnDeleteAllBankItems.Size = New System.Drawing.Size(125, 23)
		Me.btnDeleteAllBankItems.TabIndex = 9
		Me.btnDeleteAllBankItems.Text = "Delete All Bank"
		Me.btnDeleteAllBankItems.UseVisualStyleBackColor = True
		AddHandler Me.btnDeleteAllBankItems.Click, New System.EventHandler(AddressOf Me.btnDeleteAllBankItems_Click)
		' 
		' label27
		' 
		Me.label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label27.AutoSize = True
		Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label27.Location = New System.Drawing.Point(6, 323)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(72, 13)
		Me.label27.TabIndex = 8
		Me.label27.Text = "Item Stack:"
		' 
		' txtBankSafeStackCount
		' 
		Me.txtBankSafeStackCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtBankSafeStackCount.Location = New System.Drawing.Point(84, 320)
		Me.txtBankSafeStackCount.Name = "txtBankSafeStackCount"
		Me.txtBankSafeStackCount.Size = New System.Drawing.Size(106, 20)
		Me.txtBankSafeStackCount.TabIndex = 7
		AddHandler Me.txtBankSafeStackCount.TextChanged, New System.EventHandler(AddressOf Me.txtBankSafeStackCount_TextChanged)
		AddHandler Me.txtBankSafeStackCount.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtBankSafeStackCount_KeyPress)
		' 
		' label26
		' 
		Me.label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label26.AutoSize = True
		Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label26.Location = New System.Drawing.Point(6, 48)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(67, 13)
		Me.label26.TabIndex = 6
		Me.label26.Text = "Item Type:"
		' 
		' cboBankSafeItemFilter
		' 
		Me.cboBankSafeItemFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboBankSafeItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBankSafeItemFilter.FormattingEnabled = True
		Me.cboBankSafeItemFilter.Items.AddRange(New Object() {"All", "Armor / Social Gear", "Accessories", "Ammunition", "Building Objects", "Consumables", _
			"Money", "Tools", "Weapons"})
		Me.cboBankSafeItemFilter.Location = New System.Drawing.Point(79, 45)
		Me.cboBankSafeItemFilter.Name = "cboBankSafeItemFilter"
		Me.cboBankSafeItemFilter.Size = New System.Drawing.Size(111, 21)
		Me.cboBankSafeItemFilter.TabIndex = 5
		AddHandler Me.cboBankSafeItemFilter.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboBankSafeItemFilter_SelectedIndexChanged)
		' 
		' label24
		' 
		Me.label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label24.AutoSize = True
		Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label24.Location = New System.Drawing.Point(6, 277)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(71, 13)
		Me.label24.TabIndex = 4
		Me.label24.Text = "Item Prefix:"
		' 
		' cboBankSafePrefix
		' 
		Me.cboBankSafePrefix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboBankSafePrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBankSafePrefix.FormattingEnabled = True
		Me.cboBankSafePrefix.Location = New System.Drawing.Point(6, 293)
		Me.cboBankSafePrefix.Name = "cboBankSafePrefix"
		Me.cboBankSafePrefix.Size = New System.Drawing.Size(184, 21)
		Me.cboBankSafePrefix.TabIndex = 3
		AddHandler Me.cboBankSafePrefix.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cboBankSafePrefix_SelectedIndexChanged)
		' 
		' label25
		' 
		Me.label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label25.AutoSize = True
		Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label25.Location = New System.Drawing.Point(6, 22)
		Me.label25.Name = "label25"
		Me.label25.Size = New System.Drawing.Size(67, 13)
		Me.label25.TabIndex = 2
		Me.label25.Text = "Item Filter:"
		' 
		' txtBankSafeFilter
		' 
		Me.txtBankSafeFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtBankSafeFilter.Location = New System.Drawing.Point(79, 19)
		Me.txtBankSafeFilter.Name = "txtBankSafeFilter"
		Me.txtBankSafeFilter.Size = New System.Drawing.Size(111, 20)
		Me.txtBankSafeFilter.TabIndex = 1
		AddHandler Me.txtBankSafeFilter.TextChanged, New System.EventHandler(AddressOf Me.txtBankSafeFilter_TextChanged)
		' 
		' lstBankSafeItems
		' 
		Me.lstBankSafeItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstBankSafeItems.FormattingEnabled = True
		Me.lstBankSafeItems.IntegralHeight = False
		Me.lstBankSafeItems.Location = New System.Drawing.Point(6, 71)
		Me.lstBankSafeItems.Name = "lstBankSafeItems"
		Me.lstBankSafeItems.Size = New System.Drawing.Size(184, 161)
		Me.lstBankSafeItems.TabIndex = 0
		AddHandler Me.lstBankSafeItems.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lstBankSafeItems_SelectedIndexChanged)
		' 
		' groupBox9
		' 
		Me.groupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox9.Controls.Add(Me.bankSafeItem02)
		Me.groupBox9.Controls.Add(Me.bankSafeItem01)
		Me.groupBox9.Controls.Add(Me.bankSafeItem03)
		Me.groupBox9.Controls.Add(Me.bankSafeItem04)
		Me.groupBox9.Controls.Add(Me.bankSafeItem05)
		Me.groupBox9.Controls.Add(Me.bankSafeItem06)
		Me.groupBox9.Controls.Add(Me.bankSafeItem07)
		Me.groupBox9.Controls.Add(Me.bankSafeItem08)
		Me.groupBox9.Controls.Add(Me.bankSafeItem16)
		Me.groupBox9.Controls.Add(Me.bankSafeItem15)
		Me.groupBox9.Controls.Add(Me.bankSafeItem14)
		Me.groupBox9.Controls.Add(Me.bankSafeItem13)
		Me.groupBox9.Controls.Add(Me.bankSafeItem12)
		Me.groupBox9.Controls.Add(Me.bankSafeItem11)
		Me.groupBox9.Controls.Add(Me.bankSafeItem10)
		Me.groupBox9.Controls.Add(Me.bankSafeItem09)
		Me.groupBox9.Controls.Add(Me.bankSafeItem24)
		Me.groupBox9.Controls.Add(Me.bankSafeItem23)
		Me.groupBox9.Controls.Add(Me.bankSafeItem22)
		Me.groupBox9.Controls.Add(Me.bankSafeItem21)
		Me.groupBox9.Controls.Add(Me.bankSafeItem20)
		Me.groupBox9.Controls.Add(Me.bankSafeItem19)
		Me.groupBox9.Controls.Add(Me.bankSafeItem18)
		Me.groupBox9.Controls.Add(Me.bankSafeItem17)
		Me.groupBox9.Controls.Add(Me.bankSafeItem32)
		Me.groupBox9.Controls.Add(Me.bankSafeItem31)
		Me.groupBox9.Controls.Add(Me.bankSafeItem30)
		Me.groupBox9.Controls.Add(Me.bankSafeItem29)
		Me.groupBox9.Controls.Add(Me.bankSafeItem28)
		Me.groupBox9.Controls.Add(Me.bankSafeItem27)
		Me.groupBox9.Controls.Add(Me.bankSafeItem26)
		Me.groupBox9.Controls.Add(Me.bankSafeItem25)
		Me.groupBox9.Controls.Add(Me.bankSafeItem39)
		Me.groupBox9.Controls.Add(Me.bankSafeItem38)
		Me.groupBox9.Controls.Add(Me.bankSafeItem37)
		Me.groupBox9.Controls.Add(Me.bankSafeItem36)
		Me.groupBox9.Controls.Add(Me.bankSafeItem35)
		Me.groupBox9.Controls.Add(Me.bankSafeItem34)
		Me.groupBox9.Controls.Add(Me.bankSafeItem33)
		Me.groupBox9.Controls.Add(Me.bankSafeItem00)
		Me.groupBox9.Location = New System.Drawing.Point(210, 3)
		Me.groupBox9.Name = "groupBox9"
		Me.groupBox9.Size = New System.Drawing.Size(399, 164)
		Me.groupBox9.TabIndex = 84
		Me.groupBox9.TabStop = False
		Me.groupBox9.Text = "Bank Items"
		' 
		' bankSafeItem02
		' 
		Me.bankSafeItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem02.Location = New System.Drawing.Point(88, 15)
		Me.bankSafeItem02.Name = "bankSafeItem02"
		Me.bankSafeItem02.ShowItemCount = True
		Me.bankSafeItem02.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem02.TabIndex = 4
		Me.bankSafeItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem02.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem02.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem02.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem02.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem01
		' 
		Me.bankSafeItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem01.Location = New System.Drawing.Point(50, 15)
		Me.bankSafeItem01.Name = "bankSafeItem01"
		Me.bankSafeItem01.ShowItemCount = True
		Me.bankSafeItem01.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem01.TabIndex = 3
		Me.bankSafeItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem01.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem01.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem01.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem01.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem03
		' 
		Me.bankSafeItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem03.Location = New System.Drawing.Point(126, 15)
		Me.bankSafeItem03.Name = "bankSafeItem03"
		Me.bankSafeItem03.ShowItemCount = True
		Me.bankSafeItem03.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem03.TabIndex = 5
		Me.bankSafeItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem03.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem03.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem03.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem03.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem04
		' 
		Me.bankSafeItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem04.Location = New System.Drawing.Point(164, 15)
		Me.bankSafeItem04.Name = "bankSafeItem04"
		Me.bankSafeItem04.ShowItemCount = True
		Me.bankSafeItem04.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem04.TabIndex = 6
		Me.bankSafeItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem04.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem04.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem04.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem04.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem05
		' 
		Me.bankSafeItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem05.Location = New System.Drawing.Point(202, 15)
		Me.bankSafeItem05.Name = "bankSafeItem05"
		Me.bankSafeItem05.ShowItemCount = True
		Me.bankSafeItem05.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem05.TabIndex = 7
		Me.bankSafeItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem05.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem05.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem05.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem05.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem06
		' 
		Me.bankSafeItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem06.Location = New System.Drawing.Point(240, 15)
		Me.bankSafeItem06.Name = "bankSafeItem06"
		Me.bankSafeItem06.ShowItemCount = True
		Me.bankSafeItem06.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem06.TabIndex = 8
		Me.bankSafeItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem06.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem06.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem06.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem06.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem07
		' 
		Me.bankSafeItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem07.Location = New System.Drawing.Point(278, 15)
		Me.bankSafeItem07.Name = "bankSafeItem07"
		Me.bankSafeItem07.ShowItemCount = True
		Me.bankSafeItem07.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem07.TabIndex = 9
		Me.bankSafeItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem07.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem07.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem07.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem07.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem08
		' 
		Me.bankSafeItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem08.Location = New System.Drawing.Point(316, 15)
		Me.bankSafeItem08.Name = "bankSafeItem08"
		Me.bankSafeItem08.ShowItemCount = True
		Me.bankSafeItem08.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem08.TabIndex = 10
		Me.bankSafeItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem08.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem08.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem08.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem08.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem16
		' 
		Me.bankSafeItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem16.Location = New System.Drawing.Point(240, 49)
		Me.bankSafeItem16.Name = "bankSafeItem16"
		Me.bankSafeItem16.ShowItemCount = True
		Me.bankSafeItem16.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem16.TabIndex = 11
		Me.bankSafeItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem16.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem16.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem16.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem16.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem15
		' 
		Me.bankSafeItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem15.Location = New System.Drawing.Point(202, 49)
		Me.bankSafeItem15.Name = "bankSafeItem15"
		Me.bankSafeItem15.ShowItemCount = True
		Me.bankSafeItem15.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem15.TabIndex = 12
		Me.bankSafeItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem15.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem15.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem15.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem15.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem14
		' 
		Me.bankSafeItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem14.Location = New System.Drawing.Point(164, 49)
		Me.bankSafeItem14.Name = "bankSafeItem14"
		Me.bankSafeItem14.ShowItemCount = True
		Me.bankSafeItem14.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem14.TabIndex = 13
		Me.bankSafeItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem14.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem14.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem14.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem14.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem13
		' 
		Me.bankSafeItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem13.Location = New System.Drawing.Point(126, 49)
		Me.bankSafeItem13.Name = "bankSafeItem13"
		Me.bankSafeItem13.ShowItemCount = True
		Me.bankSafeItem13.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem13.TabIndex = 14
		Me.bankSafeItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem13.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem13.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem13.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem13.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem12
		' 
		Me.bankSafeItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem12.Location = New System.Drawing.Point(88, 49)
		Me.bankSafeItem12.Name = "bankSafeItem12"
		Me.bankSafeItem12.ShowItemCount = True
		Me.bankSafeItem12.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem12.TabIndex = 15
		Me.bankSafeItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem12.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem12.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem12.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem12.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem11
		' 
		Me.bankSafeItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem11.Location = New System.Drawing.Point(50, 49)
		Me.bankSafeItem11.Name = "bankSafeItem11"
		Me.bankSafeItem11.ShowItemCount = True
		Me.bankSafeItem11.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem11.TabIndex = 16
		Me.bankSafeItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem11.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem11.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem11.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem11.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem10
		' 
		Me.bankSafeItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem10.Location = New System.Drawing.Point(12, 49)
		Me.bankSafeItem10.Name = "bankSafeItem10"
		Me.bankSafeItem10.ShowItemCount = True
		Me.bankSafeItem10.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem10.TabIndex = 17
		Me.bankSafeItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem10.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem10.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem10.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem10.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem09
		' 
		Me.bankSafeItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem09.Location = New System.Drawing.Point(354, 15)
		Me.bankSafeItem09.Name = "bankSafeItem09"
		Me.bankSafeItem09.ShowItemCount = True
		Me.bankSafeItem09.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem09.TabIndex = 18
		Me.bankSafeItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem09.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem09.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem09.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem09.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem24
		' 
		Me.bankSafeItem24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem24.Location = New System.Drawing.Point(164, 84)
		Me.bankSafeItem24.Name = "bankSafeItem24"
		Me.bankSafeItem24.ShowItemCount = True
		Me.bankSafeItem24.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem24.TabIndex = 19
		Me.bankSafeItem24.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem24.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem24.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem24.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem24.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem23
		' 
		Me.bankSafeItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem23.Location = New System.Drawing.Point(126, 84)
		Me.bankSafeItem23.Name = "bankSafeItem23"
		Me.bankSafeItem23.ShowItemCount = True
		Me.bankSafeItem23.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem23.TabIndex = 20
		Me.bankSafeItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem23.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem23.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem23.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem23.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem22
		' 
		Me.bankSafeItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem22.Location = New System.Drawing.Point(88, 84)
		Me.bankSafeItem22.Name = "bankSafeItem22"
		Me.bankSafeItem22.ShowItemCount = True
		Me.bankSafeItem22.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem22.TabIndex = 21
		Me.bankSafeItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem22.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem22.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem22.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem22.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem21
		' 
		Me.bankSafeItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem21.Location = New System.Drawing.Point(50, 84)
		Me.bankSafeItem21.Name = "bankSafeItem21"
		Me.bankSafeItem21.ShowItemCount = True
		Me.bankSafeItem21.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem21.TabIndex = 22
		Me.bankSafeItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem21.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem21.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem21.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem21.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem20
		' 
		Me.bankSafeItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem20.Location = New System.Drawing.Point(12, 84)
		Me.bankSafeItem20.Name = "bankSafeItem20"
		Me.bankSafeItem20.ShowItemCount = True
		Me.bankSafeItem20.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem20.TabIndex = 23
		Me.bankSafeItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem20.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem20.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem20.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem20.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem19
		' 
		Me.bankSafeItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem19.Location = New System.Drawing.Point(354, 49)
		Me.bankSafeItem19.Name = "bankSafeItem19"
		Me.bankSafeItem19.ShowItemCount = True
		Me.bankSafeItem19.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem19.TabIndex = 24
		Me.bankSafeItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem19.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem19.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem19.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem19.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem18
		' 
		Me.bankSafeItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem18.Location = New System.Drawing.Point(316, 49)
		Me.bankSafeItem18.Name = "bankSafeItem18"
		Me.bankSafeItem18.ShowItemCount = True
		Me.bankSafeItem18.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem18.TabIndex = 25
		Me.bankSafeItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem18.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem18.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem18.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem18.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem17
		' 
		Me.bankSafeItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem17.Location = New System.Drawing.Point(278, 49)
		Me.bankSafeItem17.Name = "bankSafeItem17"
		Me.bankSafeItem17.ShowItemCount = True
		Me.bankSafeItem17.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem17.TabIndex = 26
		Me.bankSafeItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem17.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem17.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem17.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem17.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem32
		' 
		Me.bankSafeItem32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem32.Location = New System.Drawing.Point(88, 120)
		Me.bankSafeItem32.Name = "bankSafeItem32"
		Me.bankSafeItem32.ShowItemCount = True
		Me.bankSafeItem32.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem32.TabIndex = 27
		Me.bankSafeItem32.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem32.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem32.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem32.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem32.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem31
		' 
		Me.bankSafeItem31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem31.Location = New System.Drawing.Point(50, 120)
		Me.bankSafeItem31.Name = "bankSafeItem31"
		Me.bankSafeItem31.ShowItemCount = True
		Me.bankSafeItem31.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem31.TabIndex = 28
		Me.bankSafeItem31.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem31.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem31.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem31.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem31.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem30
		' 
		Me.bankSafeItem30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem30.Location = New System.Drawing.Point(12, 120)
		Me.bankSafeItem30.Name = "bankSafeItem30"
		Me.bankSafeItem30.ShowItemCount = True
		Me.bankSafeItem30.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem30.TabIndex = 29
		Me.bankSafeItem30.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem30.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem30.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem30.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem30.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem29
		' 
		Me.bankSafeItem29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem29.Location = New System.Drawing.Point(354, 84)
		Me.bankSafeItem29.Name = "bankSafeItem29"
		Me.bankSafeItem29.ShowItemCount = True
		Me.bankSafeItem29.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem29.TabIndex = 30
		Me.bankSafeItem29.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem29.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem29.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem29.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem29.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem28
		' 
		Me.bankSafeItem28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem28.Location = New System.Drawing.Point(316, 84)
		Me.bankSafeItem28.Name = "bankSafeItem28"
		Me.bankSafeItem28.ShowItemCount = True
		Me.bankSafeItem28.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem28.TabIndex = 31
		Me.bankSafeItem28.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem28.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem28.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem28.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem28.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem27
		' 
		Me.bankSafeItem27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem27.Location = New System.Drawing.Point(278, 84)
		Me.bankSafeItem27.Name = "bankSafeItem27"
		Me.bankSafeItem27.ShowItemCount = True
		Me.bankSafeItem27.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem27.TabIndex = 32
		Me.bankSafeItem27.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem27.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem27.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem27.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem27.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem26
		' 
		Me.bankSafeItem26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem26.Location = New System.Drawing.Point(240, 84)
		Me.bankSafeItem26.Name = "bankSafeItem26"
		Me.bankSafeItem26.ShowItemCount = True
		Me.bankSafeItem26.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem26.TabIndex = 33
		Me.bankSafeItem26.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem26.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem26.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem26.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem26.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem25
		' 
		Me.bankSafeItem25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem25.Location = New System.Drawing.Point(202, 84)
		Me.bankSafeItem25.Name = "bankSafeItem25"
		Me.bankSafeItem25.ShowItemCount = True
		Me.bankSafeItem25.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem25.TabIndex = 34
		Me.bankSafeItem25.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem25.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem25.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem25.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem25.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem39
		' 
		Me.bankSafeItem39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem39.Location = New System.Drawing.Point(354, 120)
		Me.bankSafeItem39.Name = "bankSafeItem39"
		Me.bankSafeItem39.ShowItemCount = True
		Me.bankSafeItem39.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem39.TabIndex = 36
		Me.bankSafeItem39.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem39.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem39.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem39.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem39.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem38
		' 
		Me.bankSafeItem38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem38.Location = New System.Drawing.Point(316, 120)
		Me.bankSafeItem38.Name = "bankSafeItem38"
		Me.bankSafeItem38.ShowItemCount = True
		Me.bankSafeItem38.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem38.TabIndex = 37
		Me.bankSafeItem38.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem38.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem38.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem38.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem38.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem37
		' 
		Me.bankSafeItem37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem37.Location = New System.Drawing.Point(278, 120)
		Me.bankSafeItem37.Name = "bankSafeItem37"
		Me.bankSafeItem37.ShowItemCount = True
		Me.bankSafeItem37.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem37.TabIndex = 38
		Me.bankSafeItem37.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem37.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem37.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem37.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem37.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem36
		' 
		Me.bankSafeItem36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem36.Location = New System.Drawing.Point(240, 120)
		Me.bankSafeItem36.Name = "bankSafeItem36"
		Me.bankSafeItem36.ShowItemCount = True
		Me.bankSafeItem36.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem36.TabIndex = 39
		Me.bankSafeItem36.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem36.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem36.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem36.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem36.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem35
		' 
		Me.bankSafeItem35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem35.Location = New System.Drawing.Point(202, 120)
		Me.bankSafeItem35.Name = "bankSafeItem35"
		Me.bankSafeItem35.ShowItemCount = True
		Me.bankSafeItem35.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem35.TabIndex = 40
		Me.bankSafeItem35.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem35.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem35.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem35.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem35.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem34
		' 
		Me.bankSafeItem34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem34.Location = New System.Drawing.Point(164, 120)
		Me.bankSafeItem34.Name = "bankSafeItem34"
		Me.bankSafeItem34.ShowItemCount = True
		Me.bankSafeItem34.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem34.TabIndex = 41
		Me.bankSafeItem34.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem34.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem34.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem34.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem34.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem33
		' 
		Me.bankSafeItem33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem33.Location = New System.Drawing.Point(126, 120)
		Me.bankSafeItem33.Name = "bankSafeItem33"
		Me.bankSafeItem33.ShowItemCount = True
		Me.bankSafeItem33.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem33.TabIndex = 42
		Me.bankSafeItem33.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem33.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem33.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem33.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem33.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem00
		' 
		Me.bankSafeItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem00.Location = New System.Drawing.Point(12, 15)
		Me.bankSafeItem00.Name = "bankSafeItem00"
		Me.bankSafeItem00.ShowItemCount = True
		Me.bankSafeItem00.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem00.TabIndex = 43
		Me.bankSafeItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem00.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem00.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem00.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem00.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' groupBox10
		' 
		Me.groupBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox10.BackColor = System.Drawing.Color.Transparent
		Me.groupBox10.Controls.Add(Me.bankSafeItem40)
		Me.groupBox10.Controls.Add(Me.bankSafeItem41)
		Me.groupBox10.Controls.Add(Me.bankSafeItem79)
		Me.groupBox10.Controls.Add(Me.bankSafeItem42)
		Me.groupBox10.Controls.Add(Me.bankSafeItem78)
		Me.groupBox10.Controls.Add(Me.bankSafeItem43)
		Me.groupBox10.Controls.Add(Me.bankSafeItem77)
		Me.groupBox10.Controls.Add(Me.bankSafeItem44)
		Me.groupBox10.Controls.Add(Me.bankSafeItem76)
		Me.groupBox10.Controls.Add(Me.bankSafeItem45)
		Me.groupBox10.Controls.Add(Me.bankSafeItem75)
		Me.groupBox10.Controls.Add(Me.bankSafeItem46)
		Me.groupBox10.Controls.Add(Me.bankSafeItem74)
		Me.groupBox10.Controls.Add(Me.bankSafeItem47)
		Me.groupBox10.Controls.Add(Me.bankSafeItem73)
		Me.groupBox10.Controls.Add(Me.bankSafeItem48)
		Me.groupBox10.Controls.Add(Me.bankSafeItem72)
		Me.groupBox10.Controls.Add(Me.bankSafeItem49)
		Me.groupBox10.Controls.Add(Me.bankSafeItem71)
		Me.groupBox10.Controls.Add(Me.bankSafeItem50)
		Me.groupBox10.Controls.Add(Me.bankSafeItem70)
		Me.groupBox10.Controls.Add(Me.bankSafeItem51)
		Me.groupBox10.Controls.Add(Me.bankSafeItem69)
		Me.groupBox10.Controls.Add(Me.bankSafeItem52)
		Me.groupBox10.Controls.Add(Me.bankSafeItem68)
		Me.groupBox10.Controls.Add(Me.bankSafeItem53)
		Me.groupBox10.Controls.Add(Me.bankSafeItem67)
		Me.groupBox10.Controls.Add(Me.bankSafeItem54)
		Me.groupBox10.Controls.Add(Me.bankSafeItem66)
		Me.groupBox10.Controls.Add(Me.bankSafeItem55)
		Me.groupBox10.Controls.Add(Me.bankSafeItem65)
		Me.groupBox10.Controls.Add(Me.bankSafeItem56)
		Me.groupBox10.Controls.Add(Me.bankSafeItem64)
		Me.groupBox10.Controls.Add(Me.bankSafeItem57)
		Me.groupBox10.Controls.Add(Me.bankSafeItem63)
		Me.groupBox10.Controls.Add(Me.bankSafeItem58)
		Me.groupBox10.Controls.Add(Me.bankSafeItem62)
		Me.groupBox10.Controls.Add(Me.bankSafeItem59)
		Me.groupBox10.Controls.Add(Me.bankSafeItem61)
		Me.groupBox10.Controls.Add(Me.bankSafeItem60)
		Me.groupBox10.Location = New System.Drawing.Point(210, 208)
		Me.groupBox10.Name = "groupBox10"
		Me.groupBox10.Size = New System.Drawing.Size(399, 169)
		Me.groupBox10.TabIndex = 85
		Me.groupBox10.TabStop = False
		Me.groupBox10.Text = "Safe Items"
		' 
		' bankSafeItem40
		' 
		Me.bankSafeItem40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem40.Location = New System.Drawing.Point(12, 16)
		Me.bankSafeItem40.Name = "bankSafeItem40"
		Me.bankSafeItem40.ShowItemCount = True
		Me.bankSafeItem40.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem40.TabIndex = 35
		Me.bankSafeItem40.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem40.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem40.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem40.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem40.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem41
		' 
		Me.bankSafeItem41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem41.Location = New System.Drawing.Point(50, 16)
		Me.bankSafeItem41.Name = "bankSafeItem41"
		Me.bankSafeItem41.ShowItemCount = True
		Me.bankSafeItem41.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem41.TabIndex = 82
		Me.bankSafeItem41.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem41.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem41.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem41.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem41.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem79
		' 
		Me.bankSafeItem79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem79.Location = New System.Drawing.Point(354, 127)
		Me.bankSafeItem79.Name = "bankSafeItem79"
		Me.bankSafeItem79.ShowItemCount = True
		Me.bankSafeItem79.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem79.TabIndex = 44
		Me.bankSafeItem79.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem79.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem79.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem79.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem79.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem42
		' 
		Me.bankSafeItem42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem42.Location = New System.Drawing.Point(88, 16)
		Me.bankSafeItem42.Name = "bankSafeItem42"
		Me.bankSafeItem42.ShowItemCount = True
		Me.bankSafeItem42.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem42.TabIndex = 81
		Me.bankSafeItem42.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem42.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem42.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem42.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem42.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem78
		' 
		Me.bankSafeItem78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem78.Location = New System.Drawing.Point(316, 127)
		Me.bankSafeItem78.Name = "bankSafeItem78"
		Me.bankSafeItem78.ShowItemCount = True
		Me.bankSafeItem78.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem78.TabIndex = 45
		Me.bankSafeItem78.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem78.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem78.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem78.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem78.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem43
		' 
		Me.bankSafeItem43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem43.Location = New System.Drawing.Point(126, 16)
		Me.bankSafeItem43.Name = "bankSafeItem43"
		Me.bankSafeItem43.ShowItemCount = True
		Me.bankSafeItem43.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem43.TabIndex = 80
		Me.bankSafeItem43.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem43.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem43.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem43.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem43.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem77
		' 
		Me.bankSafeItem77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem77.Location = New System.Drawing.Point(278, 127)
		Me.bankSafeItem77.Name = "bankSafeItem77"
		Me.bankSafeItem77.ShowItemCount = True
		Me.bankSafeItem77.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem77.TabIndex = 46
		Me.bankSafeItem77.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem77.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem77.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem77.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem77.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem44
		' 
		Me.bankSafeItem44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem44.Location = New System.Drawing.Point(164, 16)
		Me.bankSafeItem44.Name = "bankSafeItem44"
		Me.bankSafeItem44.ShowItemCount = True
		Me.bankSafeItem44.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem44.TabIndex = 79
		Me.bankSafeItem44.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem44.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem44.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem44.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem44.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem76
		' 
		Me.bankSafeItem76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem76.Location = New System.Drawing.Point(240, 127)
		Me.bankSafeItem76.Name = "bankSafeItem76"
		Me.bankSafeItem76.ShowItemCount = True
		Me.bankSafeItem76.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem76.TabIndex = 47
		Me.bankSafeItem76.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem76.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem76.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem76.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem76.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem45
		' 
		Me.bankSafeItem45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem45.Location = New System.Drawing.Point(202, 16)
		Me.bankSafeItem45.Name = "bankSafeItem45"
		Me.bankSafeItem45.ShowItemCount = True
		Me.bankSafeItem45.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem45.TabIndex = 78
		Me.bankSafeItem45.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem45.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem45.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem45.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem45.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem75
		' 
		Me.bankSafeItem75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem75.Location = New System.Drawing.Point(202, 127)
		Me.bankSafeItem75.Name = "bankSafeItem75"
		Me.bankSafeItem75.ShowItemCount = True
		Me.bankSafeItem75.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem75.TabIndex = 48
		Me.bankSafeItem75.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem75.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem75.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem75.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem75.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem46
		' 
		Me.bankSafeItem46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem46.Location = New System.Drawing.Point(240, 16)
		Me.bankSafeItem46.Name = "bankSafeItem46"
		Me.bankSafeItem46.ShowItemCount = True
		Me.bankSafeItem46.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem46.TabIndex = 77
		Me.bankSafeItem46.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem46.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem46.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem46.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem46.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem74
		' 
		Me.bankSafeItem74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem74.Location = New System.Drawing.Point(164, 127)
		Me.bankSafeItem74.Name = "bankSafeItem74"
		Me.bankSafeItem74.ShowItemCount = True
		Me.bankSafeItem74.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem74.TabIndex = 49
		Me.bankSafeItem74.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem74.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem74.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem74.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem74.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem47
		' 
		Me.bankSafeItem47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem47.Location = New System.Drawing.Point(278, 16)
		Me.bankSafeItem47.Name = "bankSafeItem47"
		Me.bankSafeItem47.ShowItemCount = True
		Me.bankSafeItem47.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem47.TabIndex = 76
		Me.bankSafeItem47.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem47.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem47.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem47.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem47.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem73
		' 
		Me.bankSafeItem73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem73.Location = New System.Drawing.Point(126, 127)
		Me.bankSafeItem73.Name = "bankSafeItem73"
		Me.bankSafeItem73.ShowItemCount = True
		Me.bankSafeItem73.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem73.TabIndex = 50
		Me.bankSafeItem73.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem73.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem73.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem73.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem73.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem48
		' 
		Me.bankSafeItem48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem48.Location = New System.Drawing.Point(316, 16)
		Me.bankSafeItem48.Name = "bankSafeItem48"
		Me.bankSafeItem48.ShowItemCount = True
		Me.bankSafeItem48.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem48.TabIndex = 75
		Me.bankSafeItem48.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem48.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem48.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem48.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem48.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem72
		' 
		Me.bankSafeItem72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem72.Location = New System.Drawing.Point(88, 127)
		Me.bankSafeItem72.Name = "bankSafeItem72"
		Me.bankSafeItem72.ShowItemCount = True
		Me.bankSafeItem72.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem72.TabIndex = 51
		Me.bankSafeItem72.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem72.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem72.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem72.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem72.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem49
		' 
		Me.bankSafeItem49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem49.Location = New System.Drawing.Point(354, 16)
		Me.bankSafeItem49.Name = "bankSafeItem49"
		Me.bankSafeItem49.ShowItemCount = True
		Me.bankSafeItem49.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem49.TabIndex = 74
		Me.bankSafeItem49.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem49.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem49.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem49.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem49.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem71
		' 
		Me.bankSafeItem71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem71.Location = New System.Drawing.Point(50, 127)
		Me.bankSafeItem71.Name = "bankSafeItem71"
		Me.bankSafeItem71.ShowItemCount = True
		Me.bankSafeItem71.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem71.TabIndex = 52
		Me.bankSafeItem71.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem71.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem71.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem71.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem71.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem50
		' 
		Me.bankSafeItem50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem50.Location = New System.Drawing.Point(12, 53)
		Me.bankSafeItem50.Name = "bankSafeItem50"
		Me.bankSafeItem50.ShowItemCount = True
		Me.bankSafeItem50.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem50.TabIndex = 73
		Me.bankSafeItem50.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem50.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem50.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem50.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem50.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem70
		' 
		Me.bankSafeItem70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem70.Location = New System.Drawing.Point(12, 127)
		Me.bankSafeItem70.Name = "bankSafeItem70"
		Me.bankSafeItem70.ShowItemCount = True
		Me.bankSafeItem70.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem70.TabIndex = 53
		Me.bankSafeItem70.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem70.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem70.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem70.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem70.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem51
		' 
		Me.bankSafeItem51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem51.Location = New System.Drawing.Point(50, 53)
		Me.bankSafeItem51.Name = "bankSafeItem51"
		Me.bankSafeItem51.ShowItemCount = True
		Me.bankSafeItem51.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem51.TabIndex = 72
		Me.bankSafeItem51.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem51.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem51.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem51.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem51.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem69
		' 
		Me.bankSafeItem69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem69.Location = New System.Drawing.Point(354, 90)
		Me.bankSafeItem69.Name = "bankSafeItem69"
		Me.bankSafeItem69.ShowItemCount = True
		Me.bankSafeItem69.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem69.TabIndex = 54
		Me.bankSafeItem69.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem69.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem69.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem69.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem69.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem52
		' 
		Me.bankSafeItem52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem52.Location = New System.Drawing.Point(88, 53)
		Me.bankSafeItem52.Name = "bankSafeItem52"
		Me.bankSafeItem52.ShowItemCount = True
		Me.bankSafeItem52.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem52.TabIndex = 71
		Me.bankSafeItem52.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem52.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem52.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem52.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem52.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem68
		' 
		Me.bankSafeItem68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem68.Location = New System.Drawing.Point(316, 92)
		Me.bankSafeItem68.Name = "bankSafeItem68"
		Me.bankSafeItem68.ShowItemCount = True
		Me.bankSafeItem68.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem68.TabIndex = 55
		Me.bankSafeItem68.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem68.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem68.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem68.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem68.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem53
		' 
		Me.bankSafeItem53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem53.Location = New System.Drawing.Point(126, 53)
		Me.bankSafeItem53.Name = "bankSafeItem53"
		Me.bankSafeItem53.ShowItemCount = True
		Me.bankSafeItem53.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem53.TabIndex = 70
		Me.bankSafeItem53.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem53.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem53.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem53.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem53.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem67
		' 
		Me.bankSafeItem67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem67.Location = New System.Drawing.Point(278, 92)
		Me.bankSafeItem67.Name = "bankSafeItem67"
		Me.bankSafeItem67.ShowItemCount = True
		Me.bankSafeItem67.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem67.TabIndex = 56
		Me.bankSafeItem67.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem67.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem67.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem67.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem67.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem54
		' 
		Me.bankSafeItem54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem54.Location = New System.Drawing.Point(164, 53)
		Me.bankSafeItem54.Name = "bankSafeItem54"
		Me.bankSafeItem54.ShowItemCount = True
		Me.bankSafeItem54.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem54.TabIndex = 69
		Me.bankSafeItem54.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem54.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem54.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem54.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem54.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem66
		' 
		Me.bankSafeItem66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem66.Location = New System.Drawing.Point(240, 92)
		Me.bankSafeItem66.Name = "bankSafeItem66"
		Me.bankSafeItem66.ShowItemCount = True
		Me.bankSafeItem66.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem66.TabIndex = 57
		Me.bankSafeItem66.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem66.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem66.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem66.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem66.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem55
		' 
		Me.bankSafeItem55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem55.Location = New System.Drawing.Point(202, 53)
		Me.bankSafeItem55.Name = "bankSafeItem55"
		Me.bankSafeItem55.ShowItemCount = True
		Me.bankSafeItem55.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem55.TabIndex = 68
		Me.bankSafeItem55.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem55.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem55.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem55.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem55.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem65
		' 
		Me.bankSafeItem65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem65.Location = New System.Drawing.Point(202, 92)
		Me.bankSafeItem65.Name = "bankSafeItem65"
		Me.bankSafeItem65.ShowItemCount = True
		Me.bankSafeItem65.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem65.TabIndex = 58
		Me.bankSafeItem65.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem65.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem65.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem65.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem65.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem56
		' 
		Me.bankSafeItem56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem56.Location = New System.Drawing.Point(240, 53)
		Me.bankSafeItem56.Name = "bankSafeItem56"
		Me.bankSafeItem56.ShowItemCount = True
		Me.bankSafeItem56.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem56.TabIndex = 67
		Me.bankSafeItem56.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem56.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem56.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem56.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem56.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem64
		' 
		Me.bankSafeItem64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem64.Location = New System.Drawing.Point(164, 92)
		Me.bankSafeItem64.Name = "bankSafeItem64"
		Me.bankSafeItem64.ShowItemCount = True
		Me.bankSafeItem64.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem64.TabIndex = 59
		Me.bankSafeItem64.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem64.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem64.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem64.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem64.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem57
		' 
		Me.bankSafeItem57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem57.Location = New System.Drawing.Point(278, 53)
		Me.bankSafeItem57.Name = "bankSafeItem57"
		Me.bankSafeItem57.ShowItemCount = True
		Me.bankSafeItem57.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem57.TabIndex = 66
		Me.bankSafeItem57.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem57.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem57.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem57.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem57.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem63
		' 
		Me.bankSafeItem63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem63.Location = New System.Drawing.Point(126, 90)
		Me.bankSafeItem63.Name = "bankSafeItem63"
		Me.bankSafeItem63.ShowItemCount = True
		Me.bankSafeItem63.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem63.TabIndex = 60
		Me.bankSafeItem63.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem63.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem63.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem63.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem63.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem58
		' 
		Me.bankSafeItem58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem58.Location = New System.Drawing.Point(316, 53)
		Me.bankSafeItem58.Name = "bankSafeItem58"
		Me.bankSafeItem58.ShowItemCount = True
		Me.bankSafeItem58.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem58.TabIndex = 65
		Me.bankSafeItem58.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem58.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem58.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem58.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem58.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem62
		' 
		Me.bankSafeItem62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem62.Location = New System.Drawing.Point(88, 90)
		Me.bankSafeItem62.Name = "bankSafeItem62"
		Me.bankSafeItem62.ShowItemCount = True
		Me.bankSafeItem62.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem62.TabIndex = 61
		Me.bankSafeItem62.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem62.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem62.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem62.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem62.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem59
		' 
		Me.bankSafeItem59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem59.Location = New System.Drawing.Point(354, 53)
		Me.bankSafeItem59.Name = "bankSafeItem59"
		Me.bankSafeItem59.ShowItemCount = True
		Me.bankSafeItem59.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem59.TabIndex = 64
		Me.bankSafeItem59.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem59.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem59.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem59.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem59.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem61
		' 
		Me.bankSafeItem61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem61.Location = New System.Drawing.Point(50, 90)
		Me.bankSafeItem61.Name = "bankSafeItem61"
		Me.bankSafeItem61.ShowItemCount = True
		Me.bankSafeItem61.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem61.TabIndex = 62
		Me.bankSafeItem61.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem61.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem61.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem61.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem61.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' bankSafeItem60
		' 
		Me.bankSafeItem60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bankSafeItem60.Location = New System.Drawing.Point(12, 90)
		Me.bankSafeItem60.Name = "bankSafeItem60"
		Me.bankSafeItem60.ShowItemCount = True
		Me.bankSafeItem60.Size = New System.Drawing.Size(32, 32)
		Me.bankSafeItem60.TabIndex = 63
		Me.bankSafeItem60.TextAlign = System.Drawing.ContentAlignment.BottomRight
		AddHandler Me.bankSafeItem60.Click, New System.EventHandler(AddressOf Me.bankSafeItem_Click)
		AddHandler Me.bankSafeItem60.MouseEnter, New System.EventHandler(AddressOf Me.bankSafeItem_MouseEnter)
		AddHandler Me.bankSafeItem60.MouseLeave, New System.EventHandler(AddressOf Me.bankSafeItem_MouseLeave)
		AddHandler Me.bankSafeItem60.PreviewKeyDown, New System.Windows.Forms.PreviewKeyDownEventHandler(AddressOf Me.bankSafeItem_PreviewKeyDown)
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscboQuickSelect, Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(620, 25)
		Me.menuStrip1.TabIndex = 2
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' tscboQuickSelect
		' 
		Me.tscboQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.tscboQuickSelect.Name = "tscboQuickSelect"
		Me.tscboQuickSelect.Size = New System.Drawing.Size(121, 21)
		AddHandler Me.tscboQuickSelect.DropDown, New System.EventHandler(AddressOf Me.tscboQuickSelect_DropDown)
		AddHandler Me.tscboQuickSelect.SelectedIndexChanged, New System.EventHandler(AddressOf Me.tscboQuickSelect_SelectedIndexChanged)
		' 
		' fileToolStripMenuItem
		' 
		Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newCharacterToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator2, _
			Me.exitToolStripMenuItem})
		Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
		Me.fileToolStripMenuItem.Size = New System.Drawing.Size(38, 21)
		Me.fileToolStripMenuItem.Text = "File"
		' 
		' newCharacterToolStripMenuItem
		' 
		Me.newCharacterToolStripMenuItem.Image = Global.TSGE.Properties.Resources.status_online
		Me.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem"
		Me.newCharacterToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.newCharacterToolStripMenuItem.Text = "New Character"
		AddHandler Me.newCharacterToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.newCharacterToolStripMenuItem_Click)
		' 
		' openToolStripMenuItem
		' 
		Me.openToolStripMenuItem.Image = Global.TSGE.Properties.Resources.folder_user
		Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
		Me.openToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.openToolStripMenuItem.Text = "Open"
		AddHandler Me.openToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.openToolStripMenuItem_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(156, 6)
		' 
		' saveToolStripMenuItem
		' 
		Me.saveToolStripMenuItem.Image = Global.TSGE.Properties.Resources.page_save
		Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
		Me.saveToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.saveToolStripMenuItem.Text = "Save"
		AddHandler Me.saveToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.saveToolStripMenuItem_Click)
		' 
		' saveAsToolStripMenuItem
		' 
		Me.saveAsToolStripMenuItem.Image = Global.TSGE.Properties.Resources.script_save
		Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
		Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.saveAsToolStripMenuItem.Text = "Save As"
		AddHandler Me.saveAsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.saveAsToolStripMenuItem_Click)
		' 
		' toolStripSeparator2
		' 
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(156, 6)
		' 
		' exitToolStripMenuItem
		' 
		Me.exitToolStripMenuItem.Image = Global.TSGE.Properties.Resources.[stop]
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.exitToolStripMenuItem.Text = "Exit"
		AddHandler Me.exitToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.exitToolStripMenuItem_Click)
		' 
		' helpToolStripMenuItem
		' 
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutTSGEToolStripMenuItem, Me.checkForUpdatesToolStripMenuItem})
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
		Me.helpToolStripMenuItem.Text = "Help"
		' 
		' aboutTSGEToolStripMenuItem
		' 
		Me.aboutTSGEToolStripMenuItem.Image = Global.TSGE.Properties.Resources.information
		Me.aboutTSGEToolStripMenuItem.Name = "aboutTSGEToolStripMenuItem"
		Me.aboutTSGEToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
		Me.aboutTSGEToolStripMenuItem.Text = "About TSGE"
		AddHandler Me.aboutTSGEToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.aboutTSGEToolStripMenuItem_Click)
		' 
		' checkForUpdatesToolStripMenuItem
		' 
		Me.checkForUpdatesToolStripMenuItem.Image = DirectCast(resources.GetObject("checkForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
		Me.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem"
		Me.checkForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
		Me.checkForUpdatesToolStripMenuItem.Text = "Check For Updates"
		AddHandler Me.checkForUpdatesToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.checkForUpdatesToolStripMenuItem_Click)
		' 
		' inventoryBindingSource
		' 
		Me.inventoryBindingSource.DataMember = "Inventory"
		Me.inventoryBindingSource.DataSource = Me.playerBindingSource
		' 
		' frmMain
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.ClientSize = New System.Drawing.Size(620, 466)
		Me.Controls.Add(Me.tcMainTabControl)
		Me.Controls.Add(Me.menuStrip1)
		Me.HelpButton = True
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "TSGE - by atom0s (Visual Changes by Walkman100)"
		Me.tcMainTabControl.ResumeLayout(False)
		Me.tpMainPlayer.ResumeLayout(False)
		Me.groupBox3.ResumeLayout(False)
		Me.groupBox3.PerformLayout()
		DirectCast(Me.pbShoesColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.playerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbPantsColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbUndershirtColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbShirtColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbEyesColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbSkinColor, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.pbHairColor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox2.PerformLayout()
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.tpBuffs.ResumeLayout(False)
		Me.groupBox4.ResumeLayout(False)
		DirectCast(Me.buffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpInventory.ResumeLayout(False)
		Me.tpInventory.PerformLayout()
		Me.groupBox11.ResumeLayout(False)
		Me.groupBox11.PerformLayout()
		Me.groupBox5.ResumeLayout(False)
		Me.groupBox6.ResumeLayout(False)
		Me.groupBox6.PerformLayout()
		Me.tpEquipment.ResumeLayout(False)
		Me.groupBox7.ResumeLayout(False)
		Me.groupBox7.PerformLayout()
		Me.tpBankSafe.ResumeLayout(False)
		Me.groupBox8.ResumeLayout(False)
		Me.groupBox8.PerformLayout()
		Me.groupBox9.ResumeLayout(False)
		Me.groupBox10.ResumeLayout(False)
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		DirectCast(Me.inventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub



	Private Sub BuffsBindingSourceOnCurrentChanged(sender As Object, eventArgs As EventArgs)
		Me.lstPlayerBuffs.Refresh()
	End Sub

	#End Region

	Private tcMainTabControl As System.Windows.Forms.TabControl
	Private tpMainPlayer As System.Windows.Forms.TabPage
	Private tpBuffs As System.Windows.Forms.TabPage
	Private tpInventory As System.Windows.Forms.TabPage
	Private tpEquipment As System.Windows.Forms.TabPage
	Private tpBankSafe As System.Windows.Forms.TabPage
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private cboDifficulty As System.Windows.Forms.ComboBox
	Private txtPlayerName As System.Windows.Forms.TextBox
	Private chkHotbarLocked As System.Windows.Forms.CheckBox
	Private chkIsMale As System.Windows.Forms.CheckBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private pbShoesColor As System.Windows.Forms.PictureBox
	Private pbPantsColor As System.Windows.Forms.PictureBox
	Private pbUndershirtColor As System.Windows.Forms.PictureBox
	Private pbShirtColor As System.Windows.Forms.PictureBox
	Private pbEyesColor As System.Windows.Forms.PictureBox
	Private pbSkinColor As System.Windows.Forms.PictureBox
	Private pbHairColor As System.Windows.Forms.PictureBox
	Private modelViewer As Controls.ModelViewer
	Private btnRandomColors As System.Windows.Forms.Button
	Private btnRandomHair As System.Windows.Forms.Button
	Private btnSelectHair As System.Windows.Forms.Button
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private pbPlayerHealth As System.Windows.Forms.ProgressBar
	Private pbPlayerMana As System.Windows.Forms.ProgressBar
	Private txtMaxMana As System.Windows.Forms.TextBox
	Private txtCurrentMana As System.Windows.Forms.TextBox
	Private txtMaxHealth As System.Windows.Forms.TextBox
	Private txtCurrentHealth As System.Windows.Forms.TextBox
	Private lstPlayerBuffs As Controls.BuffListBox
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private newCharacterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aboutTSGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private playerBindingSource As System.Windows.Forms.BindingSource
	Private buffsBindingSource As BindingSource
	Private groupBox4 As GroupBox
	Private lstBuffSelection As Controls.BuffSelectionListBox
	Private btnHackAllBuffDurations As Button
	Private btnMaxAllBuffDurations As Button
	Private btnDeleteAllBuffs As Button
	Private btnHackBuffDuration As Button
	Private btnMaxBuffDuration As Button
	Private btnDeleteBuff As Button
	Private inventoryBindingSource As BindingSource
	Private inventoryItem00 As Controls.ItemLabel
	Private inventoryItem01 As Controls.ItemLabel
	Private inventoryItem40 As Controls.ItemLabel
	Private inventoryItem41 As Controls.ItemLabel
	Private inventoryItem42 As Controls.ItemLabel
	Private inventoryItem43 As Controls.ItemLabel
	Private inventoryItem44 As Controls.ItemLabel
	Private inventoryItem45 As Controls.ItemLabel
	Private inventoryItem46 As Controls.ItemLabel
	Private inventoryItem47 As Controls.ItemLabel
	Private inventoryItem48 As Controls.ItemLabel
	Private inventoryItem49 As Controls.ItemLabel
	Private inventoryItem30 As Controls.ItemLabel
	Private inventoryItem31 As Controls.ItemLabel
	Private inventoryItem32 As Controls.ItemLabel
	Private inventoryItem33 As Controls.ItemLabel
	Private inventoryItem34 As Controls.ItemLabel
	Private inventoryItem35 As Controls.ItemLabel
	Private inventoryItem36 As Controls.ItemLabel
	Private inventoryItem37 As Controls.ItemLabel
	Private inventoryItem38 As Controls.ItemLabel
	Private inventoryItem39 As Controls.ItemLabel
	Private inventoryItem20 As Controls.ItemLabel
	Private inventoryItem21 As Controls.ItemLabel
	Private inventoryItem22 As Controls.ItemLabel
	Private inventoryItem23 As Controls.ItemLabel
	Private inventoryItem24 As Controls.ItemLabel
	Private inventoryItem25 As Controls.ItemLabel
	Private inventoryItem26 As Controls.ItemLabel
	Private inventoryItem27 As Controls.ItemLabel
	Private inventoryItem28 As Controls.ItemLabel
	Private inventoryItem29 As Controls.ItemLabel
	Private inventoryItem10 As Controls.ItemLabel
	Private inventoryItem11 As Controls.ItemLabel
	Private inventoryItem12 As Controls.ItemLabel
	Private inventoryItem13 As Controls.ItemLabel
	Private inventoryItem14 As Controls.ItemLabel
	Private inventoryItem15 As Controls.ItemLabel
	Private inventoryItem16 As Controls.ItemLabel
	Private inventoryItem17 As Controls.ItemLabel
	Private inventoryItem18 As Controls.ItemLabel
	Private inventoryItem19 As Controls.ItemLabel
	Private inventoryItem09 As Controls.ItemLabel
	Private inventoryItem08 As Controls.ItemLabel
	Private inventoryItem07 As Controls.ItemLabel
	Private inventoryItem06 As Controls.ItemLabel
	Private inventoryItem05 As Controls.ItemLabel
	Private inventoryItem04 As Controls.ItemLabel
	Private inventoryItem03 As Controls.ItemLabel
	Private inventoryItem02 As Controls.ItemLabel
	Private groupBox5 As GroupBox
	Private lstInventoryItems As ListBox
	Private label6 As Label
	Private label5 As Label
	Private inventoryItem54 As Controls.ItemLabel
	Private inventoryItem53 As Controls.ItemLabel
	Private inventoryItem57 As Controls.ItemLabel
	Private inventoryItem52 As Controls.ItemLabel
	Private inventoryItem56 As Controls.ItemLabel
	Private inventoryItem51 As Controls.ItemLabel
	Private inventoryItem55 As Controls.ItemLabel
	Private inventoryItem50 As Controls.ItemLabel
	Private groupBox7 As GroupBox
	Private label19 As Label
	Private cboEquipmentPrefix As ComboBox
	Private label18 As Label
	Private txtEquipmentFilter As TextBox
	Private lstEquipmentItems As ListBox
	Private label23 As Label
	Private equipmentItem13 As Controls.ItemLabel
	Private equipmentItem12 As Controls.ItemLabel
	Private equipmentItem11 As Controls.ItemLabel
	Private equipmentItem10 As Controls.ItemLabel
	Private equipmentItem09 As Controls.ItemLabel
	Private label22 As Label
	Private equipmentItem08 As Controls.ItemLabel
	Private equipmentItem07 As Controls.ItemLabel
	Private equipmentItem06 As Controls.ItemLabel
	Private label21 As Label
	Private label20 As Label
	Private equipmentItem05 As Controls.ItemLabel
	Private equipmentItem04 As Controls.ItemLabel
	Private equipmentItem03 As Controls.ItemLabel
	Private equipmentItem02 As Controls.ItemLabel
	Private equipmentItem01 As Controls.ItemLabel
	Private equipmentItem00 As Controls.ItemLabel
	Private bankSafeItem07 As Controls.ItemLabel
	Private bankSafeItem06 As Controls.ItemLabel
	Private bankSafeItem05 As Controls.ItemLabel
	Private bankSafeItem04 As Controls.ItemLabel
	Private bankSafeItem03 As Controls.ItemLabel
	Private bankSafeItem02 As Controls.ItemLabel
	Private bankSafeItem01 As Controls.ItemLabel
	Private bankSafeItem33 As Controls.ItemLabel
	Private bankSafeItem34 As Controls.ItemLabel
	Private bankSafeItem35 As Controls.ItemLabel
	Private bankSafeItem36 As Controls.ItemLabel
	Private bankSafeItem37 As Controls.ItemLabel
	Private bankSafeItem38 As Controls.ItemLabel
	Private bankSafeItem39 As Controls.ItemLabel
	Private bankSafeItem40 As Controls.ItemLabel
	Private bankSafeItem25 As Controls.ItemLabel
	Private bankSafeItem26 As Controls.ItemLabel
	Private bankSafeItem27 As Controls.ItemLabel
	Private bankSafeItem28 As Controls.ItemLabel
	Private bankSafeItem29 As Controls.ItemLabel
	Private bankSafeItem30 As Controls.ItemLabel
	Private bankSafeItem31 As Controls.ItemLabel
	Private bankSafeItem32 As Controls.ItemLabel
	Private bankSafeItem17 As Controls.ItemLabel
	Private bankSafeItem18 As Controls.ItemLabel
	Private bankSafeItem19 As Controls.ItemLabel
	Private bankSafeItem20 As Controls.ItemLabel
	Private bankSafeItem21 As Controls.ItemLabel
	Private bankSafeItem22 As Controls.ItemLabel
	Private bankSafeItem23 As Controls.ItemLabel
	Private bankSafeItem24 As Controls.ItemLabel
	Private bankSafeItem09 As Controls.ItemLabel
	Private bankSafeItem10 As Controls.ItemLabel
	Private bankSafeItem11 As Controls.ItemLabel
	Private bankSafeItem12 As Controls.ItemLabel
	Private bankSafeItem13 As Controls.ItemLabel
	Private bankSafeItem14 As Controls.ItemLabel
	Private bankSafeItem15 As Controls.ItemLabel
	Private bankSafeItem16 As Controls.ItemLabel
	Private bankSafeItem08 As Controls.ItemLabel
	Private bankSafeItem41 As Controls.ItemLabel
	Private bankSafeItem42 As Controls.ItemLabel
	Private bankSafeItem43 As Controls.ItemLabel
	Private bankSafeItem44 As Controls.ItemLabel
	Private bankSafeItem45 As Controls.ItemLabel
	Private bankSafeItem46 As Controls.ItemLabel
	Private bankSafeItem47 As Controls.ItemLabel
	Private bankSafeItem48 As Controls.ItemLabel
	Private bankSafeItem49 As Controls.ItemLabel
	Private bankSafeItem50 As Controls.ItemLabel
	Private bankSafeItem51 As Controls.ItemLabel
	Private bankSafeItem52 As Controls.ItemLabel
	Private bankSafeItem53 As Controls.ItemLabel
	Private bankSafeItem54 As Controls.ItemLabel
	Private bankSafeItem55 As Controls.ItemLabel
	Private bankSafeItem56 As Controls.ItemLabel
	Private bankSafeItem57 As Controls.ItemLabel
	Private bankSafeItem58 As Controls.ItemLabel
	Private bankSafeItem59 As Controls.ItemLabel
	Private bankSafeItem60 As Controls.ItemLabel
	Private bankSafeItem61 As Controls.ItemLabel
	Private bankSafeItem62 As Controls.ItemLabel
	Private bankSafeItem63 As Controls.ItemLabel
	Private bankSafeItem64 As Controls.ItemLabel
	Private bankSafeItem65 As Controls.ItemLabel
	Private bankSafeItem66 As Controls.ItemLabel
	Private bankSafeItem67 As Controls.ItemLabel
	Private bankSafeItem68 As Controls.ItemLabel
	Private bankSafeItem69 As Controls.ItemLabel
	Private bankSafeItem70 As Controls.ItemLabel
	Private bankSafeItem71 As Controls.ItemLabel
	Private bankSafeItem72 As Controls.ItemLabel
	Private bankSafeItem73 As Controls.ItemLabel
	Private bankSafeItem74 As Controls.ItemLabel
	Private bankSafeItem75 As Controls.ItemLabel
	Private bankSafeItem76 As Controls.ItemLabel
	Private bankSafeItem77 As Controls.ItemLabel
	Private bankSafeItem78 As Controls.ItemLabel
	Private bankSafeItem79 As Controls.ItemLabel
	Private bankSafeItem00 As Controls.ItemLabel
	Private groupBox8 As GroupBox
	Private label26 As Label
	Private cboBankSafeItemFilter As ComboBox
	Private label24 As Label
	Private cboBankSafePrefix As ComboBox
	Private label25 As Label
	Private txtBankSafeFilter As TextBox
	Private lstBankSafeItems As ListBox
	Private label27 As Label
	Private txtBankSafeStackCount As TextBox
	Private groupBox9 As GroupBox
	Private groupBox10 As GroupBox
	Private btnHackAllBankSafeStacks As Button
	Private btnMaxAllBankSafeStacks As Button
	Private btnDeleteAllSafeItems As Button
	Private btnDeleteAllBankItems As Button
	Private tscboQuickSelect As ToolStripComboBox
	Private checkForUpdatesToolStripMenuItem As ToolStripMenuItem
	Private btnLoadEquipmentSet As Button
	Private btnSaveEquipmentSet As Button
	Private btnLoadSafeItems As Button
	Private btnSaveSafeItems As Button
	Private btnLoadBankItems As Button
	Private btnSaveBankItems As Button
	Private groupBox11 As GroupBox
	Private label17 As Label
	Private txtInventoryStackCount As TextBox
	Private label28 As Label
	Private cboInventoryPrefixCategory As ComboBox
	Private label16 As Label
	Private cboInventoryPrefix As ComboBox
	Private btnInventoryHackAllStacks As Button
	Private btnInventoryDeleteAllItems As Button
	Private btnInventoryMaxAllStacks As Button
	Private btnInventoryDeleteItem As Button
	Private btnLoadInventory As Button
	Private btnSaveInventory As Button
	Private groupBox6 As GroupBox
	Private cboInvItemFilter As ComboBox
	Private label15 As Label
	Private txtInvItemFilter As TextBox
	Private label14 As Label
	Private label29 As Label
	Private cboEquipmentPrefixCategory As ComboBox
	Private label30 As Label
	Private cboBankSafePrefixCategory As ComboBox
	Private btnSaveColorHair As Button
	Private btnLoadColorHair As Button
	Private btnLoadBuffs As Button
	Private btnSaveBuffs As Button
	Private chkHideVisual As CheckBox
	Private label31 As Label
	Private equipmentItem18 As Controls.ItemLabel
	Private equipmentItem17 As Controls.ItemLabel
	Private equipmentItem16 As Controls.ItemLabel
	Private equipmentItem15 As Controls.ItemLabel
	Private equipmentItem14 As Controls.ItemLabel
	Private equipmentItem23 As Controls.ItemLabel
	Private equipmentItem22 As Controls.ItemLabel
	Private equipmentItem21 As Controls.ItemLabel
	Private equipmentItem20 As Controls.ItemLabel
	Private equipmentItem19 As Controls.ItemLabel
	Private label32 As Label
	Private txtFishQuestsCompleted As TextBox

End Class

