using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetinho
{
    public partial class Drefresco1 : Form
    {
        public Drefresco1()
        {
            InitializeComponent();
        }

        private void Drefresco1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDrefresco2_Click(object sender, EventArgs e)
        {
            Drefresco2 novaJanela = new Drefresco2();
            novaJanela.Text = "Refresco";
            novaJanela.Show();
        }
    }
}
