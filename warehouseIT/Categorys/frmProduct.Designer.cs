
namespace warehouseIT.Category
{
    partial class frmProduct
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
        ///
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lbTenNhomHang = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Detail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Manufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGr_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProductGr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.lbTenNhomHang);
            this.layoutControl.Controls.Add(this.gridControl);
            resources.ApplyResources(this.layoutControl, "layoutControl");
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            // 
            // lbTenNhomHang
            // 
            this.lbTenNhomHang.AllowHtmlString = true;
            this.lbTenNhomHang.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbTenNhomHang.Appearance.Font")));
            this.lbTenNhomHang.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lbTenNhomHang.Appearance.Options.UseFont = true;
            this.lbTenNhomHang.Appearance.Options.UseForeColor = true;
            this.lbTenNhomHang.Appearance.Options.UseTextOptions = true;
            this.lbTenNhomHang.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lbTenNhomHang, "lbTenNhomHang");
            this.lbTenNhomHang.Name = "lbTenNhomHang";
            this.lbTenNhomHang.StyleController = this.layoutControl;
            // 
            // gridControl
            // 
            resources.ApplyResources(this.gridControl, "gridControl");
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_code,
            this.colProduct_Name,
            this.colProduct_Detail,
            this.colProduct_Manufacturer,
            this.colProduct_Unit,
            this.colProduct_Country,
            this.colUserInsert,
            this.colDateInsert,
            this.colIDNhomHang,
            this.colProductGr_name,
            this.colIDProductGr,
            this.colProduct_Price});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 30;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colProduct_code
            // 
            this.colProduct_code.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_code, "colProduct_code");
            this.colProduct_code.FieldName = "Product_Code";
            this.colProduct_code.Name = "colProduct_code";
            this.colProduct_code.OptionsColumn.AllowEdit = false;
            this.colProduct_code.OptionsColumn.AllowFocus = false;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_Name, "colProduct_Name");
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.AllowEdit = false;
            this.colProduct_Name.OptionsColumn.AllowFocus = false;
            // 
            // colProduct_Detail
            // 
            this.colProduct_Detail.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Detail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_Detail, "colProduct_Detail");
            this.colProduct_Detail.FieldName = "Product_Detail";
            this.colProduct_Detail.Name = "colProduct_Detail";
            // 
            // colProduct_Manufacturer
            // 
            this.colProduct_Manufacturer.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Manufacturer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_Manufacturer, "colProduct_Manufacturer");
            this.colProduct_Manufacturer.FieldName = "Product_Manufacturer";
            this.colProduct_Manufacturer.Name = "colProduct_Manufacturer";
            // 
            // colProduct_Unit
            // 
            this.colProduct_Unit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_Unit, "colProduct_Unit");
            this.colProduct_Unit.FieldName = "Product_Unit";
            this.colProduct_Unit.Name = "colProduct_Unit";
            // 
            // colProduct_Country
            // 
            this.colProduct_Country.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Country.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct_Country, "colProduct_Country");
            this.colProduct_Country.FieldName = "Product_Country";
            this.colProduct_Country.Name = "colProduct_Country";
            // 
            // colUserInsert
            // 
            this.colUserInsert.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserInsert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colUserInsert, "colUserInsert");
            this.colUserInsert.FieldName = "UserInsert";
            this.colUserInsert.Name = "colUserInsert";
            this.colUserInsert.OptionsColumn.AllowEdit = false;
            this.colUserInsert.OptionsColumn.AllowFocus = false;
            // 
            // colDateInsert
            // 
            this.colDateInsert.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateInsert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colDateInsert, "colDateInsert");
            this.colDateInsert.FieldName = "DateInsert";
            this.colDateInsert.Name = "colDateInsert";
            this.colDateInsert.OptionsColumn.AllowEdit = false;
            this.colDateInsert.OptionsColumn.AllowFocus = false;
            // 
            // colIDNhomHang
            // 
            this.colIDNhomHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDNhomHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colIDNhomHang, "colIDNhomHang");
            this.colIDNhomHang.FieldName = "IDProductGr";
            this.colIDNhomHang.Name = "colIDNhomHang";
            this.colIDNhomHang.OptionsColumn.AllowEdit = false;
            this.colIDNhomHang.OptionsColumn.AllowFocus = false;
            // 
            // colProductGr_name
            // 
            this.colProductGr_name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGr_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProductGr_name, "colProductGr_name");
            this.colProductGr_name.FieldName = "ProductGr_Name";
            this.colProductGr_name.Name = "colProductGr_name";
            // 
            // colIDProductGr
            // 
            resources.ApplyResources(this.colIDProductGr, "colIDProductGr");
            this.colIDProductGr.FieldName = "IDProduct";
            this.colIDProductGr.Name = "colIDProductGr";
            // 
            // colProduct_Price
            // 
            resources.ApplyResources(this.colProduct_Price, "colProduct_Price");
            this.colProduct_Price.FieldName = "Product_Price";
            this.colProduct_Price.Name = "colProduct_Price";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.itemGrid});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(1251, 622);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.lbTenNhomHang;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(1231, 34);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.Location = new System.Drawing.Point(0, 34);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(1231, 588);
            this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.itemGrid.TextVisible = false;
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta")));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta")));
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta")));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "New;Size32x32;GrayScaled";
            windowsUIButtonImageOptions2.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            windowsUIButtonImageOptions3.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
            windowsUIButtonImageOptions4.ImageUri.Uri = "Refresh;Size32x32;GrayScaled";
            windowsUIButtonImageOptions5.ImageUri.Uri = "Preview;Size32x32;GrayScaled";
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons1"))), windowsUIButtonImageOptions1, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons2"))), resources.GetString("windowsUIButtonPanel.Buttons3"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons4"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons5"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons6"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons7"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons8"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons9"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons10"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons11"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons12")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons13"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons14"))), windowsUIButtonImageOptions2, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons15"))), resources.GetString("windowsUIButtonPanel.Buttons16"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons17"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons18"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons19"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons20"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons21"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons22"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons23"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons24"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons25")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons26"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons27"))), windowsUIButtonImageOptions3, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons28"))), resources.GetString("windowsUIButtonPanel.Buttons29"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons30"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons31"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons32"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons33"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons34"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons35"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons36"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons37"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons38")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons39"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons40"))), windowsUIButtonImageOptions4, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons41"))), resources.GetString("windowsUIButtonPanel.Buttons42"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons43"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons44"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons45"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons46"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons47"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons48"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons49"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons50"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons51")))),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons52"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons53"))), windowsUIButtonImageOptions5, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons54"))), resources.GetString("windowsUIButtonPanel.Buttons55"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons56"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons57"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons58"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons59"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons60"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons61"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons62"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons63"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons64"))))});
            resources.ApplyResources(this.windowsUIButtonPanel, "windowsUIButtonPanel");
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // frmProduct
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Name = "frmProduct";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lbTenNhomHang;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_code;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUserInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colDateInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Detail;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Manufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Country;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGr_name;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProductGr;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Price;
    }
}