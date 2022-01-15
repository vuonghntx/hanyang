
namespace warehouseIT
{
    partial class frmLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguage));
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.radioKorean = new System.Windows.Forms.RadioButton();
            this.radioVietNam = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider3 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider4 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.radioEnglish = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider2
            // 
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.Location = new System.Drawing.Point(43, 12);
            this.imageSlider2.Name = "imageSlider2";
            this.imageSlider2.Size = new System.Drawing.Size(62, 39);
            this.imageSlider2.TabIndex = 1;
            this.imageSlider2.Text = "imageSlider1";
            // 
            // radioKorean
            // 
            this.radioKorean.AutoSize = true;
            this.radioKorean.Checked = true;
            this.radioKorean.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKorean.Location = new System.Drawing.Point(114, 23);
            this.radioKorean.Name = "radioKorean";
            this.radioKorean.Size = new System.Drawing.Size(72, 22);
            this.radioKorean.TabIndex = 3;
            this.radioKorean.TabStop = true;
            this.radioKorean.Text = "Korean";
            this.radioKorean.UseVisualStyleBackColor = true;
            // 
            // radioVietNam
            // 
            this.radioVietNam.AutoSize = true;
            this.radioVietNam.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVietNam.Location = new System.Drawing.Point(114, 125);
            this.radioVietNam.Name = "radioVietNam";
            this.radioVietNam.Size = new System.Drawing.Size(102, 22);
            this.radioVietNam.TabIndex = 3;
            this.radioVietNam.TabStop = true;
            this.radioVietNam.Text = "Vietnamese";
            this.radioVietNam.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(43, 160);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(62, 32);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imageSlider3
            // 
            this.imageSlider3.CurrentImageIndex = 0;
            this.imageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider3.Images"))));
            this.imageSlider3.Location = new System.Drawing.Point(43, 61);
            this.imageSlider3.Name = "imageSlider3";
            this.imageSlider3.Size = new System.Drawing.Size(62, 39);
            this.imageSlider3.TabIndex = 1;
            this.imageSlider3.Text = "imageSlider1";
            // 
            // imageSlider4
            // 
            this.imageSlider4.CurrentImageIndex = 0;
            this.imageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider4.Images"))));
            this.imageSlider4.Location = new System.Drawing.Point(43, 115);
            this.imageSlider4.Name = "imageSlider4";
            this.imageSlider4.Size = new System.Drawing.Size(62, 39);
            this.imageSlider4.TabIndex = 1;
            this.imageSlider4.Text = "imageSlider1";
            // 
            // radioEnglish
            // 
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnglish.Location = new System.Drawing.Point(114, 71);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(69, 22);
            this.radioEnglish.TabIndex = 3;
            this.radioEnglish.TabStop = true;
            this.radioEnglish.Text = "English";
            this.radioEnglish.UseVisualStyleBackColor = true;
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 198);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.radioEnglish);
            this.Controls.Add(this.radioVietNam);
            this.Controls.Add(this.radioKorean);
            this.Controls.Add(this.imageSlider3);
            this.Controls.Add(this.imageSlider2);
            this.Controls.Add(this.imageSlider4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmLanguage.IconOptions.LargeImage")));
            this.MaximumSize = new System.Drawing.Size(270, 230);
            this.MinimumSize = new System.Drawing.Size(270, 230);
            this.Name = "frmLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Language";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private System.Windows.Forms.RadioButton radioKorean;
        private System.Windows.Forms.RadioButton radioVietNam;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider3;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider4;
        private System.Windows.Forms.RadioButton radioEnglish;
    }
}