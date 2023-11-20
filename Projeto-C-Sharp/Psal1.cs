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
    public partial class Psal1 : Form
    {
        public Psal1()
        {
            InitializeComponent();
        }

        private void Psal1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPsal2_Click(object sender, EventArgs e)
        {
            Psal2 novaJanela = new Psal2();
            novaJanela.Text = "Sal de Ervas";
            novaJanela.Show();
        }
    }
}
