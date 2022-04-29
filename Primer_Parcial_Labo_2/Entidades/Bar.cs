using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        public static Dictionary<string, string> listaEmpleados;
        public static Dictionary<string, string> listaAdministradores;

        public static List<EspacioConsumo> listaEspaciosConsumo;
        public static List<Consumision> stockConsumisiones;
        public static List<Venta> registroVentas;

        static Bar ()
        {
            listaEmpleados = new Dictionary<string, string>();
            listaAdministradores = new Dictionary<string, string>();
            stockConsumisiones = new List<Consumision>();
            listaEspaciosConsumo = new List<EspacioConsumo>();
            registroVentas = new List<Venta>();
        }

        public static List<Consumision> CopiarListaConsumisiones(List<Consumision> listaACopiar)
        {
            Consumision consumision;
            if (listaACopiar is not null)
            {
                List<Consumision> listaNueva = new List<Consumision>();

                foreach (Consumision item in listaACopiar)
                {
                    consumision = new Consumision(item);
                    listaNueva.Add(consumision);
                }

                return listaNueva;
            }

            return null;
        }
    }
}
