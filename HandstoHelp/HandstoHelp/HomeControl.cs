using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandstoHelp
{
    public partial class HomeControl : UserControl
    {
        private int imagenumber = 1;
        public HomeControl()
        {
            InitializeComponent();
        }
        
        private void loadnextimage()
        {
            if(imagenumber == 12)
            {
                imagenumber = 1;
            }
            slidepic.ImageLocation = string.Format(@"images\{0}.jpg", imagenumber);
            imagenumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimage();
        }
    }
}
