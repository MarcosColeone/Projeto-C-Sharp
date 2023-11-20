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
    public partial class Dcaponata1 : Form
    {
        public Dcaponata1()
        {
            InitializeComponent();
        }

        private void Dcaponata1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDcaponata2_Click(object sender, EventArgs e)
        {
            Dcaponata2 novaJanela = new Dcaponata2();
            novaJanela.Text = "Caponata de Berinjela";
            novaJanela.Show();
        }
    }
}
