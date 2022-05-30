using System.Collections.Generic;

namespace Entidades
{
    public class EspacioConsumo
    {
        private static int ultimoId;
        private int id;
        private bool esMesa;
        private decimal saldo;
        private bool estaOcupado;
        private List<Consumicion> consumiciones;

        #region Propiedades
        public int IdEspacio
        {
            get { return id; }
        }

        public bool EsMesa
        {
            get { return esMesa; }
        }

        public decimal Saldo
        {
            get { return this.saldo; }
        }

        public bool Ocupado
        {
            get { return estaOcupado; }
            set { estaOcupado = value; }
        }

        public List<Consumicion> Consumiciones
        {
            get { return consumiciones; }
        }

        #endregion

        static EspacioConsumo()
        {
            ultimoId = 1;
        }

        public EspacioConsumo(bool esMesa)
        {
            this.id = EspacioConsumo.ultimoId;
            this.saldo = 0;
            this.esMesa = esMesa;
            this.estaOcupado = false;
            this.consumiciones = new List<Consumicion>();
            EspacioConsumo.ultimoId++;
        }

        private EspacioConsumo(EspacioConsumo espacio)
        {
            this.id = espacio.IdEspacio;
            this.esMesa = espacio.esMesa;
            this.saldo = espacio.Saldo;
            this.estaOcupado = espacio.Ocupado;
            this.consumiciones = Bar.ClonarListaStock(espacio.Consumiciones);
        }

        /// <summary>
        /// Copia la instancia del espacio de consumo y lo retorna
        /// </summary>
        /// <returns></returns>
        public EspacioConsumo ClonarEspacioConsumo()
        {
            return new EspacioConsumo(this);
        }

        /// <summary>
        /// Agrega un espacio de consumo a la lista general correspondiente
        /// </summary>
        /// <param name="eConsumo"></param>
        public static void AltaEspacioConsumo(EspacioConsumo eConsumo)
        {
            if (eConsumo is not null)
            {
                Bar.listaEspaciosConsumo.Add(eConsumo);
            }
        }

        /// <summary>
        /// Quita un espacio de consumo de la lista general correspondiente
        /// </summary>
        /// <param name="idABorrar"></param>
        public static void BajaEspacioConsumo(int idABorrar)
        {
            foreach (EspacioConsumo item in Bar.listaEspaciosConsumo)
            {
                if (item.id == idABorrar)
                {
                    Bar.listaEspaciosConsumo.Remove(item);
                    break;
                }
            }
        }

        /// <summary>
        /// Vuelve a poner al espacio de consumo disponible para ser ocupado y vacío de pedidos.
        /// </summary>
        public void CerrarEspacio()
        {
            this.saldo = 0;
            this.estaOcupado = false;
            this.consumiciones = new List<Consumicion>();
        }

        /// <summary>
        /// Verifica si el espacio ya tiene cargada al menos un pedido de una consumición
        /// </summary>
        /// <param name="consumicion"></param>
        /// <returns></returns>
        public int VerificarProductoYaPedido(Consumicion consumicion)
        {
            if (consumicion is not null)
            {
                int longitud = this.consumiciones.Count;
                foreach (Consumicion item in this.consumiciones)
                {
                    if (item == consumicion)
                    {
                        return this.consumiciones.IndexOf(item);
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Agrega una cantidad determinada de una consumicion a los pedidos realizados por el espacio de consumo.
        /// </summary>
        /// <param name="consumicion"></param>
        /// <param name="cantidadPedida"></param>
        /// <returns></returns>
        public bool AgregarConsumo(Consumicion consumicion, int cantidadPedida)
        {
            if (!this.esMesa && consumicion is Comida)
            {
                return false;
            }

            if (consumicion.VerificarAlcanzaStock(cantidadPedida))
            {
                int index = this.VerificarProductoYaPedido(consumicion);
                if (index != -1)
                {
                    this.consumiciones[index].Cantidad += cantidadPedida;
                }
                else
                {
                    Consumicion consumicionNueva = consumicion.ClonarConsumicion();
                    consumicionNueva.Cantidad = cantidadPedida;
                    this.consumiciones.Add(consumicionNueva);
                }
                this.saldo += consumicion.PrecioUnitario * cantidadPedida;
                this.estaOcupado = true;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Elimina una cantidad determinada de una consumicion a los pedidos realizados por el espacio de consumo.
        /// </summary>
        /// <param name="consumicion"></param>
        /// <param name="cantidadARestar"></param>
        public void RestarConsumo(Consumicion consumicion, int cantidadARestar)
        {
            if (consumicion is not null && cantidadARestar > 0)
            {
                consumicion.Cantidad -= cantidadARestar;
                this.saldo -= consumicion.PrecioUnitario * cantidadARestar;


                if (consumicion.Cantidad == 0)
                {
                    this.consumiciones.Remove(consumicion);
                }

                if (this.consumiciones.Count == 0)
                {
                    this.estaOcupado = false;
                }
            }
        }

        /// <summary>
        /// Guarda el espacio de consumo con su información actualizada de la lista de espacios general
        /// </summary>
        /// <param name="espacio"></param>
        public static void GuardarEspacioConCambios(EspacioConsumo espacio)
        {
            int longitud = Bar.listaEspaciosConsumo.Count;

            for (int i = 0; i < longitud; i++)
            {
                if (espacio == Bar.listaEspaciosConsumo[i])
                {
                    Bar.listaEspaciosConsumo[i] = espacio.ClonarEspacioConsumo();
                    break;
                }
            }
        }

        /// <summary>
        /// Verifica que todos los espacios de consumo estén desocupados.
        /// </summary>
        /// <returns></returns>
        public static bool VerificarTodosEspaciosDesocupados()
        {
            foreach(EspacioConsumo item in Bar.listaEspaciosConsumo)
            {
                if (item.Ocupado)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(EspacioConsumo e1, EspacioConsumo e2)
        {
            return (e1 is not null) && (e2 is not null) && (e1.id == e2.id);
        }

        public static bool operator !=(EspacioConsumo e1, EspacioConsumo e2)
        {
            return !(e1 == e2);
        }
    }
}
