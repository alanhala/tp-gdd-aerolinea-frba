﻿namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaFinVidaUtil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaFinVidaUtil));
            this.tbNumeroMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumeroMatricula
            // 
            this.tbNumeroMatricula.Location = new System.Drawing.Point(128, 37);
            this.tbNumeroMatricula.Name = "tbNumeroMatricula";
            this.tbNumeroMatricula.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroMatricula.TabIndex = 35;
            this.tbNumeroMatricula.TextChanged += new System.EventHandler(this.tbNumeroMatricula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número de matrícula";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(157, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDarDeBaja.Location = new System.Drawing.Point(252, 127);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.btnDarDeBaja.TabIndex = 40;
            this.btnDarDeBaja.Text = "Aceptar";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.tbNumeroMatricula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 91);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes campos";
            // 
            // BajaFinVidaUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(339, 162);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDarDeBaja);
            this.Name = "BajaFinVidaUtil";
            this.Text = "Suspender Aeronave por fin de vida útil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeroMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}