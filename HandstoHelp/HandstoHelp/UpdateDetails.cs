using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace HandstoHelp
{
    public partial class UpdateDetails : Form
    {
        string gender;
        public UpdateDetails()
        {
            InitializeComponent();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminmax_Click(object sender, EventArgs e)
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

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
               MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] image = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(image, 0, image.Length);
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update NewMember set FirstName = @FName, MiddleName = @MName,LastName = @LName,Gender = @Gender,Address = @Address,Dob = @Dob,email = @email,Memberimage = @image,IDProof = @IDProof,IDProofNo = @IDProofNo,Post = @Post,Mobile_No = @MobileNo,Occupation = @Occupation where MembershipNo = @MNo", con);
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
                        cmd.Parameters.Add("@MobileNo", SqlDbType.NVarChar, 50, "Mobile_No").Value = txtmobileno.Text;
                        cmd.Parameters.Add("@occupation", SqlDbType.VarChar, 50, "occupation").Value = txtoccupation.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txtfname.Text + " Your Membership Details has been Updated");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
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
            if (txtMNo.Text == "" || txtfname.Text == "" || txtlname.Text == "" || (rbmale.Checked == false && rbfemale.Checked == false) || txtemail.Text == ""
                || txtmobileno.Text == "" || txtoccupation.Text == "" || pictureBox1.Image == null || txtidno.Text == "" || cbIDProof.SelectedIndex == -1 || cbpost.SelectedIndex == -1)
            {
                if (txtMNo.Text == "")
                {
                    errorProvider1.SetError(txtMNo, "Please Enter or Set Membership No.");
                    return false;
                }
                else if (txtfname.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtfname, "Please Enter First Name");
                    return false;
                }
                else if (txtlname.Text == "")
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
                else if (txtaddress.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtaddress, "Please Enter Address of Member");
                    return false;
                }
                else if (txtemail.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtemail, "Please Enter Member email");
                    return false;
                }
                else if(txtmobileno.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtmobileno, "Please Enter Member mobile No");
                    return false;
                }
                else if(txtoccupation.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtoccupation, "Please Enter Member Occupation");
                    return false;
                }
                else if (pictureBox1.Image == null)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtidno, "Please Enter " + cbIDProof.SelectedItem + " No.");
                    return false;
                }
                else if (cbIDProof.SelectedIndex == -1)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbIDProof, "Please Select Any ID Proof");
                    return false;
                }
                errorProvider1.Clear();
                return false;
            }
            else if (!Regex.Match(txtMNo.Text, "^[0-9]+$").Success)
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
            else if (txtmname.Text != "" && (!Regex.Match(txtmname.Text, @"^[a-zA-Z\s]+$").Success))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtmname, "Invalid Middle Name");
                return false;
            }
            else if (!Regex.Match(txtlname.Text, @"^[a-zA-Z\s]+$").Success)
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

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imgloc;
                imgloc = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }
    }
}
