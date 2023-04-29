Public Class FLEXS_Mgmt
    Private Sub FLEXS_Mgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.StatusReportAudit_ALL' table. You can move, or remove it, as needed.
        Me.RadGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.StatusReportAudit_ALLTableAdapter.Fill(Me.ProdSupport_DataSet.StatusReportAudit_ALL)
        RadGridView1.BestFitColumns()
    End Sub
End Class
