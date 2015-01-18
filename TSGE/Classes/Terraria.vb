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

Imports Comparers
Imports Extensions
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml.Serialization
Namespace Classes

    Public Class Terraria
        ''' <summary>
        ''' Singleton instance of this class.
        ''' </summary>
        Private Shared m_Instance As Terraria

        ''' <summary>
        ''' Internal buff list.
        ''' </summary>
        Private m_BuffList As List(Of Buff)

        ''' <summary>
        ''' Internal item list.
        ''' </summary>
        Private m_ItemList As List(Of Item)

        ''' <summary>
        ''' Internal item prefix list.
        ''' </summary>
        Private m_PrefixList As List(Of ItemPrefix)

        ''' <summary>
        ''' Current supported game version.
        ''' </summary>
        Public Shared GameVersions As New List(Of Integer)(New () {38, 47, 58, 68, 69, 70, _
            71, 72, 73, 77, 81, 83, _
            93, 94, 101, 102})

        ''' <summary>
        ''' The latest supported version of Terraria.
        ''' </summary>
        Public Shared LatestVersion As Integer = 102

        ''' <summary>
        ''' The latest max item used while handling profiles.
        ''' </summary>
        Public Shared MaxItemCount As Integer = 2749

        ''' <summary>
        ''' Profile path to the Terraria save game files.
        ''' </summary>
        Public Shared ProfilePath As String = String.Join(Path.DirectorySeparatorChar.ToString(), New () {Environment.GetFolderPath(Environment.SpecialFolder.Personal), "My Games", "Terraria", "Players"})

        ''' <summary>
        ''' Encryption key used to encrypt and decrypt player files.
        ''' </summary>
        Private Const ENCRYPTION_KEY As String = "h3y_gUyZ"

        ''' <summary>
        ''' Encryption key converted to byte data for crypto provider.
        ''' </summary>
        Private Shared ReadOnly ENCRYPTION_DATA As Byte() = Encoding.Unicode.GetBytes(ENCRYPTION_KEY)

        ''' <summary>
        ''' Default Constructor
        ''' </summary>
        Public Sub New()
            ' Initialize internl lists..
            Me.m_BuffList = New List(Of Buff)()
            Me.m_ItemList = New List(Of Item)()
            Me.m_PrefixList = New List(Of ItemPrefix)()
            Me.HairFiles = New List(Of String)()
        End Sub

        ''' <summary>
        ''' Gets the singleton instance of this class.
        ''' </summary>
        Public Shared ReadOnly Property Instance() As Terraria
            Get
                Return If(m_Instance, (InlineAssignHelper(m_Instance, New Terraria())))
            End Get
        End Property

        ''' <summary>
        ''' Initializes the Terraria class.
        ''' </summary>
        ''' <returns></returns>
        Public Function Initialize() As Boolean
            ' Load buff list..
            Using fStream = New FileStream("Data\_bufflist.xml", FileMode.Open, FileAccess.Read)
                Dim xls = New XmlSerializer(GetType(Buff()))
                Me.Buffs = DirectCast(xls.Deserialize(fStream), Buff()).ToList()
            End Using

            ' Load item list..
            Using fStream = New FileStream("Data\_itemlist.xml", FileMode.Open, FileAccess.Read)
                Dim xls = New XmlSerializer(GetType(Item()))
                Me.m_ItemList = DirectCast(xls.Deserialize(fStream), Item()).ToList()
            End Using

            ' Load item prefix list..
            Using fStream = New FileStream("Data\_prefixlist.xml", FileMode.Open, FileAccess.Read)
                Dim xls = New XmlSerializer(GetType(ItemPrefix()))
                Me.Prefixes = DirectCast(xls.Deserialize(fStream), ItemPrefix()).ToList()
            End Using

            ' Load the hair style list..
            Dim dir = New DirectoryInfo("Data\Hair")
            Dim files = (From f In dir.GetFiles("*.png") Where f.FullName.Contains("_alt_") = Falsef).ToList().OrderBy(Function(file) file, New NaturalFileInfoNameComparer())

            For Each f As var In files
                Me.HairFiles.Add(f.Name)
            Next


            Return (Me.Buffs IsNot Nothing AndAlso Me.m_ItemList IsNot Nothing AndAlso Me.m_PrefixList IsNot Nothing)
        End Function

        ''' <summary>
        ''' Decrypts the given player profile and returns the data as an array.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Private Shared Function DecryptProfile(fileName As String) As Byte()
            Try
                Using fStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
                    Dim rjm = New RijndaelManaged()
                    Using cStream = New CryptoStream(fStream, rjm.CreateDecryptor(ENCRYPTION_DATA, ENCRYPTION_DATA), CryptoStreamMode.Read)
                        Using mStream = New MemoryStream()
                            Dim dataRead As Integer
                            While (InlineAssignHelper(dataRead, cStream.ReadByte())) <> -1
                                mStream.WriteByte(CByte(dataRead))
                            End While
                            Return TryCast(mStream.GetBuffer().Clone(), Byte())
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(String.Format("Failed to decrypt profile; error was:" & vbCr & vbLf & vbCr & vbLf & "{0}", ex), "Error!")
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Encrypts the given player profile.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Private Shared Function EncryptProfile(fileName As String) As Boolean
            Try
                Using fStreamOut = New FileStream(fileName, FileMode.Create, FileAccess.Write)
                    Dim rjm = New RijndaelManaged()
                    Using cStream = New CryptoStream(fStreamOut, rjm.CreateEncryptor(ENCRYPTION_DATA, ENCRYPTION_DATA), CryptoStreamMode.Write)
                        Using fStreamTmp = New FileStream(fileName & ".tmp", FileMode.Open, FileAccess.Read)
                            Dim dataRead As Integer
                            While (InlineAssignHelper(dataRead, fStreamTmp.ReadByte())) <> -1
                                cStream.WriteByte(CByte(dataRead))
                            End While
                            Return True
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(String.Format("Failed to encrypt profile; error was:" & vbCr & vbLf & vbCr & vbLf & "{0}", ex), "Error!")
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Attempts to decrypt and load a player file.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Function LoadProfile(fileName As String) As Player
            Try
                ' Attempt to decrypt the player file..
                Dim playerData = DecryptProfile(fileName)
                If playerData Is Nothing Then
                    Return Nothing
                End If

                ' Attempt to read the player file..
                Using mStream = New MemoryStream(playerData)
                    Using bReader = New BinaryReader(mStream)
                        ' Create the new player object..
                        Dim p = New Player() With { _
                            Key .GameVersion = bReader.ReadInt32() _
                        }

                        ' Ensure game version is valid..
                        If p.GameVersion < Terraria.GameVersions.Min() OrElse p.GameVersion > Terraria.GameVersions.Max() Then
                            Throw New InvalidDataException("GameVersion does not match the supported value!")
                        End If

                        ' Read basic player info..
                        p.Name = bReader.ReadString()
                        p.Difficulty = bReader.ReadByte()
                        p.Hair = bReader.ReadInt32()

                        ' Hair Dye
                        If p.GameVersion >= 82 Then
                            p.HairDye = bReader.ReadByte()
                        End If

                        ' Hide Visual
                        If p.GameVersion >= 83 Then
                            p.HideVisual = bReader.ReadByte()
                        End If

                        p.IsMale = bReader.ReadBoolean()
                        p.Health = bReader.ReadInt32()
                        p.HealthMax = bReader.ReadInt32()
                        p.Mana = bReader.ReadInt32()
                        p.ManaMax = bReader.ReadInt32()

                        ' Read character colors..
                        p.HairColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.SkinColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.EyeColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.ShirtColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.UndershirtColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.PantsColor = New Color().FromBytes(bReader.ReadBytes(3))
                        p.ShoesColor = New Color().FromBytes(bReader.ReadBytes(3))

                        ' Read Armor..
                        For x As var = 0 To 2
                            p.Armor(x).SetItem(bReader.ReadInt32())
                            p.Armor(x).Prefix = bReader.ReadByte()
                        Next

                        ' Read accessories..
                        For x As var = 0 To 4
                            p.Accessories(x).SetItem(bReader.ReadInt32())
                            p.Accessories(x).Prefix = bReader.ReadByte()
                        Next

                        ' Read vanity items..
                        For x As var = 0 To 2
                            p.Vanity(x).SetItem(bReader.ReadInt32())
                            p.Vanity(x).Prefix = bReader.ReadByte()
                        Next

                        ' Read social accessories..
                        If p.GameVersion >= 81 Then
                            For x As var = 0 To 4
                                p.SocialAccessories(x).SetItem(bReader.ReadInt32())
                                p.SocialAccessories(x).Prefix = bReader.ReadByte()
                            Next
                        End If

                        ' Read dye items..
                        If p.GameVersion >= 47 Then
                            Dim dyeCount = If((p.GameVersion >= 81), 8, 3)
                            For x As var = 0 To dyeCount - 1
                                p.Dye(x).SetItem(bReader.ReadInt32())
                                p.Dye(x).Prefix = bReader.ReadByte()
                            Next
                        End If

                        ' Read inventory..
                        For x As var = 0 To (If((p.GameVersion >= 58), 58, 48)) - 1
                            Dim temp = bReader.ReadInt32()
                            If temp >= Terraria.MaxItemCount Then
                                p.Inventory(x).SetItem(0)
                            Else
                                p.Inventory(x).SetItem(temp)
                                p.Inventory(x).Count = bReader.ReadInt32()
                                p.Inventory(x).Prefix = bReader.ReadByte()
                            End If
                        Next

                        ' Read Bank1..
                        For x As var = 0 To (If((p.GameVersion >= 58), 40, 20)) - 1
                            p.Bank1(x).SetItem(bReader.ReadInt32())
                            p.Bank1(x).Count = bReader.ReadInt32()
                            p.Bank1(x).Prefix = bReader.ReadByte()
                        Next

                        ' Read Bank2..
                        For x As var = 0 To (If((p.GameVersion >= 58), 40, 20)) - 1
                            p.Bank2(x).SetItem(bReader.ReadInt32())
                            p.Bank2(x).Count = bReader.ReadInt32()
                            p.Bank2(x).Prefix = bReader.ReadByte()
                        Next

                        ' Read Buffs..
                        Dim buffCount = If((p.GameVersion < 74), 10, 22)
                        For x As var = 0 To buffCount - 1
                            p.Buffs(x).SetBuff(bReader.ReadInt32())
                            p.Buffs(x).Duration = bReader.ReadInt32()
                        Next

                        ' Read Server Entries..
                        For x As var = 0 To 199
                            Dim temp = bReader.ReadInt32()
                            If temp = -1 Then
                                Exit For
                            End If

                            p.ServerEntries(x).SpawnX = temp
                            p.ServerEntries(x).SpawnY = bReader.ReadInt32()
                            p.ServerEntries(x).ServerAddress = bReader.ReadInt32()
                            p.ServerEntries(x).ServerName = bReader.ReadString()
                        Next

                        ' Read Hotbar Locked Flag..
                        p.IsHotbarLocked = bReader.ReadBoolean()

                        ' Read angler quest data..
                        If p.GameVersion >= 98 Then
                            p.AnglerQuestsFinished = bReader.ReadInt32()
                        End If

                        ' Force the new profile to latest version..
                        p.GameVersion = Terraria.LatestVersion
                        Return p
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(String.Format("Failed to load profile; error was:" & vbCr & vbLf & vbCr & vbLf & "{0}", ex), "Error!")
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Attempts to obtain the profiles name.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Function GetProfileName(fileName As String) As String
            ' Attempt to decrypt the player file..
            Dim playerData = DecryptProfile(fileName)
            If playerData Is Nothing Then
                Return String.Empty
            End If

            ' Attempt to read the name..
            Try
                Using mStream = New MemoryStream(playerData)
                    Using bReader = New BinaryReader(mStream)
                        bReader.ReadInt32()
                        ' GameVersion
                        Return bReader.ReadString()
                    End Using
                End Using
            Catch
                Return String.Empty
            End Try
        End Function

        ''' <summary>
        ''' Attempts to encrypt and save a player object.
        ''' </summary>
        ''' <param name="player"></param>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Function SaveProfile(player As Player, fileName As String) As Boolean
            Dim fStream As FileStream = Nothing
            Dim bWriter As BinaryWriter = Nothing

            Try
                ' Open or create temp file to write to..
                fStream = New FileStream(fileName & ".tmp", FileMode.OpenOrCreate, FileAccess.Write)
                bWriter = New BinaryWriter(fStream)

                ' Write the game version..
                bWriter.Write(player.GameVersion)

                ' Write basic player info..
                bWriter.Write(player.Name)
                bWriter.Write(player.Difficulty)
                bWriter.Write(player.Hair)

                ' Write hair dye and hide visual flag..
                bWriter.Write(CByte(player.HairDye))
                bWriter.Write(CByte(player.HideVisual))

                bWriter.Write(player.IsMale)
                bWriter.Write(player.Health)
                bWriter.Write(player.HealthMax)
                bWriter.Write(player.Mana)
                bWriter.Write(player.ManaMax)

                ' Write player colors..
                bWriter.Write(player.HairColor.ToBytes())
                bWriter.Write(player.SkinColor.ToBytes())
                bWriter.Write(player.EyeColor.ToBytes())
                bWriter.Write(player.ShirtColor.ToBytes())
                bWriter.Write(player.UndershirtColor.ToBytes())
                bWriter.Write(player.PantsColor.ToBytes())
                bWriter.Write(player.ShoesColor.ToBytes())

                ' Write player armor..
                For x As var = 0 To 2
                    bWriter.Write(player.Armor(x).NetID)
                    bWriter.Write(player.Armor(x).Prefix)
                Next

                ' Write player accessories..
                For x As var = 0 To 4
                    bWriter.Write(player.Accessories(x).NetID)
                    bWriter.Write(player.Accessories(x).Prefix)
                Next

                ' Write player vanity items..
                For x As var = 0 To 2
                    bWriter.Write(player.Vanity(x).NetID)
                    bWriter.Write(player.Vanity(x).Prefix)
                Next

                ' Write social accessories items..
                For x As var = 0 To 4
                    bWriter.Write(player.SocialAccessories(x).NetID)
                    bWriter.Write(player.SocialAccessories(x).Prefix)
                Next

                ' Write player dye..
                For x As var = 0 To 7
                    bWriter.Write(player.Dye(x).NetID)
                    bWriter.Write(player.Dye(x).Prefix)
                Next

                ' Write player inventory..
                For x As var = 0 To 57
                    bWriter.Write(player.Inventory(x).NetID)
                    bWriter.Write(player.Inventory(x).Count)
                    bWriter.Write(player.Inventory(x).Prefix)
                Next

                ' Write player bank1..
                For x As var = 0 To 39
                    bWriter.Write(player.Bank1(x).NetID)
                    bWriter.Write(player.Bank1(x).Count)
                    bWriter.Write(player.Bank1(x).Prefix)
                Next

                ' Write player bank2..
                For x As var = 0 To 39
                    bWriter.Write(player.Bank2(x).NetID)
                    bWriter.Write(player.Bank2(x).Count)
                    bWriter.Write(player.Bank2(x).Prefix)
                Next

                ' Write player buffs..
                Dim buffCount = If((player.GameVersion < 74), 10, 22)
                For x As var = 0 To buffCount - 1
                    bWriter.Write(player.Buffs(x).Id)
                    bWriter.Write(player.Buffs(x).Duration)
                Next

                ' Write server entries..
                For x As var = 0 To 199
                    If player.ServerEntries(x).SpawnX = -1 Then
                        bWriter.Write(player.ServerEntries(x).SpawnX)
                        Exit For
                    End If

                    bWriter.Write(player.ServerEntries(x).SpawnX)
                    bWriter.Write(player.ServerEntries(x).SpawnY)
                    bWriter.Write(player.ServerEntries(x).ServerAddress)
                    bWriter.Write(player.ServerEntries(x).ServerName)
                Next

                ' Write hotbar locked flag..
                bWriter.Write(player.IsHotbarLocked)
                bWriter.Write(player.AnglerQuestsFinished)

                ' Cleanup..
                bWriter.Close()
                fStream.Close()

                ' Encrypt the file and save it to real path..
                Dim ret = EncryptProfile(fileName)

                ' Delete the temp file..
                File.Delete(fileName & ".tmp")
                Return ret
            Catch ex As Exception
                MessageBox.Show(String.Format("Failed to save profile; error was:" & vbCr & vbLf & vbCr & vbLf & "{0}", ex), "Error!")
                Return False
            Finally
                ' Ensure streams are cleaned up..
                If bWriter IsNot Nothing Then
                    bWriter.Close()
                End If
                If fStream IsNot Nothing Then
                    fStream.Close()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Gets or sets the list of buffs.
        ''' </summary>
        Public Property Buffs() As List(Of Buff)
            Get
                If Me.m_BuffList IsNot Nothing AndAlso Me.m_BuffList.Count > 0 Then
                    Me.m_BuffList.Sort(New NaturalBuffNameComparer())
                End If
                Return Me.m_BuffList
            End Get
            Set
                Me.m_BuffList = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the list of Items.
        ''' </summary>
        Public ReadOnly Property Items() As List(Of Item)
            Get
                If Me.m_ItemList IsNot Nothing AndAlso Me.m_ItemList.Count > 0 Then
                    Me.m_ItemList.Sort(New NaturalItemNameComparer())
                End If

                If Me.m_ItemList Is Nothing Then
                    Return Nothing
                End If

                Dim items__1 = Me.m_ItemList
                Return New List(Of Item)(DirectCast(items__1.ToArray().Clone(), Item()))
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the list of Prefixes.
        ''' </summary>
        Public Property Prefixes() As List(Of ItemPrefix)
            Get
                If Me.m_PrefixList IsNot Nothing AndAlso Me.m_PrefixList.Count > 0 Then
                    Me.m_PrefixList.Sort(New NaturalItemPrefixNameComparer())
                End If

                If Me.m_PrefixList Is Nothing Then
                    Return Nothing
                End If

                Dim prefixes__1 = Me.m_PrefixList
                Return New List(Of ItemPrefix)(DirectCast(prefixes__1.ToArray().Clone(), ItemPrefix()))
            End Get
            Set
                Me.m_PrefixList = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the hair file list.
        ''' </summary>
        Public Property HairFiles() As List(Of String)
            Get
                Return m_HairFiles
            End Get
            Set
                m_HairFiles = Value
            End Set
        End Property
        Private m_HairFiles As List(Of String)
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace
