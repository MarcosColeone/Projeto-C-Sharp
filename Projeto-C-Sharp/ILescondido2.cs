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
    public partial class ILescondido2 : Form
    {
        public ILescondido2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILescondido3_Click(object sender, EventArgs e)
        {
            ILescondido3 novaJanela = new ILescondido3();
            novaJanela.Text = "Escondidinho";
            novaJanela.Show();
        }
    }
}
