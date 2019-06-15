using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;


namespace HandstoHelp
{
    public partial class ImportDetails : UserControl
    {
        DataSet ds = new DataSet();

        
        public ImportDetails()
        {
            InitializeComponent();
        }
        private void fill()
        {
            try
            {
                string path = txtbrowser.Text;
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path + "; Extended Properties=Excel 8.0; Persist Security Info = False");
                OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + txtsheetname.Text + "$]", con);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no sheet with " + txtsheetname.Text + " Name please enter correct name");
            }
        }
      
        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtbrowser.Text = ofd.FileName;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtbrowser.Text != "" && txtsheetname.Text != "")
            {
                this.progressBar1.Increment(50);
                fill();
                dgview.DataSource = ds.Tables[0];
               
            }
            else
            {
                MessageBox.Show("Please Select folder and enter Sheet name !!");
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (txtbrowser.Text != "" && txtsheetname.Text != "")
            {
                this.progressBar1.Increment(100);

                string path = txtbrowser.Text;
                int MNo;
                string fname, mname = null, lname, gender, address, DOB, email, IDproof, IDproofNo, Post;
                Bitmap img;

                fill();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        MNo = int.Parse(dr[0].ToString());
                        fname = dr[1].ToString();
                        mname = dr[2].ToString();
                        lname = dr[3].ToString();
                        gender = dr[4].ToString();
                        address = dr[5].ToString();
                        DOB = dr[6].ToString();
                        email = dr[7].ToString();
                        img = (Bitmap)dr[8]; //dgview.CurrentRow.Cells[8].Value;
                        IDproof = dr[9].ToString();
                        IDproofNo = dr[10].ToString();
                        Post = dr[11].ToString();
                        save(MNo, fname, mname, lname, gender, address, DOB, email, img, IDproof, IDproofNo, Post);
                    }
                    ds.Tables[0].Clear();
                }
                MessageBox.Show("Data Inserted Successfully !!!!!!");
            }
            else
            {
                MessageBox.Show("Please Select folder and enter Sheet name !!");
            }
        }
        private void save(int MNo, string fname, string Mname, string lname, string gender, string address, string Dob, string email, Bitmap img, string IDproof, string IDproofNO, string Post)
        {
            byte[] image = null;

            MemoryStream stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            image = stream.ToArray();

            string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into NewMember values(@MNo,@FName,@MName,@LName,@Gender,@Address,@Dob,@email,@image,@IDProof,@IDProofNo,@Post)", con);
                    cmd.Parameters.Add("@MNo", SqlDbType.Int, 0, "MemberShipNo").Value = MNo;
                    cmd.Parameters.Add("@FName", SqlDbType.VarChar, 200, "FirstName").Value = fname;
                    cmd.Parameters.Add("@MName", SqlDbType.VarChar, 200, "MiddleName").Value = Mname;
                    cmd.Parameters.Add("@LName", SqlDbType.VarChar, 200, "LastName").Value = lname;
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 50, "Gender").Value = gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500, "Address").Value = address;
                    cmd.Parameters.Add("@Dob", SqlDbType.Date, 0, "Dob").Value = DateTime.Parse(Dob);
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email").Value = email;
                    cmd.Parameters.Add("@image", SqlDbType.Image, 0, "Memberimage").Value = image;
                    cmd.Parameters.Add("@IDProof", SqlDbType.NVarChar, 50, "IDProof").Value = IDproof;
                    cmd.Parameters.Add("@IDProofNo", SqlDbType.NVarChar, 50, "IDProofNo").Value = IDproofNO;
                    cmd.Parameters.Add("@Post", SqlDbType.VarChar, 50, "Post").Value = Post;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Membership has been added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
