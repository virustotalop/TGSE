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

Partial Class frmAbout
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblSourceCode = New System.Windows.Forms.LinkLabel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(312, 32)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Terraria Save Game Editor"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label2.Location = New System.Drawing.Point(30, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Version:"
        ' 
        ' lblVersion
        ' 
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblVersion.Location = New System.Drawing.Point(85, 41)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(37, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "0.0.0.0"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label4.Location = New System.Drawing.Point(30, 54)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(210, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "(c) 2012 - 2014 atom0s [atom0s@live.com]"
        ' 
        ' lblSourceCode
        ' 
        Me.lblSourceCode.AutoSize = True
        Me.lblSourceCode.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblSourceCode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblSourceCode.Location = New System.Drawing.Point(30, 127)
        Me.lblSourceCode.Name = "lblSourceCode"
        Me.lblSourceCode.Size = New System.Drawing.Size(238, 13)
        Me.lblSourceCode.TabIndex = 4
        Me.lblSourceCode.TabStop = True
        Me.lblSourceCode.Text = "TSGE is open source; click here for more info!"
        AddHandler Me.lblSourceCode.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.lblSourceCode_LinkClicked)
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label3.Location = New System.Drawing.Point(12, 95)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(158, 32)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Source Code"
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label5.Location = New System.Drawing.Point(12, 163)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(232, 32)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Credits and Thanks"
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label6.Location = New System.Drawing.Point(30, 195)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(219, 65)
        Me.label6.TabIndex = 7
        Me.label6.Text = "atom0s - Core development." & vbCr & vbLf & "Austin Andrews - Titlebar icons." & vbCr & vbLf & "Terraria - Item tex" & "tures and application icon." & vbCr & vbLf & "Sinzfeldt - For buying me Terraria." & vbCr & vbLf & "attilathedud -" & " Original beta testing."
        ' 
        ' label7
        ' 
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label7.Location = New System.Drawing.Point(12, 278)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(312, 32)
        Me.label7.TabIndex = 8
        Me.label7.Text = "Supported Game Versions"
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label8.Location = New System.Drawing.Point(30, 310)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(126, 78)
        Me.label8.TabIndex = 9
        Me.label8.Text = "Terraria 1.1.2+" & vbCr & vbLf & "Terraria 1.2.0.0" & vbCr & vbLf & "Terraria 1.2.0.1" & vbCr & vbLf & "Terraria 1.2.0.2" & vbCr & vbLf & "Terraria 1" & ".2.0.3 / 1.2.0.3.1" & vbCr & vbLf & "Terraria 1.2.1 / 1.2.1.2"
        ' 
        ' btnDonate
        ' 
        Me.btnDonate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnDonate.Image = Global.TSGE.Properties.Resources.donate
        Me.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDonate.Location = New System.Drawing.Point(362, 82)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(166, 64)
        Me.btnDonate.TabIndex = 11
        Me.btnDonate.Text = "Donate!"
        Me.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDonate.UseVisualStyleBackColor = True
        AddHandler Me.btnDonate.Click, New System.EventHandler(AddressOf Me.btnDonate_Click)
        ' 
        ' btnTwitter
        ' 
        Me.btnTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnTwitter.Image = Global.TSGE.Properties.Resources.Twitter
        Me.btnTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTwitter.Location = New System.Drawing.Point(362, 12)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(166, 64)
        Me.btnTwitter.TabIndex = 10
        Me.btnTwitter.Text = "Follow me on Twitter!"
        Me.btnTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTwitter.UseVisualStyleBackColor = True
        AddHandler Me.btnTwitter.Click, New System.EventHandler(AddressOf Me.btnTwitter_Click)
        ' 
        ' label9
        ' 
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.label9.Location = New System.Drawing.Point(162, 310)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(151, 26)
        Me.label9.TabIndex = 12
        Me.label9.Text = "Terraria 1.2.3 / 1.2.3.1" & vbCr & vbLf & "Terraria 1.2.4 / Terraria 1.2.4.1"
        ' 
        ' frmAbout
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(540, 408)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.btnTwitter)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblSourceCode)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About TSGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    #End Region

    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private lblVersion As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private lblSourceCode As System.Windows.Forms.LinkLabel
    Private label3 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private label8 As System.Windows.Forms.Label
    Private btnTwitter As System.Windows.Forms.Button
    Private btnDonate As System.Windows.Forms.Button
    Private label9 As System.Windows.Forms.Label
End Class
