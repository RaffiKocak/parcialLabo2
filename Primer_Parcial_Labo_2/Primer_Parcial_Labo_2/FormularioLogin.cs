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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            HardcodeoDatos.CargarUsuarios();
            HardcodeoDatos.CargarEspaciosDeConsumo();
            HardcodeoDatos.CargarConsumisiones();
            chk_esAdmin.Checked = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txt_usuario.Text;
            string passwdIngresada = txt_passwd.Text;
            bool banderaLogin = false;
            

            if (chk_esAdmin.Checked == true)
            {
                foreach (KeyValuePair<string, string> item in Bar.listaAdministradores)
                {
                    if (usuarioIngresado == item.Key && passwdIngresada == item.Value)
                    {
                        FormAdministrador frmAdmin = new FormAdministrador();
                        frmAdmin.ShowDialog();

                        banderaLogin = true;
                    }
                }
            } else
            {
                foreach (KeyValuePair<string, string> item in Bar.listaEmpleados)
                {
                    if (usuarioIngresado == item.Key && passwdIngresada == item.Value)
                    {
                        MessageBox.Show("Logueaste re piola pa");
                        banderaLogin = true;
                    }
                }
            }

            if (!banderaLogin)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
