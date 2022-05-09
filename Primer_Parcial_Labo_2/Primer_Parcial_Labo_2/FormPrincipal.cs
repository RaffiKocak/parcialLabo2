using Entidades;
using System;
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
            // RELLENAR LISTAS
            // VARIAR COLOR SEGÚN TIPO DE USUARIO
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
            Dispose();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
