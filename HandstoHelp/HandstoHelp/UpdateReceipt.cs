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
using System.Text.RegularExpressions;

namespace HandstoHelp
{
    public partial class UpdateReceipt : Form
    {
        public UpdateReceipt()
        {
            InitializeComponent();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdatereceipt_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "update DonationDetails set Name = @Name,ReceiptDate = @Date,Amount = @Amount,DonationIn = @In,PANCardNo = @CardNo,Address = @Address,emailid = @email,Descripetion = @Descripetion where ReceiptNo = @ReceiptNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 250, "Name").Value = txtname.Text;
                    cmd.Parameters.Add("@Date", SqlDbType.Date, 0, "ReceiptDate").Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@Amount", SqlDbType.Money, 0, "Amount").Value = txtamount.Text;
                    cmd.Parameters.Add("@In", SqlDbType.VarChar, 100, "DonationIn").Value = comboBox1.Text;
                    cmd.Parameters.Add("@CardNo", SqlDbType.NVarChar, 100, "PANCardNO").Value = txtCardNo.Text;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500, "Address").Value = txtaddress.Text;
                    if (txtemail.Text == null)
                    {
                        object email = null;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100, "emailid").Value = email;
                    }
                    else
                    {
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100, "emailid").Value = txtemail.Text;
                    }
                    cmd.Parameters.Add("@Descripetion", SqlDbType.NVarChar, 500, "Descripetion").Value = txtdiscreption.Text;
                    cmd.Parameters.Add("@ReceiptNo", SqlDbType.Int, 0, "ReceiptNo").Value = txtreceiptno.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validate()
        {
            if (txtreceiptno.Text == "" || txtname.Text == "" || txtamount.Text == "" || comboBox1.SelectedIndex == -1 || txtCardNo.Text == "" || txtaddress.Text == "" || txtdiscreption.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory !!!!");
                if (txtreceiptno.Text == "")
                {
                    errorProvider1.SetError(txtreceiptno, "Please Enter or Set Recepit No.");
                    return false;
                }
                else if (txtname.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtname, "Please Enter Donors Name");
                    return false;
                }
                else if (txtamount.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtamount, "Please Enter Donation Amount");
                    return false;
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(comboBox1, "Please Select Donation Payment Mode");
                    return false;
                }
                else if (txtCardNo.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCardNo, "Please enter Donors PAN Card No.");
                    return false;
                }
                else if (txtaddress.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtaddress, "Please enter Donors Address");
                    return false;
                }
                else if (txtdiscreption.Text == "")
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
            else if (!Regex.Match(txtname.Text, @"^[a-zA-Z\s]+$").Success)
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
