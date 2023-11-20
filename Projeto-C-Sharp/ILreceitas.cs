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
    public partial class ILreceitas : Form
    {
        public ILreceitas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ILreceitas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnILcoxinha1_Click(object sender, EventArgs e)
        {
            ILcoxinha1 novaJanela = new ILcoxinha1();
            novaJanela.Text = "Coxinha";
            novaJanela.Show();
        }

        private void btnILcrepioca1_Click(object sender, EventArgs e)
        {
            ILcrepioca1 novaJanela = new ILcrepioca1();
            novaJanela.Text = "Crepioca";
            novaJanela.Show();
        }

        private void btnILescondido1_Click(object sender, EventArgs e)
        {
            ILescondido1 novaJanela = new ILescondido1();
            novaJanela.Text = "Escondidinho";
            novaJanela.Show();
        }

        private void btnILtorta1_Click(object sender, EventArgs e)
        {
            ILtorta1 novaJanela = new ILtorta1();
            novaJanela.Text = "Torta Integral";
            novaJanela.Show();
        }
    }
}
