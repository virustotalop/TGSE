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
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Namespace Controls

    Public Partial Class ItemLabel
        Inherits Label
        ''' <summary>
        ''' Default Constructor
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            ' Set item count to show default..
            Me.ShowItemCount = True
        End Sub

        ''' <summary>
        ''' OnPaint override to draw our custom item label.
        ''' </summary>
        ''' <param name="e"></param>
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            ' Adjust the graphics quality..
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality

            ' Draw the item image..
            If Me.Image IsNot Nothing Then
                e.Graphics.DrawImage(Me.Image, (e.ClipRectangle.Width \ 2) - (Me.Image.Width \ 2), (e.ClipRectangle.Height \ 2) - (Me.Image.Height \ 2))
            End If

            ' Don't draw the item count if not needed..
            If Not Me.ShowItemCount Then
                Return
            End If

            ' Draw the text background..
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(75, 0, 0, 0)), 0, e.ClipRectangle.Height - 15, e.ClipRectangle.Width, 15)

            ' Draw the text..
            Dim f = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
            Dim sf = New StringFormat() With { _
                Key .Alignment = StringAlignment.Far, _
                Key .LineAlignment = StringAlignment.Far _
            }
            Dim p = New Pen(Color.FromArgb(255, 0, 0, 0), 2) With { _
                Key .LineJoin = LineJoin.Round _
            }

            Try
                Using gp = New GraphicsPath()
                    gp.AddString(Me.Text, f.FontFamily, CInt(f.Style), 14, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1), sf)
                    e.Graphics.DrawPath(p, gp)
                    e.Graphics.FillPath(Brushes.White, gp)
                End Using
                    ' Swallow designer exception.. 
            Catch
            End Try

            ' Cleanup..
            p.Dispose()
            sf.Dispose()
            f.Dispose()
        End Sub

        ''' <summary>
        ''' Gets or sets if the item count should be drawn.
        ''' </summary>
        Public Property ShowItemCount() As Boolean
            Get
                Return m_ShowItemCount
            End Get
            Set
                m_ShowItemCount = Value
            End Set
        End Property
        Private m_ShowItemCount As Boolean
    End Class
End Namespace
