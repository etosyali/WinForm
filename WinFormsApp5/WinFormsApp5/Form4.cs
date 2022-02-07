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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(listBox1.SelectedIndex > -1)
            {
                label1.Text = listBox1.SelectedIndex.ToString();
                label2.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                label1.Text = "";
                label2.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "İstanbul")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Sarıyer");
                listBox2.Items.Add("Bakırköy");
                listBox2.Items.Add("Şişli");
                listBox2.Items.Add("Üsküdar");
                listBox2.SelectedIndex = 0;
            }
            else if (listBox1.Text == "Ankara")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Ulus");
                listBox2.Items.Add("Keçiören");
                listBox2.Items.Add("Çankaya");
                listBox2.SelectedIndex = 0;

            }
            else if (listBox1.Text == "İzmir")
            {
                listBox2.Items.Clear();
                MessageBox.Show("İlçesi Yok");
                listBox2.Items.Add("İlçesi Yok ");
                listBox2.SelectedIndex = 0;
            }
            else if (listBox1.Text == "Adana")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Seyhan");
                listBox2.Items.Add("Ceyhan");
            }
            /* for (int i = 0; i <listBox1.Items.Count; i++)
             {
                 listBox2.Items.Add(listBox1.Items[i].ToString());
             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox1.SelectedIndex > -1)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    Refresh();
                    listBox2.Items.Clear();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                
            }
        }
    }
}
