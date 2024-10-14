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

namespace Nicola_Victor_Ratoni
{
    public partial class FormGrila : Form
    {
        public int nrIntrebari, nrIntrebariCorecte;
        private StreamReader reader = new StreamReader("assets\\intrebari.txt");

        public void CitesteIntrebari()
        {

        }

        public FormGrila()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
