using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dork_Maker_V1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();

            if (radioButton1.Checked == true)
            {
                form3.Show();
            }
            else if(radioButton2.Checked == true)
            {
                form4.Show();
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("This program was developed by TurKLoJeN \n \n ");
                form5.Show();
            }
        }
    }
}
