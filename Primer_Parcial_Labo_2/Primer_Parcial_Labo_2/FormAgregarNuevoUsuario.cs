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
            int retornoOperacion = this.AgregarUsuario();

            switch(retornoOperacion)
            {
                case -2:
                    this.lbl_error.Visible = true;
                    break;

                case -1:
                    MessageBox.Show("Ya existe este usuario o DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                    break;

                case 0:
                    Logica.ActualizarDGV(this.refTablaPadre, this.listaParaActualizar);
                    this.Dispose();
                    break;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int AgregarUsuario()
        {
            int retorno = -2;
            if (Validacion.ValidarTextosNoVacios(this) && Validacion.ValidarDni(this.txt_dni.Text, out int dniAIngresar) &&
                Validacion.ValidarNombreOApellido(this.txt_nombre.Text, out string nombreAIngresar) &&
                Validacion.ValidarNombreOApellido(this.txt_apellido.Text, out string apellidoAIngresar))
            {
                retorno = -1;
                string usuarioAIngresar = this.txt_userLogin.Text;
                string passwdAIngresar = this.txt_passwd.Text;
                bool esAdminAIngresar = this.chk_esAdmin.Checked;

                if (!Usuario.VerificarDniExistente(dniAIngresar) && !Usuario.VerificarUsuarioExistente(usuarioAIngresar))
                {
                    Usuario nuevoUsuario = new Usuario(nombreAIngresar, apellidoAIngresar, dniAIngresar,
                    passwdAIngresar, esAdminAIngresar);
                    Usuario.AltaUsuario(usuarioAIngresar, nuevoUsuario);
                    retorno = 0;

                    this.listaParaActualizar.Add(nuevoUsuario);
                }
            }

            return retorno;
        }
    }
}
