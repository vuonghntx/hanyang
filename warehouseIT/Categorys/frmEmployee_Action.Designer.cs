﻿
namespace warehouseIT.Category
{
    partial class frmEmployee_Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee_Action));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridDepartment = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbDepartment = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartment_Name = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartment_Code = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbDepartment_Code = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgDepartment_Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDepartment_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDepartment_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridDepartment);
            this.dataLayoutControl1.Controls.Add(this.lbDepartment);
            this.dataLayoutControl1.Controls.Add(this.txtDepartment_Name);
            this.dataLayoutControl1.Controls.Add(this.txtDepartment_Code);
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1012, 240, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            // 
            // gridDepartment
            // 
            resources.ApplyResources(this.gridDepartment, "gridDepartment");
            this.gridDepartment.Name = "gridDepartment";
            this.gridDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("gridDepartment.Properties.Buttons"))))});
            this.gridDepartment.Properties.DisplayMember = "Department_Name";
            this.gridDepartment.Properties.NullText = resources.GetString("gridDepartment.Properties.NullText");
            this.gridDepartment.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridDepartment.Properties.ValueMember = "IDDepartment";
            this.gridDepartment.StyleController = this.dataLayoutControl1;
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
            // lbDepartment
            // 
            this.lbDepartment.AllowHtmlString = true;
            this.lbDepartment.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbDepartment.Appearance.Font")));
            this.lbDepartment.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lbDepartment.Appearance.Options.UseFont = true;
            this.lbDepartment.Appearance.Options.UseForeColor = true;
            this.lbDepartment.Appearance.Options.UseTextOptions = true;
            this.lbDepartment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.lbDepartment, "lbDepartment");
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.StyleController = this.dataLayoutControl1;
            // 
            // txtDepartment_Name
            // 
            resources.ApplyResources(this.txtDepartment_Name, "txtDepartment_Name");
            this.txtDepartment_Name.Name = "txtDepartment_Name";
            this.txtDepartment_Name.StyleController = this.dataLayoutControl1;
            // 
            // txtDepartment_Code
            // 
            resources.ApplyResources(this.txtDepartment_Code, "txtDepartment_Code");
            this.txtDepartment_Code.Name = "txtDepartment_Code";
            this.txtDepartment_Code.StyleController = this.dataLayoutControl1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbDepartment_Code,
            this.emptySpaceItem1,
            this.lgDepartment_Name,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(362, 140);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbDepartment_Code
            // 
            this.lbDepartment_Code.Control = this.txtDepartment_Code;
            this.lbDepartment_Code.Location = new System.Drawing.Point(0, 34);
            this.lbDepartment_Code.Name = "lbDepartment_Code";
            this.lbDepartment_Code.Size = new System.Drawing.Size(342, 24);
            resources.ApplyResources(this.lbDepartment_Code, "lbDepartment_Code");
            this.lbDepartment_Code.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 106);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(342, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgDepartment_Name
            // 
            this.lgDepartment_Name.Control = this.txtDepartment_Name;
            this.lgDepartment_Name.Location = new System.Drawing.Point(0, 58);
            this.lgDepartment_Name.Name = "lgDepartment_Name";
            this.lgDepartment_Name.Size = new System.Drawing.Size(342, 24);
            resources.ApplyResources(this.lgDepartment_Name, "lgDepartment_Name");
            this.lgDepartment_Name.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbDepartment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridDepartment;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(342, 24);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
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
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "Department_Name";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // frmEmployee_Action
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmEmployee_Action";
            this.Load += new System.EventHandler(this.frmNhomHang_Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDepartment_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDepartment_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.TextEdit txtDepartment_Name;
        private DevExpress.XtraEditors.TextEdit txtDepartment_Code;
        private DevExpress.XtraLayout.LayoutControlItem lbDepartment_Code;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lgDepartment_Name;
        private DevExpress.XtraEditors.LabelControl lbDepartment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GridLookUpEdit gridDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }

}