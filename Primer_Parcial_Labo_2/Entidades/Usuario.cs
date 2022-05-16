using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string password;
        private bool esAdmin;

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public bool EsAdmin
        {
            get { return esAdmin; }
        }

        public Usuario(string nombre, string apellido, int dni, string password, bool esAdmin)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.password = password;
            this.esAdmin = esAdmin;
        }

        public static void AltaUsuario(string nombreUsuario, Usuario usuario)
        {
            Bar.listaUsuarios.Add(nombreUsuario, usuario);
        }

        public static void BajaUsuario(string nombreUsuario)
        {
            Bar.listaUsuarios.Remove(nombreUsuario);
        }

        public bool VerificarPasswd(string passwdIngresada)
        {
            return this.password == passwdIngresada;
        }

        public static string BuscarCuentaLoginUsuario(Usuario usuario)
        {
            foreach (KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (item.Value == usuario)
                {
                    return item.Key;
                }
            }

            return null;
        }

        public static bool VerificarDniExistente(int dniAVerificar)
        {
            foreach(KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (item.Value.Dni == dniAVerificar)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool VerificarUsuarioExistente(string usuarioAVerificar)
        {
            string usuarioAComparar = usuarioAVerificar.ToLower();
            foreach (KeyValuePair<string, Usuario> item in Bar.listaUsuarios)
            {
                if (item.Key.ToLower() == usuarioAComparar)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// IMPORTANTE!!!!! Este método SÓLO está creado con el fin de cumplir con la consigna del parcial,
        /// la cual solicita que al momento de tener el formulario de login, se autocompleten los datos de un usuario.
        /// En ningún otro segmento del programa existe una exposición de la contraseña del usuario.
        /// </summary>
        /// <returns></returns>
        public string DevolverPasswd()
        {
            return this.password;
        }
    }
}