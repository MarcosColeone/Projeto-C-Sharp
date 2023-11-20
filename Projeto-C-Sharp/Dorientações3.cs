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
    public partial class Dorientações3 : Form
    {
        public Dorientações3()
        {
            InitializeComponent();
        }

        private void Dorientações3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnDorientações4_Click(object sender, EventArgs e)
        {
            Dorientações4 novaJanela = new Dorientações4();
            novaJanela.Text = "Orientações Nutricionais";
            novaJanela.Show();
        }
    }
}
