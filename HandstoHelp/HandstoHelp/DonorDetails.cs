using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace HandstoHelp
{
    public partial class DonorDetails : UserControl
    {
        
        public DonorDetails()
        {
            InitializeComponent();
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "Insert into DonationDetails values(@ReceiptNo,@Name,@Date,@Amount,@DonatedIN,@PANCardNo,@Address,@Email,@Description)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@ReceiptNo", SqlDbType.Int, 0, "ReceiptNo").Value = int.Parse(txtreceiptno.Text);
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 250, "Name").Value = txtname.Text;
                        cmd.Parameters.Add("@Date", SqlDbType.Date, 0, "ReceiptDate").Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@Amount", SqlDbType.Money, 0, "Amount").Value = double.Parse(txtamount.Text);
                        cmd.Parameters.Add("@DonatedIN", SqlDbType.VarChar, 100, "DonationIN").Value = comboBox1.SelectedItem.ToString();
                        cmd.Parameters.Add("@PANCardNo", SqlDbType.NVarChar, 100, "PANCardNo").Value = txtCardNo.Text;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500, "Address").Value = txtaddress.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "emailID").Value = txtemail.Text;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500, "Descripetion").Value = txtdiscreption.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Donor Details has been stored");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                using (SqlConnection con1 = new SqlConnection(cs))
                {
                    try
                    {
                        con1.Open();
                        SqlCommand cmd = new SqlCommand("Select * from DonationDetails Where ReceiptNo = " + txtreceiptno.Text + "", con1);
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        CrystalReport cr = new CrystalReport();
                        CrystalReport1 c = new CrystalReport1();
                        c.SetDataSource(dt);
                        cr.crystalReportViewer1.ReportSource = c;
                        cr.crystalReportViewer1.Refresh();
                        cr.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Email e1 = new Email();
            e1.ShowDialog();
        }

        private void btnOldReceipt_Click(object sender, EventArgs e)
        {
            OldReceipt or = new OldReceipt();
            or.ShowDialog();
        }

        private void btnSetNo_Click(object sender, EventArgs e)
        {
            if(txtreceiptno.Text == "")
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Max(ReceiptNo) from DonationDetails", con);
                        int count = (int)cmd.ExecuteScalar();
                        count++;
                        txtreceiptno.Text = count.ToString();
                        txtreceiptno.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Clear Data From RNo. Column");
            }
            
        }
        private bool validate()
        {
            if (txtreceiptno.Text == "" || txtname.Text == "" || txtamount.Text == "" || comboBox1.SelectedIndex == -1 || txtCardNo.Text == "" || txtaddress.Text == "" || txtdiscreption.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory !!!!");
                if(txtreceiptno.Text == "")
                {
                    errorProvider1.SetError(txtreceiptno, "Please Enter or Set Recepit No.");
                    return false;
                }
                else if(txtname.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtname, "Please Enter Donors Name");
                    return false;
                }
                else if(txtamount.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtamount, "Please Enter Donation Amount");
                    return false;
                }
                else if(comboBox1.SelectedIndex == -1)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(comboBox1, "Please Select Donation Payment Mode");
                    return false;
                }
                else if(txtCardNo.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCardNo, "Please enter Donors PAN Card No.");
                    return false;
                }
                else if(txtaddress.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtaddress, "Please enter Donors Address");
                    return false;
                }
                else if(txtdiscreption.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtdiscreption, "Please enter Discreption");
                    return false;
                }
                errorProvider1.Clear();
                return false;
            }
            else if (!Regex.Match(txtreceiptno.Text, "^[0-9]+$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtreceiptno, "Invalid Receipt No.");
                return false;
            }
            else if(!Regex.Match(txtname.Text, @"^[a-zA-Z\s]+$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtname, "Invalid Donor Name");
                return false;
            }
            else if (txtemail.Text != "" && (!Regex.Match(txtemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtemail, "Invalid Middle Name");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    
}
