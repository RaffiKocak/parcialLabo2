using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        protected string nombreUsuario;
        protected string password;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
        }

        public Usuario(string nombreUsuario, string password)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }
    }
}