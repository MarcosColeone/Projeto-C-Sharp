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
    public partial class Cintrodução3 : Form
    {
        public Cintrodução3()
        {
            InitializeComponent();
        }

        private void Cintrodução3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCintrodução4_Click_1(object sender, EventArgs e)
        {
            Cintrodução4 novaJanela = new Cintrodução4();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }
    }
}
