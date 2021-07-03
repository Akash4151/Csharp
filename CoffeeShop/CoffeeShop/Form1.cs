using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Coffee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from welc where username= '" + txtuser.Text + "' and password='" + txtpass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemvalue = comboBox1.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                    if (dt.Rows[i]["usertype"].ToString() == cmbItemvalue)
                    {
                        MessageBox.Show("you are login as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            admin ad = new admin();
                            ad.Show();
                            this.Hide();

                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            customer cs = new customer();
                            cs.Show();
                            this.Hide();
 
                        }

                        else
                        {
                            employee emp = new employee();
                            emp.Show();
                            this.Hide();

                        }

                    }

            }
            else
            {
                MessageBox.Show("error");
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
