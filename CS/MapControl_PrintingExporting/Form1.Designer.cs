namespace MapControl_PrintingExporting {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageTilesLayer3 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider3 = new DevExpress.XtraMap.BingMapDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ddbPrint = new DevExpress.XtraEditors.DropDownButton();
            this.ddbExport = new DevExpress.XtraEditors.DropDownButton();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbSizeMode = new System.Windows.Forms.ComboBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbSizeMode);
            this.layoutControl1.Controls.Add(this.ddbPrint);
            this.layoutControl1.Controls.Add(this.ddbExport);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(818, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ddbPrint
            // 
            this.ddbPrint.Location = new System.Drawing.Point(555, 12);
            this.ddbPrint.Name = "ddbPrint";
            this.ddbPrint.Size = new System.Drawing.Size(116, 22);
            this.ddbPrint.StyleController = this.layoutControl1;
            this.ddbPrint.TabIndex = 8;
            this.ddbPrint.Text = "dropDownButton1";
            this.ddbPrint.Click += new System.EventHandler(this.ddbPrint_Click);
            // 
            // ddbExport
            // 
            this.ddbExport.Location = new System.Drawing.Point(675, 12);
            this.ddbExport.Name = "ddbExport";
            this.ddbExport.Size = new System.Drawing.Size(131, 22);
            this.ddbExport.StyleController = this.layoutControl1;
            this.ddbExport.TabIndex = 5;
            this.ddbExport.Text = "dropDownButton1";
            this.ddbExport.Click += new System.EventHandler(this.ddbExport_Click);
            // 
            // mapControl
            // 
            imageTilesLayer3.DataProvider = bingMapDataProvider3;
            this.mapControl.Layers.Add(imageTilesLayer3);
            this.mapControl.Location = new System.Drawing.Point(12, 38);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(794, 476);
            this.mapControl.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(818, 526);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(798, 480);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ddbExport;
            this.layoutControlItem2.Location = new System.Drawing.Point(663, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(135, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ddbPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(543, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // cbSizeMode
            // 
            this.cbSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeMode.FormattingEnabled = true;
            this.cbSizeMode.Location = new System.Drawing.Point(67, 12);
            this.cbSizeMode.Name = "cbSizeMode";
            this.cbSizeMode.Size = new System.Drawing.Size(484, 21);
            this.cbSizeMode.TabIndex = 9;
            this.cbSizeMode.SelectedIndexChanged += new System.EventHandler(this.cbSizeMode_SelectedIndexChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbSizeMode;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(543, 26);
            this.layoutControlItem4.Text = "Size Mode:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 526);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "MapControl Printing Exporting Example";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DropDownButton ddbExport;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DropDownButton ddbPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox cbSizeMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}

