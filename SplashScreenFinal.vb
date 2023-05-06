Imports System.IO

Public Class SplashScreenFinal
    Sub New()
        InitializeComponent()
        Me.labelCopyright.Text = "For Internal Use Only (2023 - " & DateTime.Now.Year.ToString() & ")"

        Telerik.WinControls.ThemeResolutionService.LoadPackageResource("RequestsManager.Office2019LightPurple.tssp")
        Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "Office2019LightPurple"

        My.Settings.Item("Local_Prod_SupportConnectionString") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GoogleSharedDrvPath() & "\Flexit360 Apps (Alain)\Access DBs\Local_RequestLog.accdb"

        My.Settings.Item("DB_Connection") = If(UCase(Environment.UserName) = "HELLF",
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Work\TELUS\DB\20230419. 43358.Prod_Support_Issue_Tracking_be.accdb",
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\l4pncdot01svm02\WebsInc\Access DB - Prod Support\Prod Support Issue Tracking_be.accdb")
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Function GoogleSharedDrvPath() As String

        Try
            Dim drvlist() As DriveInfo = DriveInfo.GetDrives()

            For Each drv In drvlist
                If drv.IsReady = True Then
                    If LCase(drv.VolumeLabel).Contains("google") Then
                        For Each value As DirectoryInfo In drv.RootDirectory.EnumerateDirectories()
                            If LCase(value.Name).Contains("shared") Or LCase(value.Name).Contains("partag") Then
                                Return value.FullName '& "\Flexit360 Team Drive\Clients\Status Reports"
                                Exit Function
                            End If
                        Next
                    End If
                End If
            Next

            Return ""
        Catch Ex As Exception
            MsgBox(Ex.Message)
            Return ""
        Finally
        End Try

    End Function
End Class
