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
    public partial class Dpanqueca1 : Form
    {
        public Dpanqueca1()
        {
            InitializeComponent();
        }

        private void Dpanqueca1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDpanqueca2_Click(object sender, EventArgs e)
        {
            Dpanqueca2 novaJanela = new Dpanqueca2();
            novaJanela.Text = "Panqueca";
            novaJanela.Show();
        }
    }
}
