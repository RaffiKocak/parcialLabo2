using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Primer_Parcial_Labo_2
{
    public partial class FormAdministrador : Form
    {
        Usuario usuario;
        FormMesas frmMesas;
        FormStock frmStock;
        FormUsuarios frmUsuarios;
        public FormAdministrador()
        {
            InitializeComponent();
        }

        public FormAdministrador(Usuario usuarioIngresado) : this()
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
            CerrarFormsContenidos();
            frmMesas = new FormMesas();
            frmMesas.TopLevel = false;
            pnl_contenedor.Controls.Add(frmMesas);
            frmMesas.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            CerrarFormsContenidos();
            frmStock = new FormStock();
            frmStock.TopLevel = false;
            pnl_contenedor.Controls.Add(frmStock);
            frmStock.Show();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            CerrarFormsContenidos();

            frmUsuarios = new FormUsuarios();
            frmUsuarios.TopLevel = false;
            pnl_contenedor.Controls.Add(frmUsuarios);
            frmUsuarios.Show();
        }

        public void CerrarFormsContenidos()
        {
            foreach (Form item in pnl_contenedor.Controls)
            {
                item.Dispose();
            }
        }

        
    }
}
