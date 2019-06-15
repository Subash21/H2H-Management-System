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
using System.Globalization;
using System.IO;

namespace HandstoHelp
{
    public partial class ViewDetails : UserControl
    {
        public ViewDetails()
        {
            InitializeComponent();
        }

        public void getdata()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from NewMember", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);


                    dgview.AllowUserToAddRows = false;
                    dgview.DataSource = dt;
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    img = (DataGridViewImageColumn)dgview.Columns[8];
                    img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dt.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnview_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from NewMember where FirstName like('%" + txtsearch.Text + "%')", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);


                    dgview.AllowUserToAddRows = false;
                    dgview.DataSource = dt;
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    img = (DataGridViewImageColumn)dgview.Columns[8];
                    img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dt.Dispose();
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(dgview.SelectedRows.Count > 0)
            {
                try
                {
                    UpdateDetails up = new UpdateDetails();
                    up.txtMNo.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    up.txtMNo.Enabled = false;
                    up.txtfname.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    up.txtmname.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                    up.txtlname.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                    if (dgview.SelectedRows[0].Cells[4].Value.ToString() == "Male")
                        up.rbmale.Checked = true;
                    else
                        up.rbfemale.Checked = true;
                    up.txtaddress.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
                    //DateTime dt = DateTime.ParseExact(dgview.SelectedRows[0].Cells[6].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    DateTime dt = DateTime.Parse(dgview.SelectedRows[0].Cells[6].Value.ToString());
                    up.DOBpicker.Value = dt;
                    up.txtemail.Text = dgview.SelectedRows[0].Cells[7].Value.ToString();
                    up.txtmobileno.Text = dgview.SelectedRows[0].Cells[13].Value.ToString();
                    up.txtoccupation.Text = dgview.SelectedRows[0].Cells[14].Value.ToString();
                    byte[] image = (byte[])dgview.SelectedRows[0].Cells[8].Value;
                    up.pictureBox1.Image = Image.FromStream(new MemoryStream(image));
                    up.cbIDProof.Text = dgview.SelectedRows[0].Cells[9].Value.ToString();
                    up.txtidno.Text = dgview.SelectedRows[0].Cells[10].Value.ToString();
                    up.cbpost.Text = dgview.SelectedRows[0].Cells[11].Value.ToString();
                    up.ShowDialog();
                    getdata();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Please Select Row to Update");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(dgview.SelectedRows.Count > 0)
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from NewMember where MembershipNo = @MNo", con);
                    cmd.Parameters.Add("@MNo", SqlDbType.Int, 0, "MemberShipNo").Value = dgview.SelectedRows[0].Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Record has been deleted Successfully");
                    getdata();
                }
            }
            else
            {
                MessageBox.Show("Please Select Row to Update");
            }
        }

        private void btndonordetails_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from DonationDetails", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgview.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
