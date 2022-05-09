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
            Usuario usuarioAEliminar = this.listaAMostrar[index];
            string nombreUsuario = Usuario.BuscarNombreDeUsuario(usuarioAEliminar);
            
            if (!(this.usuarioLogueado.Dni == usuarioAEliminar.Dni))
            {
                if (usuarioAEliminar.EsAdmin)
                {
                    if (Usuario.ContarCantidadAdmins() > 1)
                    {
                        if (Logica.PedirConfirmacion("Borrar usuario"))
                        {
                            Usuario.BajaUsuario(nombreUsuario);
                        }
                    } else
                    {
                        MessageBox.Show("Se necesita tener al menos un usuario administrador en la base de datos");
                    }
                } else
                {
                    if (Logica.PedirConfirmacion("Borrar usuario"))
                    {
                        Usuario.BajaUsuario(nombreUsuario);
                    }
                }
            } else
            {
                MessageBox.Show("No puede borrarse a sí mismo!!");
            }

            listaAMostrar = Bar.listaUsuarios.Values.ToList();
            Logica.ActualizarDGV(this.dgv_usuarios, listaAMostrar);
        }
    }
}
