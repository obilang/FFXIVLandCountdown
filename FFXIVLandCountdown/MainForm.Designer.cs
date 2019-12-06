namespace FFXIVLandCountdown
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.landItemLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.landItemControl1 = new LandItem.LandItemControl();
            this.landItemLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // landItemLayoutPanel
            // 
            this.landItemLayoutPanel.Controls.Add(this.landItemControl1);
            this.landItemLayoutPanel.Location = new System.Drawing.Point(230, 78);
            this.landItemLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.landItemLayoutPanel.Name = "landItemLayoutPanel";
            this.landItemLayoutPanel.Size = new System.Drawing.Size(496, 382);
            this.landItemLayoutPanel.TabIndex = 4;
            // 
            // landItemControl1
            // 
            this.landItemControl1.Location = new System.Drawing.Point(2, 3);
            this.landItemControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.landItemControl1.Name = "landItemControl1";
            this.landItemControl1.Size = new System.Drawing.Size(221, 88);
            this.landItemControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.landItemLayoutPanel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.landItemLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LandItem.LandItemControl landItemControl1;
        private System.Windows.Forms.FlowLayoutPanel landItemLayoutPanel;
    }
}

