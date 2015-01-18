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

Imports Microsoft.Xna.Framework
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Namespace Classes

    <Serializable> _
    Public Class Item
        Inherits ModelBase
        Implements ICloneable
        ''' <summary>
        ''' Updates this item entry to the given item.
        ''' </summary>
        ''' <param name="itemId"></param>
        Public Sub SetItem(itemId As Integer)
            ' Obtain item..
            Dim item = TryCast(Terraria.Instance.Items.[Single](Function(i) i.NetID = itemId).Clone(), Item)
            If item Is Nothing Then
                Return
            End If

            ' Set this item info..
            Me.Mech = item.Mech
            Me.Wet = item.Wet
            Me.WetCount = item.WetCount
            Me.LavaWet = item.LavaWet
            Me.Width = item.Width
            Me.Height = item.Height
            Me.Active = item.Active
            Me.NoGrabDelay = item.NoGrabDelay
            Me.BeingGrabbed = item.BeingGrabbed
            Me.SpawnTime = item.SpawnTime
            Me.WornArmor = item.WornArmor
            Me.OwnIgnore = item.OwnIgnore
            Me.OwnTime = item.OwnTime
            Me.KeepTime = item.KeepTime
            Me.Type = item.Type
            Me.Name = item.Name
            Me.HoldStyle = item.HoldStyle
            Me.UseStyle = item.UseStyle
            Me.Channel = item.Channel
            Me.Accessory = item.Accessory
            Me.UseAnimation = item.UseAnimation
            Me.UseTime = item.UseTime
            Me.Stack = item.Stack
            Me.MaxStack = item.MaxStack
            Me.Pick = item.Pick
            Me.Axe = item.Axe
            Me.Hammer = item.Hammer
            Me.TileBoost = item.TileBoost
            Me.CreateTile = item.CreateTile
            Me.CreateWall = item.CreateWall
            Me.PlaceStyle = item.PlaceStyle
            Me.Damage = item.Damage
            Me.KnockBack = item.KnockBack
            Me.HealLife = item.HealLife
            Me.HealMana = item.HealMana
            Me.Potion = item.Potion
            Me.Consumable = item.Consumable
            Me.AutoReuse = item.AutoReuse
            Me.UseTurn = item.UseTurn
            Me.Color = item.Color
            Me.Alpha = item.Alpha
            Me.Scale = item.Scale
            Me.UseSound = item.UseSound
            Me.Defense = item.Defense
            Me.HeadSlot = item.HeadSlot
            Me.BodySlot = item.BodySlot
            Me.LegSlot = item.LegSlot
            Me.ToolTip = item.ToolTip
            Me.ToolTip2 = item.ToolTip2
            Me.Owner = item.Owner
            Me.Rare = item.Rare
            Me.Shoot = item.Shoot
            Me.ShootSpeed = item.ShootSpeed
            Me.Ammo = item.Ammo
            Me.UseAmmo = item.UseAmmo
            Me.LifeRegen = item.LifeRegen
            Me.ManaIncrease = item.ManaIncrease
            Me.BuyOnce = item.BuyOnce
            Me.Mana = item.Mana
            Me.NoUseGraphic = item.NoUseGraphic
            Me.NoMelee = item.NoMelee
            Me.Release = item.Release
            Me.Value = item.Value
            Me.Buy = item.Buy
            Me.Social = item.Social
            Me.Vanity = item.Vanity
            Me.Material = item.Material
            Me.NoWet = item.NoWet
            Me.BuffType = item.BuffType
            Me.BuffTime = item.BuffTime
            Me.NetID = item.NetID
            Me.Crit = item.Crit
            Me.Prefix = item.Prefix
            Me.Melee = item.Melee
            Me.Magic = item.Magic
            Me.Ranged = item.Ranged
            Me.ReuseDelay = item.ReuseDelay
            'this.Id = item.Id;
            'this.Icon = item.Icon;
            'this.Count = item.Count;
            Me.TileWand = item.TileWand
            Me.Flame = item.Flame
            Me.HoneyWet = item.HoneyWet
            Me.Position = item.Position
            Me.Velocity = item.Velocity
            Me.Dye = item.Dye
            Me.Paint = item.Paint
            Me.NotAmmo = item.NotAmmo
            Me.Summon = item.Summon
        End Sub

        ''' <summary>
        ''' Gets or sets the mech of this item.
        ''' </summary>
        <XmlElement("mech")> _
        Public Property Mech() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Mech")
            End Get
            Set
                Me.[Set]("Mech", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the wet of this item.
        ''' </summary>
        <XmlElement("wet")> _
        Public Property Wet() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Wet")
            End Get
            Set
                Me.[Set]("Wet", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the wet count of this item.
        ''' </summary>
        <XmlElement("wetCount")> _
        Public Property WetCount() As Byte
            Get
                Return Me.[Get](Of Byte)("WetCount")
            End Get
            Set
                Me.[Set]("WetCount", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the lava wet of this item.
        ''' </summary>
        <XmlElement("lavaWet")> _
        Public Property LavaWet() As Boolean
            Get
                Return Me.[Get](Of Boolean)("LavaWet")
            End Get
            Set
                Me.[Set]("LavaWet", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the width of this item.
        ''' </summary>
        <XmlElement("width")> _
        Public Property Width() As Integer
            Get
                Return Me.[Get](Of Integer)("Width")
            End Get
            Set
                Me.[Set]("Width", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the height of this item.
        ''' </summary>
        <XmlElement("height")> _
        Public Property Height() As Integer
            Get
                Return Me.[Get](Of Integer)("Height")
            End Get
            Set
                Me.[Set]("Height", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the active state of this item.
        ''' </summary>
        <XmlElement("active")> _
        Public Property Active() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Active")
            End Get
            Set
                Me.[Set]("Active", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the no grab delay of this item.
        ''' </summary>
        <XmlElement("noGrabDelay")> _
        Public Property NoGrabDelay() As Integer
            Get
                Return Me.[Get](Of Integer)("NoGrabDelay")
            End Get
            Set
                Me.[Set]("NoGrabDelay", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the being grabbed state of this item.
        ''' </summary>
        <XmlElement("beingGrabbed")> _
        Public Property BeingGrabbed() As Boolean
            Get
                Return Me.[Get](Of Boolean)("BeingGrabbed")
            End Get
            Set
                Me.[Set]("BeingGrabbed", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the spawn time of this item.
        ''' </summary>
        <XmlElement("spawnTime")> _
        Public Property SpawnTime() As Integer
            Get
                Return Me.[Get](Of Integer)("SpawnTime")
            End Get
            Set
                Me.[Set]("SpawnTime", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the worm armor flag of this item.
        ''' </summary>
        <XmlElement("wornArmor")> _
        Public Property WornArmor() As Boolean
            Get
                Return Me.[Get](Of Boolean)("WornArmor")
            End Get
            Set
                Me.[Set]("WornArmor", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the own ignore of this item.
        ''' </summary>
        <XmlElement("ownIgnore")> _
        Public Property OwnIgnore() As Integer
            Get
                Return Me.[Get](Of Integer)("OwnIgnore")
            End Get
            Set
                Me.[Set]("OwnIgnore", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the own time of this item.
        ''' </summary>
        <XmlElement("ownTime")> _
        Public Property OwnTime() As Integer
            Get
                Return Me.[Get](Of Integer)("OwnTime")
            End Get
            Set
                Me.[Set]("OwnTime", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the keep time of this item.
        ''' </summary>
        <XmlElement("keepTime")> _
        Public Property KeepTime() As Integer
            Get
                Return Me.[Get](Of Integer)("KeepTime")
            End Get
            Set
                Me.[Set]("KeepTime", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the type of this item.
        ''' </summary>
        <XmlElement("type")> _
        Public Property Type() As Integer
            Get
                Return Me.[Get](Of Integer)("Type")
            End Get
            Set
                Me.Id = value
                Me.[Set]("Type", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the name of this item.
        ''' </summary>
        <XmlElement("name")> _
        Public Property Name() As String
            Get
                Return Me.[Get](Of String)("Name")
            End Get
            Set
                Me.[Set]("Name", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the hold style of this item.
        ''' </summary>
        <XmlElement("holdStyle")> _
        Public Property HoldStyle() As Integer
            Get
                Return Me.[Get](Of Integer)("HoldStyle")
            End Get
            Set
                Me.[Set]("HoldStyle", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use style of this item.
        ''' </summary>
        <XmlElement("useStyle")> _
        Public Property UseStyle() As Integer
            Get
                Return Me.[Get](Of Integer)("UseStyle")
            End Get
            Set
                Me.[Set]("UseStyle", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the channel of this item.
        ''' </summary>
        <XmlElement("channel")> _
        Public Property Channel() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Channel")
            End Get
            Set
                Me.[Set]("Channel", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the accessory flag of this item.
        ''' </summary>
        <XmlElement("accessory")> _
        Public Property Accessory() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Accessory")
            End Get
            Set
                Me.[Set]("Accessory", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use animation of this item.
        ''' </summary>
        <XmlElement("useAnimation")> _
        Public Property UseAnimation() As Integer
            Get
                Return Me.[Get](Of Integer)("UseAnimation")
            End Get
            Set
                Me.[Set]("UseAnimation", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use time of this item.
        ''' </summary>
        <XmlElement("useTime")> _
        Public Property UseTime() As Integer
            Get
                Return Me.[Get](Of Integer)("UseTime")
            End Get
            Set
                Me.[Set]("UseTime", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the stack of this item.
        ''' </summary>
        <XmlElement("stack")> _
        Public Property Stack() As Integer
            Get
                Return Me.[Get](Of Integer)("Stack")
            End Get
            Set
                Me.[Set]("Stack", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the max stack of this item.
        ''' </summary>
        <XmlElement("maxStack")> _
        Public Property MaxStack() As Integer
            Get
                Return Me.[Get](Of Integer)("MaxStack")
            End Get
            Set
                Me.[Set]("MaxStack", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the pick of this item.
        ''' </summary>
        <XmlElement("pick")> _
        Public Property Pick() As Integer
            Get
                Return Me.[Get](Of Integer)("Pick")
            End Get
            Set
                Me.[Set]("Pick", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the axe of this item.
        ''' </summary>
        <XmlElement("axe")> _
        Public Property Axe() As Integer
            Get
                Return Me.[Get](Of Integer)("Axe")
            End Get
            Set
                Me.[Set]("Axe", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the hammer of this item.
        ''' </summary>
        <XmlElement("hammer")> _
        Public Property Hammer() As Integer
            Get
                Return Me.[Get](Of Integer)("Hammer")
            End Get
            Set
                Me.[Set]("Hammer", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the tile boost of this item.
        ''' </summary>
        <XmlElement("tileBoost")> _
        Public Property TileBoost() As Integer
            Get
                Return Me.[Get](Of Integer)("TileBoost")
            End Get
            Set
                Me.[Set]("TileBoost", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the create tile of this item.
        ''' </summary>
        <XmlElement("createTile")> _
        Public Property CreateTile() As Integer
            Get
                Return Me.[Get](Of Integer)("CreateTile")
            End Get
            Set
                Me.[Set]("CreateTile", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the create wall of this item.
        ''' </summary>
        <XmlElement("createWall")> _
        Public Property CreateWall() As Integer
            Get
                Return Me.[Get](Of Integer)("CreateWall")
            End Get
            Set
                Me.[Set]("CreateWall", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the place style of this item.
        ''' </summary>
        <XmlElement("placeStyle")> _
        Public Property PlaceStyle() As Integer
            Get
                Return Me.[Get](Of Integer)("PlaceStyle")
            End Get
            Set
                Me.[Set]("PlaceStyle", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the damage of this item.
        ''' </summary>
        <XmlElement("damage")> _
        Public Property Damage() As Integer
            Get
                Return Me.[Get](Of Integer)("Damage")
            End Get
            Set
                Me.[Set]("Damage", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the knock back of this item.
        ''' </summary>
        <XmlElement("knockBack")> _
        Public Property KnockBack() As Single
            Get
                Return Me.[Get](Of Single)("KnockBack")
            End Get
            Set
                Me.[Set]("KnockBack", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the heal life of this item.
        ''' </summary>
        <XmlElement("healLife")> _
        Public Property HealLife() As Integer
            Get
                Return Me.[Get](Of Integer)("HealLife")
            End Get
            Set
                Me.[Set]("HealLife", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the heal mana of this item.
        ''' </summary>
        <XmlElement("healMana")> _
        Public Property HealMana() As Integer
            Get
                Return Me.[Get](Of Integer)("HealMana")
            End Get
            Set
                Me.[Set]("HealMana", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the potion flag of this item.
        ''' </summary>
        <XmlElement("potion")> _
        Public Property Potion() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Potion")
            End Get
            Set
                Me.[Set]("Potion", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the consumable flag of this item.
        ''' </summary>
        <XmlElement("consumable")> _
        Public Property Consumable() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Consumable")
            End Get
            Set
                Me.[Set]("Consumable", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the auto reuse flag of this item.
        ''' </summary>
        <XmlElement("autoReuse")> _
        Public Property AutoReuse() As Boolean
            Get
                Return Me.[Get](Of Boolean)("AutoReuse")
            End Get
            Set
                Me.[Set]("AutoReuse", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use turn flag of this item.
        ''' </summary>
        <XmlElement("useTurn")> _
        Public Property UseTurn() As Boolean
            Get
                Return Me.[Get](Of Boolean)("UseTurn")
            End Get
            Set
                Me.[Set]("UseTurn", value)
            End Set
        End Property
        <XmlElement("color")> _
        Public Property Color() As System.Drawing.Color
            Get
                Return Me.[Get](Of System.Drawing.Color)("Color")
            End Get
            Set
                Me.[Set]("Color", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the alpha of this item.
        ''' </summary>
        <XmlElement("alpha")> _
        Public Property Alpha() As Integer
            Get
                Return Me.[Get](Of Integer)("Alpha")
            End Get
            Set
                Me.[Set]("Alpha", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the scale of this item.
        ''' </summary>
        <XmlElement("scale")> _
        Public Property Scale() As Single
            Get
                Return Me.[Get](Of Single)("Scale")
            End Get
            Set
                Me.[Set]("Scale", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use sound of this item.
        ''' </summary>
        <XmlElement("useSound")> _
        Public Property UseSound() As Integer
            Get
                Return Me.[Get](Of Integer)("UseSound")
            End Get
            Set
                Me.[Set]("UseSound", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the defense of this item.
        ''' </summary>
        <XmlElement("defense")> _
        Public Property Defense() As Integer
            Get
                Return Me.[Get](Of Integer)("Defense")
            End Get
            Set
                Me.[Set]("Defense", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the head slot of this item.
        ''' </summary>
        <XmlElement("headSlot")> _
        Public Property HeadSlot() As Integer
            Get
                Return Me.[Get](Of Integer)("HeadSlot")
            End Get
            Set
                Me.[Set]("HeadSlot", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the body slot of this item.
        ''' </summary>
        <XmlElement("bodySlot")> _
        Public Property BodySlot() As Integer
            Get
                Return Me.[Get](Of Integer)("BodySlot")
            End Get
            Set
                Me.[Set]("BodySlot", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the leg slot of this item.
        ''' </summary>
        <XmlElement("legSlot")> _
        Public Property LegSlot() As Integer
            Get
                Return Me.[Get](Of Integer)("LegSlot")
            End Get
            Set
                Me.[Set]("LegSlot", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the tooltip of this item.
        ''' </summary>
        <XmlElement("toolTip")> _
        Public Property ToolTip() As String
            Get
                Return Me.[Get](Of String)("ToolTip")
            End Get
            Set
                Me.[Set]("ToolTip", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the tooltip2 of this item.
        ''' </summary>
        <XmlElement("toolTip2")> _
        Public Property ToolTip2() As String
            Get
                Return Me.[Get](Of String)("ToolTip2")
            End Get
            Set
                Me.[Set]("ToolTip2", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the owner of this item.
        ''' </summary>
        <XmlElement("owner")> _
        Public Property Owner() As Integer
            Get
                Return Me.[Get](Of Integer)("Owner")
            End Get
            Set
                Me.[Set]("Owner", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the rare of this item.
        ''' </summary>
        <XmlElement("rare")> _
        Public Property Rare() As Integer
            Get
                Return Me.[Get](Of Integer)("Rare")
            End Get
            Set
                Me.[Set]("Rare", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the shoot of this item.
        ''' </summary>
        <XmlElement("shoot")> _
        Public Property Shoot() As Integer
            Get
                Return Me.[Get](Of Integer)("Shoot")
            End Get
            Set
                Me.[Set]("Shoot", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the shoot speed of this item.
        ''' </summary>
        <XmlElement("shootSpeed")> _
        Public Property ShootSpeed() As Single
            Get
                Return Me.[Get](Of Single)("ShootSpeed")
            End Get
            Set
                Me.[Set]("ShootSpeed", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the ammo of this item.
        ''' </summary>
        <XmlElement("ammo")> _
        Public Property Ammo() As Integer
            Get
                Return Me.[Get](Of Integer)("Ammo")
            End Get
            Set
                Me.[Set]("Ammo", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the use ammo of this item.
        ''' </summary>
        <XmlElement("useAmmo")> _
        Public Property UseAmmo() As Integer
            Get
                Return Me.[Get](Of Integer)("UseAmmo")
            End Get
            Set
                Me.[Set]("UseAmmo", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the life regen of this item.
        ''' </summary>
        <XmlElement("lifeRegen")> _
        Public Property LifeRegen() As Integer
            Get
                Return Me.[Get](Of Integer)("LifeRegen")
            End Get
            Set
                Me.[Set]("LifeRegen", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the mana increase of this item.
        ''' </summary>
        <XmlElement("manaIncrease")> _
        Public Property ManaIncrease() As Integer
            Get
                Return Me.[Get](Of Integer)("ManaIncrease")
            End Get
            Set
                Me.[Set]("ManaIncrease", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the buy once flag of this item.
        ''' </summary>
        <XmlElement("buyOnce")> _
        Public Property BuyOnce() As Boolean
            Get
                Return Me.[Get](Of Boolean)("BuyOnce")
            End Get
            Set
                Me.[Set]("BuyOnce", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the mana of this item.
        ''' </summary>
        <XmlElement("mana")> _
        Public Property Mana() As Integer
            Get
                Return Me.[Get](Of Integer)("Mana")
            End Get
            Set
                Me.[Set]("Mana", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the no use graphic flag of this item.
        ''' </summary>
        <XmlElement("noUseGraphic")> _
        Public Property NoUseGraphic() As Boolean
            Get
                Return Me.[Get](Of Boolean)("NoUseGraphic")
            End Get
            Set
                Me.[Set]("NoUseGraphic", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the no melee flag of this item.
        ''' </summary>
        <XmlElement("noMelee")> _
        Public Property NoMelee() As Boolean
            Get
                Return Me.[Get](Of Boolean)("NoMelee")
            End Get
            Set
                Me.[Set]("NoMelee", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the release of this item.
        ''' </summary>
        <XmlElement("release")> _
        Public Property Release() As Integer
            Get
                Return Me.[Get](Of Integer)("Release")
            End Get
            Set
                Me.[Set]("Release", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value of this item.
        ''' </summary>
        <XmlElement("value")> _
        Public Property Value() As Integer
            Get
                Return Me.[Get](Of Integer)("Value")
            End Get
            Set
                Me.[Set]("Value", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the buy of this item.
        ''' </summary>
        <XmlElement("buy")> _
        Public Property Buy() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Buy")
            End Get
            Set
                Me.[Set]("Buy", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the social flag of this item.
        ''' </summary>
        <XmlElement("social")> _
        Public Property Social() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Social")
            End Get
            Set
                Me.[Set]("Social", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the vanity flag of this item.
        ''' </summary>
        <XmlElement("vanity")> _
        Public Property Vanity() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Vanity")
            End Get
            Set
                Me.[Set]("Vanity", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the metarial flag of this item.
        ''' </summary>
        <XmlElement("material")> _
        Public Property Material() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Material")
            End Get
            Set
                Me.[Set]("Material", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the no wet flag of this item.
        ''' </summary>
        <XmlElement("noWet")> _
        Public Property NoWet() As Boolean
            Get
                Return Me.[Get](Of Boolean)("NoWet")
            End Get
            Set
                Me.[Set]("NoWet", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the buff type of this item.
        ''' </summary>
        <XmlElement("buffType")> _
        Public Property BuffType() As Integer
            Get
                Return Me.[Get](Of Integer)("BuffType")
            End Get
            Set
                Me.[Set]("BuffType", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the buff time of this item.
        ''' </summary>
        <XmlElement("buffTime")> _
        Public Property BuffTime() As Integer
            Get
                Return Me.[Get](Of Integer)("BuffTime")
            End Get
            Set
                Me.[Set]("BuffTime", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the net id of this item.
        ''' </summary>
        <XmlElement("netID")> _
        Public Property NetID() As Integer
            Get
                Return Me.[Get](Of Integer)("NetID")
            End Get
            Set
                Me.[Set]("NetID", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the crit of this item.
        ''' </summary>
        <XmlElement("crit")> _
        Public Property Crit() As Integer
            Get
                Return Me.[Get](Of Integer)("Crit")
            End Get
            Set
                Me.[Set]("Crit", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the prefix of this item.
        ''' </summary>
        <XmlElement("prefix")> _
        Public Property Prefix() As Byte
            Get
                Return Me.[Get](Of Byte)("Prefix")
            End Get
            Set
                Me.[Set]("Prefix", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the melee flag of this item.
        ''' </summary>
        <XmlElement("melee")> _
        Public Property Melee() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Melee")
            End Get
            Set
                Me.[Set]("Melee", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the magic flag of this item.
        ''' </summary>
        <XmlElement("magic")> _
        Public Property Magic() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Magic")
            End Get
            Set
                Me.[Set]("Magic", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the ranged flag of this item.
        ''' </summary>
        <XmlElement("ranged")> _
        Public Property Ranged() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Ranged")
            End Get
            Set
                Me.[Set]("Ranged", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the reuse delay of this item.
        ''' </summary>
        <XmlElement("reuseDelay")> _
        Public Property ReuseDelay() As Integer
            Get
                Return Me.[Get](Of Integer)("ReuseDelay")
            End Get
            Set
                Me.[Set]("ReuseDelay", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the id of this item.
        ''' </summary>
        <XmlIgnore> _
        Public Property Id() As Integer
            Get
                Return Me.[Get](Of Integer)("Id")
            End Get
            Set
                Me.Icon = New Uri(String.Format("{0}\Data\Items\item_{1}.png", AppDomain.CurrentDomain.BaseDirectory, value), UriKind.Absolute)
                Me.[Set]("Id", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the icon of this item.
        ''' </summary>
        <XmlIgnore> _
        Public Property Icon() As Uri
            Get
                Return Me.[Get](Of Uri)("Icon")
            End Get
            Set
                Me.[Set]("Icon", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the count of this item.
        ''' </summary>
        <XmlIgnore> _
        Public Property Count() As Integer
            Get
                Return Me.[Get](Of Integer)("Count")
            End Get
            Set
                Me.[Set]("Count", value)
            End Set
        End Property

        '
        ' New Properties in 1.2
        '

        ''' <summary>
        ''' Gets or sets the tile wand of this item.
        ''' </summary>
        <XmlElement("tileWand")> _
        Public Property TileWand() As Integer
            Get
                Return Me.[Get](Of Integer)("TileWand")
            End Get
            Set
                Me.[Set]("TileWand", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the flame of this item.
        ''' </summary>
        <XmlElement("flame")> _
        Public Property Flame() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Flame")
            End Get
            Set
                Me.[Set]("Flame", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the honey wet of this item.
        ''' </summary>
        <XmlElement("honeyWet")> _
        Public Property HoneyWet() As Boolean
            Get
                Return Me.[Get](Of Boolean)("HoneyWet")
            End Get
            Set
                Me.[Set]("HoneyWet", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the position of this item.
        ''' </summary>
        <XmlElement("position")> _
        Public Property Position() As Vector2
            Get
                Return Me.[Get](Of Vector2)("Position")
            End Get
            Set
                Me.[Set]("Position", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the velocity of this item.
        ''' </summary>
        <XmlElement("velocity")> _
        Public Property Velocity() As Vector2
            Get
                Return Me.[Get](Of Vector2)("Velocity")
            End Get
            Set
                Me.[Set]("Velocity", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the dye of this item.
        ''' </summary>
        <XmlElement("dye")> _
        Public Property Dye() As Byte
            Get
                Return Me.[Get](Of Byte)("Dye")
            End Get
            Set
                Me.[Set]("Dye", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the paint of this item.
        ''' </summary>
        <XmlElement("paint")> _
        Public Property Paint() As Byte
            Get
                Return Me.[Get](Of Byte)("Paint")
            End Get
            Set
                Me.[Set]("Paint", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the not ammo of this item.
        ''' </summary>
        <XmlElement("notAmmo")> _
        Public Property NotAmmo() As Boolean
            Get
                Return Me.[Get](Of Boolean)("NotAmmo")
            End Get
            Set
                Me.[Set]("NotAmmo", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the summon of this item.
        ''' </summary>
        <XmlElement("summon")> _
        Public Property Summon() As Boolean
            Get
                Return Me.[Get](Of Boolean)("Summon")
            End Get
            Set
                Me.[Set]("Summon", value)
            End Set
        End Property

        ''' <summary>
        ''' ToString override to return the name of the item with its prefix.
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function ToString() As String
            Dim toolTip = String.Empty
            ' string.Format("[{0:D04}]", this.NetID);
            Dim prefix = Terraria.Instance.Prefixes.SingleOrDefault(Function(p) p.Id = Me.Prefix)
            If prefix IsNot Nothing AndAlso prefix.Id > 0 Then
                toolTip += prefix.Prefix & " "
            End If
            toolTip += Me.Name

            Return toolTip
        End Function

        ''' <summary>
        ''' ICloneable implementation.
        ''' </summary>
        ''' <returns></returns>
        Public Function Clone() As Object Implements ICloneable.Clone
            Try
                Using mStream = New MemoryStream()
                    Dim formatter = New BinaryFormatter()
                    formatter.Serialize(mStream, Me)
                    mStream.Position = 0
                    Return formatter.Deserialize(mStream)
                End Using
            Catch
                Return Me.MemberwiseClone()
            End Try
        End Function
    End Class
End Namespace
