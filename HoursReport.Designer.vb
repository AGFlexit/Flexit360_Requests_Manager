<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoursReport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoursReport))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssue_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChannelName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientRequestID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequester = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssignee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssue_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChannelName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClient1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientRequestID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateReceived1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequester1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssignee1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResource1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHours1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillable1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.btConfigureConnection = New DevExpress.XtraBars.BarButtonItem()
        Me.btEditQuery = New DevExpress.XtraBars.BarButtonItem()
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProdSupport_DataSet1 = New RequestsManager.ProdSupport_DataSet()
        Me.Hours_Summary_DetailsTableAdapter1 = New RequestsManager.ProdSupport_DataSet_AsyncTableAdapters.Hours_Summary_DetailsTableAdapter()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdSupport_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssue_ID, Me.colChannelName, Me.colClient, Me.colClientRequestID, Me.colDateReceived, Me.colRequester, Me.colDetails, Me.colCategory, Me.colAssignee, Me.colStatus, Me.colResource, Me.colDate, Me.colHours, Me.colBillable})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'colIssue_ID
        '
        Me.colIssue_ID.FieldName = "Issue_ID"
        Me.colIssue_ID.Name = "colIssue_ID"
        Me.colIssue_ID.Visible = True
        Me.colIssue_ID.VisibleIndex = 0
        '
        'colChannelName
        '
        Me.colChannelName.FieldName = "Channel Name"
        Me.colChannelName.Name = "colChannelName"
        Me.colChannelName.Visible = True
        Me.colChannelName.VisibleIndex = 1
        '
        'colClient
        '
        Me.colClient.FieldName = "Client"
        Me.colClient.Name = "colClient"
        Me.colClient.Visible = True
        Me.colClient.VisibleIndex = 2
        '
        'colClientRequestID
        '
        Me.colClientRequestID.FieldName = "Client Request ID"
        Me.colClientRequestID.Name = "colClientRequestID"
        Me.colClientRequestID.Visible = True
        Me.colClientRequestID.VisibleIndex = 3
        '
        'colDateReceived
        '
        Me.colDateReceived.FieldName = "Date Received"
        Me.colDateReceived.Name = "colDateReceived"
        Me.colDateReceived.Visible = True
        Me.colDateReceived.VisibleIndex = 4
        '
        'colRequester
        '
        Me.colRequester.FieldName = "Requester"
        Me.colRequester.Name = "colRequester"
        Me.colRequester.Visible = True
        Me.colRequester.VisibleIndex = 5
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 6
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 7
        '
        'colAssignee
        '
        Me.colAssignee.FieldName = "Assignee"
        Me.colAssignee.Name = "colAssignee"
        Me.colAssignee.Visible = True
        Me.colAssignee.VisibleIndex = 8
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 9
        '
        'colResource
        '
        Me.colResource.FieldName = "Resource"
        Me.colResource.Name = "colResource"
        Me.colResource.Visible = True
        Me.colResource.VisibleIndex = 10
        '
        'colDate
        '
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 11
        '
        'colHours
        '
        Me.colHours.FieldName = "Hours"
        Me.colHours.Name = "colHours"
        Me.colHours.Visible = True
        Me.colHours.VisibleIndex = 12
        '
        'colBillable
        '
        Me.colBillable.FieldName = "Billable"
        Me.colBillable.Name = "colBillable"
        Me.colBillable.Visible = True
        Me.colBillable.VisibleIndex = 13
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "HoursSummary"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 49)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1132, 429)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "RequestsManager.My.MySettings.DB_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "Issue_ID"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""345"" />"
        Table1.Name = "Hours_Summary_Complete"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Channel Name"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Client"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Client Request ID"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Date Received"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Requester"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Details"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "Category"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        Column9.Alias = "Assignee"
        ColumnExpression9.ColumnName = "Contact Name"
        Table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""465"" />"
        Table2.Name = "Contacts Extended"
        ColumnExpression9.Table = Table2
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "Status"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "Resource"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "Date"
        ColumnExpression12.Table = Table1
        Column12.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "Hours"
        ColumnExpression13.Table = Table1
        Column13.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "Billable"
        ColumnExpression14.Table = Table1
        Column14.Expression = ColumnExpression14
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.Columns.Add(Column12)
        SelectQuery1.Columns.Add(Column13)
        SelectQuery1.Columns.Add(Column14)
        SelectQuery1.FilterString = "[Hours_Summary_Complete.Date] >= ?DateSixMntsAgo"
        SelectQuery1.GroupFilterString = ""
        SelectQuery1.Name = "HoursSummary"
        QueryParameter1.Name = "DateSixMntsAgo"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("ADDMONTHS(TODAY(), -6)", GetType(Date))
        SelectQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        RelationColumnInfo1.NestedKeyColumn = "ID"
        RelationColumnInfo1.ParentKeyColumn = "Assigned To"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table2
        Join1.Parent = Table1
        SelectQuery1.Relations.Add(Join1)
        Sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression15.ColumnName = "Date"
        ColumnExpression15.Table = Table1
        Sorting1.Expression = ColumnExpression15
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Tables.Add(Table1)
        SelectQuery1.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssue_ID1, Me.colChannelName1, Me.colClient1, Me.colClientRequestID1, Me.colDateReceived1, Me.colRequester1, Me.colDetails1, Me.colCategory1, Me.colAssignee1, Me.colStatus1, Me.colResource1, Me.colDate1, Me.colHours1, Me.colBillable1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colIssue_ID1
        '
        Me.colIssue_ID1.FieldName = "Issue_ID"
        Me.colIssue_ID1.Name = "colIssue_ID1"
        Me.colIssue_ID1.Visible = True
        Me.colIssue_ID1.VisibleIndex = 0
        Me.colIssue_ID1.Width = 51
        '
        'colChannelName1
        '
        Me.colChannelName1.FieldName = "Channel Name"
        Me.colChannelName1.Name = "colChannelName1"
        Me.colChannelName1.Visible = True
        Me.colChannelName1.VisibleIndex = 1
        Me.colChannelName1.Width = 81
        '
        'colClient1
        '
        Me.colClient1.FieldName = "Client"
        Me.colClient1.Name = "colClient1"
        Me.colClient1.Visible = True
        Me.colClient1.VisibleIndex = 2
        Me.colClient1.Width = 81
        '
        'colClientRequestID1
        '
        Me.colClientRequestID1.FieldName = "Client Request ID"
        Me.colClientRequestID1.Name = "colClientRequestID1"
        Me.colClientRequestID1.Visible = True
        Me.colClientRequestID1.VisibleIndex = 3
        Me.colClientRequestID1.Width = 81
        '
        'colDateReceived1
        '
        Me.colDateReceived1.FieldName = "Date Received"
        Me.colDateReceived1.Name = "colDateReceived1"
        Me.colDateReceived1.Visible = True
        Me.colDateReceived1.VisibleIndex = 4
        Me.colDateReceived1.Width = 81
        '
        'colRequester1
        '
        Me.colRequester1.FieldName = "Requester"
        Me.colRequester1.Name = "colRequester1"
        Me.colRequester1.Visible = True
        Me.colRequester1.VisibleIndex = 5
        Me.colRequester1.Width = 81
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 6
        Me.colDetails1.Width = 81
        '
        'colCategory1
        '
        Me.colCategory1.FieldName = "Category"
        Me.colCategory1.Name = "colCategory1"
        Me.colCategory1.Visible = True
        Me.colCategory1.VisibleIndex = 7
        Me.colCategory1.Width = 81
        '
        'colAssignee1
        '
        Me.colAssignee1.FieldName = "Assignee"
        Me.colAssignee1.Name = "colAssignee1"
        Me.colAssignee1.Visible = True
        Me.colAssignee1.VisibleIndex = 8
        Me.colAssignee1.Width = 81
        '
        'colStatus1
        '
        Me.colStatus1.FieldName = "Status"
        Me.colStatus1.Name = "colStatus1"
        Me.colStatus1.Visible = True
        Me.colStatus1.VisibleIndex = 9
        Me.colStatus1.Width = 81
        '
        'colResource1
        '
        Me.colResource1.FieldName = "Resource"
        Me.colResource1.Name = "colResource1"
        Me.colResource1.Visible = True
        Me.colResource1.VisibleIndex = 10
        Me.colResource1.Width = 81
        '
        'colDate1
        '
        Me.colDate1.FieldName = "Date"
        Me.colDate1.Name = "colDate1"
        Me.colDate1.Visible = True
        Me.colDate1.VisibleIndex = 11
        Me.colDate1.Width = 81
        '
        'colHours1
        '
        Me.colHours1.FieldName = "Hours"
        Me.colHours1.Name = "colHours1"
        Me.colHours1.Visible = True
        Me.colHours1.VisibleIndex = 12
        Me.colHours1.Width = 81
        '
        'colBillable1
        '
        Me.colBillable1.FieldName = "Billable"
        Me.colBillable1.Name = "colBillable1"
        Me.colBillable1.Visible = True
        Me.colBillable1.VisibleIndex = 13
        Me.colBillable1.Width = 84
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btConfigureConnection, Me.btEditQuery})
        Me.barManager1.MainMenu = Me.bar2
        Me.barManager1.MaxItemId = 3
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 1
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.bar1.Text = "Tools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Export"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bar2
        '
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btConfigureConnection), New DevExpress.XtraBars.LinkPersistInfo(Me.btEditQuery)})
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
        '
        'btConfigureConnection
        '
        Me.btConfigureConnection.Caption = "Connection"
        Me.btConfigureConnection.Id = 1
        Me.btConfigureConnection.ImageOptions.SvgImage = CType(resources.GetObject("btConfigureConnection.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btConfigureConnection.Name = "btConfigureConnection"
        Me.btConfigureConnection.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btEditQuery
        '
        Me.btEditQuery.Caption = "Query"
        Me.btEditQuery.Id = 2
        Me.btEditQuery.ImageOptions.SvgImage = CType(resources.GetObject("btEditQuery.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btEditQuery.Name = "btEditQuery"
        Me.btEditQuery.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bar3
        '
        Me.bar3.BarName = "Status bar"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1132, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 478)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1132, 20)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1132, 49)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
        '
        'ProdSupport_DataSet1
        '
        Me.ProdSupport_DataSet1.DataSetName = "ProdSupport_DataSet"
        Me.ProdSupport_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hours_Summary_DetailsTableAdapter1
        '
        Me.Hours_Summary_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'HoursReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 498)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HoursReport"
        Me.Text = "HoursReport"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdSupport_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend barManager1 As DevExpress.XtraBars.BarManager
    Friend bar1 As DevExpress.XtraBars.Bar
    Friend bar2 As DevExpress.XtraBars.Bar
    Friend bar3 As DevExpress.XtraBars.Bar
    Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ProdSupport_DataSet1 As ProdSupport_DataSet
    Friend WithEvents Hours_Summary_DetailsTableAdapter1 As ProdSupport_DataSet_AsyncTableAdapters.Hours_Summary_DetailsTableAdapter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIssue_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChannelName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientRequestID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateReceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequester As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssignee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIssue_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChannelName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClient1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientRequestID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateReceived1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequester1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssignee1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResource1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHours1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillable1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btConfigureConnection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btEditQuery As DevExpress.XtraBars.BarButtonItem
End Class
