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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;


            txt_city.Items.Add("Alexandria");
            txt_city.Items.Add("Aswan");
            txt_city.Items.Add("Asyut");
            txt_city.Items.Add("Beheira");
            txt_city.Items.Add("Bani Sweif");
            txt_city.Items.Add("Cairo");            
            txt_city.Items.Add("Dakahlia");
            txt_city.Items.Add("Damietta");
            txt_city.Items.Add("Fayoum");
            txt_city.Items.Add("Gharbia");
            txt_city.Items.Add("Giza");
            txt_city.Items.Add("Helwan");
            txt_city.Items.Add("Hurghada");
            txt_city.Items.Add("Ismailia");
            txt_city.Items.Add("Kafr Al Sheikh");
            txt_city.Items.Add("Luxor");
            txt_city.Items.Add("Mahalla");
            txt_city.Items.Add("Mansoura");
            txt_city.Items.Add("Matrouh");
            txt_city.Items.Add("Menoufia");
            txt_city.Items.Add("Minya");
            txt_city.Items.Add("Nasser City");
            txt_city.Items.Add("New valley");
            txt_city.Items.Add("Port Said");
            txt_city.Items.Add("Qalyubia");
            txt_city.Items.Add("qena");
            txt_city.Items.Add("sharqia");
            txt_city.Items.Add("Shoubra");
            txt_city.Items.Add("Sohag");            
            txt_city.Items.Add("Suez");
            txt_city.Items.Add("Tanta");
            txt_city.SelectedIndex = 5;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_hospital_name_Enter(object sender, EventArgs e)
        {
            if(txt_hospital_name.Text == "HOSPITAL NAME")
            {
                txt_hospital_name.Text = "";
                txt_hospital_name.ForeColor = Color.Black;
            }
        }

        private void txt_hospital_name_Leave(object sender, EventArgs e)
        {
            if (txt_hospital_name.Text == "")
            {
                txt_hospital_name.Text = "HOSPITAL NAME";
                txt_hospital_name.ForeColor = Color.Silver;
            }
        }

        

        private void txt_hospital_address_Enter(object sender, EventArgs e)
        {
            if(txt_hospital_address.Text == "HOSPITAL ADDRESS")
            {
                txt_hospital_address.Text = "";
                txt_hospital_address.ForeColor = Color.Black; ;
            }
        }

        private void txt_hospital_address_Leave(object sender, EventArgs e)
        {
            if (txt_hospital_address.Text == "")
            {
                txt_hospital_address.Text = "HOSPITAL ADDRESS";
                txt_hospital_address.ForeColor = Color.Silver; 
            }
        }

        private void txt_city_Enter(object sender, EventArgs e)
        {
            if( txt_city.Text == "CITY")
            {
                txt_city.Text = "";
                txt_city.ForeColor = Color.Black;
            }
        }
        
        private void txt_city_Leave(object sender, EventArgs e)
        {
            if (txt_city.Text == "")
            {
                txt_city.Text = "CITY";
                txt_city.ForeColor = Color.Silver;
            }
        }


        private void txt_street_Enter(object sender, EventArgs e)
        {
            if(txt_street.Text == "STREET")
            {
                txt_street.Text = "";
                txt_street.ForeColor = Color.Black;
            }
        }

        private void txt_street_Leave(object sender, EventArgs e)
        {
            if (txt_street.Text == "")
            {
                txt_street.Text = "STREET";
                txt_street.ForeColor = Color.Silver;
            }
        }

        private void txt_longitude_Enter(object sender, EventArgs e)
        {
            if(txt_longitude.Text == "LONGITUDE")
            {
                txt_longitude.Text = "";
                txt_longitude.ForeColor = Color.Black;
            }
        }

        private void txt_longitude_Leave(object sender, EventArgs e)
        {
            if (txt_longitude.Text == "")
            {
                txt_longitude.Text = "LONGITUDE";
                txt_longitude.ForeColor = Color.Silver;
            }
        }

        private void txt_latitude_Enter(object sender, EventArgs e)
        {
            if(txt_latitude.Text == "LATITUDE")
            {
                txt_latitude.Text = "";
                txt_latitude.ForeColor = Color.Black;
            }
        }

        private void txt_latitude_Leave(object sender, EventArgs e)
        {
            if (txt_latitude.Text == "")
            {
                txt_latitude.Text = "LATITUDE";
                txt_latitude.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String city = txt_city.Text;
            string street = txt_street.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("http://maps.google.com/maps?q=");

            if(city != string.Empty)
            {
                sb.Append(city + "," + "+");
            }

            if (street != string.Empty)
            {
                sb.Append(street + "," + "+");
            }

            webBrowser1.Navigate(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // connected datadase "table hospitals"
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J5HRLL8;Initial Catalog=Blood_Transformatiom;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into hospitals(hospital_name,pickup_latitude,pickup_longitude,city,hospital_address,hospital_street)" +
                "values('"+txt_hospital_name.Text+"' , '"+txt_latitude.Text+"','"+txt_longitude.Text+"','"+txt_city.Text+"'," +
                " '"+txt_hospital_address.Text+"' ,'"+txt_street.Text+"' )", con);
            cmd.ExecuteNonQuery();

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
