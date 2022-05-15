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

        public EspacioConsumo ClonarEspacioConsumo()
        {
            return new EspacioConsumo(this);
        }

        public static void AltaEspacioConsumo(EspacioConsumo eConsumo)
        {
            if (eConsumo is not null)
            {
                Bar.listaEspaciosConsumo.Add(eConsumo);
            }
        }

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

        public void CerrarMesa()
        {
            this.saldo = 0;
            this.estaOcupado = false;
            this.consumiciones = new List<Consumicion>();
        }

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

                return true;
            }

            return false;
        }

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
            }
        }

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
