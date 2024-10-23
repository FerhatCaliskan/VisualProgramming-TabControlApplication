using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox3.BackColor = color.Color;
            color.Reset();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 10;
            listBox1.Items.Add("Your Name: " + textBox1.Text);
            listBox1.Items.Add("Your Surname: " + textBox2.Text);
            listBox1.Items.Add("Your Age : "+(DateTime.Now.Year - dateTimePicker1.Value.Year));
            listBox1.Items.Add("Your Country: " + comboBox1.Text);
            listBox1.Items.Add("Your Color: " + textBox3.ForeColor);
            if (rb_male.Checked) listBox1.Items.Add("Your Gender:" + rb_male.Text); else listBox1.Items.Add("Your Gender:" + rb_female.Text);
            if(chb_Y.Checked)listBox1.Items.Add("Your Position: "+chb_Y.Text);else listBox1.Items.Add("Your Position: "+chb_Y.Text);
            progressBar1.Value=100;
            tabPage1.Refresh();

            



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
