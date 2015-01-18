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

Imports Classes
Imports System.Drawing
Imports System.Windows.Forms
Namespace Controls

	Public NotInheritable Partial Class BuffSelectionListBox
		Inherits ListBox
		''' <summary>
		''' Default Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()
		End Sub

		''' <summary>
		''' OnDrawItem override to draw our custom item.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
			' Validation check to prevent designer errors..
			If Me.Items.Count <= 0 Then
				Return
			End If

			' Cast the incoming argument as a buff entry..
			Dim buff = DirectCast(Me.Items(e.Index), Buff)

			' Adjust the background based on selection..
			e.Graphics.FillRectangle(If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Brushes.SkyBlue, Brushes.White), e.Bounds)

			' Draw seperator line..
			e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y)

			' Draw the buff icon..
			Dim bmp = New Bitmap(buff.Icon.LocalPath)
			e.Graphics.DrawImage(bmp, e.Bounds.X + Me.Margin.Left, e.Bounds.Y + Me.Margin.Top, 32, 32)

			' Calculate name string bounds..
			Dim nameBounds = New Rectangle(e.Bounds.X + Me.Margin.Horizontal + 32, e.Bounds.Y + Me.Margin.Top, e.Bounds.Width - Me.Margin.Right - 32 - Me.Margin.Horizontal, CInt(Math.Truncate(Me.Font.GetHeight())) + 2)

			' Draw buff information strings..
			e.Graphics.DrawString(buff.Name, Me.Font, Brushes.Black, nameBounds)

			' Draw the focused item rect..
			e.DrawFocusRectangle()
		End Sub
	End Class
End Namespace
