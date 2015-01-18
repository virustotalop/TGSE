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

Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms

Public Partial Class frmAbout
    Inherits Form
    ''' <summary>
    ''' Default Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        ' Set the application version label..
        Dim appVersion = Assembly.GetExecutingAssembly().GetName().Version
        Me.lblVersion.Text = String.Format("{0}.{1}.{2}.{3}", appVersion.Major, appVersion.Minor, appVersion.Build, appVersion.Revision) & " - Made resisable by Walkman100"
    End Sub

    ''' <summary>
    ''' Launches the users browser and navigates to Twitter.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTwitter_Click(sender As Object, e As System.EventArgs)
        Process.Start(New ProcessStartInfo("http://www.twitter.com/atom0s"))
    End Sub

    ''' <summary>
    ''' Launches the users browser and navigates to Paypal.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDonate_Click(sender As Object, e As System.EventArgs)
        Process.Start(New ProcessStartInfo("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7U7Q2GRT6KUJN"))
    End Sub

    ''' <summary>
    ''' Launches the users browser and navigates to Github.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lblSourceCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start(New ProcessStartInfo("https://github.com/atom0s/TSGE"))
    End Sub
End Class
