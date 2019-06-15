using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace HandstoHelp
{
    public partial class AddDetails : UserControl
    {
        string imgloc = "", gender = string.Empty;
        public AddDetails()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Max(MemberShipNo) from NewMember", con);   
                        int count = (int)cmd.ExecuteScalar();
                        count++;
                        txtMNo.Text = count.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imgloc = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }

        private void cbIDProof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDProof.SelectedItem.ToString() != "Others" && cbIDProof.SelectedIndex != 0)
            {
                label10.Text = cbIDProof.SelectedItem + " No.";
            }
            else
            {
                label10.Text = "ID No.";
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            
            if (validate() == true)
            {
                byte[] image = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into NewMember values(@MNo,@FName,@MName,@LName,@Gender,@Address,@Dob,@email,@image,@IDProof,@IDProofNo,@Post,@JoiningDate,@MobileNo,@occupation)", con);
                        cmd.Parameters.Add("@MNo", SqlDbType.Int, 0, "MemberShipNo").Value = txtMNo.Text;
                        cmd.Parameters.Add("@FName", SqlDbType.VarChar, 200, "FirstName").Value = txtfname.Text;
                        cmd.Parameters.Add("@MName", SqlDbType.VarChar, 200, "MiddleName").Value = txtmname.Text;
                        cmd.Parameters.Add("@LName", SqlDbType.VarChar, 200, "LastName").Value = txtlname.Text;
                        cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 50, "Gender").Value = gender1();
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500, "Address").Value = txtaddress.Text;
                        cmd.Parameters.Add("@Dob", SqlDbType.Date, 0, "Dob").Value = DOBpicker.Value;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email").Value = txtemail.Text;
                        cmd.Parameters.Add("@image", SqlDbType.Image, 0, "Memberimage").Value = image;
                        cmd.Parameters.Add("@IDProof", SqlDbType.NVarChar, 50, "IDProof").Value = cbIDProof.Text;
                        cmd.Parameters.Add("@IDProofNo", SqlDbType.NVarChar, 50, "IDProofNo").Value = txtidno.Text;
                        cmd.Parameters.Add("@Post", SqlDbType.VarChar, 50, "Post").Value = cbpost.Text;
                        cmd.Parameters.Add("@JoiningDate", SqlDbType.Date, 0, "Joinedon").Value = dtpJoinedon.Value;
                        cmd.Parameters.Add("@MobileNo", SqlDbType.NVarChar, 50, "Mobile_No").Value = txtmobileno.Text;
                        cmd.Parameters.Add("@occupation", SqlDbType.VarChar, 50, "occupation").Value = txtoccupation.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txtfname.Text + " Your Membership has been added");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 
                    try
                    {
                        string cs1 = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                        using (SqlConnection con1 = new SqlConnection(cs1))
                        {
                            con1.Open();
                            string name = txtfname.Text + " " + txtmname.Text + " " + txtlname.Text;
                            string query = "Insert into Membershipfees values(@MembershipNo,@MembershipName,@Fees,@Month,@Date)";
                            SqlCommand cmd = new SqlCommand(query, con1);
                            cmd.Parameters.Add("@MemberShipNo", SqlDbType.Int, 0, "MemberShipNo").Value = txtMNo.Text;
                            cmd.Parameters.Add("@MembershipName", SqlDbType.NVarChar, 100, "MemberShip_Name").Value = name;
                            cmd.Parameters.Add("@Fees", SqlDbType.Money, 0, "Membership_Fees").Value = double.Parse(txtmfees.Text);
                            DateTime month = dtpJoinedon.Value;
                            cmd.Parameters.Add("@Month", SqlDbType.VarChar, 50, "LastPaidMonth").Value = month.ToString("MMMM");
                            cmd.Parameters.Add("@Date", SqlDbType.Date, 0, "LastPaidDate").Value = dtpJoinedon.Value;
                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    clear();
                }
            }
        }
      
        public void clear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }  
            }
            txtMNo.Enabled = true;
            txtMNo.Focus();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            pictureBox1.Image = null;
            pictureBox1.Update();
            dtpJoinedon.Value = DateTime.Today;
            DOBpicker.Value = DateTime.Today;
            cbIDProof.SelectedIndex = 0;
            cbpost.SelectedIndex = 0;
            errorProvider1.Clear();
            
            
        }
        public string gender1()
        {
            if (rbmale.Checked)
            {
                return gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                return gender = "Female";
            }
            else
            {
                return gender = "";
            }   
        }
        public bool validate()
        {
            if(txtMNo.Text == "" || txtfname.Text == "" || txtlname.Text == "" || (rbmale.Checked == false && rbfemale.Checked == false) || txtemail.Text == "" || txtmobileno.Text == "" || txtoccupation.Text == ""
                || pictureBox1.Image == null || txtidno.Text == "" || (cbIDProof.SelectedIndex == -1 && cbIDProof.SelectedIndex == 0) || (cbpost.SelectedIndex == -1 && cbpost.SelectedIndex == 0))
            {
                MessageBox.Show("All Fields are Mandatory !!!!");
                if(txtMNo.Text == "")
                {
                    errorProvider1.SetError(txtMNo, "Please Enter or Set Membership No.");
                    return false;
                }
                
                else if(txtfname.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtfname, "Please Enter First Name");
                    return false;
                }
                else if(txtlname.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtlname, "Please Enter Last Name");
                    return false;
                }
                else if (rbmale.Checked == false && rbfemale.Checked == false)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(rbfemale, "Please Select either Male or Female");
                    return false;
                }
                else if(txtaddress.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtaddress, "Please Enter Address of Member");
                    return false;
                }
                else if(txtemail.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtemail, "Please Enter Member email");
                    return false;
                }
                else if(txtmobileno.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtmobileno, "Please Enter Member Mobile No.");
                    return false;
                }
                else if(txtoccupation.Text == "")
                {

                    errorProvider1.Clear();
                    errorProvider1.SetError(txtoccupation, "Please Enter Member Occupation");
                    return false;
                }
                else if(pictureBox1.Image == null)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(pictureBox1, "Please Select Member Image");
                    return false;
                }
                else if(txtidno.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtidno, "Please Enter " + cbIDProof.SelectedItem + " No.");
                    return false;
                }
                else if(cbIDProof.SelectedIndex == -1 && cbIDProof.SelectedIndex == 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbIDProof, "Please Select Any ID Proof");
                    return false;
                }
                else if(cbpost.SelectedIndex == -1 && cbpost.SelectedIndex == 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbpost, "Please Select Any Post");
                    return false;
                }
               errorProvider1.Clear();
               return false;
            }
            else if(!Regex.Match(txtMNo.Text, "^[0-9]+$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMNo, "Invalid Membership No.");
                return false;
            }
            else if (!Regex.Match(txtfname.Text, @"^[a-zA-Z\s]+$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtfname, "Invalid First Name");
                return false;
            }
            else if(txtmname.Text != "" && (!Regex.Match(txtmname.Text, @"^[a-zA-Z\s]+$").Success))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtmname, "Invalid Middle Name");
                return false;
            }
            else if(!Regex.Match(txtlname.Text, @"^[a-zA-Z\s]+$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtlname, "Invalid Last Name");
                return false;
            }
            else if (!Regex.Match(txtmobileno.Text, "(^[0-9]{10}$)").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtmobileno, "Invalid mobile No.");
                return false;
            }
            else if (!Regex.Match(txtemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtemail, "Invalid Email No.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
