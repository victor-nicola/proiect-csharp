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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormInformare f = new FormInformare();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRelaxare f = new FormRelaxare();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTestare f = new FormTestare();
            f.Show();
        }
    }
}
