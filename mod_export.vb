Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module mod_export



    Sub SavePDFDialog()
        frmViewResto.txtStatus.Text = frmViewResto.txtStatus.Text + " exporting"
        frmViewResto.SaveFileDialog1.ShowDialog()
        If frmViewResto.SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            '' ExportDataToPDFTable()
            exportPDF()

            frmViewResto.txtStatus.Text = frmViewResto.txtStatus.Text + " PDF Created. "
            MsgBox("PDF Created Successfully")
        End If
    End Sub


    Sub exportPDF()
        frmViewResto.txtStatus.Text = "STATUS : "



        '' DataGridView1.DataSource = PopulateDataGridViewResto()
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(frmViewResto.DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        ''Label2.Text = "Adding header row"

        'Adding Header row
        For Each column As DataGridViewColumn In frmViewResto.DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            '' cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        ''Label2.Text = "Adding data row"

        'Adding DataRow
        For Each row As DataGridViewRow In frmViewResto.DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If row.IsNewRow Then Continue For

                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        ''Label2.Text = "Exporting pdf"

        'Exporting to PDF
        Dim folderPath As String = "C:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(folderPath & "DataGridViewExport.pdf", FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub










End Module
