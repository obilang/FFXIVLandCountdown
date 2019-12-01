﻿namespace LandItem
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
            this.IndexText.Location = new System.Drawing.Point(37, 40);
            this.IndexText.Name = "IndexText";
            this.IndexText.Size = new System.Drawing.Size(15, 15);
            this.IndexText.TabIndex = 0;
            this.IndexText.Text = "1";
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.Location = new System.Drawing.Point(85, 40);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(47, 15);
            this.StateText.TabIndex = 1;
            this.StateText.Text = "Empty";
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(176, 40);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(71, 15);
            this.TimeText.TabIndex = 2;
            this.TimeText.Text = "10:00:00";
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Location = new System.Drawing.Point(395, 32);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 30);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "开始计时";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DeleteButton.Location = new System.Drawing.Point(501, 32);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "移除计时";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoreButton
            // 
            this.MoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoreButton.Location = new System.Drawing.Point(607, 32);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(100, 30);
            this.MoreButton.TabIndex = 5;
            this.MoreButton.Text = "更多选项";
            this.MoreButton.UseVisualStyleBackColor = true;
            // 
            // LandItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.IndexText);
            this.Name = "LandItemControl";
            this.Size = new System.Drawing.Size(752, 92);
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
