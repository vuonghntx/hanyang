
namespace DemoComponentOne
{
    partial class Form1
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
            this.flexPie1 = new C1.Win.Chart.FlexPie();
            this.c1HScrollBar1 = new C1.Win.C1ScrollBar.C1HScrollBar();
            this.SuspendLayout();
            // 
            // flexPie1
            // 
            this.flexPie1.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            this.flexPie1.AnimationLoad.Duration = 400;
            this.flexPie1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.flexPie1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.flexPie1.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.flexPie1.AnimationUpdate.Duration = 400;
            this.flexPie1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.flexPie1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.flexPie1.DataLabel.Border = false;
            this.flexPie1.DataLabel.ConnectingLine = false;
            this.flexPie1.DataLabel.Content = null;
            this.flexPie1.DataLabel.Offset = 0;
            this.flexPie1.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            this.flexPie1.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            this.flexPie1.Legend.ItemMaxWidth = 0;
            this.flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexPie1.Legend.Position = C1.Chart.Position.Right;
            this.flexPie1.Legend.Reversed = false;
            this.flexPie1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexPie1.Legend.Title = null;
            this.flexPie1.Location = new System.Drawing.Point(482, 50);
            this.flexPie1.Name = "flexPie1";
            this.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexPie1.Size = new System.Drawing.Size(319, 300);
            this.flexPie1.TabIndex = 0;
            this.flexPie1.Text = "flexPie1";
            this.flexPie1.Titles = null;
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "";
            // 
            // c1HScrollBar1
            // 
            this.c1HScrollBar1.Location = new System.Drawing.Point(97, 359);
            this.c1HScrollBar1.Name = "c1HScrollBar1";
            this.c1HScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.c1HScrollBar1.TabIndex = 1;
            this.c1HScrollBar1.TabStop = false;
            this.c1HScrollBar1.Text = "c1HScrollBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1HScrollBar1);
            this.Controls.Add(this.flexPie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Chart.FlexPie flexPie1;
        private C1HScrollBar c1HScrollBar1;
    }
}

