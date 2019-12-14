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
            this.landItemControl1 = new FFXIVLandCountdown.LandItemControl();
            this.RegionLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SectionSelectTemplateButton = new System.Windows.Forms.Button();
            this.AvailabelItemsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.availableListItemControl1 = new FFXIVLandCountdown.AvailableListItemControl();
            this.landItemLayoutPanel.SuspendLayout();
            this.RegionLayoutPanel.SuspendLayout();
            this.SectionLayoutPanel.SuspendLayout();
            this.AvailabelItemsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegionTemplateButton
            // 
            this.RegionTemplateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegionTemplateButton.Location = new System.Drawing.Point(3, 3);
            this.RegionTemplateButton.Name = "RegionTemplateButton";
            this.RegionTemplateButton.Size = new System.Drawing.Size(99, 25);
            this.RegionTemplateButton.TabIndex = 0;
            this.RegionTemplateButton.Text = "button1";
            this.RegionTemplateButton.UseVisualStyleBackColor = true;
            this.RegionTemplateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // landItemLayoutPanel
            // 
            this.landItemLayoutPanel.Controls.Add(this.landItemControl1);
            this.landItemLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.landItemLayoutPanel.Location = new System.Drawing.Point(208, 68);
            this.landItemLayoutPanel.Name = "landItemLayoutPanel";
            this.landItemLayoutPanel.Size = new System.Drawing.Size(1168, 463);
            this.landItemLayoutPanel.TabIndex = 4;
            // 
            // landItemControl1
            // 
            this.landItemControl1.Location = new System.Drawing.Point(5, 3);
            this.landItemControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.landItemControl1.Name = "landItemControl1";
            this.landItemControl1.Size = new System.Drawing.Size(296, 32);
            this.landItemControl1.TabIndex = 0;
            // 
            // RegionLayoutPanel
            // 
            this.RegionLayoutPanel.Controls.Add(this.RegionTemplateButton);
            this.RegionLayoutPanel.Location = new System.Drawing.Point(21, 14);
            this.RegionLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegionLayoutPanel.Name = "RegionLayoutPanel";
            this.RegionLayoutPanel.Size = new System.Drawing.Size(632, 43);
            this.RegionLayoutPanel.TabIndex = 5;
            // 
            // SectionLayoutPanel
            // 
            this.SectionLayoutPanel.Controls.Add(this.SectionSelectTemplateButton);
            this.SectionLayoutPanel.Location = new System.Drawing.Point(21, 68);
            this.SectionLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SectionLayoutPanel.Name = "SectionLayoutPanel";
            this.SectionLayoutPanel.Size = new System.Drawing.Size(180, 462);
            this.SectionLayoutPanel.TabIndex = 6;
            // 
            // SectionSelectTemplateButton
            // 
            this.SectionSelectTemplateButton.Location = new System.Drawing.Point(4, 3);
            this.SectionSelectTemplateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SectionSelectTemplateButton.Name = "SectionSelectTemplateButton";
            this.SectionSelectTemplateButton.Size = new System.Drawing.Size(37, 32);
            this.SectionSelectTemplateButton.TabIndex = 0;
            this.SectionSelectTemplateButton.Text = "button1";
            this.SectionSelectTemplateButton.UseVisualStyleBackColor = true;
            // 
            // AvailabelItemsLayoutPanel
            // 
            this.AvailabelItemsLayoutPanel.AutoScroll = true;
            this.AvailabelItemsLayoutPanel.Controls.Add(this.availableListItemControl1);
            this.AvailabelItemsLayoutPanel.Location = new System.Drawing.Point(27, 561);
            this.AvailabelItemsLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AvailabelItemsLayoutPanel.Name = "AvailabelItemsLayoutPanel";
            this.AvailabelItemsLayoutPanel.Size = new System.Drawing.Size(816, 309);
            this.AvailabelItemsLayoutPanel.TabIndex = 7;
            // 
            // availableListItemControl1
            // 
            this.availableListItemControl1.Location = new System.Drawing.Point(5, 3);
            this.availableListItemControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.availableListItemControl1.Name = "availableListItemControl1";
            this.availableListItemControl1.Size = new System.Drawing.Size(583, 28);
            this.availableListItemControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 886);
            this.Controls.Add(this.AvailabelItemsLayoutPanel);
            this.Controls.Add(this.SectionLayoutPanel);
            this.Controls.Add(this.RegionLayoutPanel);
            this.Controls.Add(this.landItemLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.landItemLayoutPanel.ResumeLayout(false);
            this.RegionLayoutPanel.ResumeLayout(false);
            this.SectionLayoutPanel.ResumeLayout(false);
            this.AvailabelItemsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegionTemplateButton;
        private System.Windows.Forms.FlowLayoutPanel landItemLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RegionLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SectionLayoutPanel;
        private System.Windows.Forms.Button SectionSelectTemplateButton;
        private System.Windows.Forms.FlowLayoutPanel AvailabelItemsLayoutPanel;
        private LandItemControl landItemControl1;
        private AvailableListItemControl availableListItemControl1;
    }
}

