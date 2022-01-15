
namespace warehouseIT.Category
{
    partial class frmProduct_Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct_Action));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridNhomHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtNuocSanXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtHangSanXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbMaHang = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgTenHang = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbMoTa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbNhaSX = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbNuocSX = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbDvt = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbDonGia = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbNhomhang = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.lbTieuDe = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgTenHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMoTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNhaSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNuocSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNhomhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridNhomHang);
            this.dataLayoutControl1.Controls.Add(this.txtDonGia);
            this.dataLayoutControl1.Controls.Add(this.txtDonViTinh);
            this.dataLayoutControl1.Controls.Add(this.txtNuocSanXuat);
            this.dataLayoutControl1.Controls.Add(this.txtHangSanXuat);
            this.dataLayoutControl1.Controls.Add(this.txtMoTa);
            this.dataLayoutControl1.Controls.Add(this.txtTenHang);
            this.dataLayoutControl1.Controls.Add(this.txtMaHang);
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1012, 240, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            // 
            // gridNhomHang
            // 
            resources.ApplyResources(this.gridNhomHang, "gridNhomHang");
            this.gridNhomHang.Name = "gridNhomHang";
            this.gridNhomHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("gridNhomHang.Properties.Buttons"))))});
            this.gridNhomHang.Properties.DisplayMember = "ProductGr_Name";
            this.gridNhomHang.Properties.NullText = resources.GetString("gridNhomHang.Properties.NullText");
            this.gridNhomHang.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridNhomHang.Properties.ValueMember = "IDProductGr";
            this.gridNhomHang.StyleController = this.dataLayoutControl1;
            this.gridNhomHang.EditValueChanged += new System.EventHandler(this.gridNhomHang_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ProductGr_Name";
            this.gridColumn1.Name = "gridColumn1";
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            // 
            // txtDonGia
            // 
            resources.ApplyResources(this.txtDonGia, "txtDonGia");
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Mask.EditMask = resources.GetString("txtDonGia.Properties.Mask.EditMask");
            this.txtDonGia.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtDonGia.Properties.Mask.MaskType")));
            this.txtDonGia.StyleController = this.dataLayoutControl1;
            // 
            // txtDonViTinh
            // 
            resources.ApplyResources(this.txtDonViTinh, "txtDonViTinh");
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.StyleController = this.dataLayoutControl1;
            // 
            // txtNuocSanXuat
            // 
            resources.ApplyResources(this.txtNuocSanXuat, "txtNuocSanXuat");
            this.txtNuocSanXuat.Name = "txtNuocSanXuat";
            this.txtNuocSanXuat.StyleController = this.dataLayoutControl1;
            // 
            // txtHangSanXuat
            // 
            resources.ApplyResources(this.txtHangSanXuat, "txtHangSanXuat");
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.StyleController = this.dataLayoutControl1;
            // 
            // txtMoTa
            // 
            resources.ApplyResources(this.txtMoTa, "txtMoTa");
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.StyleController = this.dataLayoutControl1;
            // 
            // txtTenHang
            // 
            resources.ApplyResources(this.txtTenHang, "txtTenHang");
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.StyleController = this.dataLayoutControl1;
            // 
            // txtMaHang
            // 
            resources.ApplyResources(this.txtMaHang, "txtMaHang");
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.StyleController = this.dataLayoutControl1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbMaHang,
            this.emptySpaceItem1,
            this.lgTenHang,
            this.lbMoTa,
            this.lbNhaSX,
            this.lbNuocSX,
            this.lbDvt,
            this.lbDonGia,
            this.lbNhomhang});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(464, 224);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbMaHang
            // 
            this.lbMaHang.Control = this.txtMaHang;
            this.lbMaHang.Location = new System.Drawing.Point(0, 0);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbMaHang, "lbMaHang");
            this.lbMaHang.TextSize = new System.Drawing.Size(70, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 192);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(444, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgTenHang
            // 
            this.lgTenHang.Control = this.txtTenHang;
            this.lgTenHang.Location = new System.Drawing.Point(0, 24);
            this.lgTenHang.Name = "lgTenHang";
            this.lgTenHang.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lgTenHang, "lgTenHang");
            this.lgTenHang.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbMoTa
            // 
            this.lbMoTa.Control = this.txtMoTa;
            this.lbMoTa.Location = new System.Drawing.Point(0, 48);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbMoTa, "lbMoTa");
            this.lbMoTa.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbNhaSX
            // 
            this.lbNhaSX.Control = this.txtHangSanXuat;
            this.lbNhaSX.Location = new System.Drawing.Point(0, 72);
            this.lbNhaSX.Name = "lbNhaSX";
            this.lbNhaSX.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbNhaSX, "lbNhaSX");
            this.lbNhaSX.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbNuocSX
            // 
            this.lbNuocSX.Control = this.txtNuocSanXuat;
            this.lbNuocSX.Location = new System.Drawing.Point(0, 96);
            this.lbNuocSX.Name = "lbNuocSX";
            this.lbNuocSX.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbNuocSX, "lbNuocSX");
            this.lbNuocSX.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbDvt
            // 
            this.lbDvt.Control = this.txtDonViTinh;
            this.lbDvt.Location = new System.Drawing.Point(0, 120);
            this.lbDvt.Name = "lbDvt";
            this.lbDvt.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbDvt, "lbDvt");
            this.lbDvt.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbDonGia
            // 
            this.lbDonGia.Control = this.txtDonGia;
            this.lbDonGia.Location = new System.Drawing.Point(0, 144);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbDonGia, "lbDonGia");
            this.lbDonGia.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lbNhomhang
            // 
            this.lbNhomhang.Control = this.gridNhomHang;
            this.lbNhomhang.Location = new System.Drawing.Point(0, 168);
            this.lbNhomhang.Name = "lbNhomhang";
            this.lbNhomhang.Size = new System.Drawing.Size(444, 24);
            resources.ApplyResources(this.lbNhomhang, "lbNhomhang");
            this.lbNhomhang.TextSize = new System.Drawing.Size(70, 13);
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta")));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta")));
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = ((int)(resources.GetObject("windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta")));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "SaveAndNew;Size32x32;GrayScaled";
            resources.ApplyResources(windowsUIButtonImageOptions2, "windowsUIButtonImageOptions2");
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanelMain.Buttons"), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons1"))), windowsUIButtonImageOptions1, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanelMain.Buttons2"))), resources.GetString("windowsUIButtonPanelMain.Buttons3"), ((int)(resources.GetObject("windowsUIButtonPanelMain.Buttons4"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons5"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanelMain.Buttons6"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons7"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons8"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons9"))), ((object)(resources.GetObject("windowsUIButtonPanelMain.Buttons10"))), ((int)(resources.GetObject("windowsUIButtonPanelMain.Buttons11"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons12")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanelMain.Buttons13"), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons14"))), windowsUIButtonImageOptions2, ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanelMain.Buttons15"))), resources.GetString("windowsUIButtonPanelMain.Buttons16"), ((int)(resources.GetObject("windowsUIButtonPanelMain.Buttons17"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons18"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanelMain.Buttons19"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons20"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons21"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons22"))), ((object)(resources.GetObject("windowsUIButtonPanelMain.Buttons23"))), ((int)(resources.GetObject("windowsUIButtonPanelMain.Buttons24"))), ((bool)(resources.GetObject("windowsUIButtonPanelMain.Buttons25"))))});
            resources.ApplyResources(this.windowsUIButtonPanelMain, "windowsUIButtonPanelMain");
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelMain.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanelMain_ButtonClick);
            this.windowsUIButtonPanelMain.Click += new System.EventHandler(this.windowsUIButtonPanelMain_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AllowHtmlString = true;
            this.lbTieuDe.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbTieuDe.Appearance.Font")));
            this.lbTieuDe.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lbTieuDe.Appearance.Options.UseFont = true;
            this.lbTieuDe.Appearance.Options.UseForeColor = true;
            this.lbTieuDe.Appearance.Options.UseTextOptions = true;
            this.lbTieuDe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lbTieuDe, "lbTieuDe");
            this.lbTieuDe.Name = "lbTieuDe";
            // 
            // frmProduct_Action
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProduct_Action";
            this.Load += new System.EventHandler(this.frmNhomHang_Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgTenHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMoTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNhaSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNuocSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNhomhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl lbTieuDe;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraLayout.LayoutControlItem lbMaHang;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lgTenHang;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtNuocSanXuat;
        private DevExpress.XtraEditors.TextEdit txtHangSanXuat;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraLayout.LayoutControlItem lbMoTa;
        private DevExpress.XtraLayout.LayoutControlItem lbNhaSX;
        private DevExpress.XtraLayout.LayoutControlItem lbNuocSX;
        private DevExpress.XtraLayout.LayoutControlItem lbDvt;
        private DevExpress.XtraLayout.LayoutControlItem lbDonGia;
        private DevExpress.XtraEditors.GridLookUpEdit gridNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem lbNhomhang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }

}