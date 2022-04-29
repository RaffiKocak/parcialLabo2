namespace Primer_Parcial_Labo_2
{
    partial class FormCierreMesa
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.grp_formaPago = new System.Windows.Forms.GroupBox();
            this.rdo_mercadopago = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdo_credito = new System.Windows.Forms.RadioButton();
            this.rdo_efectivo = new System.Windows.Forms.RadioButton();
            this.grp_estacionamiento = new System.Windows.Forms.GroupBox();
            this.rdo_estacionamientoNo = new System.Windows.Forms.RadioButton();
            this.rdo_estacionamientoSi = new System.Windows.Forms.RadioButton();
            this.grp_formaPago.SuspendLayout();
            this.grp_estacionamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(26, 250);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(140, 37);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(196, 250);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 37);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // grp_formaPago
            // 
            this.grp_formaPago.Controls.Add(this.rdo_mercadopago);
            this.grp_formaPago.Controls.Add(this.radioButton1);
            this.grp_formaPago.Controls.Add(this.rdo_credito);
            this.grp_formaPago.Controls.Add(this.rdo_efectivo);
            this.grp_formaPago.Location = new System.Drawing.Point(21, 40);
            this.grp_formaPago.Name = "grp_formaPago";
            this.grp_formaPago.Size = new System.Drawing.Size(326, 93);
            this.grp_formaPago.TabIndex = 2;
            this.grp_formaPago.TabStop = false;
            this.grp_formaPago.Text = "Forma de pago";
            // 
            // rdo_mercadopago
            // 
            this.rdo_mercadopago.AutoSize = true;
            this.rdo_mercadopago.Location = new System.Drawing.Point(33, 58);
            this.rdo_mercadopago.Name = "rdo_mercadopago";
            this.rdo_mercadopago.Size = new System.Drawing.Size(102, 19);
            this.rdo_mercadopago.TabIndex = 3;
            this.rdo_mercadopago.TabStop = true;
            this.rdo_mercadopago.Text = "Mercado Pago";
            this.rdo_mercadopago.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(189, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tarjeta Débito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdo_credito
            // 
            this.rdo_credito.AutoSize = true;
            this.rdo_credito.Location = new System.Drawing.Point(189, 58);
            this.rdo_credito.Name = "rdo_credito";
            this.rdo_credito.Size = new System.Drawing.Size(101, 19);
            this.rdo_credito.TabIndex = 1;
            this.rdo_credito.TabStop = true;
            this.rdo_credito.Text = "Tarjeta Crédito";
            this.rdo_credito.UseVisualStyleBackColor = true;
            // 
            // rdo_efectivo
            // 
            this.rdo_efectivo.AutoSize = true;
            this.rdo_efectivo.Location = new System.Drawing.Point(33, 24);
            this.rdo_efectivo.Name = "rdo_efectivo";
            this.rdo_efectivo.Size = new System.Drawing.Size(67, 19);
            this.rdo_efectivo.TabIndex = 0;
            this.rdo_efectivo.TabStop = true;
            this.rdo_efectivo.Text = "Efectivo";
            this.rdo_efectivo.UseVisualStyleBackColor = true;
            // 
            // grp_estacionamiento
            // 
            this.grp_estacionamiento.Controls.Add(this.rdo_estacionamientoNo);
            this.grp_estacionamiento.Controls.Add(this.rdo_estacionamientoSi);
            this.grp_estacionamiento.Location = new System.Drawing.Point(84, 152);
            this.grp_estacionamiento.Name = "grp_estacionamiento";
            this.grp_estacionamiento.Size = new System.Drawing.Size(198, 67);
            this.grp_estacionamiento.TabIndex = 3;
            this.grp_estacionamiento.TabStop = false;
            this.grp_estacionamiento.Text = "Usa estacionamiento";
            // 
            // rdo_estacionamientoNo
            // 
            this.rdo_estacionamientoNo.AutoSize = true;
            this.rdo_estacionamientoNo.Location = new System.Drawing.Point(126, 32);
            this.rdo_estacionamientoNo.Name = "rdo_estacionamientoNo";
            this.rdo_estacionamientoNo.Size = new System.Drawing.Size(41, 19);
            this.rdo_estacionamientoNo.TabIndex = 5;
            this.rdo_estacionamientoNo.TabStop = true;
            this.rdo_estacionamientoNo.Text = "No";
            this.rdo_estacionamientoNo.UseVisualStyleBackColor = true;
            // 
            // rdo_estacionamientoSi
            // 
            this.rdo_estacionamientoSi.AutoSize = true;
            this.rdo_estacionamientoSi.Location = new System.Drawing.Point(22, 32);
            this.rdo_estacionamientoSi.Name = "rdo_estacionamientoSi";
            this.rdo_estacionamientoSi.Size = new System.Drawing.Size(34, 19);
            this.rdo_estacionamientoSi.TabIndex = 4;
            this.rdo_estacionamientoSi.TabStop = true;
            this.rdo_estacionamientoSi.Text = "Si";
            this.rdo_estacionamientoSi.UseVisualStyleBackColor = true;
            // 
            // FormCierreMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 312);
            this.Controls.Add(this.grp_estacionamiento);
            this.Controls.Add(this.grp_formaPago);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "FormCierreMesa";
            this.Text = "FormCierreMesa";
            this.Load += new System.EventHandler(this.FormCierreMesa_Load);
            this.grp_formaPago.ResumeLayout(false);
            this.grp_formaPago.PerformLayout();
            this.grp_estacionamiento.ResumeLayout(false);
            this.grp_estacionamiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox grp_formaPago;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdo_credito;
        private System.Windows.Forms.RadioButton rdo_efectivo;
        private System.Windows.Forms.RadioButton rdo_mercadopago;
        private System.Windows.Forms.GroupBox grp_estacionamiento;
        private System.Windows.Forms.RadioButton rdo_estacionamientoNo;
        private System.Windows.Forms.RadioButton rdo_estacionamientoSi;
    }
}