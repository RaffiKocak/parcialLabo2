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
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarUsuarios();
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarNuevoUsuario frmNuevoUser = new FormAgregarNuevoUsuario(this.dgv_usuarios, listaAMostrar);
            frmNuevoUser.TopLevel = false;
            pnl_contenedor.Controls.Add(frmNuevoUser);
            frmNuevoUser.Show();
        }

        private void ActualizarUsuarios()
        {
            listaAMostrar = Bar.listaUsuarios.Values.ToList();
            this.dgv_usuarios.DataSource = listaAMostrar;
        }
    }
}
