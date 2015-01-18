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

Namespace Classes
    Public Class ServerEntry
        Inherits ModelBase
        ''' <summary>
        ''' Default Constructor
        ''' </summary>
        Public Sub New()
            Me.ServerAddress = -1
            Me.ServerName = String.Empty
            Me.SpawnX = -1
            Me.SpawnY = -1
        End Sub

        ''' <summary>
        ''' Gets or sets the server address of this server entry.
        ''' </summary>
        Public Property ServerAddress() As Integer
            Get
                Return Me.[Get](Of Integer)("ServerAddress")
            End Get
            Set
                Me.[Set]("ServerAddress", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the server name of this server entry.
        ''' </summary>
        Public Property ServerName() As String
            Get
                Return Me.[Get](Of String)("ServerName")
            End Get
            Set
                Me.[Set]("ServerName", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the x spawn location of this server entry.
        ''' </summary>
        Public Property SpawnX() As Integer
            Get
                Return Me.[Get](Of Integer)("SpawnX")
            End Get
            Set
                Me.[Set]("SpawnX", value)
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the y spawn location of this server entry.
        ''' </summary>
        Public Property SpawnY() As Integer
            Get
                Return Me.[Get](Of Integer)("SpawnY")
            End Get
            Set
                Me.[Set]("SpawnY", value)
            End Set
        End Property
    End Class
End Namespace
