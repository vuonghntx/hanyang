
namespace warehouseIT.SystemsAdmin
{
    partial class frmPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermission));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridDSChucNang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collIDQCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collIDUserGr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collMenu_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collIDPermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTenNhomHang = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            resources.ApplyResources(this.layoutControl, "layoutControl");
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.gridDSChucNang);
            this.layoutControl.Controls.Add(this.lbTenNhomHang);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            // 
            // gridDSChucNang
            // 
            resources.ApplyResources(this.gridDSChucNang, "gridDSChucNang");
            this.gridDSChucNang.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridDSChucNang.EmbeddedNavigator.AccessibleDescription");
            this.gridDSChucNang.EmbeddedNavigator.AccessibleName = resources.GetString("gridDSChucNang.EmbeddedNavigator.AccessibleName");
            this.gridDSChucNang.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridDSChucNang.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.Anchor")));
            this.gridDSChucNang.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.BackgroundImage")));
            this.gridDSChucNang.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridDSChucNang.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.ImeMode")));
            this.gridDSChucNang.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.MaximumSize")));
            this.gridDSChucNang.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.TextLocation")));
            this.gridDSChucNang.EmbeddedNavigator.ToolTip = resources.GetString("gridDSChucNang.EmbeddedNavigator.ToolTip");
            this.gridDSChucNang.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridDSChucNang.EmbeddedNavigator.ToolTipIconType")));
            this.gridDSChucNang.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridDSChucNang.EmbeddedNavigator.ToolTipTitle");
            this.gridDSChucNang.MainView = this.gridView2;
            this.gridDSChucNang.Name = "gridDSChucNang";
            this.gridDSChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            resources.ApplyResources(this.gridView2, "gridView2");
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuyen,
            this.gridColumn4,
            this.collIDQCT,
            this.collIDUserGr,
            this.collMenu_Name,
            this.collIDPermission});
            this.gridView2.GridControl = this.gridDSChucNang;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.collMenu_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // colQuyen
            // 
            resources.ApplyResources(this.colQuyen, "colQuyen");
            this.colQuyen.FieldName = "Permission_Name";
            this.colQuyen.Name = "colQuyen";
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.FieldName = "IsActive";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // collIDQCT
            // 
            resources.ApplyResources(this.collIDQCT, "collIDQCT");
            this.collIDQCT.FieldName = "IDQCT";
            this.collIDQCT.Name = "collIDQCT";
            // 
            // collIDUserGr
            // 
            resources.ApplyResources(this.collIDUserGr, "collIDUserGr");
            this.collIDUserGr.FieldName = "IDUserGr";
            this.collIDUserGr.Name = "collIDUserGr";
            // 
            // collMenu_Name
            // 
            resources.ApplyResources(this.collMenu_Name, "collMenu_Name");
            this.collMenu_Name.FieldName = "Menu_Name";
            this.collMenu_Name.Name = "collMenu_Name";
            // 
            // collIDPermission
            // 
            resources.ApplyResources(this.collIDPermission, "collIDPermission");
            this.collIDPermission.FieldName = "IDPermission";
            this.collIDPermission.Name = "collIDPermission";
            // 
            // lbTenNhomHang
            // 
            resources.ApplyResources(this.lbTenNhomHang, "lbTenNhomHang");
            this.lbTenNhomHang.AllowHtmlString = true;
            this.lbTenNhomHang.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbTenNhomHang.Appearance.Font")));
            this.lbTenNhomHang.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lbTenNhomHang.Appearance.Options.UseFont = true;
            this.lbTenNhomHang.Appearance.Options.UseForeColor = true;
            this.lbTenNhomHang.Appearance.Options.UseTextOptions = true;
            this.lbTenNhomHang.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lbTenNhomHang.Name = "lbTenNhomHang";
            this.lbTenNhomHang.StyleController = this.layoutControl;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.layoutControlItem1});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(1114, 667);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            resources.ApplyResources(this.itemLabel, "itemLabel");
            this.itemLabel.Control = this.lbTenNhomHang;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(1094, 34);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Control = this.gridDSChucNang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1094, 633);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmPermission
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "frmPermission";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lbTenNhomHang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraGrid.GridControl gridDSChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn collIDQCT;
        private DevExpress.XtraGrid.Columns.GridColumn collIDUserGr;
        private DevExpress.XtraGrid.Columns.GridColumn collMenu_Name;
        private DevExpress.XtraGrid.Columns.GridColumn collIDPermission;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}