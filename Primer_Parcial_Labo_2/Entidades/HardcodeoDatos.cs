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
            Usuario.AltaUsuario("RKocak", new Usuario("Raffi", "Kocak", 12345678, "asd123", true));
            Usuario.AltaUsuario("LivinLaVidaLoca", new Usuario("Ricky", "Martin", 45678912, "aa2", false));
        }

        public static void CargarEspaciosDeConsumo()
        {
            CargarMesas(Bar.listaEspaciosConsumo, 15);
            CargarSillas(Bar.listaEspaciosConsumo, 5);
        }

        public static void CargarConsumiciones()
        {
            Bar.stockComidas.Add(new Comida("Hamburguesa", 100, 25, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Pancho", 50, 25, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Pizza muzzarella", 100, 120, Comida.ETipoComida.Principal, false));
            Bar.stockComidas.Add(new Comida("Papas con cheddar", 100, 25, Comida.ETipoComida.Principal, true));
            Bar.stockBebidas.Add(new Bebida("IPA", 40, 50, Bebida.ETipoBebida.Cerveza, Bebida.EEnvase.Vaso, true, true));
            Bar.stockBebidas.Add(new Bebida("APA", 40, 50, Bebida.ETipoBebida.Cerveza, Bebida.EEnvase.Vaso, true, true));
            Bar.stockBebidas.Add(new Bebida("Vino Malbec", 70, 50, Bebida.ETipoBebida.Vino, Bebida.EEnvase.Botella, true, false));
            Bar.stockBebidas.Add(new Bebida("Agua sin gas", 30, 50, Bebida.ETipoBebida.Agua, Bebida.EEnvase.Botella, false, false));
        }
        
        private static void CargarMesas(List<EspacioConsumo> lista, int cantidadMesas)
        {
            for (int i = 0; i < cantidadMesas; i++)
            {
                EspacioConsumo.AltaEspacioConsumo(new EspacioConsumo(true));
            }
        }

        private static void CargarSillas(List<EspacioConsumo> lista, int cantidadSillas)
        {
            for (int i = 0; i < cantidadSillas; i++)
            {
                EspacioConsumo.AltaEspacioConsumo(new EspacioConsumo(false));
            }
        }

        public static void CargarVentas()
        {
            Bar.registroVentas.Add(new Venta(500, "Efectivo", true));
            Bar.registroVentas.Add(new Venta(600, "Tarjeta Débito", false));
            Bar.registroVentas.Add(new Venta(804.5M, "Tarjeta Crédito", true));
            Bar.registroVentas.Add(new Venta(100, "Mercado Pago", true));
        }
    }
}