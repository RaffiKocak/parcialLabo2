using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Consumision
    {
        private static int ultimoId;
        protected int id;
        protected decimal precioUnitario;
        protected string descripcion;
        protected int cantidad;

        #region Propiedades

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public decimal PrecioUnitario
        {
            get { return this.precioUnitario; }
            set { this.precioUnitario = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        #endregion

        #region Constructores

        static Consumision()
        {
            Consumision.ultimoId = 1;
        }

        public Consumision(string descripcion, decimal precioUnitario, int cantidad)
        {
            this.id = Consumision.ultimoId;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;
            Consumision.ultimoId++;
        }

        protected Consumision(Consumision consumision)
        {
            this.id = consumision.id;
            this.precioUnitario = consumision.precioUnitario;
            this.descripcion = consumision.descripcion;
            this.cantidad = consumision.cantidad;
        }

        #endregion

        public abstract Consumision ClonarConsumision();

        public override string ToString()
        {
            return $"{this.descripcion}: {this.cantidad} x ${this.precioUnitario} = {this.cantidad * this.precioUnitario}";
        }

        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Descripcion: {this.descripcion}");
            sb.AppendLine($"Precio Unitario: {this.precioUnitario}");

            return sb.ToString();
        }

        #region Agregar, eliminar y actualizar stock

        public static bool AgregarNuevoStock(Consumision consumision)
        {
            if (consumision is not null)
            {
                string descripcionAComparar = consumision.descripcion.ToLower();
                if (consumision is Bebida)
                {
                    foreach (Bebida item in Bar.stockBebidas)
                    {
                        if (item.descripcion.ToLower() == descripcionAComparar)
                        {
                            return false;
                        }
                    }
                    Bar.stockBebidas.Add((Bebida)consumision);
                } else
                {
                    foreach (Comida item in Bar.stockComidas)
                    {
                        if (item.descripcion.ToLower() == descripcionAComparar)
                        {
                            return false;
                        }
                    }
                    Bar.stockComidas.Add((Comida)consumision);
                }
                return true;
            }

            return false;
        }

        public static bool EliminarStock(Consumision consumision)
        {
            if (consumision is not null)
            {
                if (consumision is Bebida)
                {
                    foreach (Bebida item in Bar.stockBebidas)
                    {
                        if (item == consumision)
                        {
                            Bar.stockBebidas.Remove(item);
                            return true;
                        }
                    }
                } else
                {
                    foreach (Comida item in Bar.stockComidas)
                    {
                        if (item == consumision)
                        {
                            Bar.stockComidas.Remove(item);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static void ActualizarTodoStockPermanente(List<Comida> listaComida, List<Bebida> listaBebida)
        {
            Bar.stockComidas = listaComida;
            Bar.stockBebidas = listaBebida;
        }

        #endregion

        public static bool VerificarExistenciaEnStock(Consumision consumision)
        {
            if (consumision is not null)
            {
                if (consumision is Bebida bebida)
                {
                    foreach (Bebida item in Bar.stockBebidas)
                    {
                        if (item == bebida)
                        {
                            return true;
                        }
                    }
                } else
                {
                    Comida comida = consumision as Comida;
                    foreach(Comida item in Bar.stockComidas)
                    {
                        if (item == comida)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        #region Sobrecarga operadores

        public static bool operator ==(Consumision c1, Consumision c2)
        {
            return (c1 is not null) && (c2 is not null) && (c1.descripcion == c2.descripcion || c1.id == c2.id);
        }

        public static bool operator !=(Consumision c1, Consumision c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
