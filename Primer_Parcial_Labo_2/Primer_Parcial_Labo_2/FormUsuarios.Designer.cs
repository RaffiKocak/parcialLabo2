﻿namespace Primer_Parcial_Labo_2
{
    partial class FormUsuarios
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_usuarios = new System.Windows.Forms.Label();
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.btn_cerrarVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(490, 47);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.RowTemplate.Height = 25;
            this.dgv_usuarios.Size = new System.Drawing.Size(448, 491);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // lbl_usuarios
            // 
            this.lbl_usuarios.AutoSize = true;
            this.lbl_usuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_usuarios.Location = new System.Drawing.Point(12, 23);
            this.lbl_usuarios.Name = "lbl_usuarios";
            this.lbl_usuarios.Size = new System.Drawing.Size(97, 30);
            this.lbl_usuarios.TabIndex = 1;
            this.lbl_usuarios.Text = "Usuarios";
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_agregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_agregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarUsuario.Location = new System.Drawing.Point(17, 100);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(216, 41);
            this.btn_agregarUsuario.TabIndex = 4;
            this.btn_agregarUsuario.Text = "Agregar usuario";
            this.btn_agregarUsuario.UseVisualStyleBackColor = false;
            this.btn_agregarUsuario.Click += new System.EventHandler(this.btn_agregarUsuario_Click);
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_eliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_eliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(256, 100);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(216, 41);
            this.btn_eliminarUsuario.TabIndex = 5;
            this.btn_eliminarUsuario.Text = "Eliminar usuario";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = false;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Location = new System.Drawing.Point(17, 173);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(455, 365);
            this.pnl_contenedor.TabIndex = 6;
            // 
            // btn_cerrarVentana
            // 
            this.btn_cerrarVentana.FlatAppearance.BorderSize = 0;
            this.btn_cerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrarVentana.Location = new System.Drawing.Point(919, 1);
            this.btn_cerrarVentana.Name = "btn_cerrarVentana";
            this.btn_cerrarVentana.Size = new System.Drawing.Size(29, 29);
            this.btn_cerrarVentana.TabIndex = 15;
            this.btn_cerrarVentana.Text = "X";
            this.btn_cerrarVentana.UseVisualStyleBackColor = true;
            this.btn_cerrarVentana.Click += new System.EventHandler(this.btn_cerrarVentana_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.btn_cerrarVentana);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.btn_agregarUsuario);
            this.Controls.Add(this.lbl_usuarios);
            this.Controls.Add(this.dgv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label lbl_usuarios;
        private System.Windows.Forms.Button btn_agregarUsuario;
        private System.Windows.Forms.Button btn_eliminarUsuario;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Button btn_cerrarVentana;
    }
}