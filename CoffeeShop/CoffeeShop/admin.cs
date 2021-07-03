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
    public partial class admin : Form
    {
        string str = @"Data Source=.;Initial Catalog=Admi;Integrated Security=True ";
        
        


        public admin()
        {
            InitializeComponent();
        }

       
        

        private void viewad_Click(object sender, EventArgs e)
        {
            
        }

        private void delad_Click(object sender, EventArgs e)
        {
            
          
        }

        private void updad_Click(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void admin_Load(object sender, EventArgs e)
        {
             
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            
            string sql= "insert into adm values('" + txtcad.Text + "', '" + txtpad.Text + "') ";
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Inserted successfully!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
           
        }

        private void lgad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
            
    }
}
