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
    public partial class ILescondido3 : Form
    {
        public ILescondido3()
        {
            InitializeComponent();
        }

        private void ILescondido3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILescondido4_Click(object sender, EventArgs e)
        {
            ILescondido4 novaJanela = new ILescondido4();
            novaJanela.Text = "Escondidinho";
            novaJanela.Show();
        }
    }
}
