namespace Primer_Parcial_Labo_2
{
    partial class FormDetalleEspacioConsumo
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
            this.lbl_idEspacio = new System.Windows.Forms.Label();
            this.lbl_infoId = new System.Windows.Forms.Label();
            this.lbl_tipoEspacio = new System.Windows.Forms.Label();
            this.lbl_infoTipo = new System.Windows.Forms.Label();
            this.lbl_saldoEspacio = new System.Windows.Forms.Label();
            this.lbl_estadoEspacio = new System.Windows.Forms.Label();
            this.lbl_infoSaldo = new System.Windows.Forms.Label();
            this.chk_ocupado = new System.Windows.Forms.CheckBox();
            this.lbl_consumisiones = new System.Windows.Forms.Label();
            this.lst_consumEspacio = new System.Windows.Forms.ListBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_consumisiones = new System.Windows.Forms.DataGridView();
            this.btn_cerrarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idEspacio
            // 
            this.lbl_idEspacio.AutoSize = true;
            this.lbl_idEspacio.Location = new System.Drawing.Point(67, 39);
            this.lbl_idEspacio.Name = "lbl_idEspacio";
            this.lbl_idEspacio.Size = new System.Drawing.Size(21, 15);
            this.lbl_idEspacio.TabIndex = 7;
            this.lbl_idEspacio.Text = "ID:";
            // 
            // lbl_infoId
            // 
            this.lbl_infoId.AutoSize = true;
            this.lbl_infoId.Location = new System.Drawing.Point(99, 39);
            this.lbl_infoId.Name = "lbl_infoId";
            this.lbl_infoId.Size = new System.Drawing.Size(66, 15);
            this.lbl_infoId.TabIndex = 17;
            this.lbl_infoId.Text = "idAMostrar";
            // 
            // lbl_tipoEspacio
            // 
            this.lbl_tipoEspacio.AutoSize = true;
            this.lbl_tipoEspacio.Location = new System.Drawing.Point(55, 72);
            this.lbl_tipoEspacio.Name = "lbl_tipoEspacio";
            this.lbl_tipoEspacio.Size = new System.Drawing.Size(33, 15);
            this.lbl_tipoEspacio.TabIndex = 18;
            this.lbl_tipoEspacio.Text = "Tipo:";
            // 
            // lbl_infoTipo
            // 
            this.lbl_infoTipo.AutoSize = true;
            this.lbl_infoTipo.Location = new System.Drawing.Point(99, 72);
            this.lbl_infoTipo.Name = "lbl_infoTipo";
            this.lbl_infoTipo.Size = new System.Drawing.Size(77, 15);
            this.lbl_infoTipo.TabIndex = 19;
            this.lbl_infoTipo.Text = "tipoAMostrar";
            // 
            // lbl_saldoEspacio
            // 
            this.lbl_saldoEspacio.AutoSize = true;
            this.lbl_saldoEspacio.Location = new System.Drawing.Point(49, 105);
            this.lbl_saldoEspacio.Name = "lbl_saldoEspacio";
            this.lbl_saldoEspacio.Size = new System.Drawing.Size(39, 15);
            this.lbl_saldoEspacio.TabIndex = 20;
            this.lbl_saldoEspacio.Text = "Saldo:";
            // 
            // lbl_estadoEspacio
            // 
            this.lbl_estadoEspacio.AutoSize = true;
            this.lbl_estadoEspacio.Location = new System.Drawing.Point(29, 157);
            this.lbl_estadoEspacio.Name = "lbl_estadoEspacio";
            this.lbl_estadoEspacio.Size = new System.Drawing.Size(59, 15);
            this.lbl_estadoEspacio.TabIndex = 22;
            this.lbl_estadoEspacio.Text = "Ocupado:";
            // 
            // lbl_infoSaldo
            // 
            this.lbl_infoSaldo.AutoSize = true;
            this.lbl_infoSaldo.Location = new System.Drawing.Point(99, 105);
            this.lbl_infoSaldo.Name = "lbl_infoSaldo";
            this.lbl_infoSaldo.Size = new System.Drawing.Size(84, 15);
            this.lbl_infoSaldo.TabIndex = 23;
            this.lbl_infoSaldo.Text = "saldoAMostrar";
            // 
            // chk_ocupado
            // 
            this.chk_ocupado.AutoSize = true;
            this.chk_ocupado.Location = new System.Drawing.Point(99, 158);
            this.chk_ocupado.Name = "chk_ocupado";
            this.chk_ocupado.Size = new System.Drawing.Size(15, 14);
            this.chk_ocupado.TabIndex = 27;
            this.chk_ocupado.UseVisualStyleBackColor = true;
            this.chk_ocupado.CheckedChanged += new System.EventHandler(this.chk_ocupado_CheckedChanged);
            // 
            // lbl_consumisiones
            // 
            this.lbl_consumisiones.AutoSize = true;
            this.lbl_consumisiones.Location = new System.Drawing.Point(12, 203);
            this.lbl_consumisiones.Name = "lbl_consumisiones";
            this.lbl_consumisiones.Size = new System.Drawing.Size(91, 15);
            this.lbl_consumisiones.TabIndex = 28;
            this.lbl_consumisiones.Text = "Consumisiones:";
            // 
            // lst_consumEspacio
            // 
            this.lst_consumEspacio.FormattingEnabled = true;
            this.lst_consumEspacio.ItemHeight = 15;
            this.lst_consumEspacio.Location = new System.Drawing.Point(214, 12);
            this.lst_consumEspacio.Name = "lst_consumEspacio";
            this.lst_consumEspacio.Size = new System.Drawing.Size(200, 199);
            this.lst_consumEspacio.TabIndex = 29;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(231, 358);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(183, 53);
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 358);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(183, 53);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_consumisiones
            // 
            this.dgv_consumisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consumisiones.Location = new System.Drawing.Point(12, 221);
            this.dgv_consumisiones.Name = "dgv_consumisiones";
            this.dgv_consumisiones.ReadOnly = true;
            this.dgv_consumisiones.RowTemplate.Height = 25;
            this.dgv_consumisiones.Size = new System.Drawing.Size(402, 131);
            this.dgv_consumisiones.TabIndex = 32;
            this.dgv_consumisiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consumisiones_CellDoubleClick);
            // 
            // btn_cerrarMesa
            // 
            this.btn_cerrarMesa.Location = new System.Drawing.Point(129, 141);
            this.btn_cerrarMesa.Name = "btn_cerrarMesa";
            this.btn_cerrarMesa.Size = new System.Drawing.Size(72, 47);
            this.btn_cerrarMesa.TabIndex = 33;
            this.btn_cerrarMesa.Text = "Cerrar mesa";
            this.btn_cerrarMesa.UseVisualStyleBackColor = true;
            this.btn_cerrarMesa.Click += new System.EventHandler(this.btn_cerrarMesa_Click);
            // 
            // FormDetalleEspacioConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 423);
            this.Controls.Add(this.btn_cerrarMesa);
            this.Controls.Add(this.dgv_consumisiones);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lst_consumEspacio);
            this.Controls.Add(this.lbl_consumisiones);
            this.Controls.Add(this.chk_ocupado);
            this.Controls.Add(this.lbl_infoSaldo);
            this.Controls.Add(this.lbl_estadoEspacio);
            this.Controls.Add(this.lbl_saldoEspacio);
            this.Controls.Add(this.lbl_infoTipo);
            this.Controls.Add(this.lbl_tipoEspacio);
            this.Controls.Add(this.lbl_infoId);
            this.Controls.Add(this.lbl_idEspacio);
            this.Name = "FormDetalleEspacioConsumo";
            this.Text = "FormDetalleEspacioConsumo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalleEspacioConsumo_FormClosing);
            this.Load += new System.EventHandler(this.FormDetalleEspacioConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idEspacio;
        private System.Windows.Forms.Label lbl_infoId;
        private System.Windows.Forms.Label lbl_tipoEspacio;
        private System.Windows.Forms.Label lbl_infoTipo;
        private System.Windows.Forms.Label lbl_saldoEspacio;
        private System.Windows.Forms.Label lbl_estadoEspacio;
        private System.Windows.Forms.Label lbl_infoSaldo;
        private System.Windows.Forms.CheckBox chk_ocupado;
        private System.Windows.Forms.Label lbl_consumisiones;
        private System.Windows.Forms.ListBox lst_consumEspacio;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_consumisiones;
        private System.Windows.Forms.Button btn_cerrarMesa;
    }
}