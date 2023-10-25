Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data.OleDb
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Partial Public Class HoursEdit

    Public Sub New()
        InitializeComponent()

        'gridControl.DataSource = GetDataSource()
    End Sub
    Private Sub windowsUIButtonPanel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Update"
                ApplyChanges()
            Case "Set Oldest"
            Case "Employee"
            Case "Cancel"
            Case "Print"
                gridControl.ShowRibbonPrintPreview()
        End Select
    End Sub
    Public Function GetDataSource() As BindingList(Of Customer)
        Dim result As New BindingList(Of Customer)()
        result.Add(New Customer() With {.ID = 1, .Name = "ACME", .Address = "2525 E El Segundo Blvd", .City = "El Segundo", .State = "CA", .ZipCode = "90245", .Phone = "(310) 536-0611"})
        result.Add(New Customer() With {.ID = 2, .Name = "Electronics Depot", .Address = "2455 Paces Ferry Road NW", .City = "Atlanta", .State = "GA", .ZipCode = "30339", .Phone = "(800) 595-3232"})
        Return result
    End Function
    Public Class Customer
        <Key, Display(AutoGenerateField:=False)>
        Public Property ID() As Integer
        <Required>
        Public Property Name() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property State() As String
        <Display(Name:="Zip Code")>
        Public Property ZipCode() As String
        Public Property Phone() As String
    End Class

    Private Sub HoursEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Hours_Summary_Details' table. You can move, or remove it, as needed.

        Me.Hours_Summary_DetailsTableAdapter.FillByEmpMaxTwoMonths(Me.ProdSupport_DataSet.Hours_Summary_Details, MenuV2.Tag)

    End Sub

    Sub ApplyChanges()
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
            Me.Hours_Summary_DetailsTableAdapter.FillByEmpMaxTwoMonths(Me.ProdSupport_DataSet.Hours_Summary_Details, MenuV2.Tag)
            Me.gridControl.RefreshDataSource()
            'Me.gridControl.

            MenuV2.Tbl_HoursWorkedLogTableAdapter1.Fill(MenuV2.ProdSupport_DataSet1.tbl_HoursWorkedLog)
            MenuV2.LoadDataAsync_NavBar("FillHours")
            MenuV2.GCtrlRequests.RefreshDataSource()

            'Me.RadGridView1.Rows(Allo).IsSelected = True
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & "Update failed")
        End Try
    End Sub
End Class
