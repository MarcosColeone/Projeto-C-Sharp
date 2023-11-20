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
    public partial class Dabobrinha1 : Form
    {
        public Dabobrinha1()
        {
            InitializeComponent();
        }

        private void Dabobrinha1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDabobrinha_Click(object sender, EventArgs e)
        {
            Dabobrinha2 novaJanela = new Dabobrinha2();
            novaJanela.Text = "Abobrinha";
            novaJanela.Show();
        }
    }
}
