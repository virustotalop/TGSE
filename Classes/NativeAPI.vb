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
Imports System.Runtime.InteropServices
Namespace Classes

    Friend NotInheritable Class NativeAPI
        Private Sub New()
        End Sub
        ''' <summary>
        ''' gdi32.GetDeviceCaps import.
        ''' </summary>
        ''' <param name="hDC"></param>
        ''' <param name="nIndex"></param>
        ''' <returns></returns>
        Friend Declare Ansi Function GetDeviceCaps Lib "gdi32.dll" (hDC As IntPtr, nIndex As Integer) As Integer
    End Class
End Namespace
