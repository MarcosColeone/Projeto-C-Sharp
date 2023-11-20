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
    public partial class Corientações3 : Form
    {
        public Corientações3()
        {
            InitializeComponent();
        }
        private void Corientações_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorientações4_Click_1(object sender, EventArgs e)
        {
            Corientações4 novaJanela = new Corientações4();
            novaJanela.Text = "Orientações Nutricionais";
            novaJanela.Show();
        }
    }
}
