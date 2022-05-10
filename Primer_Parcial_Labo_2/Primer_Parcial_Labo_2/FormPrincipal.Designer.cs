namespace Primer_Parcial_Labo_2
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btn_mesas = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.pnl_cabecera = new System.Windows.Forms.Panel();
            this.lbl_reloj = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_izq = new System.Windows.Forms.Panel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.pnl_der = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.il_botonesMenus = new System.Windows.Forms.ImageList(this.components);
            this.pnl_cabecera.SuspendLayout();
            this.pnl_izq.SuspendLayout();
            this.pnl_der.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mesas
            // 
            this.btn_mesas.Location = new System.Drawing.Point(16, 117);
            this.btn_mesas.Name = "btn_mesas";
            this.btn_mesas.Size = new System.Drawing.Size(57, 50);
            this.btn_mesas.TabIndex = 0;
            this.btn_mesas.Text = "Mesas";
            this.btn_mesas.UseVisualStyleBackColor = true;
            this.btn_mesas.Click += new System.EventHandler(this.btn_mesas_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(15, 260);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(57, 50);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // pnl_cabecera
            // 
            this.pnl_cabecera.BackColor = System.Drawing.Color.SlateGray;
            this.pnl_cabecera.Controls.Add(this.lbl_reloj);
            this.pnl_cabecera.Controls.Add(this.btn_cerrar);
            this.pnl_cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(1126, 66);
            this.pnl_cabecera.TabIndex = 2;
            // 
            // lbl_reloj
            // 
            this.lbl_reloj.AutoSize = true;
            this.lbl_reloj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_reloj.Location = new System.Drawing.Point(1043, 33);
            this.lbl_reloj.Name = "lbl_reloj";
            this.lbl_reloj.Size = new System.Drawing.Size(22, 25);
            this.lbl_reloj.TabIndex = 1;
            this.lbl_reloj.Text = "a";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1096, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(27, 25);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // pnl_izq
            // 
            this.pnl_izq.BackColor = System.Drawing.Color.SlateGray;
            this.pnl_izq.Controls.Add(this.btn_cerrarSesion);
            this.pnl_izq.Controls.Add(this.btn_mesas);
            this.pnl_izq.Controls.Add(this.btn_stock);
            this.pnl_izq.Location = new System.Drawing.Point(0, 65);
            this.pnl_izq.Name = "pnl_izq";
            this.pnl_izq.Size = new System.Drawing.Size(86, 543);
            this.pnl_izq.TabIndex = 3;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Location = new System.Drawing.Point(16, 403);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(57, 50);
            this.btn_cerrarSesion.TabIndex = 2;
            this.btn_cerrarSesion.Text = "Cerrar Sesion";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // pnl_der
            // 
            this.pnl_der.BackColor = System.Drawing.Color.SlateGray;
            this.pnl_der.Controls.Add(this.btn_ventas);
            this.pnl_der.Controls.Add(this.btn_usuarios);
            this.pnl_der.Location = new System.Drawing.Point(1037, 65);
            this.pnl_der.Name = "pnl_der";
            this.pnl_der.Size = new System.Drawing.Size(89, 543);
            this.pnl_der.TabIndex = 4;
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(17, 260);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(57, 50);
            this.btn_ventas.TabIndex = 3;
            this.btn_ventas.Text = "TotalVentas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(17, 117);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(57, 50);
            this.btn_usuarios.TabIndex = 2;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Location = new System.Drawing.Point(92, 66);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(939, 540);
            this.pnl_contenedor.TabIndex = 5;
            // 
            // tmr_tiempo
            // 
            this.tmr_tiempo.Enabled = true;
            this.tmr_tiempo.Interval = 500;
            this.tmr_tiempo.Tick += new System.EventHandler(this.tmr_tiempo_Tick);
            // 
            // il_botonesMenus
            // 
            this.il_botonesMenus.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_botonesMenus.ImageSize = new System.Drawing.Size(16, 16);
            this.il_botonesMenus.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1126, 608);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.pnl_der);
            this.Controls.Add(this.pnl_izq);
            this.Controls.Add(this.pnl_cabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.pnl_cabecera.ResumeLayout(false);
            this.pnl_cabecera.PerformLayout();
            this.pnl_izq.ResumeLayout(false);
            this.pnl_der.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mesas;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_izq;
        private System.Windows.Forms.Panel pnl_der;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label lbl_reloj;
        private System.Windows.Forms.Timer tmr_tiempo;
        private System.Windows.Forms.ImageList il_botonesMenus;
    }
}