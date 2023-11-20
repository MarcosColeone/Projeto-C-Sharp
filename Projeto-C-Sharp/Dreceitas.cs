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
    public partial class Dreceitas : Form
    {
        public Dreceitas()
        {
            InitializeComponent();
        }

        private void Dreceitas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDpanqueca1_Click(object sender, EventArgs e)
        {
            Dpanqueca1 novaJanela = new Dpanqueca1();
            novaJanela.Text = "Panqueca";
            novaJanela.Show();
        }

        private void btnDcaponata1_Click(object sender, EventArgs e)
        {
            Dcaponata1 novaJanela = new Dcaponata1();
            novaJanela.Text = "Caponata de Berinjela";
            novaJanela.Show();
        }

        private void btnDabobrinha1_Click(object sender, EventArgs e)
        {
            Dabobrinha1 novaJanela = new Dabobrinha1();
            novaJanela.Text = "Abobrinha Recheada";
            novaJanela.Show();
        }

        private void btnDsorvete1_Click(object sender, EventArgs e)
        {
            Dsorvete1 novaJanela = new Dsorvete1();
            novaJanela.Text = "Sorvete";
            novaJanela.Show();
        }

        private void btnDrefresco1_Click(object sender, EventArgs e)
        {
            Drefresco1 novaJanela = new Drefresco1();
            novaJanela.Text = "Refresco de Melancia";
            novaJanela.Show();
        }

        private void btnDbolo1_Click_1(object sender, EventArgs e)
        {
            Dbolo1 novaJanela = new Dbolo1();
            novaJanela.Text = "Bolo de Caneca";
            novaJanela.Show();
        }
    }
}
