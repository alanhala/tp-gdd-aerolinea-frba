﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaFinVidaUtil : Form
    {
        public BajaFinVidaUtil()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            string bajaAeronave = "UPDATE JUST_DO_IT.Aeronaves SET baja_vida_util = 1 WHERE matricula = '" + tbNumeroMatricula.Text + "'";
            server.query(bajaAeronave);
            server.closeReader();
        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}