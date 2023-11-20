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
    public partial class ILtorta2 : Form
    {
        public ILtorta2()
        {
            InitializeComponent();
        }

        private void ILtorta2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILtorta3_Click(object sender, EventArgs e)
        {
            ILtorta3 novaJanela = new ILtorta3();
            novaJanela.Text = "Torta Integral";
            novaJanela.Show();
        }
    }
}
