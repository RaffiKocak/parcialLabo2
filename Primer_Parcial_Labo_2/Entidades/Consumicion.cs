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
                if (!VerificarDescripcionEnStock(descripcionAComparar))
                {
                    if (consumicion is Bebida)
                    {
                        Bar.stockBebidas.Add((Bebida)consumicion);
                    }
                    else
                    {
                        Bar.stockComidas.Add((Comida)consumicion);
                    }
                    return true;
                }
            }

            return false;
        }

        public static bool EliminarStock(Consumicion consumicion)
        {
            if (consumicion is not null)
            {
                string descripcionAComparar = consumicion.descripcion.ToLower();
                if (VerificarDescripcionEnStock(descripcionAComparar))
                {
                    if (consumicion is Bebida)
                    {
                        Bar.stockBebidas.Remove((Bebida)consumicion);
                        return true;
                    }
                    else
                    {
                        Bar.stockComidas.Remove((Comida)consumicion);
                        return true;
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

        public static bool VerificarDescripcionEnStock(string descripcion)
        {
            if (!string.IsNullOrEmpty(descripcion))
            {
                descripcion = descripcion.ToLower();
                foreach (Bebida item in Bar.stockBebidas)
                {
                    if (item.descripcion.ToLower() == descripcion)
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

        public static bool operator ==(Consumicion c1, Consumicion c2)
        {
            return (c1 is not null) && (c2 is not null) && (c1.id == c2.id);
        }

        public static bool operator !=(Consumicion c1, Consumicion c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Bebida bebida, Consumicion consumicion)
        {
            return (bebida is not null) && (consumicion is not null) && (bebida.id == consumicion.id);
        }

        public static bool operator !=(Bebida bebida, Consumicion consumicion)
        {
            return !(bebida == consumicion);
        }

        public static bool operator ==(Comida comida, Consumicion consumicion)
        {
            return (comida is not null) && (consumicion is not null) && (comida.id == consumicion.id);
        }

        public static bool operator !=(Comida comida, Consumicion consumicion)
        {
            return !(comida == consumicion);
        }
    }
}
