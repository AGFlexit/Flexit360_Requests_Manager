Imports Telerik.WinControls

Public Class ShapedForm2
    Private Sub ShapedForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Issues' table. You can move, or remove it, as needed.
        Me.IssuesTableAdapter.Fill(Me.ProdSupport_DataSet.Issues)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Contacts' table. You can move, or remove it, as needed.
        Me.ContactsTableAdapter.Fill(Me.ProdSupport_DataSet.Contacts)
        Dim fontName As String = TelerikWebUIFont.Name
        'Dim glyphText As String =
        Me.RadButtonElement1.Text = ChrW(&HF08D).ToString()
        'Me.RadButtonElement1.Text = Telerik.WinControls.fon
        'TelerikWebUIFont.GlyphDownload

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        'ShapedForm1.AnalystsTableAdapter.ClearBeforeFill = True
        'ShapedForm1.Contacts_ExtendedTableAdapter.ClearBeforeFill = True
        Main.AnalystsTableAdapter.Fill(ProdSupport_DataSet.Analysts)
        Main.Contacts_ExtendedTableAdapter.Fill(ProdSupport_DataSet.Contacts_Extended)
        Main.RadGridView1.Refresh()
        Me.Close()
    End Sub

    Private Sub RadRichTextEditor1_Leave(sender As Object, e As EventArgs) Handles RadRichTextEditor1.Leave
        Dim poo As String = Me.RadRichTextEditor1.Document.ToString
    End Sub
End Class
