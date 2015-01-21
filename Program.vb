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

Imports System.IO
Imports System.Windows.Forms

Friend NotInheritable Class Program
    Private Sub New()
    End Sub
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread> _
    Friend Shared Sub Main()
        ' Attach unhandled exception handler..
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomainOnUnhandledException

        ' Execute the application..
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmMain())
    End Sub

    ''' <summary>
    ''' Catches and saves unhandled exceptions.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="unhandledExceptionEventArgs"></param>
    Private Shared Sub CurrentDomainOnUnhandledException(sender As Object, unhandledExceptionEventArgs As UnhandledExceptionEventArgs)
        Try
            If unhandledExceptionEventArgs.ExceptionObject Is Nothing Then
                Return
            End If

            Dim ex = DirectCast(unhandledExceptionEventArgs.ExceptionObject, Exception)
            Using writer = New StreamWriter("crashlog.txt")
                writer.Write(ex)
                writer.Flush()
            End Using

            MessageBox.Show(ex.ToString(), "Error!")
        Catch
        End Try
    End Sub
End Class
