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
    public partial class Cintrodução : Form
    {
        public Cintrodução()
        {
            InitializeComponent();
        }

        private void Cintrodução_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCintrodução2_Click(object sender, EventArgs e)
        {
            Cintrodução2 novaJanela = new Cintrodução2();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
