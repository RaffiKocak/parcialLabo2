using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class EspacioConsumo
    {
        private static int ultimoId;
        protected int id;
        protected string tipo;
        protected float saldo;
        protected bool usaEstacionamiento;
        protected bool estaOcupado;
        protected List<Consumision> consumisiones;

        static EspacioConsumo()
        {
            ultimoId = 1;
        }

        public EspacioConsumo()
        {
            this.id = EspacioConsumo.ultimoId;
            this.saldo = 0;
            this.estaOcupado = false;
            this.consumisiones = new List<Consumision>();
            EspacioConsumo.ultimoId++;
        }

        public EspacioConsumo(EspacioConsumo espacio)
        {
            // creo una copia local para modificar
            this.id = espacio.IdMesa;
            this.tipo = espacio.Tipo;
            this.saldo = espacio.Saldo;
            this.estaOcupado = espacio.Ocupado;
            this.consumisiones = Bar.CopiarListaConsumisiones(espacio.Consumisiones);
        }

        public int IdMesa
        {
            get { return id; }
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public float Saldo
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

        public abstract void AgregarConsumo(Consumision consumision, int cantidadPedida);

        public static void GuardarEspacioConCambios(EspacioConsumo espacio)
        {
            int longitud = Bar.listaEspaciosConsumo.Count;

            for (int i = 0; i < longitud; i++)
            {
                if (espacio == Bar.listaEspaciosConsumo[i])
                {
                    if (espacio is Mesa)
                    {
                        Bar.listaEspaciosConsumo[i] = new Mesa(espacio);
                    } else
                    {
                        Bar.listaEspaciosConsumo[i] = new Barra(espacio);
                    }
                                      
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
