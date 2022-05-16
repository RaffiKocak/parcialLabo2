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
            HardcodeoDatos.CargarConsumiciones();
            HardcodeoDatos.CargarVentas();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txt_usuario.Text;
            string passwdIngresada = txt_passwd.Text;
            bool banderaLogin = false;
            string KeyALoguear = String.Empty;
            
            foreach(KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if(item.Key == usuarioIngresado && item.Value.VerificarPasswd(passwdIngresada))
                {
                    banderaLogin = true;
                    KeyALoguear = item.Key;
                    break;
                }
            }

            if (banderaLogin)
            {
                FormPrincipal formAdministrador = new FormPrincipal(Bar.listaUsuarios[KeyALoguear]);
                this.Hide();
                if (formAdministrador.ShowDialog() == DialogResult.OK)
                {
                    txt_usuario.Text = String.Empty;
                    txt_passwd.Text = String.Empty;
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }else
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

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string usuarioIngresado = txt_usuario.Text.ToLower();
            string passwdIngresada = txt_passwd.Text;
            bool banderaLogin = false;
            string KeyALoguear = String.Empty;

            foreach (KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (item.Key.ToLower() == usuarioIngresado && item.Value.VerificarPasswd(passwdIngresada))
                {
                    banderaLogin = true;
                    KeyALoguear = item.Key;
                    break;
                }
            }

            if (banderaLogin)
            {
                FormPrincipal formAdministrador = new FormPrincipal(Bar.listaUsuarios[KeyALoguear]);
                this.Hide();
                if (formAdministrador.ShowDialog() == DialogResult.OK)
                {
                    txt_usuario.Text = String.Empty;
                    txt_passwd.Text = String.Empty;
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btn_fillAdmin_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (item.Value.EsAdmin)
                {
                    this.txt_usuario.Text = item.Key;
                    this.txt_passwd.Text = item.Value.DevolverPasswd();
                }
            }
        }

        private void btn_fillEmpleado_Click(object sender, EventArgs e)
        {
            bool existeUsuario = false;
            foreach (KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (!item.Value.EsAdmin)
                {
                    this.txt_usuario.Text = item.Key;
                    this.txt_passwd.Text = item.Value.DevolverPasswd();
                    existeUsuario = true;
                }
            }

            if (!existeUsuario)
            {
                MessageBox.Show("No existen usuarios sin privilegio de administrador. Por favor crear uno", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
