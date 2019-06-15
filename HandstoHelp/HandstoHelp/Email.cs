using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace HandstoHelp
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txtemail.Text, txtDonoremail.Text, txtemailsubject.Text, txtemailbody.Text);
                mail.Attachments.Add(new Attachment(txtattachmentpath.Text.ToString()));
                SmtpClient client = new SmtpClient();
                client.Host = cbsmtp.SelectedItem.ToString();

                client.Port = 587;
                client.Credentials = new NetworkCredential(txtemail.Text, txtpassword.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail Sent");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Select File";
            opd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif |All Files(*.*)|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                string path = opd.FileName.ToString();
                txtattachmentpath.Text = path;
            }
        }
        private void clear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            txtemail.Focus();
            cbsmtp.SelectedItem = null;
        }
    }
}
