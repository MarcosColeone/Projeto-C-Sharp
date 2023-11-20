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
    public partial class ILtorta1 : Form
    {
        public ILtorta1()
        {
            InitializeComponent();
        }

        private void ILtorta1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILtorta2_Click(object sender, EventArgs e)
        {
            ILtorta2 novaJanela = new ILtorta2();
            novaJanela.Text = "Torta Integral";
            novaJanela.Show();
        }
    }
}
