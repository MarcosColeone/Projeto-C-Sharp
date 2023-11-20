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
    public partial class Diabetes : Form
    {
        public Diabetes()
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
        private void Diabetes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnDintrodução_Click(object sender, EventArgs e)
        {
            Dintrodução novaJanela = new Dintrodução();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void btnDorientações_Click(object sender, EventArgs e)
        {
            Dorientações novaJanela = new Dorientações();
            novaJanela.Text = "Orientações para o tratamento";
            novaJanela.Show();
        }

        private void btnDreceitas_Click(object sender, EventArgs e)
        {
            Dreceitas novaJanela = new Dreceitas();
            novaJanela.Text = "Receitas";
            novaJanela.Show();
        }
    }
}
