<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm2
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadChat1 = New Telerik.WinControls.UI.RadChat()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadChat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadChat1
        '
        Me.RadChat1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadChat1.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadChat1.Location = New System.Drawing.Point(802, 0)
        Me.RadChat1.Name = "RadChat1"
        Me.RadChat1.Size = New System.Drawing.Size(208, 532)
        Me.RadChat1.TabIndex = 0
        Me.RadChat1.Text = "RadChat1"
        Me.RadChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00")
        CType(Me.RadChat1.GetChildAt(0), Telerik.WinControls.UI.RadChatElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        CType(Me.RadChat1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChatMessagesViewElement).Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadGridView1
        '
        Me.RadGridView1.AutoGenerateHierarchy = True
        Me.RadGridView1.AutoSizeRows = True
        Me.RadGridView1.BackColor = System.Drawing.Color.White
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.Size = New System.Drawing.Size(802, 532)
        Me.RadGridView1.TabIndex = 1
        '
        'RadForm2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 532)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadChat1)
        Me.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Name = "RadForm2"
        Me.Text = "RadForm2"
        CType(Me.RadChat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadChat1 As Telerik.WinControls.UI.RadChat
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class

