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
            this.lbl_consumicionesDisponibles = new System.Windows.Forms.Label();
            this.lst_consumEspacio = new System.Windows.Forms.ListBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_consumiciones = new System.Windows.Forms.DataGridView();
            this.btn_cerrarMesa = new System.Windows.Forms.Button();
            this.cmb_opciones = new System.Windows.Forms.ComboBox();
            this.lbl_ocupado = new System.Windows.Forms.Label();
            this.lbl_consumicionesPedidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idEspacio
            // 
            this.lbl_idEspacio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_idEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_idEspacio.Location = new System.Drawing.Point(52, 27);
            this.lbl_idEspacio.Name = "lbl_idEspacio";
            this.lbl_idEspacio.Size = new System.Drawing.Size(76, 15);
            this.lbl_idEspacio.TabIndex = 7;
            this.lbl_idEspacio.Text = "ID:";
            // 
            // lbl_infoId
            // 
            this.lbl_infoId.AutoSize = true;
            this.lbl_infoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_infoId.Location = new System.Drawing.Point(139, 27);
            this.lbl_infoId.Name = "lbl_infoId";
            this.lbl_infoId.Size = new System.Drawing.Size(66, 15);
            this.lbl_infoId.TabIndex = 17;
            this.lbl_infoId.Text = "idAMostrar";
            // 
            // lbl_tipoEspacio
            // 
            this.lbl_tipoEspacio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_tipoEspacio.Location = new System.Drawing.Point(52, 59);
            this.lbl_tipoEspacio.Name = "lbl_tipoEspacio";
            this.lbl_tipoEspacio.Size = new System.Drawing.Size(76, 15);
            this.lbl_tipoEspacio.TabIndex = 18;
            this.lbl_tipoEspacio.Text = "Tipo:";
            // 
            // lbl_infoTipo
            // 
            this.lbl_infoTipo.AutoSize = true;
            this.lbl_infoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_infoTipo.Location = new System.Drawing.Point(139, 59);
            this.lbl_infoTipo.Name = "lbl_infoTipo";
            this.lbl_infoTipo.Size = new System.Drawing.Size(77, 15);
            this.lbl_infoTipo.TabIndex = 19;
            this.lbl_infoTipo.Text = "tipoAMostrar";
            // 
            // lbl_saldoEspacio
            // 
            this.lbl_saldoEspacio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_saldoEspacio.Location = new System.Drawing.Point(52, 95);
            this.lbl_saldoEspacio.Name = "lbl_saldoEspacio";
            this.lbl_saldoEspacio.Size = new System.Drawing.Size(76, 15);
            this.lbl_saldoEspacio.TabIndex = 20;
            this.lbl_saldoEspacio.Text = "Saldo:";
            // 
            // lbl_estadoEspacio
            // 
            this.lbl_estadoEspacio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadoEspacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_estadoEspacio.Location = new System.Drawing.Point(52, 131);
            this.lbl_estadoEspacio.Name = "lbl_estadoEspacio";
            this.lbl_estadoEspacio.Size = new System.Drawing.Size(76, 15);
            this.lbl_estadoEspacio.TabIndex = 22;
            this.lbl_estadoEspacio.Text = "Ocupado:";
            // 
            // lbl_infoSaldo
            // 
            this.lbl_infoSaldo.AutoSize = true;
            this.lbl_infoSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_infoSaldo.Location = new System.Drawing.Point(139, 95);
            this.lbl_infoSaldo.Name = "lbl_infoSaldo";
            this.lbl_infoSaldo.Size = new System.Drawing.Size(84, 15);
            this.lbl_infoSaldo.TabIndex = 23;
            this.lbl_infoSaldo.Text = "saldoAMostrar";
            // 
            // lbl_consumicionesDisponibles
            // 
            this.lbl_consumicionesDisponibles.AutoSize = true;
            this.lbl_consumicionesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_consumicionesDisponibles.Location = new System.Drawing.Point(15, 211);
            this.lbl_consumicionesDisponibles.Name = "lbl_consumicionesDisponibles";
            this.lbl_consumicionesDisponibles.Size = new System.Drawing.Size(155, 15);
            this.lbl_consumicionesDisponibles.TabIndex = 28;
            this.lbl_consumicionesDisponibles.Text = "Consumiciones disponibles:";
            // 
            // lst_consumEspacio
            // 
            this.lst_consumEspacio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_consumEspacio.FormattingEnabled = true;
            this.lst_consumEspacio.HorizontalScrollbar = true;
            this.lst_consumEspacio.ItemHeight = 15;
            this.lst_consumEspacio.Location = new System.Drawing.Point(324, 27);
            this.lst_consumEspacio.Name = "lst_consumEspacio";
            this.lst_consumEspacio.Size = new System.Drawing.Size(194, 154);
            this.lst_consumEspacio.TabIndex = 29;
            this.lst_consumEspacio.DoubleClick += new System.EventHandler(this.lst_consumEspacio_DoubleClick);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(278, 417);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(240, 53);
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(15, 417);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(240, 53);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_consumiciones
            // 
            this.dgv_consumiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consumiciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_consumiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consumiciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consumiciones.Location = new System.Drawing.Point(15, 232);
            this.dgv_consumiciones.MultiSelect = false;
            this.dgv_consumiciones.Name = "dgv_consumiciones";
            this.dgv_consumiciones.ReadOnly = true;
            this.dgv_consumiciones.RowTemplate.Height = 25;
            this.dgv_consumiciones.Size = new System.Drawing.Size(503, 175);
            this.dgv_consumiciones.TabIndex = 32;
            this.dgv_consumiciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consumisiones_CellDoubleClick);
            this.dgv_consumiciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_consumisiones_CellFormatting);
            // 
            // btn_cerrarMesa
            // 
            this.btn_cerrarMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarMesa.FlatAppearance.BorderSize = 0;
            this.btn_cerrarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarMesa.Location = new System.Drawing.Point(15, 170);
            this.btn_cerrarMesa.Name = "btn_cerrarMesa";
            this.btn_cerrarMesa.Size = new System.Drawing.Size(240, 26);
            this.btn_cerrarMesa.TabIndex = 33;
            this.btn_cerrarMesa.Text = "Cerrar mesa";
            this.btn_cerrarMesa.UseVisualStyleBackColor = false;
            this.btn_cerrarMesa.Click += new System.EventHandler(this.btn_cerrarMesa_Click);
            // 
            // cmb_opciones
            // 
            this.cmb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_opciones.FormattingEnabled = true;
            this.cmb_opciones.Location = new System.Drawing.Point(324, 203);
            this.cmb_opciones.Name = "cmb_opciones";
            this.cmb_opciones.Size = new System.Drawing.Size(194, 23);
            this.cmb_opciones.TabIndex = 35;
            this.cmb_opciones.SelectedIndexChanged += new System.EventHandler(this.cmb_opciones_SelectedIndexChanged);
            // 
            // lbl_ocupado
            // 
            this.lbl_ocupado.AutoSize = true;
            this.lbl_ocupado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_ocupado.Location = new System.Drawing.Point(139, 131);
            this.lbl_ocupado.Name = "lbl_ocupado";
            this.lbl_ocupado.Size = new System.Drawing.Size(103, 15);
            this.lbl_ocupado.TabIndex = 36;
            this.lbl_ocupado.Text = "ocupadoAMostrar";
            // 
            // lbl_consumicionesPedidas
            // 
            this.lbl_consumicionesPedidas.AutoSize = true;
            this.lbl_consumicionesPedidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_consumicionesPedidas.Location = new System.Drawing.Point(324, 9);
            this.lbl_consumicionesPedidas.Name = "lbl_consumicionesPedidas";
            this.lbl_consumicionesPedidas.Size = new System.Drawing.Size(136, 15);
            this.lbl_consumicionesPedidas.TabIndex = 37;
            this.lbl_consumicionesPedidas.Text = "Consumiciones pedidas:";
            // 
            // FormDetalleEspacioConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(530, 492);
            this.Controls.Add(this.lbl_consumicionesPedidas);
            this.Controls.Add(this.lbl_ocupado);
            this.Controls.Add(this.cmb_opciones);
            this.Controls.Add(this.btn_cerrarMesa);
            this.Controls.Add(this.dgv_consumiciones);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lst_consumEspacio);
            this.Controls.Add(this.lbl_consumicionesDisponibles);
            this.Controls.Add(this.lbl_infoSaldo);
            this.Controls.Add(this.lbl_estadoEspacio);
            this.Controls.Add(this.lbl_saldoEspacio);
            this.Controls.Add(this.lbl_infoTipo);
            this.Controls.Add(this.lbl_tipoEspacio);
            this.Controls.Add(this.lbl_infoId);
            this.Controls.Add(this.lbl_idEspacio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleEspacioConsumo";
            this.Text = "FormDetalleEspacioConsumo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalleEspacioConsumo_FormClosing);
            this.Load += new System.EventHandler(this.FormDetalleEspacioConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consumiciones)).EndInit();
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
        private System.Windows.Forms.Label lbl_consumicionesDisponibles;
        private System.Windows.Forms.ListBox lst_consumEspacio;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_consumiciones;
        private System.Windows.Forms.Button btn_cerrarMesa;
        private System.Windows.Forms.ComboBox cmb_opciones;
        private System.Windows.Forms.Label lbl_ocupado;
        private System.Windows.Forms.Label lbl_consumicionesPedidas;
    }
}