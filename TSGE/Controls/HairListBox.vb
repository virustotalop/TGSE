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

	Public Partial Class HairListBox
		Inherits ListBox
		''' <summary>
		''' Default Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			' Add each hair file to our item list..
			For Each file As var In Terraria.Instance.HairFiles
				Me.Items.Add(file)
			Next
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

			' Cast the incoming argument as a string..
			Dim filePath = DirectCast(Me.Items(e.Index), String)

			' Adjust the background based on selection..
			e.Graphics.FillRectangle(If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Brushes.SkyBlue, Brushes.White), e.Bounds)

			' Draw seperator line..
			e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y)

			' Draw the hair icon..
			Dim bmp = New Bitmap(String.Format("{0}\Data\Hair\{1}", Application.StartupPath, filePath))
			e.Graphics.DrawImage(bmp, e.Bounds.X + Me.Margin.Left, e.Bounds.Y + Me.Margin.Top, 48, 48)

			' Calculate name string bounds..
			Dim nameBounds = New Rectangle(e.Bounds.X + Me.Margin.Horizontal + 48, e.Bounds.Y + Me.Margin.Top + (e.Bounds.Height \ 2) - CInt(Math.Truncate(Me.Font.GetHeight())), e.Bounds.Width - Me.Margin.Right - 48 - Me.Margin.Horizontal, CInt(Math.Truncate(Me.Font.GetHeight())) + 2)

			Dim styleId = filePath.Replace("hair_", "").Replace(".png", "")

			' Draw style information string..
			e.Graphics.DrawString(String.Format("Hair Style: {0}", styleId), Me.Font, Brushes.Black, nameBounds)

			' Draw the focused item rect..
			e.DrawFocusRectangle()
		End Sub
	End Class
End Namespace
