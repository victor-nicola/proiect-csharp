using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nicola_Victor_Ratoni
{
    public partial class FormMozaic : Form
    {
        public FormMozaic()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Width *= 2;
            (sender as PictureBox).Height *= 2;
            (sender as PictureBox).BringToFront();

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Width /= 2;
            (sender as PictureBox).Height /= 2;
        }
    }
}
