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
    public partial class FormAgregarNuevoUsuario : Form
    {
        DataGridView refTablaPadre;
        List<Usuario> listaParaActualizar;
        public FormAgregarNuevoUsuario()
        {
            InitializeComponent();
        }

        public FormAgregarNuevoUsuario(DataGridView tablaPadre, List<Usuario> listaParaActualizar) : this()
        {
            this.refTablaPadre = tablaPadre;
            this.listaParaActualizar = listaParaActualizar;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            // verificar que todos los datos están correctos y no están vacíos
            // si no se verifican los datos, poner lbl_error visible

            if (Validacion.ValidarTextosNoVacios(this) && Validacion.ValidarDni(this.txt_dni.Text, out int dniAIngresar) && 
                Validacion.ValidarNombreOApellido(this.txt_nombre.Text, out string nombreAIngresar) &&
                Validacion.ValidarNombreOApellido(this.txt_apellido.Text, out string apellidoAIngresar))
            {
                string usuarioAIngresar = this.txt_userLogin.Text;
                string passwdAIngresar = this.txt_passwd.Text;
                bool esAdminAIngresar = this.chk_esAdmin.Checked;

                if (!Usuario.VerificarDniExistente(dniAIngresar) && !Usuario.VerificarUsuarioExistente(usuarioAIngresar))
                {
                    Usuario nuevoUsuario = new Usuario(nombreAIngresar, apellidoAIngresar, dniAIngresar,
                    passwdAIngresar, esAdminAIngresar);
                    Usuario.AltaUsuario(usuarioAIngresar, nuevoUsuario);

                    this.listaParaActualizar.Add(nuevoUsuario);
                    Logica.ActualizarDGV(this.refTablaPadre, this.listaParaActualizar);

                    this.Dispose();
                } else
                {
                    MessageBox.Show("Ya existe este usuario o DNI.");
                }
            } else
            {
                this.lbl_error.Visible = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
