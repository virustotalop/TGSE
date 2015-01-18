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

Imports System.Windows.Forms

Public Partial Class frmHairSelection
	Inherits Form
	''' <summary>
	''' Internal hair id value.
	''' </summary>
	Private m_HairId As Integer

	''' <summary>
	''' Default Constructor
	''' </summary>
	Public Sub New()
		InitializeComponent()

		Me.m_HairId = 0
		Me.lstHairSelection.SelectedIndex = Me.HairId
	End Sub

	''' <summary>
	''' Selects the hair style.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub lstHairSelection_SelectedIndexChanged(sender As Object, e As EventArgs)
		Me.HairId = Me.lstHairSelection.SelectedIndex
	End Sub

	''' <summary>
	''' Closes this form with a valid result.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSelectHair_Click(sender As Object, e As EventArgs)
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	''' <summary>
	''' Closes this form with a cancelled result.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnCancel_Click(sender As Object, e As EventArgs)
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	''' <summary>
	''' Gets or sets the selected hair index.
	''' </summary>
	Public Property HairId() As Integer

		Get
			Return Me.m_HairId
		End Get
		Set
			Me.m_HairId = value
			Me.lstHairSelection.SelectedIndex = value
		End Set
	End Property
End Class
