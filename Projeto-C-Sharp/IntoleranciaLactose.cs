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
    public partial class IntoleranciaLactose : Form
    {
        public IntoleranciaLactose()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void IntoleranciaLactose_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnILintrodução_Click(object sender, EventArgs e)
        {
            ILintrodução novaJanela = new ILintrodução();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void btnILcausas_Click(object sender, EventArgs e)
        {
            ILcausas novaJanela = new ILcausas();
            novaJanela.Text = "Causas da Intolerância";
            novaJanela.Show();
        }

        private void btnILsintomas_Click(object sender, EventArgs e)
        {
            ILsintomas novaJanela = new ILsintomas();
            novaJanela.Text = "Sintomas";
            novaJanela.Show();
        }

        private void btnILdiagnóstico_Click(object sender, EventArgs e)
        {
            ILdiagnostico novaJanela = new ILdiagnostico();
            novaJanela.Text = "Diagnótisco";
            novaJanela.Show();
        }

        private void btnILpossoconsumir_Click(object sender, EventArgs e)
        {
            ILpossoconsumir novaJanela = new ILpossoconsumir();
            novaJanela.Text = "Posso consumir Leite e Derivados";
            novaJanela.Show();
        }

        private void btnILreceitas_Click(object sender, EventArgs e)
        {
            ILreceitas novaJanela = new ILreceitas();
            novaJanela.Text = "Receitas";
            novaJanela.Show();
        }
    }
}
