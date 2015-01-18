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

Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Classes

	<Serializable> _
	Public Class ModelBase
		Implements INotifyPropertyChanged
		''' <summary>
		''' Internal properties container.
		''' </summary>
		Private ReadOnly _properties As Dictionary(Of String, Object)

		''' <summary>
		''' Event triggered when a property is changed.
		''' </summary>
		Public Event PropertyChanged As PropertyChangedEventHandler

		''' <summary>
		''' Default Constructor
		''' </summary>
		Public Sub New()
			Me._properties = New Dictionary(Of [String], [Object])()
		End Sub

		''' <summary>
		''' Method used to raise the PropertyChanged event.
		''' </summary>
		''' <param name="prop"></param>
		Public Sub OnPropertyChanged(prop As [String])
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
		End Sub

		''' <summary>
		''' Method to raise the PropertyChanged event.
		''' </summary>
		''' <param name="property"></param>
		Protected Sub RaisePropertyChanged([property] As String)
			If String.IsNullOrEmpty([property]) Then
				Throw New ArgumentNullException([property])
			End If
			Me.OnPropertyChanged([property])
		End Sub

		''' <summary>
		''' Gets a property from the internal container.
		''' </summary>
		''' <typeparam name="T"></typeparam>
		''' <param name="prop"></param>
		''' <returns></returns>
		Protected Function [Get](Of T)(prop As [String]) As T
			If Me._properties.ContainsKey(prop) Then
				Return DirectCast(Me._properties(prop), T)
			End If
			Return Nothing
		End Function

		''' <summary>
		''' Sets a property in the internal container.
		''' </summary>
		''' <typeparam name="T"></typeparam>
		''' <param name="prop"></param>
		''' <param name="val"></param>
		Protected Sub [Set](Of T)(prop As [String], val As T)
			Dim curr = Me.[Get](Of T)(prop)
			If Equals(curr, val) Then
				Return
			End If

			Me._properties(prop) = val
			Me.OnPropertyChanged(prop)
		End Sub
	End Class
End Namespace
