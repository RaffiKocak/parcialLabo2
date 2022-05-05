using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Consumision
    {
        public enum ETipoComida
        {
            Entrada, Principal, Postre
        }

        private ETipoComida tipoComida;
        private bool esVegano;

        public ETipoComida Tipo
        {
            get { return tipoComida; }
        }

        public bool EsVegano
        {
            get { return esVegano; }
        }

        public Comida(string descripcion, decimal precioUnitario, int cantidad, ETipoComida tipoComida, bool esVegano) 
            : base(descripcion, precioUnitario, cantidad)
        {
            this.tipoComida = tipoComida;
            this.esVegano = esVegano;
        }

        public Comida(Comida comida) : base(comida)
        {
            this.tipoComida = comida.tipoComida;
            this.esVegano= comida.esVegano;
        }

        public override Comida ClonarConsumision()
        {
            return new Comida(this);
        }

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarInfo());
            sb.AppendLine($"Tipo: {this.tipoComida.ToString()}");
            sb.AppendLine($"Plato Vegano: {(this.esVegano ? "Si" : "No")}");

            return sb.ToString();
        }

        //public static Comida operator +(Comida comida, int cantidadASumar)
        //{
        //    if (comida is not null)
        //    {
        //        Comida comidaNueva = comida.ClonarConsumision();
        //        comidaNueva.cantidad = comidaNueva.cantidad + cantidadASumar;
        //        return comidaNueva;
        //    }

        //    return null;
        //}

        //public static Comida operator -(Comida comida, int cantidadARestar)
        //{
        //    if (comida is not null)
        //    {
        //        Comida comidaNueva = comida.ClonarConsumision();
        //        comidaNueva.cantidad = comidaNueva.cantidad - cantidadARestar;
        //        return comidaNueva;
        //    }

        //    return null;
        //}
    }
}
