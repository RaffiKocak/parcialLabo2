using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public Empleado(string nombreUsuario, string password) : base(nombreUsuario, password)
        {
        }

        public static void AltaUsuario(Empleado empleado)
        {
            Bar.listaEmpleados.Add(empleado.nombreUsuario, empleado.password);
        }

        public static void BajaUsuario(Empleado empleado)
        {
            Bar.listaEmpleados.Remove(empleado.nombreUsuario);
        }
    }
}
