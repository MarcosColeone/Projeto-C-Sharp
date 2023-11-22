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
    public partial class Dorientações2 : Form
    {
        public Dorientações2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDorientações3_Click(object sender, EventArgs e)
        {
            Dorientações3 novaJanela = new Dorientações3();
            novaJanela.Text = "Orientações Nutricionais";
            novaJanela.Show();
        }

        private void Dorientações2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                // Itera sobre as formas abertas, exceto a primeira (principal)
                for (int intIndex = Application.OpenForms.Count - 1; intIndex > 1; intIndex--)
                {
                    Application.OpenForms[intIndex].Close();
                }
            }
        }
    }
}
