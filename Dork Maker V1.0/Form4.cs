using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dork_Maker_V1._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader maq = new System.IO.StreamReader(openFileDialog1.FileName);
            textBox1.Text = maq.ReadToEnd();
            maq.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                MessageBox.Show("please choose");
            }
            else if (comboBox1.Text == "Choose Dork")
            {
                MessageBox.Show("please choose");

            }
            if (textBox1.Lines.Length >= 1)
            {
                for (int x = 0; x <= textBox1.Lines.Length; x++)
                {
                    try
                    {
                        listBox1.Items.Add(comboBox1.SelectedItem + textBox1.Lines[x]);
                    }
                    catch { }

                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader maq = new System.IO.StreamReader(openFileDialog1.FileName);
            textBox1.Text = maq.ReadToEnd();
            maq.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text == null)
            {
                MessageBox.Show("please choose");
            }
            else if (comboBox2.Text == "Choose Dork")
            {
                MessageBox.Show("please choose");

            }

            if (textBox2.Lines.Length >= 1)
            {
                for (int x = 0; x <= textBox2.Lines.Length; x++)
                {
                    try
                    {
                        listBox2.Items.Add(comboBox2.SelectedItem + textBox2.Lines[x]);
                    }
                    catch { }

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("wordpress_dork.txt"))
                {
                    foreach (string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("wordpress_dork.txt");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("joomla_dork.txt"))
                {
                    foreach (string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("joomla_dork.txt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBox1.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBox1.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(System.IO.File.ReadAllLines("sql_dork.txt"));
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox3.SelectionMode = SelectionMode.MultiSimple;
            listBox4.SelectionMode = SelectionMode.MultiSimple;  // 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(System.IO.File.ReadAllLines("xss_dork.txt"));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(System.IO.File.ReadAllLines("rfi_dork.txt"));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(System.IO.File.ReadAllLines("lfi_dork.txt"));
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(System.IO.File.ReadAllLines("file_upload_dork.txt"));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // aktar düğmesi
            int i;
            for (i = listBox3.SelectedIndices.Count - 1; i >= 0; i--)
            {
                //Seçili elemanı ikinci listeye ekle
                listBox4.Items.Add(listBox3.SelectedItems[i]);
                //seçili elemanı birinci listeden çıkar
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i;
            for (i = listBox4.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox4.Items.RemoveAt(listBox4.SelectedIndices[i]);
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (listBox4.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("dorks.txt"))
                {
                    foreach (string itemText in listBox4.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("dorks.txt");
            }
        }
    }
}
