Public Class RadForm1
    Sub New()

        InitializeComponent()
        'AddHandler Me.WindowsUIView1.QueryControl, AddressOf WindowsUIView1_QueryControl
        AddHandler Me.NativeMdiView1.QueryControl, AddressOf NativeMdiView1_QueryControl
    End Sub

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub WindowsUIView1_QueryControl(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
        If e.Document Is MenuV2Document Then
            e.Control = New RequestsManager.MenuV2()
        End If
        'If e.Document Is flyoutInteractiveContentDocument Then
        '    e.Control = New RequestsManager.FlyoutInteractiveContent()
        'End If
        If e.Control Is Nothing Then
            e.Control = New System.Windows.Forms.Control()
        End If
    End Sub

    Sub NativeMdiView1_QueryControl(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
        If e.Document Is flyoutLogHoursDocument Then
            e.Control = New RequestsManager.FlyoutLogHours()
        End If
        If e.Document Is flyoutInteractiveContentDocument Then
            e.Control = New RequestsManager.FlyoutInteractiveContent()
        End If
        If e.Document Is MenuV2Document Then
            e.Control = New RequestsManager.MenuV2()
        End If
        If e.Control Is jIRASearchDocument Then
            e.Control = New RequestsManager.JIRASearch(Nothing, Nothing)
        End If
        If e.Control Is Nothing Then
            e.Control = New System.Windows.Forms.Control()
        End If
    End Sub
End Class
