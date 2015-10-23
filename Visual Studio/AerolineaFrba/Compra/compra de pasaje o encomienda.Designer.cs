﻿namespace AerolineaFrba.Compra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFechaLlegadaVuelo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaSalidaVuelo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCiudadDestino = new System.Windows.Forms.TextBox();
            this.tbCiudadOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.viajeDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantButacasLibres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPasajesAComprar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgAEnviar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprarPasaje = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Compra de Pasaje/Encomienda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaLlegadaVuelo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpFechaSalidaVuelo);
            this.groupBox3.Location = new System.Drawing.Point(212, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 79);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del vuelo";
            // 
            // dtpFechaLlegadaVuelo
            // 
            this.dtpFechaLlegadaVuelo.Location = new System.Drawing.Point(158, 49);
            this.dtpFechaLlegadaVuelo.Name = "dtpFechaLlegadaVuelo";
            this.dtpFechaLlegadaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLlegadaVuelo.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha Llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha Salida";
            // 
            // dtpFechaSalidaVuelo
            // 
            this.dtpFechaSalidaVuelo.Location = new System.Drawing.Point(158, 20);
            this.dtpFechaSalidaVuelo.Name = "dtpFechaSalidaVuelo";
            this.dtpFechaSalidaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalidaVuelo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCiudadDestino);
            this.groupBox1.Controls.Add(this.tbCiudadOrigen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(212, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la ruta";
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Location = new System.Drawing.Point(230, 43);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(128, 20);
            this.tbCiudadDestino.TabIndex = 14;
            // 
            // tbCiudadOrigen
            // 
            this.tbCiudadOrigen.Location = new System.Drawing.Point(230, 18);
            this.tbCiudadOrigen.Name = "tbCiudadOrigen";
            this.tbCiudadOrigen.Size = new System.Drawing.Size(128, 20);
            this.tbCiudadOrigen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ciudad Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad Origen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvViajesDisponibles
            // 
            this.dgvViajesDisponibles.AllowUserToAddRows = false;
            this.dgvViajesDisponibles.AllowUserToDeleteRows = false;
            this.dgvViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viajeDisponible,
            this.cantButacasLibres,
            this.kgDisponibles,
            this.tipoServicio,
            this.cantPasajesAComprar,
            this.kgAEnviar,
            this.comprarPasaje});
            this.dgvViajesDisponibles.Location = new System.Drawing.Point(27, 256);
            this.dgvViajesDisponibles.Name = "dgvViajesDisponibles";
            this.dgvViajesDisponibles.ReadOnly = true;
            this.dgvViajesDisponibles.Size = new System.Drawing.Size(744, 133);
            this.dgvViajesDisponibles.TabIndex = 18;
            // 
            // viajeDisponible
            // 
            this.viajeDisponible.HeaderText = "Viajes Disponibles";
            this.viajeDisponible.Name = "viajeDisponible";
            this.viajeDisponible.ReadOnly = true;
            // 
            // cantButacasLibres
            // 
            this.cantButacasLibres.HeaderText = "Cantidad de butacas libres";
            this.cantButacasLibres.Name = "cantButacasLibres";
            this.cantButacasLibres.ReadOnly = true;
            // 
            // kgDisponibles
            // 
            this.kgDisponibles.HeaderText = "Kg disponibles para Encomienda";
            this.kgDisponibles.Name = "kgDisponibles";
            this.kgDisponibles.ReadOnly = true;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            // 
            // cantPasajesAComprar
            // 
            this.cantPasajesAComprar.HeaderText = "Cantidad de pasajes a comprar";
            this.cantPasajesAComprar.Name = "cantPasajesAComprar";
            this.cantPasajesAComprar.ReadOnly = true;
            // 
            // kgAEnviar
            // 
            this.kgAEnviar.HeaderText = "kg a enviar por Encomienda";
            this.kgAEnviar.Name = "kgAEnviar";
            this.kgAEnviar.ReadOnly = true;
            // 
            // comprarPasaje
            // 
            this.comprarPasaje.HeaderText = "Comprar Pasaje";
            this.comprarPasaje.Name = "comprarPasaje";
            this.comprarPasaje.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(696, 401);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(602, 401);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 436);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvViajesDisponibles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Compra de pasaje/encomienda";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaVuelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaVuelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCiudadDestino;
        private System.Windows.Forms.TextBox tbCiudadOrigen;
        private System.Windows.Forms.DataGridView dgvViajesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajeDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantButacasLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPasajesAComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgAEnviar;
        private System.Windows.Forms.DataGridViewButtonColumn comprarPasaje;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnLimpiar;
    }
}