namespace FFXIVLandCountdown
{
    partial class ItemPopupForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(253, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(167, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "日";
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(209, 34);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(41, 25);
            this.MinTextBox.TabIndex = 14;
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(120, 34);
            this.HourTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(44, 25);
            this.HourTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "设置空地空出来的时间";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.Location = new System.Drawing.Point(395, 34);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(64, 30);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(327, 34);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(64, 30);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DayTextBox
            // 
            this.DayTextBox.Location = new System.Drawing.Point(16, 34);
            this.DayTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(58, 25);
            this.DayTextBox.TabIndex = 9;
            // 
            // ItemPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 79);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DayTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemPopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ItemPopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox HourTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox DayTextBox;
    }
}