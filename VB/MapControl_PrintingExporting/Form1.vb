Imports DevExpress.Utils.Menu
Imports DevExpress.XtraMap
Imports DevExpress.XtraPrinting
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Namespace MapControl_PrintingExporting
    Public Enum PrintType
        Preview
        RibbonPreview
        Dialog
    End Enum

    Partial Public Class Form1
        Inherits Form

        Private Const printButtonTextBase As String = "Show "
        Private Const exportButtonTextBase As String = "Export to "
        Private Const filepathBase As String = "Exported Map"

        Private printType As PrintType = MapControl_PrintingExporting.PrintType.Preview
        Private exportFormat As ExportFormat = ExportFormat.Image

        Private printHashtable As New Hashtable()
        Private exportHashtable As New Hashtable()

        Public Sub New()
            InitializeComponent()
            InitializePrintButton()
            InitializeExportButton()
            InitializeSizeModeComboBox()
        End Sub

        #Region "#InitSizeModes"
        Private Sub InitializeSizeModeComboBox()
            cbSizeMode.DataSource = System.Enum.GetValues(GetType(MapPrintSizeMode))
        End Sub
        #End Region ' #InitSizeModes

        Private Sub InitializePrintButton()
            Dim popup As New DXPopupMenu()
            Dim item As New DXMenuItem("Print Preview", AddressOf printPopupItem_Click)
            printHashtable.Add(item, MapControl_PrintingExporting.PrintType.Preview)
            popup.Items.Add(item)

            item = New DXMenuItem("Ribbon Print Preview", AddressOf printPopupItem_Click)
            printHashtable.Add(item, MapControl_PrintingExporting.PrintType.RibbonPreview)
            popup.Items.Add(item)

            item = New DXMenuItem("Print Dialog", AddressOf printPopupItem_Click)
            printHashtable.Add(item, MapControl_PrintingExporting.PrintType.Dialog)
            popup.Items.Add(item)

            ddbPrint.DropDownControl = popup
            ddbPrint.Text = printButtonTextBase & printType.ToString()
        End Sub

        Private Sub InitializeExportButton()
            Dim popup As New DXPopupMenu()

            Dim item As New DXMenuItem(ExportFormat.Image.ToString(), AddressOf exportPopupItem_Click)
            exportHashtable.Add(item, ExportFormat.Image)
            popup.Items.Add(item)

            item = New DXMenuItem(ExportFormat.Mht.ToString(), AddressOf exportPopupItem_Click)
            exportHashtable.Add(item, ExportFormat.Mht)
            popup.Items.Add(item)

            item = New DXMenuItem(ExportFormat.Pdf.ToString(), AddressOf exportPopupItem_Click)
            exportHashtable.Add(item, ExportFormat.Pdf)
            popup.Items.Add(item)

            item = New DXMenuItem(ExportFormat.Xls.ToString(), AddressOf exportPopupItem_Click)
            exportHashtable.Add(item, ExportFormat.Xls)
            popup.Items.Add(item)

            item = New DXMenuItem(ExportFormat.Xlsx.ToString(), AddressOf exportPopupItem_Click)
            exportHashtable.Add(item, ExportFormat.Xlsx)
            popup.Items.Add(item)

            ddbExport.DropDownControl = popup
            ddbExport.Text = exportButtonTextBase & exportFormat.ToString()
        End Sub

        Private Sub printPopupItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
            ddbPrint.Text = printButtonTextBase & item.Caption
            printType = DirectCast(printHashtable(item), PrintType)
        End Sub

        Private Sub exportPopupItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
            ddbExport.Text = exportButtonTextBase & item.Caption
            exportFormat = DirectCast(exportHashtable(item), ExportFormat)
        End Sub

        #Region "#SizeModeChanged"
        Private Sub cbSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSizeMode.SelectedIndexChanged
            Dim mode As MapPrintSizeMode = DirectCast(cbSizeMode.SelectedValue, MapPrintSizeMode)
            mapControl.PrintOptions.SizeMode = mode
        End Sub
        #End Region ' #SizeModeChanged

        #Region "#Printing"
        Private Sub ddbPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ddbPrint.Click
            Select Case printType
                Case (MapControl_PrintingExporting.PrintType.Preview)
                    mapControl.ShowPrintPreview()
                Case (MapControl_PrintingExporting.PrintType.RibbonPreview)
                    mapControl.ShowRibbonPrintPreview()
                Case (MapControl_PrintingExporting.PrintType.Dialog)
                    mapControl.ShowPrintDialog()
            End Select
        End Sub
        #End Region ' #Printing

        #Region "#Exporting"
        Private Sub ddbExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ddbExport.Click
            Dim filepath As String = filepathBase & exportFormat.ToString()
            Select Case exportFormat
                Case (ExportFormat.Image)
                    mapControl.ExportToImage(filepath, ImageFormat.Jpeg)
                Case (ExportFormat.Mht)
                    mapControl.ExportToMht(filepathBase)
                Case (ExportFormat.Pdf)
                    mapControl.ExportToPdf(filepathBase)
                Case (ExportFormat.Xls)
                    mapControl.ExportToXls(filepathBase)
                Case (ExportFormat.Xlsx)
                    mapControl.ExportToXlsx(filepathBase)
                Case Else
                    MessageBox.Show("Export to a *" & exportFormat.ToString() & " file format is impossible.", "Export to " & exportFormat.ToString())
                    Return
            End Select

            MessageBox.Show("Export to a *" & exportFormat.ToString() & " file is done.", "Export to " & exportFormat.ToString())
        End Sub
        #End Region ' #Exporting
    End Class
End Namespace
