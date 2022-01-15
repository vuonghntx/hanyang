
namespace warehouseIT.SystemsAdmin
{
    partial class frmUser_Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser_Action));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtTenHienThi = new DevExpress.XtraEditors.TextEdit();
            this.gridNhomQuyen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtXacNhanMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lbPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPasswordRp = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbGroupUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.lbLabel = new DevExpress.XtraEditors.LabelControl();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHienThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPasswordRp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGroupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbFullName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.txtTenHienThi);
            this.dataLayoutControl1.Controls.Add(this.gridNhomQuyen);
            this.dataLayoutControl1.Controls.Add(this.txtXacNhanMatKhau);
            this.dataLayoutControl1.Controls.Add(this.txtMatKhau);
            this.dataLayoutControl1.Controls.Add(this.txtTenDangNhap);
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1012, 240, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            // 
            // txtTenHienThi
            // 
            resources.ApplyResources(this.txtTenHienThi, "txtTenHienThi");
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.StyleController = this.dataLayoutControl1;
            // 
            // gridNhomQuyen
            // 
            resources.ApplyResources(this.gridNhomQuyen, "gridNhomQuyen");
            this.gridNhomQuyen.Name = "gridNhomQuyen";
            this.gridNhomQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("gridNhomQuyen.Properties.Buttons"))))});
            this.gridNhomQuyen.Properties.DisplayMember = "TenNhom";
            this.gridNhomQuyen.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridNhomQuyen.Properties.ValueMember = "NhomQID";
            this.gridNhomQuyen.StyleController = this.dataLayoutControl1;
            this.gridNhomQuyen.EditValueChanged += new System.EventHandler(this.gridNhomQuyen_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtXacNhanMatKhau
            // 
            resources.ApplyResources(this.txtXacNhanMatKhau, "txtXacNhanMatKhau");
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtXacNhanMatKhau.StyleController = this.dataLayoutControl1;
            // 
            // txtMatKhau
            // 
            resources.ApplyResources(this.txtMatKhau, "txtMatKhau");
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.StyleController = this.dataLayoutControl1;
            // 
            // txtTenDangNhap
            // 
            resources.ApplyResources(this.txtTenDangNhap, "txtTenDangNhap");
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.StyleController = this.dataLayoutControl1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbUserName,
            this.emptySpaceItem1,
            this.lbPassword,
            this.lbPasswordRp,
            this.lbGroupUser,
            this.lbFullName});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(431, 153);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbUserName
            // 
            this.lbUserName.Control = this.txtTenDangNhap;
            this.lbUserName.Location = new System.Drawing.Point(0, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(411, 24);
            resources.ApplyResources(this.lbUserName, "lbUserName");
            this.lbUserName.TextSize = new System.Drawing.Size(91, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(411, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lbPassword
            // 
            this.lbPassword.Control = this.txtMatKhau;
            this.lbPassword.Location = new System.Drawing.Point(0, 24);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(411, 24);
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.TextSize = new System.Drawing.Size(91, 13);
            // 
            // lbPasswordRp
            // 
            this.lbPasswordRp.Control = this.txtXacNhanMatKhau;
            this.lbPasswordRp.Location = new System.Drawing.Point(0, 48);
            this.lbPasswordRp.Name = "lbPasswordRp";
            this.lbPasswordRp.Size = new System.Drawing.Size(411, 24);
            resources.ApplyResources(this.lbPasswordRp, "lbPasswordRp");
            this.lbPasswordRp.TextSize = new System.Drawing.Size(91, 13);
            // 
            // lbGroupUser
            // 
            this.lbGroupUser.Control = this.gridNhomQuyen;
            this.lbGroupUser.Location = new System.Drawing.Point(0, 96);
            this.lbGroupUser.Name = "lbGroupUser";
            this.lbGroupUser.Size = new System.Drawing.Size(411, 24);
            resources.ApplyResources(this.lbGroupUser, "lbGroupUser");
            this.lbGroupUser.TextSize = new System.Drawing.Size(91, 13);
            // 
            // lbFullName
            // 
            this.lbFullName.Control = this.txtTenHienThi;
            this.lbFullName.Location = new System.Drawing.Point(0, 72);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(411, 24);
            resources.ApplyResources(this.lbFullName, "lbFullName");
            this.lbFullName.TextSize = new System.Drawing.Size(91, 13);
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
            // lbLabel
            // 
            this.lbLabel.AllowHtmlString = true;
            this.lbLabel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl.Appearance.Font")));
            this.lbLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lbLabel.Appearance.Options.UseFont = true;
            this.lbLabel.Appearance.Options.UseForeColor = true;
            this.lbLabel.Appearance.Options.UseTextOptions = true;
            this.lbLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lbLabel, "lbLabel");
            this.lbLabel.Name = "lbLabel";
            // 
            // colGroupName
            // 
            resources.ApplyResources(this.colGroupName, "colGroupName");
            this.colGroupName.FieldName = "TenNhom";
            this.colGroupName.Name = "colGroupName";
            // 
            // frmUser_Action
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUser_Action";
            this.Load += new System.EventHandler(this.frmNhomHang_Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHienThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPasswordRp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGroupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbFullName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl lbLabel;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem lbUserName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtTenHienThi;
        private DevExpress.XtraEditors.GridLookUpEdit gridNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem lbPassword;
        private DevExpress.XtraLayout.LayoutControlItem lbPasswordRp;
        private DevExpress.XtraLayout.LayoutControlItem lbGroupUser;
        private DevExpress.XtraLayout.LayoutControlItem lbFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
    }

}