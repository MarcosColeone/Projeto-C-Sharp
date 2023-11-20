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
    public partial class ILescondido1 : Form
    {
        public ILescondido1()
        {
            InitializeComponent();
        }

        private void ILescondido1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILescondido2_Click(object sender, EventArgs e)
        {
            ILescondido2 novaJanela = new ILescondido2();
            novaJanela.Text = "Escondidinho";
            novaJanela.Show();
        }
    }
}
