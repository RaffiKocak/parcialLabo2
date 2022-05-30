using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Bar
    {
        public static Dictionary<string, Usuario> listaUsuarios;

        public static List<EspacioConsumo> listaEspaciosConsumo;
        public static List<Comida> stockComidas;
        public static List<Bebida> stockBebidas;
        public static List<Venta> registroVentas;

        static Bar ()
        {
            listaUsuarios = new Dictionary<string, Usuario>();
            stockComidas = new List<Comida>();
            stockBebidas = new List<Bebida>();
            listaEspaciosConsumo = new List<EspacioConsumo>();
            registroVentas = new List<Venta>();
        }

        /// <summary>
        /// Copia la lista ingresada por parámetro y la retorna
        /// </summary>
        /// <param name="listaACopiar"></param>
        /// <returns></returns>
        public static List<Comida> ClonarListaStock(List<Comida> listaACopiar)
        {
            Comida comida;
            if (listaACopiar is not null)
            {
                List<Comida> listaNueva = new List<Comida>();

                foreach (Comida item in listaACopiar)
                {
                    comida = item.ClonarConsumicion();
                    listaNueva.Add(comida);
                }

                return listaNueva;
            }

            return null;
        }

        /// <summary>
        /// Copia la lista ingresada por parámetro y la retorna
        /// </summary>
        /// <param name="listaACopiar"></param>
        /// <returns></returns>
        public static List<Bebida> ClonarListaStock(List<Bebida> listaACopiar)
        {
            Bebida bebida;
            if (listaACopiar is not null)
            {
                List<Bebida> listaNueva = new List<Bebida>();

                foreach (Bebida item in listaACopiar)
                {
                    bebida = item.ClonarConsumicion();
                    listaNueva.Add(bebida);
                }

                return listaNueva;
            }

            return null;
        }

        /// <summary>
        /// Copia la lista ingresada por parámetro y la retorna
        /// </summary>
        /// <param name="listaConsumisiones"></param>
        /// <returns></returns>
        public static List<Consumicion> ClonarListaStock(List<Consumicion> listaConsumisiones)
        {
            Consumicion comida;
            Consumicion bebida;
            if (listaConsumisiones is not null)
            {
                List<Consumicion> listaNueva = new List<Consumicion>();

                foreach (Consumicion item in listaConsumisiones)
                {
                    if (item is Comida)
                    {
                        comida = item.ClonarConsumicion();
                        listaNueva.Add(comida);
                    } else
                    {
                        bebida = item.ClonarConsumicion();
                        listaNueva.Add(bebida);
                    }
                }

                return listaNueva;
            }

            return null;
        }
    }
}
