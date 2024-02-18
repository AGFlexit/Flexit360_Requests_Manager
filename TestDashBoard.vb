﻿Imports DevExpress.DataAccess.UI.Sql

Public Class TestDashBoard
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        SqlDataSource1.FillAsync()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        'SqlDataSource1.FillAsync()
    End Sub

    Private Sub TestDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Issues' table. You can move, or remove it, as needed.
        Me.IssuesTableAdapter.Fill(Me.ProdSupport_DataSet.Issues)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Issues' table. You can move, or remove it, as needed.
        'Me.IssuesTableAdapter.Fill(Me.ProdSupport_DataSet.Issues)

    End Sub

    Private Sub btConfigureConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btConfigureConnection.Click
        SqlDataSourceUIHelper.ConfigureConnection(SqlDataSource1)
    End Sub

    Private Sub btEditQuery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEditQuery.Click
        SqlDataSourceUIHelper.EditQuery(SqlDataSource1.Queries("Issues"))

        SqlDataSource1.Fill()

        GridView1.PopulateColumns()
    End Sub

    Private Sub FilterControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class