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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void btnvoltarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconcluirC_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
