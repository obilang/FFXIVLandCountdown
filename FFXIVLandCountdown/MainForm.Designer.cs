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
            this.RegionTemplateButton = new System.Windows.Forms.Button();
            this.landItemLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RegionLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionSelectTemplateButton = new System.Windows.Forms.Button();
            this.landItemControl1 = new LandItem.LandItemControl();
            this.landItemLayoutPanel.SuspendLayout();
            this.RegionLayoutPanel.SuspendLayout();
            this.SectionLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegionTemplateButton
            // 
            this.RegionTemplateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegionTemplateButton.Location = new System.Drawing.Point(2, 3);
            this.RegionTemplateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RegionTemplateButton.Name = "RegionTemplateButton";
            this.RegionTemplateButton.Size = new System.Drawing.Size(74, 22);
            this.RegionTemplateButton.TabIndex = 0;
            this.RegionTemplateButton.Text = "button1";
            this.RegionTemplateButton.UseVisualStyleBackColor = true;
            this.RegionTemplateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // landItemLayoutPanel
            // 
            this.landItemLayoutPanel.Controls.Add(this.landItemControl1);
            this.landItemLayoutPanel.Location = new System.Drawing.Point(156, 59);
            this.landItemLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.landItemLayoutPanel.Name = "landItemLayoutPanel";
            this.landItemLayoutPanel.Size = new System.Drawing.Size(570, 401);
            this.landItemLayoutPanel.TabIndex = 4;
            // 
            // RegionLayoutPanel
            // 
            this.RegionLayoutPanel.Controls.Add(this.RegionTemplateButton);
            this.RegionLayoutPanel.Location = new System.Drawing.Point(16, 12);
            this.RegionLayoutPanel.Name = "RegionLayoutPanel";
            this.RegionLayoutPanel.Size = new System.Drawing.Size(474, 37);
            this.RegionLayoutPanel.TabIndex = 5;
            // 
            // SectionLayoutPanel
            // 
            this.SectionLayoutPanel.Controls.Add(this.SectionSelectTemplateButton);
            this.SectionLayoutPanel.Location = new System.Drawing.Point(16, 59);
            this.SectionLayoutPanel.Name = "SectionLayoutPanel";
            this.SectionLayoutPanel.Size = new System.Drawing.Size(135, 400);
            this.SectionLayoutPanel.TabIndex = 6;
            // 
            // SectionSelectTemplateButton
            // 
            this.SectionSelectTemplateButton.Location = new System.Drawing.Point(3, 3);
            this.SectionSelectTemplateButton.Name = "SectionSelectTemplateButton";
            this.SectionSelectTemplateButton.Size = new System.Drawing.Size(28, 28);
            this.SectionSelectTemplateButton.TabIndex = 0;
            this.SectionSelectTemplateButton.Text = "button1";
            this.SectionSelectTemplateButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.SectionLayoutPanel);
            this.Controls.Add(this.RegionLayoutPanel);
            this.Controls.Add(this.landItemLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.landItemLayoutPanel.ResumeLayout(false);
            this.RegionLayoutPanel.ResumeLayout(false);
            this.SectionLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegionTemplateButton;
        private LandItem.LandItemControl landItemControl1;
        private System.Windows.Forms.FlowLayoutPanel landItemLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RegionLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SectionLayoutPanel;
        private System.Windows.Forms.Button SectionSelectTemplateButton;
    }
}

