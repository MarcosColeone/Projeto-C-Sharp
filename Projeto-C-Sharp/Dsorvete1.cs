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
    public partial class Dsorvete1 : Form
    {
        public Dsorvete1()
        {
            InitializeComponent();
        }

        private void Dsorvete1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDsorvete2_Click(object sender, EventArgs e)
        {
            Dsorvete2 novaJanela = new Dsorvete2();
            novaJanela.Text = "Sorvete";
            novaJanela.Show();
        }
    }
}
