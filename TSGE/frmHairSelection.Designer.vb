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

Partial Class frmHairSelection
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmHairSelection))
        Me.lstHairSelection = New TSGE.Controls.HairListBox()
        Me.btnSelectHair = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' lstHairSelection
        ' 
        Me.lstHairSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstHairSelection.FormattingEnabled = True
        Me.lstHairSelection.ItemHeight = 48
        Me.lstHairSelection.Location = New System.Drawing.Point(12, 12)
        Me.lstHairSelection.Name = "lstHairSelection"
        Me.lstHairSelection.Size = New System.Drawing.Size(293, 333)
        Me.lstHairSelection.TabIndex = 0
        AddHandler Me.lstHairSelection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lstHairSelection_SelectedIndexChanged)
        ' 
        ' btnSelectHair
        ' 
        Me.btnSelectHair.Location = New System.Drawing.Point(149, 351)
        Me.btnSelectHair.Name = "btnSelectHair"
        Me.btnSelectHair.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectHair.TabIndex = 1
        Me.btnSelectHair.Text = "Select Hair"
        Me.btnSelectHair.UseVisualStyleBackColor = True
        AddHandler Me.btnSelectHair.Click, New System.EventHandler(AddressOf Me.btnSelectHair_Click)
        ' 
        ' btnCancel
        ' 
        Me.btnCancel.Location = New System.Drawing.Point(230, 351)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
        ' 
        ' frmHairSelection
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(317, 386)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelectHair)
        Me.Controls.Add(Me.lstHairSelection)
        Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHairSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select a hair style.."
        Me.ResumeLayout(False)

    End Sub

    #End Region

    Private lstHairSelection As Controls.HairListBox
    Private btnSelectHair As System.Windows.Forms.Button
    Private btnCancel As System.Windows.Forms.Button
End Class
