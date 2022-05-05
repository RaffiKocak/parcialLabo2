namespace Primer_Parcial_Labo_2
{
    partial class FormStock
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
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_agregarStock = new System.Windows.Forms.Button();
            this.btn_eliminarConsumision = new System.Windows.Forms.Button();
            this.btn_cambiarPrecio = new System.Windows.Forms.Button();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.btn_restarStock = new System.Windows.Forms.Button();
            this.btn_agregarComida = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.cmb_opciones = new System.Windows.Forms.ComboBox();
            this.lbl_opciones = new System.Windows.Forms.Label();
            this.btn_agregarBebida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(391, 26);
            this.dgv_stock.MultiSelect = false;
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.RowTemplate.Height = 25;
            this.dgv_stock.Size = new System.Drawing.Size(524, 342);
            this.dgv_stock.TabIndex = 0;
            // 
            // btn_agregarStock
            // 
            this.btn_agregarStock.Location = new System.Drawing.Point(574, 426);
            this.btn_agregarStock.Name = "btn_agregarStock";
            this.btn_agregarStock.Size = new System.Drawing.Size(156, 41);
            this.btn_agregarStock.TabIndex = 1;
            this.btn_agregarStock.Text = "Agregar stock existente";
            this.btn_agregarStock.UseVisualStyleBackColor = true;
            this.btn_agregarStock.Click += new System.EventHandler(this.btn_agregarStock_Click);
            // 
            // btn_eliminarConsumision
            // 
            this.btn_eliminarConsumision.Location = new System.Drawing.Point(759, 374);
            this.btn_eliminarConsumision.Name = "btn_eliminarConsumision";
            this.btn_eliminarConsumision.Size = new System.Drawing.Size(156, 41);
            this.btn_eliminarConsumision.TabIndex = 2;
            this.btn_eliminarConsumision.Text = "Eliminar consumisión";
            this.btn_eliminarConsumision.UseVisualStyleBackColor = true;
            this.btn_eliminarConsumision.Click += new System.EventHandler(this.btn_eliminarConsumision_Click);
            // 
            // btn_cambiarPrecio
            // 
            this.btn_cambiarPrecio.Location = new System.Drawing.Point(391, 426);
            this.btn_cambiarPrecio.Name = "btn_cambiarPrecio";
            this.btn_cambiarPrecio.Size = new System.Drawing.Size(156, 41);
            this.btn_cambiarPrecio.TabIndex = 3;
            this.btn_cambiarPrecio.Text = "Cambiar precio unitario";
            this.btn_cambiarPrecio.UseVisualStyleBackColor = true;
            this.btn_cambiarPrecio.Click += new System.EventHandler(this.btn_cambiarPrecio_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_stock.Location = new System.Drawing.Point(12, 9);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(62, 30);
            this.lbl_stock.TabIndex = 4;
            this.lbl_stock.Text = "Stock";
            // 
            // btn_restarStock
            // 
            this.btn_restarStock.Location = new System.Drawing.Point(759, 426);
            this.btn_restarStock.Name = "btn_restarStock";
            this.btn_restarStock.Size = new System.Drawing.Size(156, 41);
            this.btn_restarStock.TabIndex = 5;
            this.btn_restarStock.Text = "Restar stock existente";
            this.btn_restarStock.UseVisualStyleBackColor = true;
            this.btn_restarStock.Click += new System.EventHandler(this.btn_restarStock_Click);
            // 
            // btn_agregarComida
            // 
            this.btn_agregarComida.Location = new System.Drawing.Point(391, 374);
            this.btn_agregarComida.Name = "btn_agregarComida";
            this.btn_agregarComida.Size = new System.Drawing.Size(156, 41);
            this.btn_agregarComida.TabIndex = 6;
            this.btn_agregarComida.Text = "Nueva comida";
            this.btn_agregarComida.UseVisualStyleBackColor = true;
            this.btn_agregarComida.Click += new System.EventHandler(this.btn_agregarConsumision_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Location = new System.Drawing.Point(10, 90);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(366, 396);
            this.pnl_contenedor.TabIndex = 7;
            // 
            // cmb_opciones
            // 
            this.cmb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_opciones.FormattingEnabled = true;
            this.cmb_opciones.Location = new System.Drawing.Point(265, 52);
            this.cmb_opciones.Name = "cmb_opciones";
            this.cmb_opciones.Size = new System.Drawing.Size(111, 23);
            this.cmb_opciones.TabIndex = 8;
            this.cmb_opciones.SelectedIndexChanged += new System.EventHandler(this.cmb_opciones_SelectedIndexChanged);
            // 
            // lbl_opciones
            // 
            this.lbl_opciones.AutoSize = true;
            this.lbl_opciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_opciones.Location = new System.Drawing.Point(191, 54);
            this.lbl_opciones.Name = "lbl_opciones";
            this.lbl_opciones.Size = new System.Drawing.Size(68, 21);
            this.lbl_opciones.TabIndex = 9;
            this.lbl_opciones.Text = "Mostrar:";
            // 
            // btn_agregarBebida
            // 
            this.btn_agregarBebida.Location = new System.Drawing.Point(574, 374);
            this.btn_agregarBebida.Name = "btn_agregarBebida";
            this.btn_agregarBebida.Size = new System.Drawing.Size(156, 41);
            this.btn_agregarBebida.TabIndex = 10;
            this.btn_agregarBebida.Text = "Nueva bebida";
            this.btn_agregarBebida.UseVisualStyleBackColor = true;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 495);
            this.Controls.Add(this.btn_agregarBebida);
            this.Controls.Add(this.lbl_opciones);
            this.Controls.Add(this.cmb_opciones);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.btn_agregarComida);
            this.Controls.Add(this.btn_restarStock);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.btn_cambiarPrecio);
            this.Controls.Add(this.btn_eliminarConsumision);
            this.Controls.Add(this.btn_agregarStock);
            this.Controls.Add(this.dgv_stock);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_agregarStock;
        private System.Windows.Forms.Button btn_eliminarConsumision;
        private System.Windows.Forms.Button btn_cambiarPrecio;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button btn_restarStock;
        private System.Windows.Forms.Button btn_agregarComida;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.ComboBox cmb_opciones;
        private System.Windows.Forms.Label lbl_opciones;
        private System.Windows.Forms.Button btn_agregarBebida;
    }
}