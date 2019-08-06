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
    public partial class Form3 : Form
    {
        public Form3(double MinRng, double MaxRng)
        {
            InitializeComponent();
            NumUpDwn_MinRange.Minimum = System.Convert.ToDecimal(MinRng);
            NumUpDwn_MinRange.Maximum = System.Convert.ToDecimal(MaxRng);
            NumUpDwn_MinRange.Value = System.Convert.ToDecimal(MinRng);
            NumUpDwn_MaxRange.Minimum = System.Convert.ToDecimal(MinRng);
            NumUpDwn_MaxRange.Maximum = System.Convert.ToDecimal(MaxRng);
            NumUpDwn_MaxRange.Value = System.Convert.ToDecimal(MaxRng);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void NumUpDwn_MinRange_ValueChanged(object sender, EventArgs e)
        {
            NumUpDwn_MaxRange.Minimum = NumUpDwn_MinRange.Value;
        }

        private void NumUpDwn_MaxRange_ValueChanged(object sender, EventArgs e)
        {
            NumUpDwn_MinRange.Maximum = NumUpDwn_MaxRange.Value;
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            MainForm frm1 = new MainForm(System.Convert.ToDouble(NumUpDwn_MinRange.Value)
                    , System.Convert.ToDouble(NumUpDwn_MaxRange.Value), true);
            this.Hide();
        }
    }
}
