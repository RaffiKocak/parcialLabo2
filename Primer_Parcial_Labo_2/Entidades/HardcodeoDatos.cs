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
            Usuario.AltaUsuario("RKocak", new Usuario("Raffi", "Kocak", 123, "asd123", true));
            Usuario.AltaUsuario("Chayannepapu", new Usuario("Chayanne", "Papaso", 456, "aa2", false));
        }

        public static void CargarEspaciosDeConsumo()
        {
            CargarMesas(Bar.listaEspaciosConsumo, 15);
            CargarSillas(Bar.listaEspaciosConsumo, 5);
        }

        public static void CargarConsumisiones()
        {
            Bar.stockComidas.Add(new Comida("Hamburguesa", 100, 25, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Panchito", 50, 25, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Bizza sin ananá", 100, 120, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Papitas con cheddar", 100, 25, Comida.ETipoComida.Principal, false));
            Bar.stockBebidas.Add(new Bebida("IPA", 40, 50, Bebida.ETipoBebida.Cerveza, Bebida.EEnvase.Vaso, true, true));
            Bar.stockBebidas.Add(new Bebida("Vino Malbec", 70, 50, Bebida.ETipoBebida.Vino, Bebida.EEnvase.Botella, true, false));
            Bar.stockBebidas.Add(new Bebida("Agua sin gas", 30, 50, Bebida.ETipoBebida.Agua, Bebida.EEnvase.Botella, false, false));
        }
        
        private static void CargarMesas(List<EspacioConsumo> lista, int cantidadMesas)
        {
            for (int i = 0; i < cantidadMesas; i++)
            {
                EspacioConsumo.AltaEspacioConsumo(new EspacioConsumo(ETipoEspacio.Mesa));
            }
        }

        private static void CargarSillas(List<EspacioConsumo> lista, int cantidadSillas)
        {
            for (int i = 0; i < cantidadSillas; i++)
            {
                EspacioConsumo.AltaEspacioConsumo(new EspacioConsumo(ETipoEspacio.Barra));
            }
        }
    }
}