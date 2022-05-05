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

            string nombreAIngresar = this.txt_nombre.Text;
            string apellidoAingresar = this.txt_apellido.Text;
            int dniAIngresar = int.Parse(this.txt_dni.Text);
            string usuarioAIngresar = this.txt_userLogin.Text;
            string passwdAIngresar = this.txt_passwd.Text;
            bool esAdminAIngresar = this.chk_esAdmin.Checked;


            // comprobar que el user no exista. también comprobar que no exista el mismo dni
            Usuario.AltaUsuario(usuarioAIngresar, new Usuario(nombreAIngresar, apellidoAingresar, dniAIngresar, 
                passwdAIngresar, esAdminAIngresar));

            ActualizarUsuarios();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ActualizarUsuarios()
        {
            this.listaParaActualizar = Bar.listaUsuarios.Values.ToList();
            this.refTablaPadre.DataSource = listaParaActualizar;
        }
    }
}
