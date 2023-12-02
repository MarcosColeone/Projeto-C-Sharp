﻿using System;
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
    public partial class ILcoxinha3 : Form
    {
        public ILcoxinha3()
        {
            InitializeComponent();
        }

        private void ILcoxinha3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnILcoxinha4_Click(object sender, EventArgs e)
        {
            ILcoxinha4 novaJanela = new ILcoxinha4();
            novaJanela.Text = "Coxinha";
            novaJanela.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                // Itera sobre as formas abertas, exceto a primeira (principal)
                for (int intIndex = Application.OpenForms.Count - 1; intIndex > 2; intIndex--)
                {
                    Application.OpenForms[intIndex].Close();
                }
            }
        }
    }
}
