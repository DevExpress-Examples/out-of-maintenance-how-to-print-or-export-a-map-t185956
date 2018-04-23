using DevExpress.Utils.Menu;
using DevExpress.XtraMap;
using DevExpress.XtraPrinting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MapControl_PrintingExporting {
    public enum PrintType { Preview, RibbonPreview, Dialog };
    
    public partial class Form1 : Form {
        const string printButtonTextBase = "Show ";
        const string exportButtonTextBase = "Export to ";
        const string filepathBase = "Exported Map";

        PrintType printType = PrintType.Preview;
        ExportFormat exportFormat = ExportFormat.Image;
        
        Hashtable printHashtable = new Hashtable();
        Hashtable exportHashtable = new Hashtable();

        public Form1() {
            InitializeComponent();
            InitializePrintButton();
            InitializeExportButton();
            InitializeSizeModeComboBox();
        }

        #region #InitSizeModes
        void InitializeSizeModeComboBox() {
            cbSizeMode.DataSource = Enum.GetValues(typeof(MapPrintSizeMode));
        }
        #endregion #InitSizeModes
        
        void InitializePrintButton() {
            DXPopupMenu popup = new DXPopupMenu();
            DXMenuItem item = new DXMenuItem("Print Preview", printPopupItem_Click);
            printHashtable.Add(item, PrintType.Preview);
            popup.Items.Add(item);

            item = new DXMenuItem("Ribbon Print Preview", printPopupItem_Click);
            printHashtable.Add(item, PrintType.RibbonPreview);
            popup.Items.Add(item);

            item = new DXMenuItem("Print Dialog", printPopupItem_Click);
            printHashtable.Add(item, PrintType.Dialog);
            popup.Items.Add(item);

            ddbPrint.DropDownControl = popup;
            ddbPrint.Text = printButtonTextBase + printType.ToString();           
        }

        void InitializeExportButton() {
            DXPopupMenu popup = new DXPopupMenu();           

            DXMenuItem item = new DXMenuItem(ExportFormat.Image.ToString(), exportPopupItem_Click);
            exportHashtable.Add(item, ExportFormat.Image);
            popup.Items.Add(item);

            item = new DXMenuItem(ExportFormat.Mht.ToString(), exportPopupItem_Click);
            exportHashtable.Add(item, ExportFormat.Mht);
            popup.Items.Add(item);

            item = new DXMenuItem(ExportFormat.Pdf.ToString(), exportPopupItem_Click);
            exportHashtable.Add(item, ExportFormat.Pdf);
            popup.Items.Add(item);

            item = new DXMenuItem(ExportFormat.Xls.ToString(), exportPopupItem_Click);
            exportHashtable.Add(item, ExportFormat.Xls);
            popup.Items.Add(item);

            item = new DXMenuItem(ExportFormat.Xlsx.ToString(), exportPopupItem_Click);
            exportHashtable.Add(item, ExportFormat.Xlsx);
            popup.Items.Add(item);

            ddbExport.DropDownControl = popup;
            ddbExport.Text = exportButtonTextBase + exportFormat.ToString();
        }

        void printPopupItem_Click(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            ddbPrint.Text = printButtonTextBase + item.Caption;
            printType = (PrintType)printHashtable[item];
        }

        void exportPopupItem_Click(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            ddbExport.Text = exportButtonTextBase + item.Caption;
            exportFormat = (ExportFormat)exportHashtable[item];
        }

        #region #SizeModeChanged
        private void cbSizeMode_SelectedIndexChanged(object sender, EventArgs e) {
            MapPrintSizeMode mode = (MapPrintSizeMode)cbSizeMode.SelectedValue;
            mapControl.PrintOptions.SizeMode = mode;
        }
        #endregion #SizeModeChanged

        #region #Printing
        private void ddbPrint_Click(object sender, EventArgs e) {
            switch (printType) {
                case (PrintType.Preview):
                    mapControl.ShowPrintPreview();
                    break;
                case (PrintType.RibbonPreview):
                    mapControl.ShowRibbonPrintPreview();
                    break;
                case (PrintType.Dialog):
                    mapControl.ShowPrintDialog();
                    break;
            }
        }
        #endregion #Printing

        #region #Exporting
        private void ddbExport_Click(object sender, EventArgs e) {
            string filepath = filepathBase + exportFormat.ToString();
            switch (exportFormat) {
                case (ExportFormat.Image):
                    mapControl.ExportToImage(filepath, ImageFormat.Jpeg);
                    break;
                case (ExportFormat.Mht):
                    mapControl.ExportToMht(filepathBase);
                    break;
                case (ExportFormat.Pdf):
                    mapControl.ExportToPdf(filepathBase);
                    break;
                case (ExportFormat.Xls):
                    mapControl.ExportToXls(filepathBase);
                    break;
                case (ExportFormat.Xlsx):
                    mapControl.ExportToXlsx(filepathBase);
                    break;
                default:
                    MessageBox.Show("Export to a *" + exportFormat.ToString() + " file format is impossible.", "Export to " + exportFormat.ToString());
                    return;
            }

            MessageBox.Show("Export to a *" + exportFormat.ToString() + " file is done.", "Export to " + exportFormat.ToString());
        }
        #endregion #Exporting
    }
}
