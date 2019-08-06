namespace Total_Slope
{
    partial class Form3
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
            this.NumUpDwn_MaxRange = new System.Windows.Forms.NumericUpDown();
            this.Lbl_ExportDialog_to = new System.Windows.Forms.Label();
            this.Lbl_AnalysisRange = new System.Windows.Forms.Label();
            this.NumUpDwn_MinRange = new System.Windows.Forms.NumericUpDown();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_ExportDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_MaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_MinRange)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ExportDialog
            // 
            this.Pnl_ExportDialog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_ExportDialog.Controls.Add(this.label1);
            this.Pnl_ExportDialog.Controls.Add(this.NumUpDwn_MaxRange);
            this.Pnl_ExportDialog.Controls.Add(this.Lbl_ExportDialog_to);
            this.Pnl_ExportDialog.Controls.Add(this.Btn_Continue);
            this.Pnl_ExportDialog.Controls.Add(this.Lbl_AnalysisRange);
            this.Pnl_ExportDialog.Controls.Add(this.NumUpDwn_MinRange);
            this.Pnl_ExportDialog.Location = new System.Drawing.Point(5, 5);
            this.Pnl_ExportDialog.Name = "Pnl_ExportDialog";
            this.Pnl_ExportDialog.Size = new System.Drawing.Size(300, 180);
            this.Pnl_ExportDialog.TabIndex = 1;
            // 
            // NumUpDwn_MaxRange
            // 
            this.NumUpDwn_MaxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumUpDwn_MaxRange.Location = new System.Drawing.Point(60, 80);
            this.NumUpDwn_MaxRange.Name = "NumUpDwn_MaxRange";
            this.NumUpDwn_MaxRange.Size = new System.Drawing.Size(220, 30);
            this.NumUpDwn_MaxRange.TabIndex = 4;
            this.NumUpDwn_MaxRange.ValueChanged += new System.EventHandler(this.NumUpDwn_MaxRange_ValueChanged);
            // 
            // Lbl_ExportDialog_to
            // 
            this.Lbl_ExportDialog_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_ExportDialog_to.Location = new System.Drawing.Point(5, 80);
            this.Lbl_ExportDialog_to.Name = "Lbl_ExportDialog_to";
            this.Lbl_ExportDialog_to.Size = new System.Drawing.Size(50, 25);
            this.Lbl_ExportDialog_to.TabIndex = 3;
            this.Lbl_ExportDialog_to.Text = "to";
            this.Lbl_ExportDialog_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_AnalysisRange
            // 
            this.Lbl_AnalysisRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AnalysisRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_AnalysisRange.Location = new System.Drawing.Point(-5, 5);
            this.Lbl_AnalysisRange.Name = "Lbl_AnalysisRange";
            this.Lbl_AnalysisRange.Size = new System.Drawing.Size(289, 25);
            this.Lbl_AnalysisRange.TabIndex = 1;
            this.Lbl_AnalysisRange.Text = "Analysis Range";
            this.Lbl_AnalysisRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumUpDwn_MinRange
            // 
            this.NumUpDwn_MinRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumUpDwn_MinRange.Location = new System.Drawing.Point(60, 40);
            this.NumUpDwn_MinRange.Name = "NumUpDwn_MinRange";
            this.NumUpDwn_MinRange.Size = new System.Drawing.Size(220, 30);
            this.NumUpDwn_MinRange.TabIndex = 0;
            this.NumUpDwn_MinRange.ValueChanged += new System.EventHandler(this.NumUpDwn_MinRange_ValueChanged);
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Continue.Location = new System.Drawing.Point(15, 120);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(265, 50);
            this.Btn_Continue.TabIndex = 2;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = true;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "from";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 183);
            this.Controls.Add(this.Pnl_ExportDialog);
            this.Name = "Form3";
            this.Text = "Select Range";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Pnl_ExportDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_MaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_MinRange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ExportDialog;
        private System.Windows.Forms.NumericUpDown NumUpDwn_MaxRange;
        private System.Windows.Forms.Label Lbl_ExportDialog_to;
        private System.Windows.Forms.Label Lbl_AnalysisRange;
        private System.Windows.Forms.NumericUpDown NumUpDwn_MinRange;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Label label1;
    }
}