namespace Primer_Parcial_Labo_2
{
    partial class FormVentas
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
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcionCantidad = new System.Windows.Forms.Label();
            this.lbl_descripcionTotal = new System.Windows.Forms.Label();
            this.lbl_cantidadVentas = new System.Windows.Forms.Label();
            this.lbl_totalRecaudado = new System.Windows.Forms.Label();
            this.lbl_precioEstacionamiento = new System.Windows.Forms.Label();
            this.lbl_estacionamiento = new System.Windows.Forms.Label();
            this.btn_modificarPrecioEstacionamiento = new System.Windows.Forms.Button();
            this.btn_cerrarVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ventas.Location = new System.Drawing.Point(345, 36);
            this.dgv_ventas.MultiSelect = false;
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.RowHeadersVisible = false;
            this.dgv_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ventas.RowTemplate.Height = 25;
            this.dgv_ventas.Size = new System.Drawing.Size(593, 502);
            this.dgv_ventas.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(76, 30);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Ventas";
            // 
            // lbl_descripcionCantidad
            // 
            this.lbl_descripcionCantidad.AutoSize = true;
            this.lbl_descripcionCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descripcionCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_descripcionCantidad.Location = new System.Drawing.Point(22, 391);
            this.lbl_descripcionCantidad.Name = "lbl_descripcionCantidad";
            this.lbl_descripcionCantidad.Size = new System.Drawing.Size(173, 30);
            this.lbl_descripcionCantidad.TabIndex = 7;
            this.lbl_descripcionCantidad.Text = "Cantidad Ventas:";
            // 
            // lbl_descripcionTotal
            // 
            this.lbl_descripcionTotal.AutoSize = true;
            this.lbl_descripcionTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descripcionTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_descripcionTotal.Location = new System.Drawing.Point(22, 438);
            this.lbl_descripcionTotal.Name = "lbl_descripcionTotal";
            this.lbl_descripcionTotal.Size = new System.Drawing.Size(173, 30);
            this.lbl_descripcionTotal.TabIndex = 8;
            this.lbl_descripcionTotal.Text = "Total recaudado:";
            // 
            // lbl_cantidadVentas
            // 
            this.lbl_cantidadVentas.AutoSize = true;
            this.lbl_cantidadVentas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidadVentas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidadVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_cantidadVentas.Location = new System.Drawing.Point(212, 391);
            this.lbl_cantidadVentas.Name = "lbl_cantidadVentas";
            this.lbl_cantidadVentas.Size = new System.Drawing.Size(24, 30);
            this.lbl_cantidadVentas.TabIndex = 9;
            this.lbl_cantidadVentas.Text = "0";
            // 
            // lbl_totalRecaudado
            // 
            this.lbl_totalRecaudado.AutoSize = true;
            this.lbl_totalRecaudado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalRecaudado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalRecaudado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_totalRecaudado.Location = new System.Drawing.Point(212, 442);
            this.lbl_totalRecaudado.Name = "lbl_totalRecaudado";
            this.lbl_totalRecaudado.Size = new System.Drawing.Size(32, 25);
            this.lbl_totalRecaudado.TabIndex = 10;
            this.lbl_totalRecaudado.Text = "$0";
            // 
            // lbl_precioEstacionamiento
            // 
            this.lbl_precioEstacionamiento.AutoSize = true;
            this.lbl_precioEstacionamiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_precioEstacionamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_precioEstacionamiento.Location = new System.Drawing.Point(233, 92);
            this.lbl_precioEstacionamiento.Name = "lbl_precioEstacionamiento";
            this.lbl_precioEstacionamiento.Size = new System.Drawing.Size(28, 21);
            this.lbl_precioEstacionamiento.TabIndex = 12;
            this.lbl_precioEstacionamiento.Text = "$0";
            // 
            // lbl_estacionamiento
            // 
            this.lbl_estacionamiento.AutoSize = true;
            this.lbl_estacionamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estacionamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_estacionamiento.Location = new System.Drawing.Point(12, 92);
            this.lbl_estacionamiento.Name = "lbl_estacionamiento";
            this.lbl_estacionamiento.Size = new System.Drawing.Size(215, 21);
            this.lbl_estacionamiento.TabIndex = 11;
            this.lbl_estacionamiento.Text = "Precio por estacionamiento:";
            // 
            // btn_modificarPrecioEstacionamiento
            // 
            this.btn_modificarPrecioEstacionamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_modificarPrecioEstacionamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificarPrecioEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btn_modificarPrecioEstacionamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarPrecioEstacionamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificarPrecioEstacionamiento.Location = new System.Drawing.Point(91, 134);
            this.btn_modificarPrecioEstacionamiento.Name = "btn_modificarPrecioEstacionamiento";
            this.btn_modificarPrecioEstacionamiento.Size = new System.Drawing.Size(147, 32);
            this.btn_modificarPrecioEstacionamiento.TabIndex = 13;
            this.btn_modificarPrecioEstacionamiento.Text = "Modificar precio";
            this.btn_modificarPrecioEstacionamiento.UseVisualStyleBackColor = false;
            this.btn_modificarPrecioEstacionamiento.Click += new System.EventHandler(this.btn_modificarPrecioEstacionamiento_Click);
            // 
            // btn_cerrarVentana
            // 
            this.btn_cerrarVentana.FlatAppearance.BorderSize = 0;
            this.btn_cerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrarVentana.Location = new System.Drawing.Point(920, 1);
            this.btn_cerrarVentana.Name = "btn_cerrarVentana";
            this.btn_cerrarVentana.Size = new System.Drawing.Size(29, 29);
            this.btn_cerrarVentana.TabIndex = 14;
            this.btn_cerrarVentana.Text = "X";
            this.btn_cerrarVentana.UseVisualStyleBackColor = true;
            this.btn_cerrarVentana.Click += new System.EventHandler(this.btn_cerrarVentana_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.btn_cerrarVentana);
            this.Controls.Add(this.btn_modificarPrecioEstacionamiento);
            this.Controls.Add(this.lbl_precioEstacionamiento);
            this.Controls.Add(this.lbl_estacionamiento);
            this.Controls.Add(this.lbl_totalRecaudado);
            this.Controls.Add(this.lbl_cantidadVentas);
            this.Controls.Add(this.lbl_descripcionTotal);
            this.Controls.Add(this.lbl_descripcionCantidad);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgv_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcionCantidad;
        private System.Windows.Forms.Label lbl_descripcionTotal;
        private System.Windows.Forms.Label lbl_cantidadVentas;
        private System.Windows.Forms.Label lbl_totalRecaudado;
        private System.Windows.Forms.Label lbl_precioEstacionamiento;
        private System.Windows.Forms.Label lbl_estacionamiento;
        private System.Windows.Forms.Button btn_modificarPrecioEstacionamiento;
        private System.Windows.Forms.Button btn_cerrarVentana;
    }
}