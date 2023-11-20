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
    public partial class Pnuggets1 : Form
    {
        public Pnuggets1()
        {
            InitializeComponent();
        }

        private void Pnuggets1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPnuggets2_Click(object sender, EventArgs e)
        {
            Pnuggets2 novaJanela = new Pnuggets2();
            novaJanela.Text = "Nuggets Saudável";
            novaJanela.Show();
        }
    }
}
