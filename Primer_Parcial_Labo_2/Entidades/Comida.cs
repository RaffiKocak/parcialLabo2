using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Consumicion
    {
        public enum ETipoComida
        {
            Entrada, Principal, Postre
        }

        private ETipoComida tipoComida;
        private bool esVegano;

        #region Propiedades

        public ETipoComida Tipo
        {
            get { return tipoComida; }
        }

        public bool EsVegano
        {
            get { return esVegano; }
        }
        #endregion

        public Comida(string descripcion, decimal precioUnitario, int cantidad, ETipoComida tipoComida, bool esVegano) 
            : base(descripcion, precioUnitario, cantidad)
        {
            this.tipoComida = tipoComida;
            this.esVegano = esVegano;
        }

        private Comida(Comida comida) : base(comida)
        {
            this.tipoComida = comida.tipoComida;
            this.esVegano= comida.esVegano;
        }

        /// <summary>
        /// Copia la instancia de la consumicion y la retorna
        /// </summary>
        /// <returns></returns>
        public override Comida ClonarConsumicion()
        {
            return new Comida(this);
        }

        /// <summary>
        /// Retorna un string con la información de instancia de una consumición
        /// </summary>
        /// <returns></returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarInfo());
            sb.AppendLine($"Tipo: {this.tipoComida.ToString()}");
            sb.AppendLine($"Plato Vegano: {(this.esVegano ? "Si" : "No")}");

            return sb.ToString();
        }
    }
}
