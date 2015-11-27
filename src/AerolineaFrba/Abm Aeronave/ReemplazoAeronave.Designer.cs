﻿namespace AerolineaFrba.Abm_Aeronave
{
    partial class ReemplazoAeronave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAeronaves = new System.Windows.Forms.DataGridView();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbutacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReemplazarAeronave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAeronaves
            // 
            this.dgvAeronaves.AllowUserToAddRows = false;
            this.dgvAeronaves.AllowUserToDeleteRows = false;
            this.dgvAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeronaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatricula,
            this.colbutacas,
            this.colKgs,
            this.colTipoServicio});
            this.dgvAeronaves.Location = new System.Drawing.Point(36, 60);
            this.dgvAeronaves.Name = "dgvAeronaves";
            this.dgvAeronaves.ReadOnly = true;
            this.dgvAeronaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAeronaves.Size = new System.Drawing.Size(444, 255);
            this.dgvAeronaves.TabIndex = 1;
            this.dgvAeronaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDeRutas_CellContentClick);
            // 
            // colMatricula
            // 
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            // 
            // colbutacas
            // 
            this.colbutacas.HeaderText = "Cantidad de butacas";
            this.colbutacas.Name = "colbutacas";
            this.colbutacas.ReadOnly = true;
            // 
            // colKgs
            // 
            this.colKgs.HeaderText = "Kgs Disponibles";
            this.colKgs.Name = "colKgs";
            this.colKgs.ReadOnly = true;
            // 
            // colTipoServicio
            // 
            this.colTipoServicio.HeaderText = "Tipo de Servicio";
            this.colTipoServicio.Name = "colTipoServicio";
            this.colTipoServicio.ReadOnly = true;
            // 
            // btnReemplazarAeronave
            // 
            this.btnReemplazarAeronave.Location = new System.Drawing.Point(332, 328);
            this.btnReemplazarAeronave.Name = "btnReemplazarAeronave";
            this.btnReemplazarAeronave.Size = new System.Drawing.Size(148, 23);
            this.btnReemplazarAeronave.TabIndex = 2;
            this.btnReemplazarAeronave.Text = "Reemplazar Aeronave";
            this.btnReemplazarAeronave.UseVisualStyleBackColor = true;
            this.btnReemplazarAeronave.UseWaitCursor = true;
            this.btnReemplazarAeronave.Click += new System.EventHandler(this.btnReemplazarAeronave_Click);
            // 
            // ReemplazoAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 363);
            this.Controls.Add(this.btnReemplazarAeronave);
            this.Controls.Add(this.dgvAeronaves);
            this.Name = "ReemplazoAeronave";
            this.Text = "Seleccionar el reemplazo de la Aeronave";
            this.Load += new System.EventHandler(this.ReemplazoAeronaveFinVidaUtil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAeronaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbutacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoServicio;
        private System.Windows.Forms.Button btnReemplazarAeronave;
    }
}