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

Imports System.Drawing
Imports System.Linq
Namespace Classes

	Public Class Player
		Inherits ModelBase
		''' <summary>
		''' Default Constructor
		''' </summary>
		Public Sub New()
			' Set player defaults..
			Me.GameVersion = Terraria.LatestVersion
			Me.Name = "Player"
			Me.Difficulty = 0
			Me.Hair = 0
			Me.IsMale = True
			Me.Health = 500
			Me.HealthMax = 500
			Me.Mana = 200
			Me.ManaMax = 200
			Me.IsHotbarLocked = False
			Me.AnglerQuestsFinished = 0
			Me.File = String.Empty

			' Set default colors..
			Me.HairColor = Color.FromArgb(&Hff, &Hd7, &H5a, &H37)
			Me.SkinColor = Color.FromArgb(&Hff, &Hff, &H7d, &H4b)
			Me.EyeColor = Color.FromArgb(&Hff, &H69, &H5a, &H4b)
			Me.ShirtColor = Color.FromArgb(&Hff, &Haf, &Ha5, &H8c)
			Me.UndershirtColor = Color.FromArgb(&Hff, &Ha0, &Hb4, &Hd7)
			Me.PantsColor = Color.FromArgb(&Hff, &Hff, &He6, &Haf)
			Me.ShoesColor = Color.FromArgb(&Hff, &Ha0, &H6a, &H3c)

			' Prepare default data..
			Me.Armor = New Item(2) {}
			Me.Vanity = New Item(2) {}
			Me.Accessories = New Item(4) {}
			Me.SocialAccessories = New Item(4) {}
			Me.Dye = New Item(7) {}
			Me.Inventory = New Item(57) {}
			Me.Bank1 = New Item(39) {}
			Me.Bank2 = New Item(39) {}
			Me.Buffs = New Buff(21) {}
			Me.ServerEntries = New ServerEntry(199) {}

			Dim item = Terraria.Instance.Items.[Single](Function(i) i.NetID = 0)
			Dim buff = Terraria.Instance.Buffs.[Single](Function(b) b.Id = 0)

			For x As var = 0 To Me.Armor.Length - 1
				Me.Armor(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Vanity.Length - 1
				Me.Vanity(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Accessories.Length - 1
				Me.Accessories(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.SocialAccessories.Length - 1
				Me.SocialAccessories(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Dye.Length - 1
				Me.Dye(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Inventory.Length - 1
				Me.Inventory(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Bank1.Length - 1
				Me.Bank1(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Bank2.Length - 1
				Me.Bank2(x) = TryCast(item.Clone(), Item)
			Next

			For x As var = 0 To Me.Buffs.Length - 1
				Me.Buffs(x) = TryCast(buff.Clone(), Buff)
			Next

			For x As var = 0 To Me.ServerEntries.Length - 1
				Me.ServerEntries(x) = New ServerEntry()
			Next
		End Sub

		''' <summary>
		''' Gets or sets the profile file of this player.
		''' </summary>
		Public Property File() As String
			Get
				Return Me.[Get](Of String)("File")
			End Get
			Set
				Me.[Set]("File", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the game version of this player.
		''' </summary>
		Public Property GameVersion() As Integer
			Get
				Return Me.[Get](Of Integer)("GameVersion")
			End Get
			Set
				Me.[Set]("GameVersion", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the name of this player.
		''' </summary>
		Public Property Name() As String
			Get
				Return Me.[Get](Of String)("Name")
			End Get
			Set
				Me.[Set]("Name", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the difficulty of this player.
		''' </summary>
		Public Property Difficulty() As Byte
			Get
				Return Me.[Get](Of Byte)("Difficulty")
			End Get
			Set
				Me.[Set]("Difficulty", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hair of this player.
		''' </summary>
		Public Property Hair() As Integer
			Get
				Return Me.[Get](Of Integer)("Hair")
			End Get
			Set
				Me.[Set]("Hair", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hair dye of this player.
		''' </summary>
		Public Property HairDye() As Byte
			Get
				Return Me.[Get](Of Byte)("HairDye")
			End Get
			Set
				Me.[Set]("HairDye", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hide visual flag of this player.
		''' </summary>
		Public Property HideVisual() As Byte
			Get
				Return Me.[Get](Of Byte)("HideVisual")
			End Get
			Set
				Me.[Set]("HideVisual", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the male flag of this player.
		''' </summary>
		Public Property IsMale() As Boolean
			Get
				Return Me.[Get](Of Boolean)("IsMale")
			End Get
			Set
				Me.[Set]("IsMale", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the health of this player.
		''' </summary>
		Public Property Health() As Integer
			Get
				Return Me.[Get](Of Integer)("Health")
			End Get
			Set
				Me.[Set]("Health", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the max health of this player.
		''' </summary>
		Public Property HealthMax() As Integer
			Get
				Return Me.[Get](Of Integer)("HealthMax")
			End Get
			Set
				Me.[Set]("HealthMax", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the mana of this player.
		''' </summary>
		Public Property Mana() As Integer
			Get
				Return Me.[Get](Of Integer)("Mana")
			End Get
			Set
				Me.[Set]("Mana", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the max mana of this player.
		''' </summary>
		Public Property ManaMax() As Integer
			Get
				Return Me.[Get](Of Integer)("ManaMax")
			End Get
			Set
				Me.[Set]("ManaMax", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hair color of this player.
		''' </summary>
		Public Property HairColor() As Color
			Get
				Return Me.[Get](Of Color)("HairColor")
			End Get
			Set
				Me.[Set]("HairColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the skin color of this player.
		''' </summary>
		Public Property SkinColor() As Color
			Get
				Return Me.[Get](Of Color)("SkinColor")
			End Get
			Set
				Me.[Set]("SkinColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the eye color of this player.
		''' </summary>
		Public Property EyeColor() As Color
			Get
				Return Me.[Get](Of Color)("EyeColor")
			End Get
			Set
				Me.[Set]("EyeColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the shirt color of this player.
		''' </summary>
		Public Property ShirtColor() As Color
			Get
				Return Me.[Get](Of Color)("ShirtColor")
			End Get
			Set
				Me.[Set]("ShirtColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the undershirt color of this player.
		''' </summary>
		Public Property UndershirtColor() As Color
			Get
				Return Me.[Get](Of Color)("UndershirtColor")
			End Get
			Set
				Me.[Set]("UndershirtColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the pants color of this player.
		''' </summary>
		Public Property PantsColor() As Color
			Get
				Return Me.[Get](Of Color)("PantsColor")
			End Get
			Set
				Me.[Set]("PantsColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the shoes color of this player.
		''' </summary>
		Public Property ShoesColor() As Color
			Get
				Return Me.[Get](Of Color)("ShoesColor")
			End Get
			Set
				Me.[Set]("ShoesColor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the armor items of this player.
		''' </summary>
		Public Property Armor() As Item()
			Get
				Return Me.[Get](Of Item())("Armor")
			End Get
			Set
				Me.[Set]("Armor", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the vanity items of this player.
		''' </summary>
		Public Property Vanity() As Item()
			Get
				Return Me.[Get](Of Item())("Vanity")
			End Get
			Set
				Me.[Set]("Vanity", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the accessory items of this player.
		''' </summary>
		Public Property Accessories() As Item()
			Get
				Return Me.[Get](Of Item())("Accessories")
			End Get
			Set
				Me.[Set]("Accessories", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the social accessory items of this player.
		''' </summary>
		Public Property SocialAccessories() As Item()
			Get
				Return Me.[Get](Of Item())("SocialAccessories")
			End Get
			Set
				Me.[Set]("SocialAccessories", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the dye items of this player.
		''' </summary>
		Public Property Dye() As Item()
			Get
				Return Me.[Get](Of Item())("Dye")
			End Get
			Set
				Me.[Set]("Dye", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the inventory items of this player.
		''' </summary>
		Public Property Inventory() As Item()
			Get
				Return Me.[Get](Of Item())("Inventory")
			End Get
			Set
				Me.[Set]("Inventory", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the bank1 items of this player.
		''' </summary>
		Public Property Bank1() As Item()
			Get
				Return Me.[Get](Of Item())("Bank1")
			End Get
			Set
				Me.[Set]("Bank1", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the bank2 items of this player.
		''' </summary>
		Public Property Bank2() As Item()
			Get
				Return Me.[Get](Of Item())("Bank2")
			End Get
			Set
				Me.[Set]("Bank2", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the buffs of this player.
		''' </summary>
		Public Property Buffs() As Buff()
			Get
				Return Me.[Get](Of Buff())("Buffs")
			End Get
			Set
				Me.[Set]("Buffs", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the server entries of this player.
		''' </summary>
		Public Property ServerEntries() As ServerEntry()
			Get
				Return Me.[Get](Of ServerEntry())("ServerEntries")
			End Get
			Set
				Me.[Set]("ServerEntries", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the is hotbar locked flag of this player.
		''' </summary>
		Public Property IsHotbarLocked() As Boolean
			Get
				Return Me.[Get](Of Boolean)("IsHotbarLocked")
			End Get
			Set
				Me.[Set]("IsHotbarLocked", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the angler quests finished status.
		''' </summary>
		Public Property AnglerQuestsFinished() As Integer
			Get
				Return Me.[Get](Of Integer)("AnglerQuestsFinished")
			End Get
			Set
				Me.[Set]("AnglerQuestsFinished", value)
			End Set
		End Property
	End Class
End Namespace
