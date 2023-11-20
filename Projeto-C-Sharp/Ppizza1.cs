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
    public partial class Ppizza1 : Form
    {
        public Ppizza1()
        {
            InitializeComponent();
        }

        private void Ppizza1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnPpizza2_Click(object sender, EventArgs e)
        {
            Ppizza2 novaJanela = new Ppizza2();
            novaJanela.Text = "Pizza Saudável";
            novaJanela.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
