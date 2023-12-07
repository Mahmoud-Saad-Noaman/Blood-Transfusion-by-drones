using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Transformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void txt_emai_Enter(object sender, EventArgs e)
        {
            if(txt_emai.Text == "EMAIL ADDRESS")
            {
                txt_emai.Text = "";
                txt_emai.ForeColor = Color.Black;
            }
        }

        private void txt_emai_Leave(object sender, EventArgs e)
        {
            if( txt_emai.Text == "")
            {
                txt_emai.Text = "EMAIL ADDRESS";
                txt_emai.ForeColor = Color.Silver;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "PASSWORD")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "PASSWORD";
                txt_password.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
 TEST
 */ 