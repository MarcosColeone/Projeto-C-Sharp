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
    public partial class ILcoxinha1 : Form
    {
        public ILcoxinha1()
        {
            InitializeComponent();
        }

        private void ILcoxinha1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnILcoxinha2_Click(object sender, EventArgs e)
        {
            ILcoxinha2 novaJanela = new ILcoxinha2();
            novaJanela.Text = "Coxinha";
            novaJanela.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
