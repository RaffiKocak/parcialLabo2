using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoEspacio
    {
        Mesa, Barra
    }

    public class EspacioConsumo
    {
        private static int ultimoId;
        protected int id;
        protected ETipoEspacio tipo;
        protected decimal saldo;
        protected bool usaEstacionamiento;
        protected bool estaOcupado;
        protected List<Consumision> consumisiones;

        public int IdMesa
        {
            get { return id; }
        }

        public ETipoEspacio Tipo
        {
            get { return tipo; }
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

        public List<Consumision> Consumisiones
        {
            get { return consumisiones; }
        }

        static EspacioConsumo()
        {
            ultimoId = 1;
        }

        public EspacioConsumo(ETipoEspacio tipo)
        {
            this.id = EspacioConsumo.ultimoId;
            this.saldo = 0;
            this.tipo = tipo;
            this.estaOcupado = false;
            this.consumisiones = new List<Consumision>();
            EspacioConsumo.ultimoId++;
        }

        protected EspacioConsumo(EspacioConsumo espacio)
        {
            this.id = espacio.IdMesa;
            this.tipo = espacio.Tipo;
            this.saldo = espacio.Saldo;
            this.estaOcupado = espacio.Ocupado;
            this.consumisiones = Bar.ClonarListaStock(espacio.Consumisiones);
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
            this.consumisiones = new List<Consumision>();
        }

        public int VerificarProductoYaPedido(Consumision consumision)
        {
            if (consumision is not null)
            {
                int longitud = this.consumisiones.Count;
                foreach (Consumision item in this.consumisiones)
                {
                    if (item == consumision)
                    {
                        return this.consumisiones.IndexOf(item);
                    }
                }
            }

            return -1;
        }

        public virtual bool AgregarConsumo(Consumision consumision, int cantidadPedida)
        {
            // validar que si es comida y barra no entre
            if (consumision.Cantidad >= cantidadPedida) // VALIDAR POR MEDIO DE BIBLIOTECA. ALCANZASTOCK
            {
                int index = this.VerificarProductoYaPedido(consumision);
                if (index != -1)
                {
                    this.consumisiones[index].Cantidad += cantidadPedida;
                }
                else
                {
                    Consumision consumisionNueva = consumision.ClonarConsumision();
                    consumisionNueva.Cantidad = cantidadPedida;
                    this.consumisiones.Add(consumisionNueva);
                }
                this.saldo += (consumision.PrecioUnitario * cantidadPedida);

                return true;
            }

            return false;
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
