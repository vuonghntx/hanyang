
namespace warehouseIT
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.txtBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_Code = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Manufacturer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Country = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDepot_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLotNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Unit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBanTonDau = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantityH = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNXTK = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantityIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colquantityOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.collTonCuoi = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantityEnd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnFind);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEndDate);
            this.groupControl1.Controls.Add(this.txtBeginDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1573, 57);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TỔNG HỢP NHẬP XUẤT TỒN";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(982, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(58, 20);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(918, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(58, 20);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(729, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày kết thúc";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(554, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ngày bắt đầu";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndDate.EditValue = null;
            this.txtEndDate.Location = new System.Drawing.Point(802, 26);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 0;
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBeginDate.EditValue = null;
            this.txtBeginDate.Location = new System.Drawing.Point(623, 26);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBeginDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtBeginDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtBeginDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtBeginDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtBeginDate.Size = new System.Drawing.Size(100, 20);
            this.txtBeginDate.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1573, 677);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.colBanTonDau,
            this.colNXTK,
            this.collTonCuoi});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_Code,
            this.colProduct_Name,
            this.colProduct_Manufacturer,
            this.colProduct_Country,
            this.colProduct_Unit,
            this.colLotNumber,
            this.colDepot_Name,
            this.colquantityIn,
            this.colquantityOut,
            this.colquantityH,
            this.colquantityEnd});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowFooter = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Thông tin chung";
            this.gridBand2.Columns.Add(this.colProduct_Code);
            this.gridBand2.Columns.Add(this.colProduct_Name);
            this.gridBand2.Columns.Add(this.colProduct_Manufacturer);
            this.gridBand2.Columns.Add(this.colProduct_Country);
            this.gridBand2.Columns.Add(this.colDepot_Name);
            this.gridBand2.Columns.Add(this.colLotNumber);
            this.gridBand2.Columns.Add(this.colProduct_Unit);
            this.gridBand2.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 607;
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Mã hàng";
            this.colProduct_Code.FieldName = "Product_Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.Width = 95;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 95;
            // 
            // colProduct_Manufacturer
            // 
            this.colProduct_Manufacturer.Caption = "Nhà sản xuất";
            this.colProduct_Manufacturer.FieldName = "Product_Manufacturer";
            this.colProduct_Manufacturer.Name = "colProduct_Manufacturer";
            this.colProduct_Manufacturer.Visible = true;
            this.colProduct_Manufacturer.Width = 95;
            // 
            // colProduct_Country
            // 
            this.colProduct_Country.Caption = "Nước sản xuất";
            this.colProduct_Country.FieldName = "Product_Country";
            this.colProduct_Country.Name = "colProduct_Country";
            this.colProduct_Country.Visible = true;
            this.colProduct_Country.Width = 97;
            // 
            // colDepot_Name
            // 
            this.colDepot_Name.Caption = "Kho hàng";
            this.colDepot_Name.FieldName = "Depot_Name";
            this.colDepot_Name.Name = "colDepot_Name";
            this.colDepot_Name.Visible = true;
            // 
            // colLotNumber
            // 
            this.colLotNumber.Caption = "Lô hàng";
            this.colLotNumber.FieldName = "LotNumber";
            this.colLotNumber.Name = "colLotNumber";
            this.colLotNumber.Visible = true;
            // 
            // colProduct_Unit
            // 
            this.colProduct_Unit.Caption = "Đơn vị tính";
            this.colProduct_Unit.FieldName = "Product_Unit";
            this.colProduct_Unit.Name = "colProduct_Unit";
            this.colProduct_Unit.Visible = true;
            // 
            // colBanTonDau
            // 
            this.colBanTonDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colBanTonDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBanTonDau.Caption = "Tồn đầu";
            this.colBanTonDau.Columns.Add(this.colquantityH);
            this.colBanTonDau.Name = "colBanTonDau";
            this.colBanTonDau.VisibleIndex = 1;
            this.colBanTonDau.Width = 75;
            // 
            // colquantityH
            // 
            this.colquantityH.Caption = "Số lượng";
            this.colquantityH.ColumnEdit = this.repositoryItemTextEdit1;
            this.colquantityH.FieldName = "quantityH";
            this.colquantityH.Name = "colquantityH";
            this.colquantityH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantityH", "SUM={0:#,#}")});
            this.colquantityH.Visible = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colNXTK
            // 
            this.colNXTK.AppearanceHeader.Options.UseTextOptions = true;
            this.colNXTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNXTK.Caption = "Nhập xuất trong kỳ";
            this.colNXTK.Columns.Add(this.colquantityIn);
            this.colNXTK.Columns.Add(this.colquantityOut);
            this.colNXTK.Name = "colNXTK";
            this.colNXTK.VisibleIndex = 2;
            this.colNXTK.Width = 150;
            // 
            // colquantityIn
            // 
            this.colquantityIn.Caption = "Lượng nhập";
            this.colquantityIn.ColumnEdit = this.repositoryItemTextEdit1;
            this.colquantityIn.FieldName = "quantityIn";
            this.colquantityIn.Name = "colquantityIn";
            this.colquantityIn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantityIn", "SUM={0:#,#}")});
            this.colquantityIn.Visible = true;
            // 
            // colquantityOut
            // 
            this.colquantityOut.Caption = "Lượng xuất";
            this.colquantityOut.ColumnEdit = this.repositoryItemTextEdit1;
            this.colquantityOut.FieldName = "quantityOut";
            this.colquantityOut.Name = "colquantityOut";
            this.colquantityOut.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantityOut", "SUM={0:#,#}")});
            this.colquantityOut.Visible = true;
            // 
            // collTonCuoi
            // 
            this.collTonCuoi.AppearanceHeader.Options.UseTextOptions = true;
            this.collTonCuoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.collTonCuoi.Caption = "Tồn cuối";
            this.collTonCuoi.Columns.Add(this.colquantityEnd);
            this.collTonCuoi.Name = "collTonCuoi";
            this.collTonCuoi.VisibleIndex = 3;
            this.collTonCuoi.Width = 75;
            // 
            // colquantityEnd
            // 
            this.colquantityEnd.Caption = "Số lượng";
            this.colquantityEnd.ColumnEdit = this.repositoryItemTextEdit1;
            this.colquantityEnd.FieldName = "quantityEnd";
            this.colquantityEnd.Name = "colquantityEnd";
            this.colquantityEnd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantityEnd", "SUM={0:#,#}")});
            this.colquantityEnd.Visible = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hàng";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên hàng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhà sản xuất";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nước sản xuất";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 734);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtEndDate;
        private DevExpress.XtraEditors.DateEdit txtBeginDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Code;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Manufacturer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Country;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDepot_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLotNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Unit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantityEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantityIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantityOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantityH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand colBanTonDau;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand colNXTK;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand collTonCuoi;
    }
}