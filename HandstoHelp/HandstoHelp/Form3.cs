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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select * from Recover where MobileNo = @MobileNo and fullname = @fullname", con);
                        cmd.Parameters.AddWithValue("@MobileNo", textBox1.Text);
                        cmd.Parameters.AddWithValue("@fullname", textBox2.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        if (dt.Rows.Count > 0)
                        {
                            try
                            {
                                string cs1 = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                                using (SqlConnection con1 = new SqlConnection(cs1))
                                {
                                    con1.Open();
                                    SqlCommand cmd1 = new SqlCommand("Select * from Login", con1);
                                    SqlDataReader dr1 = cmd1.ExecuteReader();
                                    while (dr1.Read())
                                    {
                                        lblUser.Text = "Your username is " + dr1["username"].ToString() ;
                                        lblpass.Text = "Your Password is " + dr1["password"].ToString();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("MobileNo. or FullName are invalid", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please MobileNo and FullName filleds cannot be empty", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
