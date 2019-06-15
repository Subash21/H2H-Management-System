using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandstoHelp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            SlidePanel.Height = button2.Height;
            SlidePanel.Top = button2.Top;
            homeControl2.BringToFront();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button2.Height;
            SlidePanel.Top = button2.Top;
            homeControl2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button3.Height;
            SlidePanel.Top = button3.Top;
            addDetails2.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button4.Height;
            SlidePanel.Top = button4.Top;
            importDetails2.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button5.Height;
            SlidePanel.Top = button5.Top;
            viewDetails1.BringToFront();
            
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnDonor.Height;
            SlidePanel.Top = btnDonor.Top;
            donorDetails2.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            MembershipFees mf = new MembershipFees();
            mf.ShowDialog();
        }
    }
}
