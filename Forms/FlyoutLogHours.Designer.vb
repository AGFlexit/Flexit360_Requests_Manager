<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FlyoutLogHours
    Inherits UserControl

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
        Me.TxtDetails = New Telerik.WinControls.UI.RadTextBox()
        Me.radButtonOK = New Telerik.WinControls.UI.RadButton()
        Me.radButtonCancel = New Telerik.WinControls.UI.RadButton()
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
        Me.NbHours = New Telerik.WinControls.UI.RadSpinEditor()
        Me.ChkBillable = New Telerik.WinControls.UI.RadCheckBox()
        Me.DtDate = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.TxtDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
        CType(Me.NbHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkBillable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDetails
        '
        Me.TxtDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.TxtDetails, 3)
        Me.TxtDetails.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtDetails.Location = New System.Drawing.Point(3, 87)
        Me.TxtDetails.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.TxtDetails.Multiline = True
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.NullText = "Optional Details"
        '
        '
        '
        Me.TxtDetails.RootElement.StretchVertically = True
        Me.TxtDetails.ShowNullText = True
        Me.TxtDetails.Size = New System.Drawing.Size(342, 56)
        Me.TxtDetails.TabIndex = 0
        '
        'radButtonOK
        '
        Me.radButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radButtonOK.BackColor = System.Drawing.Color.White
        Me.radButtonOK.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radButtonOK.Location = New System.Drawing.Point(139, 163)
        Me.radButtonOK.Name = "radButtonOK"
        Me.radButtonOK.Size = New System.Drawing.Size(98, 24)
        Me.radButtonOK.TabIndex = 4
        Me.radButtonOK.Text = "Submit"
        '
        'radButtonCancel
        '
        Me.radButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radButtonCancel.BackColor = System.Drawing.Color.White
        Me.radButtonCancel.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radButtonCancel.Location = New System.Drawing.Point(243, 163)
        Me.radButtonCancel.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.radButtonCancel.Name = "radButtonCancel"
        Me.radButtonCancel.Size = New System.Drawing.Size(102, 24)
        Me.radButtonCancel.TabIndex = 5
        Me.radButtonCancel.Text = "Cancel"
        '
        'radLabel3
        '
        Me.radLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel3.AutoSize = False
        Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabel3, 3)
        Me.radLabel3.Font = New System.Drawing.Font("Arial Nova", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radLabel3.Location = New System.Drawing.Point(1, 3)
        Me.radLabel3.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(351, 34)
        Me.radLabel3.TabIndex = 3
        Me.radLabel3.Text = "Log Hours"
        '
        'doubleBufferedTableLayoutPanel1
        '
        Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.59155!))
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747!))
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.11267!))
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonCancel, 2, 3)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 0)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonOK, 1, 3)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.TxtDetails, 0, 2)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.NbHours, 1, 1)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.ChkBillable, 2, 1)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.DtDate, 0, 1)
        Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
        Me.doubleBufferedTableLayoutPanel1.RowCount = 4
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(355, 201)
        Me.doubleBufferedTableLayoutPanel1.TabIndex = 6
        '
        'NbHours
        '
        Me.NbHours.DecimalPlaces = 2
        Me.NbHours.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NbHours.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.NbHours.Location = New System.Drawing.Point(139, 43)
        Me.NbHours.Name = "NbHours"
        Me.NbHours.Size = New System.Drawing.Size(98, 24)
        Me.NbHours.TabIndex = 1
        '
        'ChkBillable
        '
        Me.ChkBillable.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBillable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ChkBillable.Location = New System.Drawing.Point(243, 43)
        Me.ChkBillable.Name = "ChkBillable"
        Me.ChkBillable.Size = New System.Drawing.Size(63, 18)
        Me.ChkBillable.TabIndex = 6
        Me.ChkBillable.Text = "Billable"
        '
        'DtDate
        '
        Me.DtDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.DtDate.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DtDate.Location = New System.Drawing.Point(3, 43)
        Me.DtDate.Name = "DtDate"
        Me.DtDate.NullText = "Select Date"
        Me.DtDate.Size = New System.Drawing.Size(130, 24)
        Me.DtDate.TabIndex = 7
        Me.DtDate.TabStop = False
        Me.DtDate.Value = New Date(CType(0, Long))
        '
        'FlyoutLogHours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
        Me.Name = "FlyoutLogHours"
        Me.Size = New System.Drawing.Size(355, 201)
        CType(Me.TxtDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
        Me.doubleBufferedTableLayoutPanel1.PerformLayout()
        CType(Me.NbHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkBillable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private TxtDetails As Telerik.WinControls.UI.RadTextBox
    Private WithEvents radButtonOK As Telerik.WinControls.UI.RadButton
    Private WithEvents radButtonCancel As Telerik.WinControls.UI.RadButton
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    Friend WithEvents NbHours As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents ChkBillable As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents DtDate As Telerik.WinControls.UI.RadDateTimePicker
End Class

