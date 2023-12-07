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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            txt_blood_type.Items.Add("AB+");
            txt_blood_type.Items.Add("AB-");
            txt_blood_type.Items.Add("A+");
            txt_blood_type.Items.Add("A-");
            txt_blood_type.Items.Add("B+");
            txt_blood_type.Items.Add("B-");
            txt_blood_type.Items.Add("O+");
            txt_blood_type.Items.Add("O-");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txt_blood_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_blood_type_Enter(object sender, EventArgs e)
        {
            if(txt_blood_type.Text == "BLOOD TYPE")
            {
                txt_blood_type.Text = "";
                txt_blood_type.ForeColor = Color.Black;
            }
        }
        private void txt_blood_type_Leave(object sender, EventArgs e)
        {
            if (txt_blood_type.Text == "")
            {
                txt_blood_type.Text = "BLOOD TYPE";
                txt_blood_type.ForeColor = Color.Silver;
            }
        }
        private void txt_liters_blood_Enter(object sender, EventArgs e)
        {
            if(txt_liters_blood.Text == "LITERS OF BLOOD NEEDED")
            {
                txt_liters_blood.Text = "";
                txt_liters_blood.ForeColor = Color.Black;
            }
        }

        private void txt_liters_blood_Leave(object sender, EventArgs e)
        {
            if (txt_liters_blood.Text == "")
            {
                txt_liters_blood.Text = "LITERS OF BLOOD NEEDED";
                txt_liters_blood.ForeColor = Color.Silver;
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("the request executed successfully");
        }
    }
}
