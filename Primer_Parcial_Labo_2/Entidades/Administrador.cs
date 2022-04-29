using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuario
    {
        public Administrador(string nombreUsuario, string password) : base(nombreUsuario, password)
        {
        }

        public static void AltaUsuario(Administrador admin)
        {
            Bar.listaAdministradores.Add(admin.nombreUsuario, admin.password);
        }

        public static void BajaUsuario(Administrador admin)
        {
            Bar.listaAdministradores.Remove(admin.nombreUsuario);
        }
    }
}
