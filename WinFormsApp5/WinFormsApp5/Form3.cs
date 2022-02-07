using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Gb_Asker.Visible = true;
            }
            else
            {
                Gb_Asker.Visible = false;
            }
        }

        private void Rb_Muaf_CheckedChanged(object sender, EventArgs e)
        {
            if(Rb_Muaf.Checked == true)
            {
                Txt_Neden.Visible = true;
            }
            else
            {
                Txt_Neden.Visible = false;
            }
        }
    }
}
