using Entidades;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormPrincipal : Form
    {
        Usuario usuario;
        FormEspacios frmMesas;
        FormStock frmStock;
        FormUsuarios frmUsuarios;
        FormVentas frmVentas;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Usuario usuarioIngresado) : this()
        {
            usuario = usuarioIngresado;
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            CambiarColoresParaUsuario();
            SoundPlayer sonidoLogin = new SoundPlayer(Properties.Resources.AperturaCerveza);
            sonidoLogin.Play();
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(pnl_contenedor);
            frmMesas = new FormEspacios();
            Logica.MostrarFormContenido(frmMesas, this.pnl_contenedor);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(pnl_contenedor);
            frmStock = new FormStock();
            Logica.MostrarFormContenido(frmStock, this.pnl_contenedor);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(pnl_contenedor);
            frmUsuarios = new FormUsuarios(this.usuario);
            Logica.MostrarFormContenido(frmUsuarios, this.pnl_contenedor);
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(pnl_contenedor);
            frmVentas = new FormVentas();
            Logica.MostrarFormContenido(frmVentas, this.pnl_contenedor);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tmr_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_reloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CambiarColoresParaUsuario()
        {
            if (!usuario.EsAdmin)
            {
                this.pnl_cabecera.BackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
                this.pnl_der.BackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
                this.pnl_linea.BackColor = Color.Black;
                this.lbl_lesUtn.ForeColor = Color.Black;
                this.lbl_bar.ForeColor = Color.Black;
                this.lbl_reloj.ForeColor = Color.Black;
                this.btn_cerrar.ForeColor = Color.Black;
                this.btn_cerrar.ForeColor = Color.Black;

                this.btn_mesas.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_11;
                this.btn_cerrarSesion.Image = global::Primer_Parcial_Labo_2.Properties.Resources.iconos_05;
                this.btn_stock.Visible = false;
                this.btn_usuarios.Visible = false;
                this.btn_ventas.Visible = false;
            }

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EspacioConsumo.VerificarTodosEspaciosDesocupados())
            {
                if (MessageBox.Show($"Aún hay mesas sin cerrar\n¿Está seguro que desea salir?", "Salir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Dispose();
                }
            }
        }
    }
}
