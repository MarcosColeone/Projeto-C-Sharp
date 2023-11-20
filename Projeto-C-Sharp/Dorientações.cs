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
    public partial class Dorientações : Form
    {
        public Dorientações()
        {
            InitializeComponent();
        }

        private void Dorientações_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDorientações2_Click(object sender, EventArgs e)
        {
            Dorientações2 novaJanela = new Dorientações2();
            novaJanela.Text = "Orientações Nutricionais";
            novaJanela.Show();
        }
    }
}
