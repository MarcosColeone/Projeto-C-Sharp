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
    public partial class ILcrepioca1 : Form
    {
        public ILcrepioca1()
        {
            InitializeComponent();
        }

        private void ILcrepioca1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnILcrepioca2_Click(object sender, EventArgs e)
        {
            ILcrepioca2 novaJanela = new ILcrepioca2();
            novaJanela.Text = "Crepioca";
            novaJanela.Show();
        }
    }
}
