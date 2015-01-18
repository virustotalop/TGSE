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
Namespace Classes

    Friend NotInheritable Class DpiHelper
        Private Sub New()
        End Sub
        ''' <summary>
        ''' Obtains the current device DPI.
        ''' </summary>
        ''' <returns></returns>
        Friend Shared Function GetCurrentDpi() As Integer
            Using g = Graphics.FromHwnd(IntPtr.Zero)
                Return NativeAPI.GetDeviceCaps(g.GetHdc(), 88)
            End Using
        End Function

        ''' <summary>
        ''' Obtains the current device DPI scale percent.
        ''' </summary>
        ''' <returns></returns>
        Friend Shared Function GetScalePercent() As Integer
            Return GetCurrentDpi() * 100 \ 96
        End Function

        ''' <summary>
        ''' Determines the scaled DPI size of an object.
        ''' </summary>
        ''' <param name="baseSize"></param>
        ''' <returns></returns>
        Friend Shared Function ScaleAsDpi(baseSize As Integer) As Integer
            Return baseSize * GetScalePercent() \ 100
        End Function
    End Class
End Namespace
