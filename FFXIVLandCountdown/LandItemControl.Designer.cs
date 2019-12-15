namespace FFXIVLandCountdown
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
            this.TimeText = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.Label();
            this.IndexText = new System.Windows.Forms.Label();
            this.MoreButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeText.Location = new System.Drawing.Point(73, 5);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(63, 20);
            this.TimeText.TabIndex = 8;
            this.TimeText.Text = "10:00:00";
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StateText.Location = new System.Drawing.Point(31, 5);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(37, 20);
            this.StateText.TabIndex = 7;
            this.StateText.Text = "空闲";
            // 
            // IndexText
            // 
            this.IndexText.AutoSize = true;
            this.IndexText.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndexText.Location = new System.Drawing.Point(11, 5);
            this.IndexText.Name = "IndexText";
            this.IndexText.Size = new System.Drawing.Size(17, 20);
            this.IndexText.TabIndex = 6;
            this.IndexText.Text = "1";
            // 
            // MoreButton
            // 
            this.MoreButton.BackgroundImage = global::FFXIVLandCountdown.Properties.Resources.menu;
            this.MoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoreButton.Location = new System.Drawing.Point(248, 3);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(24, 24);
            this.MoreButton.TabIndex = 11;
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::FFXIVLandCountdown.Properties.Resources.cancel;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.Location = new System.Drawing.Point(219, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackgroundImage = global::FFXIVLandCountdown.Properties.Resources.reload;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Location = new System.Drawing.Point(188, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(24, 24);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LandItemControl";
            this.Size = new System.Drawing.Size(281, 32);
            this.Load += new System.EventHandler(this.LandItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.Label IndexText;
    }
}
