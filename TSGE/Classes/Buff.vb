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

Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Namespace Classes

	<Serializable> _
	Public Class Buff
		Inherits ModelBase
		Implements ICloneable
		''' <summary>
		''' Updates this buff entry to the given buff.
		''' </summary>
		''' <param name="buffId"></param>
		Public Sub SetBuff(buffId As Integer)
			' Obtain the buff info..
			Dim buff = Terraria.Instance.Buffs.SingleOrDefault(Function(b) b.Id = buffId)
			If buff Is Nothing Then
				Return
			End If

			' Set this buff info..
			Me.Duration = buff.Duration
			Me.Icon = New Uri(String.Format("{0}\Data\Buffs\buff_{1}.png", AppDomain.CurrentDomain.BaseDirectory, buff.Id), UriKind.Absolute)
			Me.Id = buff.Id
			Me.Name = buff.Name
			Me.Tooltip = buff.Tooltip
		End Sub

		''' <summary>
		''' Gets or sets the id property.
		''' </summary>
		<XmlAttribute("index")> _
		Public Property Id() As Integer
			Get
				Return Me.[Get](Of Integer)("Id")
			End Get
			Set
				Me.[Set]("Id", value)
				Me.Icon = New Uri(String.Format("{0}\Data\Buffs\buff_{1}.png", AppDomain.CurrentDomain.BaseDirectory, value), UriKind.Absolute)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the name property.
		''' </summary>
		<XmlAttribute("name")> _
		Public Property Name() As String
			Get
				Return Me.[Get](Of String)("Name")
			End Get
			Set
				Me.[Set]("Name", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the tooltip property.
		''' </summary>
		<XmlAttribute("tooltip")> _
		Public Property Tooltip() As String
			Get
				Return Me.[Get](Of String)("Tooltip")
			End Get
			Set
				Me.[Set]("Tooltip", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the duration property.
		''' </summary>
		<XmlAttribute("duration")> _
		Public Property Duration() As Integer
			Get
				Return Me.[Get](Of Integer)("Duration")
			End Get
			Set
				Me.[Set]("Duration", value)
				Me.DurationString = "Refreshing.."
			End Set
		End Property

		''' <summary>
		''' Gets or sets the icon property.
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
		''' Gets or sets the duration string property.
		''' </summary>
		<XmlIgnore> _
		Public Property DurationString() As String
			Get
				Me.[Set]("DurationString", String.Format("{0} second(s)", Me.Duration \ 60))
				Return Me.[Get](Of String)("DurationString")
			End Get
			Set
				If value Is Nothing Then
					Throw New ArgumentNullException("value")
				End If
				Me.[Set]("DurationString", String.Format("{0} second(s)", Me.Duration \ 60))
			End Set
		End Property

		''' <summary>
		''' Tostring override to return this buffs name.
		''' </summary>
		''' <returns></returns>
		Public Overrides Function ToString() As String
			Return Me.Name
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
