Public Class FLEXS_Mgmt
    Private Sub FLEXS_Mgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.Audit' table. You can move, or remove it, as needed.
        Me.AuditTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.Audit)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.tbl_HoursWorkedLog' table. You can move, or remove it, as needed.
        Me.Tbl_HoursWorkedLogTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.tbl_HoursWorkedLog)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.Clients)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.Channels' table. You can move, or remove it, as needed.
        Me.ChannelsTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.Channels)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.Contacts_Extended' table. You can move, or remove it, as needed.
        Me.Contacts_ExtendedTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.Contacts_Extended)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet_Async.Analysts' table. You can move, or remove it, as needed.
        Me.AnalystsTableAdapter_Async.Fill(Me.ProdSupport_DataSet_Async.Analysts)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.StatusReportAudit_ALL' table. You can move, or remove it, as needed.
        Me.RadGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.StatusReportAudit_ALLTableAdapter.Fill(Me.ProdSupport_DataSet.StatusReportAudit_ALL)
        RadGridView1.BestFitColumns()
    End Sub
End Class
