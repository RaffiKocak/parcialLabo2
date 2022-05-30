namespace Primer_Parcial_Labo_2
{
    partial class FormEspacios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspacios));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dgv_espaciosConsumo = new System.Windows.Forms.DataGridView();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_espaciosConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(188, 30);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Barra y mesas";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrar.Location = new System.Drawing.Point(922, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(26, 28);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dgv_espaciosConsumo
            // 
            this.dgv_espaciosConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_espaciosConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_espaciosConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_espaciosConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_espaciosConsumo.Location = new System.Drawing.Point(551, 46);
            this.dgv_espaciosConsumo.MultiSelect = false;
            this.dgv_espaciosConsumo.Name = "dgv_espaciosConsumo";
            this.dgv_espaciosConsumo.ReadOnly = true;
            this.dgv_espaciosConsumo.RowHeadersVisible = false;
            this.dgv_espaciosConsumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_espaciosConsumo.RowTemplate.Height = 25;
            this.dgv_espaciosConsumo.Size = new System.Drawing.Size(387, 492);
            this.dgv_espaciosConsumo.TabIndex = 4;
            this.dgv_espaciosConsumo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_espaciosConsumo_CellDoubleClick);
            this.dgv_espaciosConsumo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_espaciosConsumo_CellFormatting);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_contenedor.BackgroundImage")));
            this.pnl_contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_contenedor.Location = new System.Drawing.Point(12, 46);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(530, 492);
            this.pnl_contenedor.TabIndex = 6;
            // 
            // FormEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.dgv_espaciosConsumo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEspacios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMesas";
            this.Load += new System.EventHandler(this.FormMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_espaciosConsumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dgv_espaciosConsumo;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}