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
    public partial class Preceitas : Form
    {
        public Preceitas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPsal1_Click(object sender, EventArgs e)
        {
            Psal1 novaJanela = new Psal1();
            novaJanela.Text = "Sal de Ervas";
            novaJanela.Show();
        }

        private void btnPnuggets1_Click(object sender, EventArgs e)
        {
            Pnuggets1 novaJanela = new Pnuggets1();
            novaJanela.Text = "Nuggets Saudável";
            novaJanela.Show();
        }

        private void btnPbolo1_Click(object sender, EventArgs e)
        {
            Pbolo1 novaJanela = new Pbolo1();
            novaJanela.Text = "Bolo de Banana";
            novaJanela.Show();
        }

        private void btnPpaodequeijo1_Click(object sender, EventArgs e)
        {
            Ppaodequeijo1 novaJanela = new Ppaodequeijo1();
            novaJanela.Text = "Pão de Queijo";
            novaJanela.Show();
        }

        private void btnIPpizza1_Click(object sender, EventArgs e)
        {
            Ppizza1 novaJanela = new Ppizza1();
            novaJanela.Text = "Pizza";
            novaJanela.Show();
        }

        private void Preceitas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }
    }
}
