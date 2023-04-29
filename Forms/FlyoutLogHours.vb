Imports Telerik.WinControls.UI
Partial Public Class FlyoutLogHours
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        Me.Result = DialogResult.Cancel
        Me.DtDate.Value = Now()
    End Sub

    Public Property Result As DialogResult

    Public ReadOnly Property Details As String
        Get
            Return Me.TxtDetails.Text
        End Get
    End Property

    Public ReadOnly Property Hours As Double
        Get
            Return Me.NbHours.Value
        End Get
    End Property

    Public ReadOnly Property DateHours As DateTime
        Get
            Return Me.DtDate.Value
        End Get
    End Property

    Public ReadOnly Property Billable As Boolean
        Get
            Return Me.ChkBillable.Checked
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
        If Me.NbHours.Value = 0 Then
            Return False
        End If

        Return True
    End Function
End Class
