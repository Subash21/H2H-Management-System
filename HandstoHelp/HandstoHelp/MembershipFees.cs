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
    public partial class MembershipFees : Form
    {
        public MembershipFees()
        {
            InitializeComponent();
        }
        private void getdata()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "Select * from MemberShipFees";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgview.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "Select * from MemberShipFees Where MemberShip_Name like('%" + txtsearch.Text + "%')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgview.DataSource = dt;
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MembershipFees_Load(object sender, EventArgs e)
        {
            getdata();
            panelData.Visible = false;
        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgview.SelectedRows.Count > 0)
            {
                panelData.Visible = true;
                lblMNo.Text = dgview.CurrentRow.Cells[0].Value.ToString();
                lblMName.Text = dgview.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void Updatefees_Click(object sender, EventArgs e)
        {
            if(dgview.SelectedRows.Count > 0)
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "Update MembershipFees set Membership_Fees = Membership_Fees + @Fees,LastPaidMonth=@Month,LastPaidDate=@Date Where MembershipNo = @MNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@Fees", SqlDbType.Money, 0, "Membership_Fees").Value = double.Parse(txtfees.Text);
                        DateTime month = dateTimePicker1.Value;
                        cmd.Parameters.Add("@Month", SqlDbType.VarChar, 50, "LastPaidMonth").Value = month.ToString("MMMM");
                        cmd.Parameters.Add("@Date", SqlDbType.Date, 0, "LastPaidDate").Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@MNo", SqlDbType.Int, 0, "MemberShipNo").Value = int.Parse(lblMNo.Text);
                        cmd.ExecuteNonQuery();
                        getdata();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select Member to Update Details");
            }
        }

        private void btnallmember_Click(object sender, EventArgs e)
        {
            getdata();
        }
        private void btnpaidM_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "Select * from MemberShipFees Where LastPaidMonth = @Month";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DateTime month = DateTime.Now;
                    cmd.Parameters.Add("@Month", SqlDbType.VarChar, 50, "LastPaidMonth").Value = month.ToString("MMMM");
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (dt.Rows.Count > 0)
                    {
                        dgview.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("All Members have paid their fees");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnnotpaidM_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "Select * from MemberShipFees Where month(LastPaidDate) < @Month AND year(LastPaidDate) <= @Year";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int month = DateTime.Now.Month;
                    cmd.Parameters.Add("@Month", SqlDbType.VarChar, 50, "LastPaidMonth").Value = month;
                    int year = DateTime.Now.Year;
                    cmd.Parameters.Add("@Year", SqlDbType.VarChar, 50, "LastPaidDate").Value = year;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (dt.Rows.Count > 0)
                    {
                        dgview.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("All Members have paid their fees");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public  void btnRmail_Click(object sender, EventArgs e)
        {
            DateTime month = DateTime.Now;
            if (dgview.SelectedRows.Count > 0)
            {
                if(dgview.SelectedRows[0].Cells["LastPaidMonth"].Value.ToString() != month.ToString("MMMM"))
                {
                    try
                    {
                        string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            Email email = new Email();
                            con.Open();
                            string query = "Select email from NewMember Where MembershipNo = @MNo";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add("@MNo", SqlDbType.Int, 0, "MembershipNo").Value = Convert.ToInt32(dgview.SelectedRows[0].Cells[0].Value);
                            email.txtemail.Text = Convert.ToString(cmd.ExecuteScalar());
                            email.ShowDialog();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Member You had selected is already Paid the fees Please verify");
                }
            }
            else
            {
                MessageBox.Show("Please Select Member to Send Email");
            }
        }

        private void btnmaximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnminimum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
