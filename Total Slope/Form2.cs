using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Slope
{
    public partial class Form2 : Form
    {
        public Form2(int Result_No)
        {
            InitializeComponent();
            NumUpDwn_ExportDialog_From.Maximum = Result_No;
            NumUpDwn_ExportDialog_To.Maximum = Result_No;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if(NumUpDwn_ExportDialog_From.Maximum==0)
            {
                NumUpDwn_ExportDialog_From.Enabled = false;
                NumUpDwn_ExportDialog_To.Enabled = false;
                Btn_ExportDialog_Export.Enabled = false;
                NumUpDwn_ExportDialog_From.Minimum = 0;
                NumUpDwn_ExportDialog_To.Minimum = 0;
                NumUpDwn_ExportDialog_From.Value = 0;
                NumUpDwn_ExportDialog_To.Value = 0;
            }
            else
            {
                NumUpDwn_ExportDialog_From.Value = 1;
                NumUpDwn_ExportDialog_To.Value = 1;
                NumUpDwn_ExportDialog_From.Minimum = 1;
                NumUpDwn_ExportDialog_To.Minimum = 1;
            }
        }
        private void NumUpDwn_ExportDialog_From_ValueChanged(object sender, EventArgs e)
        {
            if (NumUpDwn_ExportDialog_From.Value > NumUpDwn_ExportDialog_To.Value)
                NumUpDwn_ExportDialog_To.Value = NumUpDwn_ExportDialog_From.Value;
        }

        private void NumUpDwn_ExportDialog_To_ValueChanged(object sender, EventArgs e)
        {
            if (NumUpDwn_ExportDialog_To.Value < NumUpDwn_ExportDialog_From.Value)
                NumUpDwn_ExportDialog_From.Value = NumUpDwn_ExportDialog_To.Value;
        }

        private void Btn_ExportDialog_Export_Click(object sender, EventArgs e)
        {
            MainForm frm1 = new MainForm(System.Convert.ToInt32(NumUpDwn_ExportDialog_From.Value)
                , System.Convert.ToInt32(NumUpDwn_ExportDialog_To.Value),true);
            this.Hide();
        }

        private void Btn_ExportDialog_Cancel_Click(object sender, EventArgs e)
        {
            MainForm frm1 = new MainForm(System.Convert.ToInt32(NumUpDwn_ExportDialog_From.Value)
                , System.Convert.ToInt32(NumUpDwn_ExportDialog_To.Value), false);
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm frm1 = new MainForm(System.Convert.ToInt32(NumUpDwn_ExportDialog_From.Value)
                , System.Convert.ToInt32(NumUpDwn_ExportDialog_To.Value), false);
            this.Hide();
        }
    }
}
