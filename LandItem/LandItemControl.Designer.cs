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
            this.StateText.Location = new System.Drawing.Point(120, 40);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(47, 15);
            this.StateText.TabIndex = 1;
            this.StateText.Text = "Empty";
            // 
            // LandItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.IndexText);
            this.Name = "LandItemControl";
            this.Size = new System.Drawing.Size(629, 100);
            this.Load += new System.EventHandler(this.LandItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexText;
        private System.Windows.Forms.Label StateText;
    }
}
