using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consumision
    {
        public enum ECategoria
        {
            Bebida, Comida
        }

        private static int ultimoId;
        private int id;
        private int precioUnitario;
        private string descripcion;
        private int cantidad;
        private ECategoria tipo;

        public int Id
        {
            get { return this.id; }
        }

        public int PrecioUnitario
        {
            get { return this.precioUnitario; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public ECategoria Tipo
        {
            get { return this.tipo; }
        }

        static Consumision()
        {
            ultimoId = 1;
        }

        public Consumision(string descripcion, int precioUnitario, int cantidad, ECategoria tipo) 
        {
            this.id = Consumision.ultimoId;
            this.precioUnitario = precioUnitario;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.tipo = tipo;
            Consumision.ultimoId++;
        }

        public Consumision(Consumision consumision, int cantidad)
        {
            this.id = consumision.id;
            this.precioUnitario = consumision.precioUnitario;
            this.descripcion = consumision.descripcion;
            this.cantidad = cantidad;
            this.tipo = consumision.tipo;
        }

        public Consumision(Consumision consumision) : this(consumision, consumision.cantidad)
        {
        }

        public static void AgregarConsumisionAStock(Consumision consumision)
        {
            if (consumision is not null)
            {
                Bar.stockConsumisiones.Add(consumision);
            }
        }

        public static void BajaConsumisionAStock(int idABorrar)
        {
            foreach(Consumision c in Bar.stockConsumisiones)
            {
                if (c.Id == idABorrar)
                {
                    Bar.stockConsumisiones.Remove(c);
                }
            }
        }

        public static void SumarStock(Consumision consumision, List<Consumision> lista, int cantidad)
        {
            AfectarStock(consumision, lista, cantidad, '+');
        }

        public static void RestarStock(Consumision consumision, List<Consumision> lista, int cantidad)
        {
            AfectarStock(consumision, lista, cantidad, '-');
        }

        private static void AfectarStock(Consumision consumision, List<Consumision> lista, int cantidadAAfectar, char operador)
        {
            foreach (Consumision item in lista)
            {
                if (item == consumision)
                {
                    if (operador == '+')
                    {
                        item.cantidad = item.cantidad + cantidadAAfectar;
                        break;
                    }
                    else
                    {
                        item.cantidad = item.cantidad - cantidadAAfectar;
                        break;
                    }
                }
            }
        }

        //public static void RestarStockParcial(Consumision consumision, List<Consumision> listaParcial, int cantidad)
        //{
            
        //    foreach (Consumision item in listaParcial)
        //    {
        //        if (item == consumision)
        //        {
        //            item.cantidad -= cantidad;
        //            break;
        //        }
        //    }
        //}

        public static void ActualizarStock(List<Consumision> listaConsumision) 
        {
            int longitud = Bar.stockConsumisiones.Count;
            for(int i = 0; i < longitud; i++)
            {
                if ((listaConsumision[i].Id == Bar.stockConsumisiones[i].Id) && 
                    (listaConsumision[i].cantidad != Bar.stockConsumisiones[i].cantidad))
                {
                    Bar.stockConsumisiones[i].cantidad = listaConsumision[i].cantidad;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.id} - {this.descripcion} - {this.precioUnitario}x{this.cantidad} -- ${this.precioUnitario * this.cantidad}";
        }


        // AGREGA ITEM NUEVO
        public static bool operator ==(List<Consumision> listaStock, Consumision consumision)
        {
            foreach (Consumision item in listaStock)
            {
                if (item == consumision)
                {
                    return true;
                }
            }
            return false;
        }

        // ELIMINA ITEM EXISTENTE
        public static bool operator !=(List<Consumision> listaStock, Consumision consumision)
        {
            return !(listaStock == consumision);
        }

        public static bool operator ==(Consumision c1, Consumision c2)
        {
            return (c1 is not null) && (c2 is not null) && c1.id == c2.id;
        }

        public static bool operator !=(Consumision c1, Consumision c2)
        {
            return (c1 is not null) && (c2 is not null) && c1.id == c2.id;
        }

    }
}
