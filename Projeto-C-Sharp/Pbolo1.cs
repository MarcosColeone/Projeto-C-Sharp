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
    public partial class Pbolo1 : Form
    {
        public Pbolo1()
        {
            InitializeComponent();
        }

        private void Pbolo1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPbolo2_Click(object sender, EventArgs e)
        {
            Pbolo2 novaJanela = new Pbolo2();
            novaJanela.Text = "Bolo de Banana";
            novaJanela.Show();
        }
    }
}
