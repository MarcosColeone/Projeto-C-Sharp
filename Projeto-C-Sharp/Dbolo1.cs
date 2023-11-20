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
    public partial class Dbolo1 : Form
    {
        public Dbolo1()
        {
            InitializeComponent();
        }

        private void Dbolo1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDbolo2_Click(object sender, EventArgs e)
        {
            Dbolo2 novaJanela = new Dbolo2();
            novaJanela.Text = "Bolo de Caneca";
            novaJanela.Show();
        }
    }
}
