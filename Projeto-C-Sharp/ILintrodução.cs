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
    public partial class ILintrodução : Form
    {
        public ILintrodução()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILintrodução2_Click(object sender, EventArgs e)
        {
            ILintrodução2 novaJanela = new ILintrodução2();
            novaJanela.Text = "Introdução";
            novaJanela.Show();
        }

        private void ILintrodução_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }
    }
}
