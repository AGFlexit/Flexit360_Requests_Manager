<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLEXS_Mgmt
    Inherits Telerik.WinControls.UI.ShapedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLEXS_Mgmt))
        Me.RoundRectShapeForm = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.RadLayoutControl1 = New Telerik.WinControls.UI.RadLayoutControl()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.StatusReportAuditALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdSupport_DataSet = New RequestsManager.ProdSupport_DataSet()
        Me.LayoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
        Me.LayoutControlItem1 = New Telerik.WinControls.UI.LayoutControlItem()
        Me.StatusReportAudit_ALLTableAdapter = New RequestsManager.ProdSupport_DataSetTableAdapters.StatusReportAudit_ALLTableAdapter()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadLayoutControl1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusReportAuditALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdSupport_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundRectShapeTitle
        '
        Me.RoundRectShapeTitle.BottomLeftRounded = False
        Me.RoundRectShapeTitle.BottomRightRounded = False
        '
        'RadTitleBar1
        '
        Me.RadTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadTitleBar1.Font = New System.Drawing.Font("Arial Nova", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.RadTitleBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RadTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        '
        '
        '
        Me.RadTitleBar1.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar1.RootElement.Shape = Me.RoundRectShapeTitle
        Me.RadTitleBar1.Size = New System.Drawing.Size(1321, 23)
        Me.RadTitleBar1.TabIndex = 0
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "FLEXS Tickets Management"
        '
        'RadLayoutControl1
        '
        Me.RadLayoutControl1.AllowCustomize = False
        Me.RadLayoutControl1.AllowHiddenItems = False
        Me.RadLayoutControl1.Controls.Add(Me.RadGridView1)
        Me.RadLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLayoutControl1.DrawBorder = False
        Me.RadLayoutControl1.EnableAnalytics = False
        Me.RadLayoutControl1.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLayoutControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RadLayoutControl1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.LayoutControlLabelItem1, Me.LayoutControlItem1})
        Me.RadLayoutControl1.Location = New System.Drawing.Point(0, 23)
        Me.RadLayoutControl1.Name = "RadLayoutControl1"
        Me.RadLayoutControl1.Size = New System.Drawing.Size(1321, 774)
        Me.RadLayoutControl1.TabIndex = 1
        Me.RadLayoutControl1.TabStop = False
        '
        'RadGridView1
        '
        Me.RadGridView1.AutoScroll = True
        Me.RadGridView1.AutoSizeRows = True
        Me.RadGridView1.BackColor = System.Drawing.Color.White
        Me.RadGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Font = New System.Drawing.Font("Arial Nova", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(4, 186)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDeleteRow = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "FLEXS"
        GridViewDecimalColumn1.HeaderText = "FLEXS"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "FLEXS"
        GridViewDecimalColumn1.Width = 63
        GridViewDecimalColumn2.DecimalPlaces = 0
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.HeaderText = "column2"
        GridViewDecimalColumn2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        GridViewDecimalColumn2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        GridViewDecimalColumn2.Name = "column2"
        GridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewDecimalColumn2.Width = 79
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Active"
        GridViewTextBoxColumn1.HeaderText = "Active"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "Active"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.Width = 72
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Title"
        GridViewTextBoxColumn2.HeaderText = "Title"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "Title"
        GridViewTextBoxColumn2.Width = 288
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Channel"
        GridViewTextBoxColumn3.HeaderText = "Channel"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "Channel"
        GridViewTextBoxColumn3.Width = 142
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "ClientID"
        GridViewTextBoxColumn4.HeaderText = "ClientID"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "ClientID"
        GridViewTextBoxColumn4.Width = 98
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "Client"
        GridViewTextBoxColumn5.HeaderText = "Client"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "Client"
        GridViewTextBoxColumn5.Width = 153
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "Assignee"
        GridViewTextBoxColumn6.HeaderText = "Assignee"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "Assignee"
        GridViewTextBoxColumn6.ReadOnly = True
        GridViewTextBoxColumn6.Width = 148
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "Status"
        GridViewTextBoxColumn7.HeaderText = "Status"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.Name = "Status"
        GridViewTextBoxColumn7.Width = 140
        GridViewDateTimeColumn1.EnableExpressionEditor = False
        GridViewDateTimeColumn1.FieldName = "Received"
        GridViewDateTimeColumn1.HeaderText = "Received"
        GridViewDateTimeColumn1.IsAutoGenerated = True
        GridViewDateTimeColumn1.IsVisible = False
        GridViewDateTimeColumn1.Name = "Received"
        GridViewDateTimeColumn1.Width = 34
        GridViewDateTimeColumn2.EnableExpressionEditor = False
        GridViewDateTimeColumn2.FieldName = "Updated"
        GridViewDateTimeColumn2.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.[Date]
        GridViewDateTimeColumn2.FilteringTimePrecision = Telerik.WinControls.UI.GridViewTimePrecisionMode.None
        GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        GridViewDateTimeColumn2.HeaderText = "Updated"
        GridViewDateTimeColumn2.IsAutoGenerated = True
        GridViewDateTimeColumn2.Name = "Updated"
        GridViewDateTimeColumn2.Width = 100
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "Comments"
        GridViewTextBoxColumn8.HeaderText = "Comments"
        GridViewTextBoxColumn8.IsAutoGenerated = True
        GridViewTextBoxColumn8.Name = "Comments"
        GridViewTextBoxColumn8.ReadOnly = True
        GridViewTextBoxColumn8.Width = 28
        GridViewDecimalColumn3.DataType = GetType(Integer)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "ID"
        GridViewDecimalColumn3.HeaderText = "ID"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.IsVisible = False
        GridViewDecimalColumn3.Name = "ID"
        GridViewDecimalColumn3.Width = 38
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewTextBoxColumn8, GridViewDecimalColumn3})
        Me.RadGridView1.MasterTemplate.DataSource = Me.StatusReportAuditALLBindingSource
        Me.RadGridView1.MasterTemplate.EnableAlternatingRowColor = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect
        Me.RadGridView1.MasterTemplate.ShowFilteringRow = False
        Me.RadGridView1.MasterTemplate.ShowHeaderCellButtons = True
        Me.RadGridView1.MasterTemplate.ShowRowHeaderColumn = False
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.ShowHeaderCellButtons = True
        Me.RadGridView1.Size = New System.Drawing.Size(1313, 584)
        Me.RadGridView1.TabIndex = 3
        '
        'StatusReportAuditALLBindingSource
        '
        Me.StatusReportAuditALLBindingSource.DataMember = "StatusReportAudit_ALL"
        Me.StatusReportAuditALLBindingSource.DataSource = Me.ProdSupport_DataSet
        '
        'ProdSupport_DataSet
        '
        Me.ProdSupport_DataSet.DataSetName = "ProdSupport_DataSet"
        Me.ProdSupport_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LayoutControlLabelItem1
        '
        Me.LayoutControlLabelItem1.Bounds = New System.Drawing.Rectangle(0, 0, 1319, 182)
        Me.LayoutControlLabelItem1.DrawText = False
        Me.LayoutControlLabelItem1.Name = "LayoutControlLabelItem1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AssociatedControl = Me.RadGridView1
        Me.LayoutControlItem1.Bounds = New System.Drawing.Rectangle(0, 182, 1319, 590)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        '
        'StatusReportAudit_ALLTableAdapter
        '
        Me.StatusReportAudit_ALLTableAdapter.ClearBeforeFill = True
        '
        'FLEXS_Mgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1321, 797)
        Me.Controls.Add(Me.RadLayoutControl1)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FLEXS_Mgmt"
        Me.Shape = Me.RoundRectShapeForm
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLEXS Tickets Management"
        Me.TopMost = True
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadLayoutControl1.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusReportAuditALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdSupport_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundRectShapeForm As Telerik.WinControls.RoundRectShape
    Friend WithEvents RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents RadLayoutControl1 As Telerik.WinControls.UI.RadLayoutControl
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents LayoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
    Friend WithEvents LayoutControlItem1 As Telerik.WinControls.UI.LayoutControlItem
    Friend WithEvents ProdSupport_DataSet As ProdSupport_DataSet
    Friend WithEvents StatusReportAuditALLBindingSource As BindingSource
    Friend WithEvents StatusReportAudit_ALLTableAdapter As ProdSupport_DataSetTableAdapters.StatusReportAudit_ALLTableAdapter
End Class

