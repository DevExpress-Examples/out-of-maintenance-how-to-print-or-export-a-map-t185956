Namespace MapControl_PrintingExporting
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer3 As New DevExpress.XtraMap.ImageLayer()
            Dim bingMapDataProvider3 As New DevExpress.XtraMap.BingMapDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ddbPrint = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbExport = New DevExpress.XtraEditors.DropDownButton()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cbSizeMode = New System.Windows.Forms.ComboBox()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbSizeMode)
            Me.layoutControl1.Controls.Add(Me.ddbPrint)
            Me.layoutControl1.Controls.Add(Me.ddbExport)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(818, 526)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ddbPrint
            ' 
            Me.ddbPrint.Location = New System.Drawing.Point(555, 12)
            Me.ddbPrint.Name = "ddbPrint"
            Me.ddbPrint.Size = New System.Drawing.Size(116, 22)
            Me.ddbPrint.StyleController = Me.layoutControl1
            Me.ddbPrint.TabIndex = 8
            Me.ddbPrint.Text = "dropDownButton1"
            ' 
            ' ddbExport
            ' 
            Me.ddbExport.Location = New System.Drawing.Point(675, 12)
            Me.ddbExport.Name = "ddbExport"
            Me.ddbExport.Size = New System.Drawing.Size(131, 22)
            Me.ddbExport.StyleController = Me.layoutControl1
            Me.ddbExport.TabIndex = 5
            Me.ddbExport.Text = "dropDownButton1"
            ' 
            ' mapControl
            ' 
            imageTilesLayer3.DataProvider = bingMapDataProvider3
            Me.mapControl.Layers.Add(imageTilesLayer3)
            Me.mapControl.Location = New System.Drawing.Point(12, 38)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(794, 476)
            Me.mapControl.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(818, 526)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(798, 480)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ddbExport
            Me.layoutControlItem2.Location = New System.Drawing.Point(663, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(135, 26)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ddbPrint
            Me.layoutControlItem3.Location = New System.Drawing.Point(543, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(120, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' cbSizeMode
            ' 
            Me.cbSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSizeMode.FormattingEnabled = True
            Me.cbSizeMode.Location = New System.Drawing.Point(67, 12)
            Me.cbSizeMode.Name = "cbSizeMode"
            Me.cbSizeMode.Size = New System.Drawing.Size(484, 21)
            Me.cbSizeMode.TabIndex = 9
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbSizeMode
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(543, 26)
            Me.layoutControlItem4.Text = "Size Mode:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(52, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(818, 526)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "MapControl Printing Exporting Example"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents ddbExport As DevExpress.XtraEditors.DropDownButton
        Private mapControl As DevExpress.XtraMap.MapControl
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents ddbPrint As DevExpress.XtraEditors.DropDownButton
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents cbSizeMode As System.Windows.Forms.ComboBox
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace

