﻿namespace Primer_Parcial_Labo_2
{
    partial class FormIngresarCantidad
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
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.txt_numeroIngresado = new System.Windows.Forms.TextBox();
            this.chk_conservarConsumicion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(30, 46);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(100, 15);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Ingrese cantidad: ";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(28, 119);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(77, 26);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(111, 119);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(77, 26);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(30, 30);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(126, 15);
            this.lbl_error.TabIndex = 4;
            this.lbl_error.Text = "Ingrese un valor válido";
            this.lbl_error.Visible = false;
            // 
            // txt_numeroIngresado
            // 
            this.txt_numeroIngresado.Location = new System.Drawing.Point(30, 66);
            this.txt_numeroIngresado.Name = "txt_numeroIngresado";
            this.txt_numeroIngresado.Size = new System.Drawing.Size(158, 23);
            this.txt_numeroIngresado.TabIndex = 5;
            // 
            // chk_conservarConsumicion
            // 
            this.chk_conservarConsumicion.AutoSize = true;
            this.chk_conservarConsumicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.chk_conservarConsumicion.Location = new System.Drawing.Point(36, 95);
            this.chk_conservarConsumicion.Name = "chk_conservarConsumicion";
            this.chk_conservarConsumicion.Size = new System.Drawing.Size(151, 19);
            this.chk_conservarConsumicion.TabIndex = 6;
            this.chk_conservarConsumicion.Text = "Conservar consumicion";
            this.chk_conservarConsumicion.UseVisualStyleBackColor = true;
            this.chk_conservarConsumicion.Visible = false;
            // 
            // FormIngresarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(222, 168);
            this.Controls.Add(this.chk_conservarConsumicion);
            this.Controls.Add(this.txt_numeroIngresado);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_cantidad);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresarCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormIngresarCantidad";
            this.Load += new System.EventHandler(this.FormIngresarCantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.TextBox txt_numeroIngresado;
        private System.Windows.Forms.CheckBox chk_conservarConsumicion;
    }
}