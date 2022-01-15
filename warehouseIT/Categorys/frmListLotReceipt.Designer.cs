
namespace warehouseIT.Category
{
    partial class frmListLotReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLotReceipt));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lbTenNhomHang = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateProduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDListLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl);
            this.groupControl2.Controls.Add(this.windowsUIButtonPanel);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
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
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSerial,
            this.colDateProduction,
            this.colDetail,
            this.colUserInsert,
            this.colDateInsert,
            this.colIDListLot,
            this.colLotNumber});
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
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colSerial
            // 
            this.colSerial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colSerial, "colSerial");
            this.colSerial.FieldName = "Serial";
            this.colSerial.Name = "colSerial";
            this.colSerial.OptionsColumn.AllowEdit = false;
            this.colSerial.OptionsColumn.AllowFocus = false;
            // 
            // colDateProduction
            // 
            this.colDateProduction.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateProduction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colDateProduction, "colDateProduction");
            this.colDateProduction.FieldName = "DateProduction";
            this.colDateProduction.Name = "colDateProduction";
            this.colDateProduction.OptionsColumn.AllowEdit = false;
            this.colDateProduction.OptionsColumn.AllowFocus = false;
            // 
            // colDetail
            // 
            resources.ApplyResources(this.colDetail, "colDetail");
            this.colDetail.FieldName = "Detail";
            this.colDetail.Name = "colDetail";
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
            // colIDListLot
            // 
            this.colIDListLot.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDListLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colIDListLot, "colIDListLot");
            this.colIDListLot.FieldName = "IDLot";
            this.colIDListLot.Name = "colIDListLot";
            this.colIDListLot.OptionsColumn.AllowEdit = false;
            this.colIDListLot.OptionsColumn.AllowFocus = false;
            // 
            // colLotNumber
            // 
            resources.ApplyResources(this.colLotNumber, "colLotNumber");
            this.colLotNumber.FieldName = "LotNumber";
            this.colLotNumber.Name = "colLotNumber";
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
            this.layoutControlGroup.Size = new System.Drawing.Size(520, 412);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.lbTenNhomHang;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(500, 34);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.Location = new System.Drawing.Point(0, 34);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(500, 378);
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
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons1"))), windowsUIButtonImageOptions1, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons2"))), resources.GetString("windowsUIButtonPanel.Buttons3"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons4"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons5"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons6"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons7"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons8"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons9"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons10"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons11"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons12")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons13"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons14"))), windowsUIButtonImageOptions2, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons15"))), resources.GetString("windowsUIButtonPanel.Buttons16"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons17"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons18"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons19"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons20"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons21"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons22"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons23"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons24"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons25")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons26"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons27"))), windowsUIButtonImageOptions3, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons28"))), resources.GetString("windowsUIButtonPanel.Buttons29"), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons30"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons31"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons32"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons33"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons34"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons35"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons36"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons37"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons38"))))});
            resources.ApplyResources(this.windowsUIButtonPanel, "windowsUIButtonPanel");
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // frmListLotReceipt
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmListLotReceipt";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lbTenNhomHang;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colDateProduction;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colUserInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colDateInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colIDListLot;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNumber;
    }
}