<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoursSummary
    Inherits Telerik.WinControls.UI.ShapedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.HoursSummaryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdSupport_DataSet = New RequestsManager.ProdSupport_DataSet()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.LblTitle = New Telerik.WinControls.UI.RadLabel()
        Me.Hours_Summary_DetailsTableAdapter = New RequestsManager.ProdSupport_DataSetTableAdapters.Hours_Summary_DetailsTableAdapter()
        Me.RadLayoutControl1 = New Telerik.WinControls.UI.RadLayoutControl()
        Me.CboAnalysts = New Telerik.WinControls.UI.RadDropDownList()
        Me.LayoutControlLabelItem1 = New Telerik.WinControls.UI.LayoutControlLabelItem()
        Me.LCTitle = New Telerik.WinControls.UI.LayoutControlLabelItem()
        Me.LayoutControlItem1 = New Telerik.WinControls.UI.LayoutControlItem()
        Me.LayoutControlItem2 = New Telerik.WinControls.UI.LayoutControlItem()
        Me.LayoutControlItem3 = New Telerik.WinControls.UI.LayoutControlItem()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoursSummaryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdSupport_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadLayoutControl1.SuspendLayout()
        CType(Me.CboAnalysts, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        '
        '
        '
        Me.RadTitleBar1.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar1.RootElement.Shape = Me.RoundRectShapeTitle
        Me.RadTitleBar1.Size = New System.Drawing.Size(1085, 23)
        Me.RadTitleBar1.TabIndex = 0
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "HoursSummary"
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.Color.White
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(4, 113)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDeleteRow = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "ID_HoursWorked"
        GridViewDecimalColumn1.HeaderText = "ID_HoursWorked"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "ID_HoursWorked"
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "Issue_ID"
        GridViewDecimalColumn2.HeaderText = "Issue_ID"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.Name = "Issue_ID"
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Channel"
        GridViewTextBoxColumn1.HeaderText = "Channel"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "Channel"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn1.Width = 72
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Client"
        GridViewTextBoxColumn2.HeaderText = "Client"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "Client"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn2.Width = 91
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Requester"
        GridViewTextBoxColumn3.HeaderText = "Requester"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "Requester"
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn3.Width = 85
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "Title"
        GridViewTextBoxColumn4.HeaderText = "Title"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "Title"
        GridViewTextBoxColumn4.ReadOnly = True
        GridViewTextBoxColumn4.Width = 237
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "Employee"
        GridViewTextBoxColumn5.HeaderText = "Employee"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "Employee"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn5.Width = 108
        GridViewDateTimeColumn1.EnableExpressionEditor = False
        GridViewDateTimeColumn1.FieldName = "Date"
        GridViewDateTimeColumn1.HeaderText = "Date"
        GridViewDateTimeColumn1.IsAutoGenerated = True
        GridViewDateTimeColumn1.Name = "Date"
        GridViewDateTimeColumn1.Width = 124
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "Hours"
        GridViewDecimalColumn3.HeaderText = "Hours"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.Name = "Hours"
        GridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewDecimalColumn3.Width = 56
        GridViewCheckBoxColumn1.EnableExpressionEditor = False
        GridViewCheckBoxColumn1.FieldName = "Billable"
        GridViewCheckBoxColumn1.HeaderText = "Billable"
        GridViewCheckBoxColumn1.IsAutoGenerated = True
        GridViewCheckBoxColumn1.MinWidth = 20
        GridViewCheckBoxColumn1.Name = "Billable"
        GridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "Details"
        GridViewTextBoxColumn6.HeaderText = "Details"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "Details"
        GridViewTextBoxColumn6.Width = 222
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewDateTimeColumn1, GridViewDecimalColumn3, GridViewCheckBoxColumn1, GridViewTextBoxColumn6})
        Me.RadGridView1.MasterTemplate.DataSource = Me.HoursSummaryDetailsBindingSource
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
        Me.RadGridView1.Size = New System.Drawing.Size(1053, 508)
        Me.RadGridView1.TabIndex = 3
        '
        'HoursSummaryDetailsBindingSource
        '
        Me.HoursSummaryDetailsBindingSource.DataMember = "Hours_Summary_Details"
        Me.HoursSummaryDetailsBindingSource.DataSource = Me.ProdSupport_DataSet
        '
        'ProdSupport_DataSet
        '
        Me.ProdSupport_DataSet.DataSetName = "ProdSupport_DataSet"
        Me.ProdSupport_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(798, 78)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(259, 29)
        Me.RadButton1.TabIndex = 4
        Me.RadButton1.Text = "Update"
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Arial Nova", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(150, 38)
        Me.LblTitle.TabIndex = 5
        Me.LblTitle.Text = "RadLabel1"
        '
        'Hours_Summary_DetailsTableAdapter
        '
        Me.Hours_Summary_DetailsTableAdapter.ClearBeforeFill = True
        '
        'RadLayoutControl1
        '
        Me.RadLayoutControl1.Controls.Add(Me.RadGridView1)
        Me.RadLayoutControl1.Controls.Add(Me.CboAnalysts)
        Me.RadLayoutControl1.Controls.Add(Me.RadButton1)
        Me.RadLayoutControl1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.LayoutControlLabelItem1, Me.LCTitle, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.RadLayoutControl1.Location = New System.Drawing.Point(12, 67)
        Me.RadLayoutControl1.Name = "RadLayoutControl1"
        Me.RadLayoutControl1.Size = New System.Drawing.Size(1061, 625)
        Me.RadLayoutControl1.TabIndex = 6
        '
        'CboAnalysts
        '
        Me.CboAnalysts.DefaultItemsCountInDropDown = 12
        Me.CboAnalysts.DropDownAnimationEnabled = True
        Me.CboAnalysts.Location = New System.Drawing.Point(4, 80)
        Me.CboAnalysts.Name = "CboAnalysts"
        Me.CboAnalysts.Size = New System.Drawing.Size(524, 24)
        Me.CboAnalysts.TabIndex = 4
        Me.CboAnalysts.Text = "RadDropDownList1"
        '
        'LayoutControlLabelItem1
        '
        Me.LayoutControlLabelItem1.Bounds = New System.Drawing.Rectangle(530, 74, 264, 35)
        Me.LayoutControlLabelItem1.DrawText = False
        Me.LayoutControlLabelItem1.Name = "LayoutControlLabelItem1"
        '
        'LCTitle
        '
        Me.LCTitle.Bounds = New System.Drawing.Rectangle(0, 0, 1059, 74)
        Me.LCTitle.Name = "LCTitle"
        Me.LCTitle.Text = "LayoutControlLabelItem2"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AssociatedControl = Me.RadGridView1
        Me.LayoutControlItem1.Bounds = New System.Drawing.Rectangle(0, 109, 1059, 514)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AssociatedControl = Me.CboAnalysts
        Me.LayoutControlItem2.Bounds = New System.Drawing.Rectangle(0, 74, 530, 35)
        Me.LayoutControlItem2.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AssociatedControl = Me.RadButton1
        Me.LayoutControlItem3.Bounds = New System.Drawing.Rectangle(794, 74, 265, 35)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        '
        'HoursSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 730)
        Me.Controls.Add(Me.RadLayoutControl1)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Name = "HoursSummary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HoursSummary"
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoursSummaryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdSupport_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadLayoutControl1.ResumeLayout(False)
        Me.RadLayoutControl1.PerformLayout()
        CType(Me.CboAnalysts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ProdSupport_DataSet As ProdSupport_DataSet
    Friend WithEvents HoursSummaryDetailsBindingSource As BindingSource
    Friend WithEvents Hours_Summary_DetailsTableAdapter As ProdSupport_DataSetTableAdapters.Hours_Summary_DetailsTableAdapter
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLayoutControl1 As Telerik.WinControls.UI.RadLayoutControl
    Friend WithEvents CboAnalysts As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LayoutControlLabelItem1 As Telerik.WinControls.UI.LayoutControlLabelItem
    Friend WithEvents LCTitle As Telerik.WinControls.UI.LayoutControlLabelItem
    Friend WithEvents LayoutControlItem1 As Telerik.WinControls.UI.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As Telerik.WinControls.UI.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As Telerik.WinControls.UI.LayoutControlItem
End Class

