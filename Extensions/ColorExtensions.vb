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
Namespace Extensions

    Public NotInheritable Class ColorExtensions
        Private Sub New()
        End Sub
        ''' <summary>
        ''' Converts a byte array of three bytes to a System.Drawing.Color.
        ''' </summary>
        ''' <param name="c"></param>
        ''' <param name="btColor"></param>
        ''' <returns></returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Shared Function FromBytes(c As Color, btColor As Byte()) As Color
            If btColor Is Nothing OrElse btColor.Length <> 3 Then
                Throw New ArgumentException("Invalid array size for incoming color.", "btColor")
            End If
            Return Color.FromArgb(255, btColor(0), btColor(1), btColor(2))
        End Function

        ''' <summary>
        ''' Converts a System.Drawing.Color to a three byte array.
        ''' </summary>
        ''' <param name="c"></param>
        ''' <returns></returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Shared Function ToBytes(c As Color) As Byte()
            Return New () {c.R, c.G, c.B}
        End Function
    End Class
End Namespace
