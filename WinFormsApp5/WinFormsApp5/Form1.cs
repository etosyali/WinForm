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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int BaslamaSayisi;
            int BitisSayisi;

            try
            {
                BaslamaSayisi = Convert.ToInt32(textBox1.Text);
                BitisSayisi = Convert.ToInt32(textBox2.Text);

                if (BaslamaSayisi > BitisSayisi)
                {

                    MessageBox.Show("Başlama Sayisi Bitişten Küçük Olmali ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                for (int i = BaslamaSayisi; i <= BitisSayisi; i++)
                {
                    textBox3.Text = textBox3.Text + i.ToString() + ",";


                }
            }
            catch (Exception Hata)
            {
                label2.Text = Hata.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, BaslamaSayisi, BitisSayisi, top;
            BaslamaSayisi = Convert.ToInt32(textBox1.Text);
            BitisSayisi = Convert.ToInt32(textBox2.Text);
            top = 0;
            for (i = BaslamaSayisi; i <= BitisSayisi; i++)
                top = top + i;
            textBox4.Text = Convert.ToString(top);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[7] { Color.Red, Color.Blue, Color.Brown, Color.Purple, Color.White, Color.Pink, Color.Yellow };
            Random rnd = new Random();
            int dizi_elemani = rnd.Next(0, 6);
            this.BackColor = renkler[dizi_elemani];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void altMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void kazılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm_list = new Form4();
            frm_list.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inşaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
    }
}
