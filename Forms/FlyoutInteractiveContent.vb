Imports Telerik.WinControls.UI
Partial Public Class FlyoutInteractiveContent
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        Me.Result = DialogResult.Cancel
    End Sub

    Public Property Result As DialogResult

    Public ReadOnly Property Comment As String
        Get
            Return Me.radTextBoxComment.Text
        End Get
    End Property

    Private Sub RadButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonOK.Click
        If Not Me.ValidateData() Then
            Return
        End If

        Me.Result = DialogResult.OK
        RadFlyoutManager.Close()
    End Sub

    Private Sub RadButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonCancel.Click
        Me.Result = DialogResult.Cancel
        RadFlyoutManager.Close()
    End Sub

    Private Function ValidateData() As Boolean
        If String.IsNullOrWhiteSpace(Me.Comment) Then
            Return False
        End If

        Return True
    End Function
End Class
