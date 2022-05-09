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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ventas.Location = new System.Drawing.Point(335, 12);
            this.dgv_ventas.MultiSelect = false;
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ventas.RowTemplate.Height = 25;
            this.dgv_ventas.Size = new System.Drawing.Size(571, 443);
            this.dgv_ventas.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(69, 25);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Ventas";
            // 
            // lbl_descripcionCantidad
            // 
            this.lbl_descripcionCantidad.AutoSize = true;
            this.lbl_descripcionCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descripcionCantidad.Location = new System.Drawing.Point(57, 306);
            this.lbl_descripcionCantidad.Name = "lbl_descripcionCantidad";
            this.lbl_descripcionCantidad.Size = new System.Drawing.Size(173, 30);
            this.lbl_descripcionCantidad.TabIndex = 7;
            this.lbl_descripcionCantidad.Text = "Cantidad Ventas:";
            // 
            // lbl_descripcionTotal
            // 
            this.lbl_descripcionTotal.AutoSize = true;
            this.lbl_descripcionTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descripcionTotal.Location = new System.Drawing.Point(57, 360);
            this.lbl_descripcionTotal.Name = "lbl_descripcionTotal";
            this.lbl_descripcionTotal.Size = new System.Drawing.Size(173, 30);
            this.lbl_descripcionTotal.TabIndex = 8;
            this.lbl_descripcionTotal.Text = "Total recaudado:";
            // 
            // lbl_cantidadVentas
            // 
            this.lbl_cantidadVentas.AutoSize = true;
            this.lbl_cantidadVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidadVentas.Location = new System.Drawing.Point(236, 306);
            this.lbl_cantidadVentas.Name = "lbl_cantidadVentas";
            this.lbl_cantidadVentas.Size = new System.Drawing.Size(25, 30);
            this.lbl_cantidadVentas.TabIndex = 9;
            this.lbl_cantidadVentas.Text = "0";
            // 
            // lbl_totalRecaudado
            // 
            this.lbl_totalRecaudado.AutoSize = true;
            this.lbl_totalRecaudado.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalRecaudado.Location = new System.Drawing.Point(236, 360);
            this.lbl_totalRecaudado.Name = "lbl_totalRecaudado";
            this.lbl_totalRecaudado.Size = new System.Drawing.Size(37, 30);
            this.lbl_totalRecaudado.TabIndex = 10;
            this.lbl_totalRecaudado.Text = "$0";
            // 
            // lbl_precioEstacionamiento
            // 
            this.lbl_precioEstacionamiento.AutoSize = true;
            this.lbl_precioEstacionamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precioEstacionamiento.Location = new System.Drawing.Point(239, 71);
            this.lbl_precioEstacionamiento.Name = "lbl_precioEstacionamiento";
            this.lbl_precioEstacionamiento.Size = new System.Drawing.Size(34, 25);
            this.lbl_precioEstacionamiento.TabIndex = 12;
            this.lbl_precioEstacionamiento.Text = "$0";
            // 
            // lbl_estacionamiento
            // 
            this.lbl_estacionamiento.AutoSize = true;
            this.lbl_estacionamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estacionamiento.Location = new System.Drawing.Point(18, 74);
            this.lbl_estacionamiento.Name = "lbl_estacionamiento";
            this.lbl_estacionamiento.Size = new System.Drawing.Size(215, 21);
            this.lbl_estacionamiento.TabIndex = 11;
            this.lbl_estacionamiento.Text = "Precio por estacionamiento:";
            // 
            // btn_modificarPrecioEstacionamiento
            // 
            this.btn_modificarPrecioEstacionamiento.Location = new System.Drawing.Point(72, 98);
            this.btn_modificarPrecioEstacionamiento.Name = "btn_modificarPrecioEstacionamiento";
            this.btn_modificarPrecioEstacionamiento.Size = new System.Drawing.Size(147, 32);
            this.btn_modificarPrecioEstacionamiento.TabIndex = 13;
            this.btn_modificarPrecioEstacionamiento.Text = "Modificar precio";
            this.btn_modificarPrecioEstacionamiento.UseVisualStyleBackColor = true;
            this.btn_modificarPrecioEstacionamiento.Click += new System.EventHandler(this.btn_modificarPrecioEstacionamiento_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 462);
            this.Controls.Add(this.btn_modificarPrecioEstacionamiento);
            this.Controls.Add(this.lbl_precioEstacionamiento);
            this.Controls.Add(this.lbl_estacionamiento);
            this.Controls.Add(this.lbl_totalRecaudado);
            this.Controls.Add(this.lbl_cantidadVentas);
            this.Controls.Add(this.lbl_descripcionTotal);
            this.Controls.Add(this.lbl_descripcionCantidad);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgv_ventas);
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
    }
}