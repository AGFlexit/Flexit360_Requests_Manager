<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlyoutInteractiveContent
    Inherits UserControl

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
        Me.radTextBoxComment = New Telerik.WinControls.UI.RadTextBox()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.radButtonOK = New Telerik.WinControls.UI.RadButton()
        Me.radButtonCancel = New Telerik.WinControls.UI.RadButton()
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
        CType(Me.radTextBoxComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radLabel3.SuspendLayout()
        Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radTextBoxComment
        '
        Me.radTextBoxComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radTextBoxComment, 3)
        Me.radTextBoxComment.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTextBoxComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radTextBoxComment.Location = New System.Drawing.Point(3, 51)
        Me.radTextBoxComment.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.radTextBoxComment.Multiline = True
        Me.radTextBoxComment.Name = "radTextBoxComment"
        Me.radTextBoxComment.NullText = "Type your new comment"
        '
        '
        '
        Me.radTextBoxComment.RootElement.StretchVertically = True
        Me.doubleBufferedTableLayoutPanel1.SetRowSpan(Me.radTextBoxComment, 2)
        Me.radTextBoxComment.ShowNullText = True
        Me.radTextBoxComment.Size = New System.Drawing.Size(257, 85)
        Me.radTextBoxComment.TabIndex = 0
        '
        'radLabel1
        '
        Me.radLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel1.AutoSize = False
        Me.radLabel1.Location = New System.Drawing.Point(188, 17)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(75, 18)
        Me.radLabel1.TabIndex = 2
        Me.radLabel1.Text = "First Name:"
        Me.radLabel1.Visible = False
        '
        'radLabel2
        '
        Me.radLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel2.AutoSize = False
        Me.radLabel2.Location = New System.Drawing.Point(188, 20)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(75, 18)
        Me.radLabel2.TabIndex = 3
        Me.radLabel2.Text = "Last Name:"
        Me.radLabel2.Visible = False
        '
        'radButtonOK
        '
        Me.radButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radButtonOK.BackColor = System.Drawing.Color.White
        Me.radButtonOK.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radButtonOK.Location = New System.Drawing.Point(84, 152)
        Me.radButtonOK.Name = "radButtonOK"
        Me.radButtonOK.Size = New System.Drawing.Size(88, 24)
        Me.radButtonOK.TabIndex = 4
        Me.radButtonOK.Text = "Submit"
        '
        'radButtonCancel
        '
        Me.radButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radButtonCancel.BackColor = System.Drawing.Color.White
        Me.radButtonCancel.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radButtonCancel.Location = New System.Drawing.Point(178, 152)
        Me.radButtonCancel.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.radButtonCancel.Name = "radButtonCancel"
        Me.radButtonCancel.Size = New System.Drawing.Size(82, 24)
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
        Me.radLabel3.Controls.Add(Me.radLabel2)
        Me.radLabel3.Controls.Add(Me.radLabel1)
        Me.radLabel3.Font = New System.Drawing.Font("Arial Nova", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.radLabel3.Location = New System.Drawing.Point(1, 3)
        Me.radLabel3.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(266, 42)
        Me.radLabel3.TabIndex = 3
        Me.radLabel3.Text = "New Comment"
        '
        'doubleBufferedTableLayoutPanel1
        '
        Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonCancel, 2, 3)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 0)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonOK, 1, 3)
        Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radTextBoxComment, 0, 1)
        Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
        Me.doubleBufferedTableLayoutPanel1.RowCount = 4
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(270, 190)
        Me.doubleBufferedTableLayoutPanel1.TabIndex = 6
        '
        'FlyoutInteractiveContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
        Me.Name = "FlyoutInteractiveContent"
        Me.Size = New System.Drawing.Size(270, 190)
        CType(Me.radTextBoxComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radLabel3.ResumeLayout(False)
        Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
        Me.doubleBufferedTableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private radTextBoxComment As Telerik.WinControls.UI.RadTextBox
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private WithEvents radButtonOK As Telerik.WinControls.UI.RadButton
    Private WithEvents radButtonCancel As Telerik.WinControls.UI.RadButton
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
End Class

