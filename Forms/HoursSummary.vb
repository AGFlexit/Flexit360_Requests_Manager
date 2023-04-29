Imports System.Data.OleDb
Imports System.ComponentModel
Imports Telerik.WinControls.UI.Data

Public Class HoursSummary

    Private WithEvents bgWorker As New BackgroundWorker

    Private Sub HoursSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LblTitle.Text = "Hours Summary for " & Main.Tag
        Me.LCTitle.Text = "Hours Summary for " & Main.Tag

        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Hours_Summary_Details' table. You can move, or remove it, as needed.
        Me.Hours_Summary_DetailsTableAdapter.FillByEmployee(Me.ProdSupport_DataSet.Hours_Summary_Details, Main.Tag)
        Me.CboAnalysts.Items.Clear()
        ' Initialize the BackgroundWorker
        bgWorker.WorkerSupportsCancellation = True
        bgWorker.WorkerReportsProgress = True

        ' Start the BackgroundWorker
        'RadOverlayManager.Show(Me)
        bgWorker.RunWorkerAsync()

    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        ' Replace with your database file path
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\path\to\your\database.accdb"

        ' Replace with your query
        Dim query As String = "SELECT DISTINCT Employee FROM tbl_HoursWorkedLog ORDER BY Employee ASC"

        Dim connection As OleDbConnection = Me.Hours_Summary_DetailsTableAdapter.Connection
        'Using connection As OleDbConnection = Me.Hours_Summary_DetailsTableAdapter.Connection
        Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()

                        While reader.Read()

                            Dim item As New Telerik.WinControls.UI.RadListDataItem(reader("Employee").ToString())
                            If item.Text = "" Then
                            Else
                                bgWorker.ReportProgress(0, item)
                            End If

                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        'End Using
    End Sub
    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        Dim item As Telerik.WinControls.UI.RadListDataItem = CType(e.UserState, Telerik.WinControls.UI.RadListDataItem)
        CboAnalysts.Items.Add(item)
    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        ' Update the UI after the data is loaded
        'If e.Error IsNot Nothing Then
        '    MessageBox.Show("Error: " & e.Error.Message)
        'End If

        'RadOverlayManager.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            Me.Validate()
            Me.HoursSummaryDetailsBindingSource.EndEdit()


            Dim dsChanged As DataTable = Me.ProdSupport_DataSet.GetChanges.Tables.Item(11)
            Dim details As String


            If Not dsChanged Is Nothing Then
                Me.Hours_Summary_DetailsTableAdapter.Connection.Open()
                Dim nbUpdates As Integer = dsChanged.Rows.Count

                'For Each dt As DataTable In dsChanged.Tables
                For Each row As DataRow In dsChanged.Rows

                    If row.Field(Of String)("Details") = "" Then
                        details = "NULL" 'DBNull.Value
                    Else
                        details = "'" & row.Field(Of String)("Details") & "'"
                    End If

                    Dim SQLEditHours As New OleDbCommand("UPDATE tbl_HoursWorkedLog SET [Employee] = '" & row.Field(Of String)("Employee") & "', [Hours_Worked_Date] = '" & row.Field(Of DateTime)("Date") & "', [Hours_Worked_Amt] = " & CDbl(row.Field(Of Decimal)("Hours")) & ", [Billable] = " & row.Field(Of Boolean)("Billable") & ", [Details] = " & details & " WHERE [ID_HoursWorked] = " & row.Field(Of Integer)("ID_HoursWorked"), Me.Hours_Summary_DetailsTableAdapter.Connection)
                    'Me.Hours_Summary_DetailsTableAdapter.Connection.Open()

                    Dim results As Integer = SQLEditHours.ExecuteNonQuery

                Next

                If nbUpdates <= 1 Then
                    MsgBox("Successfully updated " & nbUpdates & " record!")
                Else
                    MsgBox("Successfully updated " & nbUpdates & " records!")
                End If
                Me.Hours_Summary_DetailsTableAdapter.Connection.Close()
                'QueryHours()
            End If



            'Me.Hours_Summary_DetailsTableAdapter.Update(Me.ProdSupport_DataSet.Hours_Summary_Details)
            'MsgBox("Update successful")
            Me.Hours_Summary_DetailsTableAdapter.FillByEmployee(Me.ProdSupport_DataSet.Hours_Summary_Details, Main.Tag)
            Me.RadGridView1.Update()

            Main.Tbl_HoursWorkedLogTableAdapter.Fill(Main.ProdSupport_DataSet.tbl_HoursWorkedLog)
            Main.RadGridView1.Update()

            'Me.RadGridView1.Rows(Allo).IsSelected = True
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & "Update failed")
        End Try
    End Sub

    Private Sub CboAnalysts_SelectedIndexChanged(sender As Object, e As PositionChangedEventArgs) Handles CboAnalysts.SelectedIndexChanged
        'Telerik.WinControls.UI.RadOverlayManager.Show(Me.RadGridView1)
        'Me.Hours_Summary_DetailsTableAdapter.Connection.Open()
        Me.Hours_Summary_DetailsTableAdapter.FillByEmployee(Me.ProdSupport_DataSet.Hours_Summary_Details, Me.CboAnalysts.SelectedItem.Text)
        'Me.Hours_Summary_DetailsTableAdapter.Connection.Close()
        Me.RadGridView1.Update()
        'Telerik.WinControls.UI.RadOverlayManager.Close()
    End Sub
End Class
