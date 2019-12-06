namespace LandItem
{
    partial class LandItemControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IndexText = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IndexText
            // 
            this.IndexText.AutoSize = true;
            this.IndexText.Location = new System.Drawing.Point(2, 0);
            this.IndexText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndexText.Name = "IndexText";
            this.IndexText.Size = new System.Drawing.Size(13, 13);
            this.IndexText.TabIndex = 0;
            this.IndexText.Text = "1";
            this.IndexText.Click += new System.EventHandler(this.IndexText_Click);
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.Location = new System.Drawing.Point(64, 35);
            this.StateText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(36, 13);
            this.StateText.TabIndex = 1;
            this.StateText.Text = "Empty";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(132, 35);
            this.TimeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(49, 13);
            this.TimeText.TabIndex = 2;
            this.TimeText.Text = "10:00:00";
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Location = new System.Drawing.Point(296, 28);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 26);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "开始计时2";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DeleteButton.Location = new System.Drawing.Point(376, 28);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(0, 24);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "移除计时";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoreButton.Location = new System.Drawing.Point(123, 25);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(86, 46);
            this.MoreButton.TabIndex = 5;
            this.MoreButton.Text = "更多选项1";
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // LandItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.IndexText);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LandItemControl";
            this.Size = new System.Drawing.Size(253, 94);
            this.Load += new System.EventHandler(this.LandItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexText;
        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MoreButton;
    }
}
