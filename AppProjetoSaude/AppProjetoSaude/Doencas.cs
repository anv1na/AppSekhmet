﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProjetoSaude
{
    public partial class Doencas : Form
    {
        public Doencas()
        {
            InitializeComponent();
        }

        private void Doencas_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Tratamento trat = new Tratamento();
            trat.ShowDialog();
        }

        private void cboContD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
