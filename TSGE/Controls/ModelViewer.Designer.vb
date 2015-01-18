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

Namespace Controls
	Partial Class ModelViewer
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pbModelViewer = New System.Windows.Forms.PictureBox()
			DirectCast(Me.pbModelViewer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pbModelViewer
			' 
			Me.pbModelViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pbModelViewer.Location = New System.Drawing.Point(0, 0)
			Me.pbModelViewer.Name = "pbModelViewer"
			Me.pbModelViewer.Size = New System.Drawing.Size(225, 246)
			Me.pbModelViewer.TabIndex = 0
			Me.pbModelViewer.TabStop = False
			' 
			' ModelViewer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pbModelViewer)
			Me.Name = "ModelViewer"
			Me.Size = New System.Drawing.Size(225, 246)
			DirectCast(Me.pbModelViewer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pbModelViewer As System.Windows.Forms.PictureBox
	End Class
End Namespace
