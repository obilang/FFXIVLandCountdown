namespace FFXIVLandCountdown
{
    partial class AvailableListItemControl
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
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PinButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LocationLabel.Location = new System.Drawing.Point(53, 6);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(93, 26);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "沙 11-11";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(162, 6);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(88, 25);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00:00:00";
            // 
            // PinButton
            // 
            this.PinButton.BackgroundImage = global::FFXIVLandCountdown.Properties.Resources.tack_save_button;
            this.PinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PinButton.Location = new System.Drawing.Point(6, 2);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(32, 32);
            this.PinButton.TabIndex = 4;
            this.PinButton.UseVisualStyleBackColor = true;
            this.PinButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::FFXIVLandCountdown.Properties.Resources.cancel;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.Location = new System.Drawing.Point(325, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(34, 34);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AvailableListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PinButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.TimeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AvailableListItemControl";
            this.Size = new System.Drawing.Size(378, 36);
            this.Load += new System.EventHandler(this.AvailableListItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
