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
Imports System.IO
Imports System.Windows.Forms
Namespace Controls

	Public Partial Class ModelViewer
		Inherits UserControl
		''' <summary>
		''' Internal copy of the hair id.
		''' </summary>
		Private m_HairId As Integer

		''' <summary>
		''' Internal copy of the hair color.
		''' </summary>
		Private m_HairColor As Color

		''' <summary>
		''' Internal copy of the head color.
		''' </summary>
		Private m_HeadColor As Color

		''' <summary>
		''' Internal copy of the eye color.
		''' </summary>
		Private m_EyeColor As Color

		''' <summary>
		''' Internal copy of the eye whites color.
		''' </summary>
		Private m_EyeWhitesColor As Color

		''' <summary>
		''' Internal copy of the hands color.
		''' </summary>
		Private m_HandsColor As Color

		''' <summary>
		''' Internal copy of the shirt color.
		''' </summary>
		Private m_ShirtColor As Color

		''' <summary>
		''' Internal copy of the undershirt color.
		''' </summary>
		Private m_UndershirtColor As Color

		''' <summary>
		''' Internal copy of the pants color.
		''' </summary>
		Private m_PantsColor As Color

		''' <summary>
		''' Internal copy of the shoes color.
		''' </summary>
		Private m_ShoesColor As Color

		''' <summary>
		''' Internal copy of the eye texture.
		''' </summary>
		Private m_EyeTexture As Bitmap

		''' <summary>
		''' Internal copy of the eye whites texture.
		''' </summary>
		Private m_EyeWhitesTexture As Bitmap

		''' <summary>
		''' Internal copy of the hair texture.
		''' </summary>
		Private m_HairTexture As Bitmap

		''' <summary>
		''' Internal copy of the hands texture.
		''' </summary>
		Private m_HandsTexture As Bitmap

		''' <summary>
		''' Internal copy of the head texture.
		''' </summary>
		Private m_HeadTexture As Bitmap

		''' <summary>
		''' Internal copy of the pants texture.
		''' </summary>
		Private m_PantsTexture As Bitmap

		''' <summary>
		''' Internal copy of the shirt texture.
		''' </summary>
		Private m_ShirtTexture As Bitmap

		''' <summary>
		''' Internal copy of the shoes texture.
		''' </summary>
		Private m_ShoesTexture As Bitmap

		''' <summary>
		''' Internal copy of the undershirt texture.
		''' </summary>
		Private m_UnderShirtTexture As Bitmap

		''' <summary>
		''' Default Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			' Set class property defaults..
			Me.Suspended = False
			Me.LargestImageWidth = 0
			Me.LargestImageHeight = 0

			' Suspend model updates..
			Me.SuspendModelUpdates()

			' Set default colors..
			Me.EyeWhitesColor = Color.FromArgb(255, 255, 255, 255)
			Me.EyeColor = Color.FromArgb(255, 105, 90, 75)
			Me.HairColor = Color.FromArgb(255, 215, 90, 55)
			Me.HandsColor = Color.FromArgb(255, 255, 125, 75)
			Me.HeadColor = Color.FromArgb(255, 255, 125, 75)
			Me.PantsColor = Color.FromArgb(255, 255, 230, 175)
			Me.ShirtColor = Color.FromArgb(255, 175, 165, 140)
			Me.ShoesColor = Color.FromArgb(255, 160, 106, 60)
			Me.UndershirtColor = Color.FromArgb(255, 160, 180, 215)

			' Set default file paths..
			Me.HairFile = "Data\Hair\hair_0.png"
			Me.EyeFile = "Data\Eyes\eyes.png"
			Me.EyeWhitesFile = "Data\Eyes\eye_whites.png"
			Me.HeadFile = "Data\Heads\head.png"
			Me.HandsFile = "Data\Hands\hands.png"
			Me.ShirtFile = "Data\Shirts\shirt.png"
			Me.UnderShirtFile = "Data\UnderShirts\undershirt.png"
			Me.PantsFile = "Data\Pants\pants.png"
			Me.ShoesFile = "Data\Shoes\shoes.png"

			' Update the model viewer..
			Me.ResumeModelUpdates()
		End Sub

		''' <summary>
		''' Colorizes a bitmap with the given color.
		''' </summary>
		''' <param name="bmpInput"></param>
		''' <param name="c"></param>
		''' <returns></returns>
		Private Function ColorizeBitmap(bmpInput As Bitmap, c As Color) As Bitmap
			If Me.Suspended Then
				Return bmpInput
			End If

			' Adjust the pixel colors..
			For h As var = 0 To bmpInput.Height - 1
				For w As var = 0 To bmpInput.Width - 1
					Dim pixel = bmpInput.GetPixel(w, h)
					If pixel = Color.FromArgb(0, 0, 0, 0) Then
						Continue For
					End If

					If pixel <> Color.FromArgb(255, 249, 249, 249) Then
						bmpInput.SetPixel(w, h, System.Drawing.Color.FromArgb((pixel.R + c.R) \ 2, (pixel.G + c.G) \ 2, (pixel.B + c.B) \ 2))
					Else
						bmpInput.SetPixel(w, h, System.Drawing.Color.White)
					End If
				Next
			Next

			' Draw the new image..
			Dim bmpColored = New Bitmap(bmpInput.Width * 4, bmpInput.Height * 4)
			Using g = Graphics.FromImage(bmpColored)
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
				g.DrawImage(bmpInput, 0, 0, bmpColored.Width, bmpColored.Height)
			End Using

			' Store the largest found texture size..
			If bmpColored.Width > Me.LargestImageWidth Then
				Me.LargestImageWidth = bmpColored.Width
			End If
			If bmpColored.Height > Me.LargestImageHeight Then
				Me.LargestImageHeight = bmpColored.Height
			End If

			Return bmpColored
		End Function

		''' <summary>
		''' Updates the model viewer textures and creates the new player preview.
		''' </summary>
		Public Sub UpdateTextures()
			If Me.Suspended Then
				Return
			End If

			' Validation check..
			If Me.ShoesFile Is Nothing Then
				Return
			End If

			Try
				' Update the texture files..
				Me.m_EyeTexture = Me.ColorizeBitmap(New Bitmap(Me.EyeFile), Me.EyeColor)
				Me.m_EyeWhitesTexture = Me.ColorizeBitmap(New Bitmap(Me.EyeWhitesFile), Me.EyeWhitesColor)
				Me.m_HairTexture = Me.ColorizeBitmap(New Bitmap(Me.HairFile), Me.HairColor)
				Me.m_HandsTexture = Me.ColorizeBitmap(New Bitmap(Me.HandsFile), Me.HandsColor)
				Me.m_HeadTexture = Me.ColorizeBitmap(New Bitmap(Me.HeadFile), Me.HeadColor)
				Me.m_PantsTexture = Me.ColorizeBitmap(New Bitmap(Me.PantsFile), Me.PantsColor)
				Me.m_ShirtTexture = Me.ColorizeBitmap(New Bitmap(Me.ShirtFile), Me.ShirtColor)
				Me.m_ShoesTexture = Me.ColorizeBitmap(New Bitmap(Me.ShoesFile), Me.ShoesColor)
				Me.m_UnderShirtTexture = Me.ColorizeBitmap(New Bitmap(Me.UnderShirtFile), Me.UndershirtColor)

				' Draw the new full model based on the largest images dimensions.
				Dim bmpModel = New Bitmap(Me.LargestImageWidth, Me.LargestImageHeight)
				Using g = Graphics.FromImage(bmpModel)
					g.DrawImage(Me.m_PantsTexture, 0, 0)
					g.DrawImage(Me.m_ShoesTexture, 0, 0)
					g.DrawImage(Me.m_ShirtTexture, 0, 0)
					g.DrawImage(Me.m_UnderShirtTexture, 0, 0)
					g.DrawImage(Me.m_HandsTexture, 0, 0)
					g.DrawImage(Me.m_HeadTexture, 0, 0)
					g.DrawImage(Me.m_HairTexture, 0, 0)
					g.DrawImage(Me.m_EyeWhitesTexture, 0, 0)
					g.DrawImage(Me.m_EyeTexture, 0, 0)
				End Using

				' Save the new bitmap to a memory stream..
				Dim ms = New MemoryStream()
				bmpModel.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
				Me.pbModelViewer.Image = New Bitmap(ms)

				' Collect garbage..
				GC.Collect()
			Catch
			End Try
		End Sub

		''' <summary>
		''' Suspends model updates from happening until resumed.
		''' </summary>
		Public Sub SuspendModelUpdates()
			Me.Suspended = True
		End Sub

		''' <summary>
		''' Resumes model updates.
		''' </summary>
		Public Sub ResumeModelUpdates()
			Me.Suspended = False
			Me.UpdateTextures()
		End Sub

		''' <summary>
		''' Gets or sets if the model viewer is paused from updating.
		''' </summary>
		Public Property Suspended() As Boolean
			Get
				Return m_Suspended
			End Get
			Set
				m_Suspended = Value
			End Set
		End Property
		Private m_Suspended As Boolean

		''' <summary>
		''' Gets or sets the largest image width.
		''' </summary>
		Public Property LargestImageWidth() As Integer
			Get
				Return m_LargestImageWidth
			End Get
			Set
				m_LargestImageWidth = Value
			End Set
		End Property
		Private m_LargestImageWidth As Integer

		''' <summary>
		''' Gets or sets the largest image height.
		''' </summary>
		Public Property LargestImageHeight() As Integer
			Get
				Return m_LargestImageHeight
			End Get
			Set
				m_LargestImageHeight = Value
			End Set
		End Property
		Private m_LargestImageHeight As Integer

		''' <summary>
		''' Gets or sets the hair id property.
		''' </summary>
		Public Property HairId() As Integer
			Get
				Return Me.m_HairId
			End Get
			Set
				Me.m_HairId = value
				Me.HairFile = String.Format("Data\Hair\hair_{0}.png", value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hair color property.
		''' </summary>
		Public Property HairColor() As Color
			Get
				Return m_HairColor
			End Get
			Set
				Me.m_HairColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the head color property.
		''' </summary>
		Public Property HeadColor() As Color
			Get
				Return m_HeadColor
			End Get
			Set
				Me.m_HeadColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the eye color property.
		''' </summary>
		Public Property EyeColor() As Color
			Get
				Return m_EyeColor
			End Get
			Set
				Me.m_EyeColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the eye whites color property.
		''' </summary>
		Public Property EyeWhitesColor() As Color
			Get
				Return m_EyeWhitesColor
			End Get
			Set
				Me.m_EyeWhitesColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hands color property.
		''' </summary>
		Public Property HandsColor() As Color
			Get
				Return m_HandsColor
			End Get
			Set
				Me.m_HandsColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the shirt color property.
		''' </summary>
		Public Property ShirtColor() As Color
			Get
				Return m_ShirtColor
			End Get
			Set
				Me.m_ShirtColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the under shirt color property.
		''' </summary>
		Public Property UndershirtColor() As Color
			Get
				Return m_UndershirtColor
			End Get
			Set
				Me.m_UndershirtColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the pants color property.
		''' </summary>
		Public Property PantsColor() As Color
			Get
				Return m_PantsColor
			End Get
			Set
				Me.m_PantsColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the shoes color property.
		''' </summary>
		Public Property ShoesColor() As Color
			Get
				Return m_ShoesColor
			End Get
			Set
				Me.m_ShoesColor = value
				Me.UpdateTextures()
			End Set
		End Property

		''' <summary>
		''' Gets or sets the hair file property.
		''' </summary>
		Public Property HairFile() As String
			Get
				Return m_HairFile
			End Get
			Set
				m_HairFile = Value
			End Set
		End Property
		Private m_HairFile As String

		''' <summary>
		''' Gets or sets the head file property.
		''' </summary>
		Public Property HeadFile() As String
			Get
				Return m_HeadFile
			End Get
			Set
				m_HeadFile = Value
			End Set
		End Property
		Private m_HeadFile As String

		''' <summary>
		''' Gets or sets the eye file property.
		''' </summary>
		Public Property EyeFile() As String
			Get
				Return m_EyeFile
			End Get
			Set
				m_EyeFile = Value
			End Set
		End Property
		Private m_EyeFile As String

		''' <summary>
		''' Gets or sets the eye whites file property.
		''' </summary>
		Public Property EyeWhitesFile() As String
			Get
				Return m_EyeWhitesFile
			End Get
			Set
				m_EyeWhitesFile = Value
			End Set
		End Property
		Private m_EyeWhitesFile As String

		''' <summary>
		''' Gets or sets the hands file property.
		''' </summary>
		Public Property HandsFile() As String
			Get
				Return m_HandsFile
			End Get
			Set
				m_HandsFile = Value
			End Set
		End Property
		Private m_HandsFile As String

		''' <summary>
		''' Gets or sets the shirt file property.
		''' </summary>
		Public Property ShirtFile() As String
			Get
				Return m_ShirtFile
			End Get
			Set
				m_ShirtFile = Value
			End Set
		End Property
		Private m_ShirtFile As String

		''' <summary>
		''' Gets or sets the under shirt file property.
		''' </summary>
		Public Property UnderShirtFile() As String
			Get
				Return m_UnderShirtFile
			End Get
			Set
				m_UnderShirtFile = Value
			End Set
		End Property
		Private m_UnderShirtFile As String

		''' <summary>
		''' Gets or sets the pants file property.
		''' </summary>
		Public Property PantsFile() As String
			Get
				Return m_PantsFile
			End Get
			Set
				m_PantsFile = Value
			End Set
		End Property
		Private m_PantsFile As String

		''' <summary>
		''' Gets or sets the shoes file property.
		''' </summary>
		Public Property ShoesFile() As String
			Get
				Return m_ShoesFile
			End Get
			Set
				m_ShoesFile = Value
			End Set
		End Property
		Private m_ShoesFile As String
	End Class
End Namespace
