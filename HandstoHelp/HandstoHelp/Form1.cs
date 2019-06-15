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
using System.Configuration;

namespace HandstoHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtusername.Text != "" && txtpassword.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Login where username = @username And password = @password", con);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (dt.Rows.Count > 0) 
                    {
                        
                        foreach(DataRow dr1 in dt.Rows)
                        {
                            if(dr1["username"].ToString() == txtusername.Text && dr1["password"].ToString() == txtpassword.Text)
                            {
                                this.Hide();
                                MainPage m = new MainPage();
                                m.Show();
                            }
                            else
                            {
                                MessageBox.Show("UserName or Password are invalid", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }  
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password are invalid", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpassword.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please UserName and PassWord filleds cannot be empty", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
                txtusername.Text = "UserName";
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "UserName")
                txtusername.Text = null;


        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.Text = "PassWord";
            }    
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PassWord")
            {
                txtpassword.Text = null;
                txtpassword.UseSystemPasswordChar = true;
            }     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void cbpwd_CheckedChanged(object sender, EventArgs e)
        {
            if(cbpwd.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
