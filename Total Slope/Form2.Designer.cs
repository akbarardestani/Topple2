namespace Total_Slope
{
    partial class Form2
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
            this.Pnl_ExportDialog = new System.Windows.Forms.Panel();
            this.Btn_ExportDialog_Cancel = new System.Windows.Forms.Button();
            this.NumUpDwn_ExportDialog_To = new System.Windows.Forms.NumericUpDown();
            this.Lbl_ExportDialog_to = new System.Windows.Forms.Label();
            this.Btn_ExportDialog_Export = new System.Windows.Forms.Button();
            this.Lbl_ExportDialog = new System.Windows.Forms.Label();
            this.NumUpDwn_ExportDialog_From = new System.Windows.Forms.NumericUpDown();
            this.Pnl_ExportDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_ExportDialog_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_ExportDialog_From)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ExportDialog
            // 
            this.Pnl_ExportDialog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_ExportDialog.Controls.Add(this.Btn_ExportDialog_Cancel);
            this.Pnl_ExportDialog.Controls.Add(this.NumUpDwn_ExportDialog_To);
            this.Pnl_ExportDialog.Controls.Add(this.Lbl_ExportDialog_to);
            this.Pnl_ExportDialog.Controls.Add(this.Btn_ExportDialog_Export);
            this.Pnl_ExportDialog.Controls.Add(this.Lbl_ExportDialog);
            this.Pnl_ExportDialog.Controls.Add(this.NumUpDwn_ExportDialog_From);
            this.Pnl_ExportDialog.Location = new System.Drawing.Point(5, 5);
            this.Pnl_ExportDialog.Name = "Pnl_ExportDialog";
            this.Pnl_ExportDialog.Size = new System.Drawing.Size(450, 150);
            this.Pnl_ExportDialog.TabIndex = 0;
            // 
            // Btn_ExportDialog_Cancel
            // 
            this.Btn_ExportDialog_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_ExportDialog_Cancel.Location = new System.Drawing.Point(250, 90);
            this.Btn_ExportDialog_Cancel.Name = "Btn_ExportDialog_Cancel";
            this.Btn_ExportDialog_Cancel.Size = new System.Drawing.Size(160, 50);
            this.Btn_ExportDialog_Cancel.TabIndex = 5;
            this.Btn_ExportDialog_Cancel.Text = "Cancel";
            this.Btn_ExportDialog_Cancel.UseVisualStyleBackColor = true;
            this.Btn_ExportDialog_Cancel.Click += new System.EventHandler(this.Btn_ExportDialog_Cancel_Click);
            // 
            // NumUpDwn_ExportDialog_To
            // 
            this.NumUpDwn_ExportDialog_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumUpDwn_ExportDialog_To.Location = new System.Drawing.Point(250, 50);
            this.NumUpDwn_ExportDialog_To.Name = "NumUpDwn_ExportDialog_To";
            this.NumUpDwn_ExportDialog_To.Size = new System.Drawing.Size(160, 30);
            this.NumUpDwn_ExportDialog_To.TabIndex = 4;
            this.NumUpDwn_ExportDialog_To.ValueChanged += new System.EventHandler(this.NumUpDwn_ExportDialog_To_ValueChanged);
            // 
            // Lbl_ExportDialog_to
            // 
            this.Lbl_ExportDialog_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_ExportDialog_to.Location = new System.Drawing.Point(200, 50);
            this.Lbl_ExportDialog_to.Name = "Lbl_ExportDialog_to";
            this.Lbl_ExportDialog_to.Size = new System.Drawing.Size(50, 25);
            this.Lbl_ExportDialog_to.TabIndex = 3;
            this.Lbl_ExportDialog_to.Text = "to";
            this.Lbl_ExportDialog_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_ExportDialog_Export
            // 
            this.Btn_ExportDialog_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_ExportDialog_Export.Location = new System.Drawing.Point(40, 90);
            this.Btn_ExportDialog_Export.Name = "Btn_ExportDialog_Export";
            this.Btn_ExportDialog_Export.Size = new System.Drawing.Size(160, 50);
            this.Btn_ExportDialog_Export.TabIndex = 2;
            this.Btn_ExportDialog_Export.Text = "Export";
            this.Btn_ExportDialog_Export.UseVisualStyleBackColor = true;
            this.Btn_ExportDialog_Export.Click += new System.EventHandler(this.Btn_ExportDialog_Export_Click);
            // 
            // Lbl_ExportDialog
            // 
            this.Lbl_ExportDialog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ExportDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_ExportDialog.Location = new System.Drawing.Point(10, 10);
            this.Lbl_ExportDialog.Name = "Lbl_ExportDialog";
            this.Lbl_ExportDialog.Size = new System.Drawing.Size(430, 25);
            this.Lbl_ExportDialog.TabIndex = 1;
            this.Lbl_ExportDialog.Text = "Which result Numbers do you want to export ?";
            this.Lbl_ExportDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumUpDwn_ExportDialog_From
            // 
            this.NumUpDwn_ExportDialog_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumUpDwn_ExportDialog_From.Location = new System.Drawing.Point(40, 50);
            this.NumUpDwn_ExportDialog_From.Name = "NumUpDwn_ExportDialog_From";
            this.NumUpDwn_ExportDialog_From.Size = new System.Drawing.Size(160, 30);
            this.NumUpDwn_ExportDialog_From.TabIndex = 0;
            this.NumUpDwn_ExportDialog_From.ValueChanged += new System.EventHandler(this.NumUpDwn_ExportDialog_From_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 158);
            this.Controls.Add(this.Pnl_ExportDialog);
            this.Name = "Form2";
            this.Text = "Excel Export Dialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Pnl_ExportDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_ExportDialog_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_ExportDialog_From)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ExportDialog;
        private System.Windows.Forms.Button Btn_ExportDialog_Cancel;
        private System.Windows.Forms.NumericUpDown NumUpDwn_ExportDialog_To;
        private System.Windows.Forms.Label Lbl_ExportDialog_to;
        private System.Windows.Forms.Button Btn_ExportDialog_Export;
        private System.Windows.Forms.Label Lbl_ExportDialog;
        private System.Windows.Forms.NumericUpDown NumUpDwn_ExportDialog_From;
    }
}