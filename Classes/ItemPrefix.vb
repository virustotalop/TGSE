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
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Namespace Classes

    Public Class ItemPrefix
        Inherits ModelBase
        Implements ICloneable
        ''' <summary>
        ''' Gets or sets the id property.
        ''' </summary>
        <XmlAttribute("id")> _
        Public Property Id() As Integer
            Get
                Return Me.[Get](Of Integer)("Id")
            End Get
            Set
                Me.[Set]("Id", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the prefix property.
        ''' </summary>
        <XmlAttribute("prefix")> _
        Public Property Prefix() As String
            Get
                Return Me.[Get](Of String)("Prefix")
            End Get
            Set
                Me.[Set]("Prefix", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the category prefix.
        ''' </summary>
        <XmlAttribute("category")> _
        Public Property Category() As Integer
            Get
                Return Me.[Get](Of Integer)("Category")
            End Get
            Set
                Me.[Set]("Category", value)
            End Set
        End Property

        ''' <summary>
        ''' Tostring override to return this item prefixes prefix.
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function ToString() As String
            Return Me.Prefix
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
