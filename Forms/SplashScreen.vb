Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.SplashScreen

Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private timer As Timer
    Private currentProgress As Integer = 0

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  
        Me.Hide()
        If UCase(Environment.UserName) = "HELLF" Then
            My.Settings.Item("DB_Connection") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:\Shared drives\Flexit360 Apps (Alain)\Access DBs\Backups\Tests_Dev\20240125.190013.Prod_Support_Issue_Tracking_be.accdb"
        Else
            My.Settings.Item("DB_Connection") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\l4pncdot01svm02\WebsInc\Access DB - Prod Support\Prod Support Issue Tracking_be.accdb"
            'G:\Shared drives\Flexit360 Apps (Alain)\Access DBs\Backups\Tests_Dev\20230403.202122.Prod_Support_Issue_Tracking_be.accdb

        End If
        ShowSplash()
        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        'RadSplashScreenManager.Close()
    End Sub

    Private Sub ShowSplash()
        timer = New Timer()
        timer.Interval = 500
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
        Dim splashSize As System.Drawing.Size = New System.Drawing.Size(450, 300)
        Dim location As System.Drawing.Point = New System.Drawing.Point((Me.Width - splashSize.Width) / 2, (Me.Height - splashSize.Height) / 2)
        Dim settings As Telerik.WinControls.UI.SplashScreen.RadSplashScreenSettings = New RadSplashScreenSettings() With {
            .StartPosition = SplashStartPosition.Manual,
            .Location = Me.PointToScreen(location),
            .Size = splashSize,
            .Image = Telerik.WinControls.ResFinder.WinFormsLogoWithText,
            .FooterLogo = New Bitmap(Telerik.WinControls.ResFinder.WinFormsIcon.ToBitmap(), New System.Drawing.Size(24, 24)),
            .State = SplashScreenProgressIndicatorState.Indeterminate,
            .Text = "Loading...",
            .FooterText = "TELUS Health. All Rights Reserved."
        }
        Telerik.WinControls.UI.RadSplashScreenManager.Show(settings)
    End Sub
    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If Me.currentProgress < 100 Then
            Me.currentProgress = Math.Min(100, Me.currentProgress + 10)
            RadSplashScreenManager.SetProgress(currentProgress)
            'RadSplashScreenManager.SetContent(String.Format("Loading...", Me.currentProgress))
            If Me.currentProgress = 100 Then
                RadSplashScreenManager.SetContent("Completed")
                System.Threading.Thread.Sleep(2000)
            End If
        Else
            Me.currentProgress = 0
            Me.timer.[Stop]()
            RadSplashScreenManager.Close()
        End If
    End Sub

    Private Sub SplashScreen_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        RadSplashScreenManager.SetContent("Completed")
        Me.currentProgress = 0
        Me.timer.[Stop]()
        RadSplashScreenManager.Close()
    End Sub
End Class
