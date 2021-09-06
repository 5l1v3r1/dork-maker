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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] kelimeler = textBox1.Text.Split(' ', '-', ',','_','/');
            foreach (string item in kelimeler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("words.txt"))
                {
                    foreach (string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("words.txt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBox1.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }
    }
}
