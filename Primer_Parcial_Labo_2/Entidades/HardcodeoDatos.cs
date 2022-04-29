using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HardcodeoDatos
    {
        public static void CargarUsuarios()
        {
            Administrador.AltaUsuario(new Administrador("Raffi", "asd123"));
            Empleado.AltaUsuario(new Empleado("Chayanne", "aa2"));
        }

        public static void CargarEspaciosDeConsumo()
        {
            CargarMesas(Bar.listaEspaciosConsumo, 15);
            CargarSillas(Bar.listaEspaciosConsumo, 5);
        }

        public static void CargarConsumisiones()
        {
            Consumision.AgregarConsumisionAStock(new Consumision("Hamburguesa", 100, 25, Consumision.ECategoria.Comida));
            Consumision.AgregarConsumisionAStock(new Consumision("Panchito", 50, 25, Consumision.ECategoria.Comida));
            Consumision.AgregarConsumisionAStock(new Consumision("BIZZA", 120, 30, Consumision.ECategoria.Comida));
            Consumision.AgregarConsumisionAStock(new Consumision("Birra", 30, 100, Consumision.ECategoria.Bebida));
            Consumision.AgregarConsumisionAStock(new Consumision("Vinitou", 50, 75, Consumision.ECategoria.Bebida));
        }
        

        private static void CargarMesas(List<EspacioConsumo> lista, int cantidadMesas)
        {
            for (int i = 0; i < cantidadMesas; i++)
            {
                Mesa.AltaEspacioConsumo(new Mesa());
            }
        }

        private static void CargarSillas(List<EspacioConsumo> lista, int cantidadSillas)
        {
            for (int i = 0; i < cantidadSillas; i++)
            {
                EspacioConsumo.AltaEspacioConsumo(new Barra());
            }
        }
    }
}