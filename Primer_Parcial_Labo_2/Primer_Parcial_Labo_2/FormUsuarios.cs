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
    public partial class FormUsuarios : Form
    {
        List<Usuario> listaAMostrar;
        Usuario usuarioLogueado;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public FormUsuarios(Usuario usuario) :this()
        {
            this.usuarioLogueado = usuario;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            listaAMostrar = Bar.listaUsuarios.Values.ToList();
            Logica.ActualizarDGV(this.dgv_usuarios, listaAMostrar);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarNuevoUsuario frmNuevoUser = new FormAgregarNuevoUsuario(this.dgv_usuarios, listaAMostrar);
            frmNuevoUser.TopLevel = false;
            pnl_contenedor.Controls.Add(frmNuevoUser);
            frmNuevoUser.Show();
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            int index = this.dgv_usuarios.CurrentCell.RowIndex;
            int dniAEliminar = this.listaAMostrar[index].Dni;
            string nombreUsuario = Usuario.BuscarCuentaLoginUsuario(this.listaAMostrar[index]);

            int retornoOperacion = this.EliminarUsuario(dniAEliminar, nombreUsuario);

            switch(retornoOperacion)
            {
                case -2:
                    MessageBox.Show("No puede borrarse a sí mismo!");                    
                    break;

                case -1:
                    MessageBox.Show("Eliminación cancelada.");
                    break;

                case 0:
                    MessageBox.Show("Usuario eliminado exitosamente");
                    listaAMostrar = Bar.listaUsuarios.Values.ToList();
                    Logica.ActualizarDGV(this.dgv_usuarios, listaAMostrar);
                    break;
            }
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int EliminarUsuario(int dniAEliminar, string usuarioAEliminar)
        {
            int retorno = -2;

            if (this.usuarioLogueado.Dni != dniAEliminar)
            {
                retorno = -1;
                if (Logica.PedirConfirmacion($"Borrar usuario"))
                {
                    Usuario.BajaUsuario(usuarioAEliminar);
                    retorno = 0;
                }
            }

            return retorno;
        }
    }
}
