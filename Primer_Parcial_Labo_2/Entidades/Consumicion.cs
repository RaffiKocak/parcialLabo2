using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Consumicion
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
            set
            {
                if (value >= 0)
                {
                    this.cantidad = value;
                }
            }
        }

        #endregion

        #region Constructores

        static Consumicion()
        {
            Consumicion.ultimoId = 1;
        }

        public Consumicion(string descripcion, decimal precioUnitario, int cantidad)
        {
            this.id = Consumicion.ultimoId;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;
            Consumicion.ultimoId++;
        }

        protected Consumicion(Consumicion consumision)
        {
            this.id = consumision.id;
            this.precioUnitario = consumision.precioUnitario;
            this.descripcion = consumision.descripcion;
            this.cantidad = consumision.cantidad;
        }

        #endregion

        public abstract Consumicion ClonarConsumicion();

        public override string ToString()
        {
            return $"{this.descripcion}: {this.cantidad} x ${this.precioUnitario} = ${this.cantidad * this.precioUnitario}";
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

        public static bool AgregarNuevoStock(Consumicion consumicion)
        {
            if (consumicion is not null)
            {
                string descripcionAComparar = consumicion.descripcion.ToLower();
                if (consumicion is Bebida)
                {
                    foreach (Bebida item in Bar.stockBebidas)
                    {
                        if (item.descripcion.ToLower() == descripcionAComparar)
                        {
                            return false;
                        }
                    }
                    Bar.stockBebidas.Add((Bebida)consumicion);
                }
                else
                {
                    foreach (Comida item in Bar.stockComidas)
                    {
                        if (item.descripcion.ToLower() == descripcionAComparar)
                        {
                            return false;
                        }
                    }
                    Bar.stockComidas.Add((Comida)consumicion);
                }
                return true;
            }

            return false;
        }

        public static bool EliminarStock(Consumicion consumicion)
        {
            if (consumicion is not null)
            {
                if (consumicion is Bebida)
                {
                    foreach (Bebida item in Bar.stockBebidas)
                    {
                        if (item == consumicion)
                        {
                            Bar.stockBebidas.Remove(item);
                            return true;
                        }
                    }
                }
                else
                {
                    foreach (Comida item in Bar.stockComidas)
                    {
                        if (item == consumicion)
                        {
                            Bar.stockComidas.Remove(item);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static void RestarStock(Consumicion consumicion, int cantidadIngresada)
        {
            if (consumicion is not null && cantidadIngresada > 0)
            {
                consumicion.cantidad -= cantidadIngresada;
            }
        }

        public static void SumarStock(Consumicion consumicion, int cantidadIngresada)
        {
            if (consumicion is not null && cantidadIngresada > 0)
            {
                consumicion.cantidad += cantidadIngresada;
            }
        }

        public static void ActualizarTodoStockPermanente(List<Comida> listaComida, List<Bebida> listaBebida)
        {
            Bar.stockComidas = listaComida;
            Bar.stockBebidas = listaBebida;
        }

        #endregion

        public static bool VerificarDescripcionEnStock(string descripcion)
        {
            if (!string.IsNullOrEmpty(descripcion))
            {
                foreach (Bebida item in Bar.stockBebidas)
                {
                    if (item.descripcion == descripcion)
                    {
                        return true;
                    }
                }

                foreach (Comida item in Bar.stockComidas)
                {
                    if (item.descripcion == descripcion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool VerificarAlcanzaStock(int cantidadPedida)
        {
            return this.cantidad >= cantidadPedida;
        }

        #region Sobrecarga operadores

        public static bool operator ==(Consumicion c1, Consumicion c2)
        {
            return (c1 is not null) && (c2 is not null) && (c1.id == c2.id);
        }

        public static bool operator !=(Consumicion c1, Consumicion c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
