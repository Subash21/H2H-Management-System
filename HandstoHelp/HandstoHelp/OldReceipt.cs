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
    public partial class OldReceipt : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbc"].ConnectionString;
        public OldReceipt()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from DonationDetails", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OldReceipt_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtRno.Text =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btngeneratereceipt_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlConnection con1 = new SqlConnection(cs))
                    {
                        con1.Open();
                        SqlCommand cmd = new SqlCommand("Select * from DonationDetails Where ReceiptNo = " + txtRno.Text + "", con1);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void btnminimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btndeletereceipt_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "Delete DonationDetails Where ReceiptNo = " + txtRno.Text+"";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully");
                        getdata();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnupdatereceipt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                UpdateReceipt up = new UpdateReceipt();
                up.txtreceiptno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                up.txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DateTime dt = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                up.dateTimePicker1.Value = dt;
                up.txtamount.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                up.comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                up.txtCardNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                up.txtaddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                up.txtemail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                up.txtdiscreption.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                up.ShowDialog();
                getdata();
            }
            else
            {
                MessageBox.Show("Please select Donation Receipt");
            }
            
        }
    }
}
