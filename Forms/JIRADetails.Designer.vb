<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JIRADetails
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
        Me.RoundRectShapeForm = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.txtFLEXNb = New Telerik.WinControls.UI.RadTextBox()
        Me.txtSummary = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPriority = New Telerik.WinControls.UI.RadTextBox()
        Me.txtStatus = New Telerik.WinControls.UI.RadTextBox()
        Me.txtReporter = New Telerik.WinControls.UI.RadTextBox()
        Me.txtAssignee = New Telerik.WinControls.UI.RadTextBox()
        Me.dtCreated = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtUpdated = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtLabels = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCarriers = New Telerik.WinControls.UI.RadTextBox()
        Me.txtClients = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFixVersion = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.txtPropRelease = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFLEXNb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReporter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssignee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtUpdated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFixVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundRectShapeTitle
        '
        Me.RoundRectShapeTitle.BottomLeftRounded = False
        Me.RoundRectShapeTitle.BottomRightRounded = False
        '
        'RadTitleBar1
        '
        Me.RadTitleBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTitleBar1.Location = New System.Drawing.Point(1, 1)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        '
        '
        '
        Me.RadTitleBar1.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar1.RootElement.Shape = Me.RoundRectShapeTitle
        Me.RadTitleBar1.Size = New System.Drawing.Size(767, 23)
        Me.RadTitleBar1.TabIndex = 0
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "JIRADetails"
        '
        'txtFLEXNb
        '
        Me.txtFLEXNb.EmbeddedLabelText = "Key"
        Me.txtFLEXNb.Location = New System.Drawing.Point(55, 76)
        Me.txtFLEXNb.Name = "txtFLEXNb"
        Me.txtFLEXNb.ShowEmbeddedLabel = True
        Me.txtFLEXNb.Size = New System.Drawing.Size(67, 42)
        Me.txtFLEXNb.TabIndex = 1
        '
        'txtSummary
        '
        Me.txtSummary.EmbeddedLabelText = "Summary"
        Me.txtSummary.Location = New System.Drawing.Point(55, 124)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        '
        '
        '
        Me.txtSummary.RootElement.StretchVertically = True
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.ShowEmbeddedLabel = True
        Me.txtSummary.Size = New System.Drawing.Size(305, 58)
        Me.txtSummary.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(55, 188)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        '
        '
        '
        Me.txtDesc.RootElement.StretchVertically = True
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.ShowEmbeddedLabel = True
        Me.txtDesc.Size = New System.Drawing.Size(305, 279)
        Me.txtDesc.TabIndex = 3
        '
        'txtPriority
        '
        Me.txtPriority.EmbeddedLabelText = "Priority"
        Me.txtPriority.Location = New System.Drawing.Point(128, 76)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.ShowEmbeddedLabel = True
        Me.txtPriority.Size = New System.Drawing.Size(69, 42)
        Me.txtPriority.TabIndex = 2
        '
        'txtStatus
        '
        Me.txtStatus.EmbeddedLabelText = "Status"
        Me.txtStatus.Location = New System.Drawing.Point(203, 76)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ShowEmbeddedLabel = True
        Me.txtStatus.Size = New System.Drawing.Size(157, 42)
        Me.txtStatus.TabIndex = 3
        '
        'txtReporter
        '
        Me.txtReporter.EmbeddedLabelText = "Reporter"
        Me.txtReporter.Location = New System.Drawing.Point(366, 76)
        Me.txtReporter.Name = "txtReporter"
        Me.txtReporter.ShowEmbeddedLabel = True
        Me.txtReporter.Size = New System.Drawing.Size(126, 42)
        Me.txtReporter.TabIndex = 4
        '
        'txtAssignee
        '
        Me.txtAssignee.EmbeddedLabelText = "Assignee"
        Me.txtAssignee.Location = New System.Drawing.Point(498, 76)
        Me.txtAssignee.Name = "txtAssignee"
        Me.txtAssignee.ShowEmbeddedLabel = True
        Me.txtAssignee.Size = New System.Drawing.Size(126, 42)
        Me.txtAssignee.TabIndex = 5
        '
        'dtCreated
        '
        Me.dtCreated.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtCreated.Location = New System.Drawing.Point(426, 125)
        Me.dtCreated.Name = "dtCreated"
        Me.dtCreated.Size = New System.Drawing.Size(198, 24)
        Me.dtCreated.TabIndex = 6
        Me.dtCreated.TabStop = False
        Me.dtCreated.Text = "March 27, 2023"
        Me.dtCreated.Value = New Date(2023, 3, 27, 2, 35, 5, 71)
        '
        'dtUpdated
        '
        Me.dtUpdated.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtUpdated.Location = New System.Drawing.Point(426, 158)
        Me.dtUpdated.Name = "dtUpdated"
        Me.dtUpdated.Size = New System.Drawing.Size(198, 24)
        Me.dtUpdated.TabIndex = 7
        Me.dtUpdated.TabStop = False
        Me.dtUpdated.Text = "March 27, 2023"
        Me.dtUpdated.Value = New Date(2023, 3, 27, 2, 35, 5, 71)
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(375, 128)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 8
        Me.RadLabel1.Text = "Created"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(371, 161)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(49, 18)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Updated"
        '
        'txtLabels
        '
        Me.txtLabels.EmbeddedLabelText = "Labels"
        Me.txtLabels.Location = New System.Drawing.Point(371, 188)
        Me.txtLabels.Multiline = True
        Me.txtLabels.Name = "txtLabels"
        '
        '
        '
        Me.txtLabels.RootElement.StretchVertically = True
        Me.txtLabels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLabels.ShowEmbeddedLabel = True
        Me.txtLabels.Size = New System.Drawing.Size(253, 51)
        Me.txtLabels.TabIndex = 3
        '
        'txtCarriers
        '
        Me.txtCarriers.EmbeddedLabelText = "Carriers"
        Me.txtCarriers.Location = New System.Drawing.Point(371, 245)
        Me.txtCarriers.Name = "txtCarriers"
        Me.txtCarriers.ShowEmbeddedLabel = True
        Me.txtCarriers.Size = New System.Drawing.Size(253, 42)
        Me.txtCarriers.TabIndex = 4
        '
        'txtClients
        '
        Me.txtClients.EmbeddedLabelText = "Clients"
        Me.txtClients.Location = New System.Drawing.Point(371, 293)
        Me.txtClients.Name = "txtClients"
        Me.txtClients.ShowEmbeddedLabel = True
        Me.txtClients.Size = New System.Drawing.Size(253, 42)
        Me.txtClients.TabIndex = 5
        '
        'txtFixVersion
        '
        Me.txtFixVersion.EmbeddedLabelText = "Release"
        Me.txtFixVersion.Location = New System.Drawing.Point(498, 341)
        Me.txtFixVersion.Multiline = True
        Me.txtFixVersion.Name = "txtFixVersion"
        '
        '
        '
        Me.txtFixVersion.RootElement.StretchVertically = True
        Me.txtFixVersion.ShowEmbeddedLabel = True
        Me.txtFixVersion.Size = New System.Drawing.Size(126, 69)
        Me.txtFixVersion.TabIndex = 5
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(371, 416)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(126, 24)
        Me.RadButton1.TabIndex = 10
        Me.RadButton1.Text = "RadButton1"
        '
        'txtPropRelease
        '
        Me.txtPropRelease.EmbeddedLabelText = "Proposed Release"
        Me.txtPropRelease.Location = New System.Drawing.Point(371, 341)
        Me.txtPropRelease.Name = "txtPropRelease"
        Me.txtPropRelease.ShowEmbeddedLabel = True
        Me.txtPropRelease.Size = New System.Drawing.Size(126, 42)
        Me.txtPropRelease.TabIndex = 5
        '
        'JIRADetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 528)
        Me.Controls.Add(Me.txtPropRelease)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.txtFixVersion)
        Me.Controls.Add(Me.txtClients)
        Me.Controls.Add(Me.txtCarriers)
        Me.Controls.Add(Me.txtLabels)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.dtUpdated)
        Me.Controls.Add(Me.dtCreated)
        Me.Controls.Add(Me.txtAssignee)
        Me.Controls.Add(Me.txtReporter)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.txtFLEXNb)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Name = "JIRADetails"
        Me.Shape = Me.RoundRectShapeForm
        Me.Text = "JIRADetails"
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFLEXNb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReporter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssignee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtUpdated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLabels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFixVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropRelease, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoundRectShapeForm As Telerik.WinControls.RoundRectShape
    Friend WithEvents RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents txtFLEXNb As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtSummary As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPriority As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtStatus As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtReporter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtAssignee As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtCreated As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtUpdated As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtLabels As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCarriers As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtClients As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtFixVersion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtPropRelease As Telerik.WinControls.UI.RadTextBox
End Class

