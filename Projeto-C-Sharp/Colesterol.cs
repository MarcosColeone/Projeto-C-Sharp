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
    public partial class Colesterol : Form
    {
        public Colesterol()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Colesterol_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnCintrodução_Click(object sender, EventArgs e)
        {
            Cintrodução novaJanela = new Cintrodução();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void btnCfatoresderisco_Click(object sender, EventArgs e)
        {
            Cfatoresderisco novaJanela = new Cfatoresderisco();
            novaJanela.Text = "Fatores de Risco";
            novaJanela.Show();
        }

        private void btnCorientações_Click(object sender, EventArgs e)
        {
            Corientações novaJanela = new Corientações();
            novaJanela.Text = "Orientções Nutricionais";
            novaJanela.Show();
        }

        private void Colesterol_Load_1(object sender, EventArgs e)
        {

        }
    }
}
