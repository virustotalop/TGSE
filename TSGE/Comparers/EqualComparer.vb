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

' -----------------------------------------------------------------------
'    Natural Sorting Implementation 
'
'    (c) 2008 Greg Beech
'    http://stackoverflow.com/questions/248603/natural-sort-order-in-c-sharp/248613#248613
' -----------------------------------------------------------------------

Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security
Namespace Comparers

	<SuppressUnmanagedCodeSecurity> _
	Friend NotInheritable Class SafeNativeMethods
		Private Sub New()
		End Sub
		''' <summary>
		''' shlwapi.StrCmpLogicalW Function Import Definition
		''' </summary>
		''' <param name="psz1"></param>
		''' <param name="psz2"></param>
		''' <returns></returns>
		<DllImport("shlwapi.dll", CharSet := CharSet.Unicode)> _
		Public Shared Function StrCmpLogicalW(psz1 As String, psz2 As String) As Integer
		End Function
	End Class

	Public NotInheritable Class NaturalStringComparer
		Implements IComparer(Of String)
		''' <summary>
		''' Compares two strings logically to each other.
		''' </summary>
		''' <param name="a"></param>
		''' <param name="b"></param>
		''' <returns></returns>
		Public Function Compare(a As String, b As String) As Integer
			Return SafeNativeMethods.StrCmpLogicalW(a, b)
		End Function
	End Class

	Public NotInheritable Class NaturalFileInfoNameComparer
		Implements IComparer(Of FileInfo)
		''' <summary>
		''' Compares two file names logically to each other.
		''' </summary>
		''' <param name="a"></param>
		''' <param name="b"></param>
		''' <returns></returns>
		Public Function Compare(a As FileInfo, b As FileInfo) As Integer
			Return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name)
		End Function
	End Class

	Public NotInheritable Class NaturalBuffNameComparer
		Implements IComparer(Of TSGE.Classes.Buff)
		''' <summary>
		''' Compares two Buff classes logically to each other by name.
		''' </summary>
		''' <param name="a"></param>
		''' <param name="b"></param>
		''' <returns></returns>
		Public Function Compare(a As TSGE.Classes.Buff, b As TSGE.Classes.Buff) As Integer
			Return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name)
		End Function
	End Class

	Public NotInheritable Class NaturalItemNameComparer
		Implements IComparer(Of TSGE.Classes.Item)
		''' <summary>
		''' Compares two Item classes logically to each other by name.
		''' </summary>
		''' <param name="a"></param>
		''' <param name="b"></param>
		''' <returns></returns>
		Public Function Compare(a As TSGE.Classes.Item, b As TSGE.Classes.Item) As Integer
			Return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name)
		End Function
	End Class

	Public NotInheritable Class NaturalItemPrefixNameComparer
		Implements IComparer(Of TSGE.Classes.ItemPrefix)
		''' <summary>
		''' Compares two ItemPrefix classes logically to each other by name.
		''' </summary>
		''' <param name="a"></param>
		''' <param name="b"></param>
		''' <returns></returns>
		Public Function Compare(a As TSGE.Classes.ItemPrefix, b As TSGE.Classes.ItemPrefix) As Integer
			Return SafeNativeMethods.StrCmpLogicalW(a.Prefix, b.Prefix)
		End Function
	End Class
End Namespace
