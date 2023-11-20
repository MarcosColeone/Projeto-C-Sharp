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
    public partial class PressaoAlta : Form
    {
        public PressaoAlta()
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
        private void PressaoAlta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnPintrodução_Click(object sender, EventArgs e)
        {
            Pintrodução novaJanela = new Pintrodução();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void btnPorientações1_Click(object sender, EventArgs e)
        {
            Porientações1 novaJanela = new Porientações1();
            novaJanela.Text = "Orientações";
            novaJanela.Show();
        }

        private void btnPreceitas_Click(object sender, EventArgs e)
        {
            Preceitas novaJanela = new Preceitas();
            novaJanela.Text = "Receitas";
            novaJanela.Show();
        }
    }
}
