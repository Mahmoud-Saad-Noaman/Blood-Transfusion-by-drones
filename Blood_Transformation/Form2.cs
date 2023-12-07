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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text == "EMAIL ADDRESS")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "EMAIL ADDRESS";
                txt_email.ForeColor = Color.Silver;
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

        private void txt_con_password_Enter(object sender, EventArgs e)
        {
            if(txt_con_password.Text == "CONFIRM PASSWORD")
            {
                txt_con_password.Text = "";
                txt_con_password.ForeColor = Color.Black;
            }
        }

        private void txt_con_password_Leave(object sender, EventArgs e)
        {
            if (txt_con_password.Text == "")
            {
                txt_con_password.Text = "CONFIRM PASSWORD";
                txt_con_password.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
