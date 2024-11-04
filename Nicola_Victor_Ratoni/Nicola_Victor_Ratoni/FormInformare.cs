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
    public partial class FormInformare : Form
    {
        public FormInformare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMozaic formMozaic = new FormMozaic();
            formMozaic.ShowDialog();
        }
    }
}
