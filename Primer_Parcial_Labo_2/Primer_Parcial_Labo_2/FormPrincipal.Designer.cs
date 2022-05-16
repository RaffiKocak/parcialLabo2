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
            this.lbl_bar = new System.Windows.Forms.Label();
            this.lbl_lesUtn = new System.Windows.Forms.Label();
            this.lbl_reloj = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.pnl_der = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_linea = new System.Windows.Forms.Panel();
            this.pnl_cabecera.SuspendLayout();
            this.pnl_der.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mesas
            // 
            this.btn_mesas.BackColor = System.Drawing.Color.Transparent;
            this.btn_mesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mesas.FlatAppearance.BorderSize = 0;
            this.btn_mesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_mesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_mesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mesas.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_12;
            this.btn_mesas.Location = new System.Drawing.Point(27, 32);
            this.btn_mesas.Name = "btn_mesas";
            this.btn_mesas.Size = new System.Drawing.Size(50, 50);
            this.btn_mesas.TabIndex = 0;
            this.btn_mesas.UseVisualStyleBackColor = false;
            this.btn_mesas.Click += new System.EventHandler(this.btn_mesas_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_07;
            this.btn_stock.Location = new System.Drawing.Point(27, 187);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(50, 50);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // pnl_cabecera
            // 
            this.pnl_cabecera.BackColor = System.Drawing.Color.Black;
            this.pnl_cabecera.Controls.Add(this.lbl_bar);
            this.pnl_cabecera.Controls.Add(this.lbl_lesUtn);
            this.pnl_cabecera.Controls.Add(this.lbl_reloj);
            this.pnl_cabecera.Controls.Add(this.btn_cerrar);
            this.pnl_cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(1150, 60);
            this.pnl_cabecera.TabIndex = 2;
            // 
            // lbl_bar
            // 
            this.lbl_bar.AutoSize = true;
            this.lbl_bar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_bar.Location = new System.Drawing.Point(97, 16);
            this.lbl_bar.Name = "lbl_bar";
            this.lbl_bar.Size = new System.Drawing.Size(52, 30);
            this.lbl_bar.TabIndex = 3;
            this.lbl_bar.Text = "BAR";
            // 
            // lbl_lesUtn
            // 
            this.lbl_lesUtn.AutoSize = true;
            this.lbl_lesUtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lesUtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_lesUtn.Location = new System.Drawing.Point(12, 16);
            this.lbl_lesUtn.Name = "lbl_lesUtn";
            this.lbl_lesUtn.Size = new System.Drawing.Size(92, 30);
            this.lbl_lesUtn.TabIndex = 2;
            this.lbl_lesUtn.Text = "LES UTN";
            // 
            // lbl_reloj
            // 
            this.lbl_reloj.AutoSize = true;
            this.lbl_reloj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_reloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.lbl_reloj.Location = new System.Drawing.Point(1034, 21);
            this.lbl_reloj.Name = "lbl_reloj";
            this.lbl_reloj.Size = new System.Drawing.Size(22, 25);
            this.lbl_reloj.TabIndex = 1;
            this.lbl_reloj.Text = "a";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btn_cerrar.Location = new System.Drawing.Point(1120, 3);
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
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_10;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(27, 473);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(50, 50);
            this.btn_cerrarSesion.TabIndex = 2;
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // pnl_der
            // 
            this.pnl_der.BackColor = System.Drawing.Color.Black;
            this.pnl_der.Controls.Add(this.btn_cerrarSesion);
            this.pnl_der.Controls.Add(this.btn_ventas);
            this.pnl_der.Controls.Add(this.btn_stock);
            this.pnl_der.Controls.Add(this.btn_mesas);
            this.pnl_der.Controls.Add(this.btn_usuarios);
            this.pnl_der.Location = new System.Drawing.Point(1050, 65);
            this.pnl_der.Name = "pnl_der";
            this.pnl_der.Size = new System.Drawing.Size(100, 550);
            this.pnl_der.TabIndex = 4;
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_08;
            this.btn_ventas.Location = new System.Drawing.Point(27, 269);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(50, 50);
            this.btn_ventas.TabIndex = 3;
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_09;
            this.btn_usuarios.Location = new System.Drawing.Point(27, 108);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(50, 50);
            this.btn_usuarios.TabIndex = 2;
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contenedor.BackgroundImage = global::Primer_Parcial_Labo_2.Properties.Resources.Fondo;
            this.pnl_contenedor.Location = new System.Drawing.Point(99, 65);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(950, 550);
            this.pnl_contenedor.TabIndex = 5;
            // 
            // tmr_tiempo
            // 
            this.tmr_tiempo.Enabled = true;
            this.tmr_tiempo.Interval = 500;
            this.tmr_tiempo.Tick += new System.EventHandler(this.tmr_tiempo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primer_Parcial_Labo_2.Properties.Resources.Pattern___100x550;
            this.pictureBox1.Location = new System.Drawing.Point(0, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 550);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_linea
            // 
            this.pnl_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.pnl_linea.Location = new System.Drawing.Point(1, 60);
            this.pnl_linea.Name = "pnl_linea";
            this.pnl_linea.Size = new System.Drawing.Size(1150, 5);
            this.pnl_linea.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1150, 615);
            this.Controls.Add(this.pnl_linea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.pnl_der);
            this.Controls.Add(this.pnl_cabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Properties.Resources.beericon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.pnl_cabecera.ResumeLayout(false);
            this.pnl_cabecera.PerformLayout();
            this.pnl_der.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mesas;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_der;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label lbl_reloj;
        private System.Windows.Forms.Timer tmr_tiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_linea;
        private System.Windows.Forms.Label lbl_bar;
        private System.Windows.Forms.Label lbl_lesUtn;
    }
}