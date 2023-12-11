using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Transformation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_patients_fname_Enter(object sender, EventArgs e)
        {
            if(txt_patients_fname.Text == "PATIENT FIRST NAME")
            {
                txt_patients_fname.Text = "";
                txt_patients_fname.ForeColor = Color.Black;
            }
        }

        private void txt_patients_fname_Leave(object sender, EventArgs e)
        {
            if (txt_patients_fname.Text == "")
            {
                txt_patients_fname.Text = "PATIENT FIRST NAME";
                txt_patients_fname.ForeColor = Color.Silver;
            }
        }

        private void txt_patients_lname_Enter(object sender, EventArgs e)
        {
            if(txt_patients_lname.Text == "PATIENT LAST NAME")
            {
                txt_patients_lname.Text = "";
                txt_patients_lname.ForeColor = Color.Black;
            }
        }

        private void txt_patients_lname_Leave(object sender, EventArgs e)
        {
            if (txt_patients_lname.Text == "")
            {
                txt_patients_lname.Text = "PATIENT LAST NAME";
                txt_patients_lname.ForeColor = Color.Silver;
            }

        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if(txt_phone.Text == "PHONE NUMBER")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.Black;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.Text = "PHONE NUMBER";
                txt_phone.ForeColor = Color.Silver;
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void cont_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J5HRLL8;Initial Catalog=Blood_Transformatiom;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patients(first_name,last_name,phone_number) values('" + txt_patients_fname.Text + "' , '" + txt_patients_lname.Text + "' , '" + txt_phone.Text + "')", con);
            cmd.ExecuteNonQuery();

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
