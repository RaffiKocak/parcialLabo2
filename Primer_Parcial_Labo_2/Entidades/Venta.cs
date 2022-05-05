using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private static int ultimoId;
        private static decimal precioEstacionamiento;
        private int id;
        private DateTime fechaVenta;
        private string metodoPago;
        private decimal precioParcial;
        private int porcentajeModificador;
        private bool usoEstacionamiento;
        private decimal precioFinal;

        public DateTime Fecha
        {
            get { return this.fechaVenta; }
        }

        public string MetodoPago
        {
            get { return this.metodoPago; }
        }

        public decimal PrecioParcial
        {
            get { return this.precioParcial; }
        }

        public int PorcentajeModificador
        {
            get { return this.porcentajeModificador; }
        }

        public bool Estacionamiento
        {
            get { return this.usoEstacionamiento; }
        }

        public decimal PrecioFinal
        {
            get { return this.precioFinal; }
        }

        static Venta()
        {
            ultimoId = 1;
            precioEstacionamiento = 100;
        }

        public Venta(decimal precioParcial, string metodoPago, bool usoEstacionamiento)
        {
            this.id = ultimoId;
            this.fechaVenta = DateTime.Now;
            this.precioParcial = precioParcial;
            this.metodoPago = metodoPago;
            this.porcentajeModificador = DeterminarPorcentajeModificador();
            this.usoEstacionamiento = usoEstacionamiento;
            this.precioFinal = this.CalcularPrecioFinal();
            Venta.ultimoId++;
        }

        private int DeterminarPorcentajeModificador()
        {
            int porcentajeAModificar = 0;
            switch(this.metodoPago)
            {
                case "Efectivo":                    
                    break;

                case "Mercado Pago":
                    break;

                case "Tarjeta Débito":
                    break;

                default:
                    porcentajeAModificar = 10;
                    break;
            }

            return porcentajeAModificar;
        }

        private decimal CalcularPrecioFinal()
        {
            if (this.usoEstacionamiento)
            {
                return this.precioFinal += Venta.precioEstacionamiento + 
                    this.precioParcial + this.precioParcial * this.porcentajeModificador / 100;
            }
            return this.precioFinal = this.precioParcial + this.precioParcial * this.porcentajeModificador / 100;
        }

        public void RegistrarVenta()
        {
            Bar.registroVentas.Add(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------");
            sb.AppendLine($"Fecha: {this.fechaVenta}");
            sb.AppendLine($"Método de pago: {this.metodoPago}");
            sb.AppendLine($"Importe: ${this.precioParcial}");
            sb.AppendLine($"Aumento/Descuento: %{this.PorcentajeModificador}");
            sb.AppendLine($"PLUS Estacionamiento: {(this.usoEstacionamiento ? $"SI +${Venta.precioEstacionamiento}" : "NO")}");
            sb.AppendLine($"TOTAL: ${this.precioFinal}");

            return sb.ToString();
        }

    }
}
