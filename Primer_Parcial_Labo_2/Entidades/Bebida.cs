using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida : Consumision
    {
        public enum ETipoBebida
        {
            Cerveza, Vino, Agua, Energizante, Batido
        }

        public enum EEnvase
        {
            Botella, Vaso, Lata
        }

        private ETipoBebida tipoBebida;
        private EEnvase tipoEnvase;
        private bool contieneAlcohol;
        private bool contieneTacc;

        #region Propiedades

        public ETipoBebida Tipo
        {
            get { return tipoBebida; }
        }

        public EEnvase Envase
        {
            get { return tipoEnvase; }
        }

        public bool Alcohol
        {
            get { return contieneAlcohol; }
        }

        public bool Tacc
        {
            get { return contieneTacc; }
        }

        #endregion

        public Bebida(string descripcion, decimal precioUnitario, int cantidad, ETipoBebida tipoBebida, 
            EEnvase tipoEnvase, bool contieneAlcohol, bool contieneTacc) 
            : base(descripcion, precioUnitario, cantidad)
        {
            this.tipoBebida = tipoBebida;
            this.tipoEnvase = tipoEnvase;
            this.contieneAlcohol = contieneAlcohol;
            this.contieneTacc = contieneTacc;
        }

        private Bebida(Bebida bebida) : base(bebida)
        {
            this.tipoBebida = bebida.tipoBebida;
            this.tipoEnvase = bebida.tipoEnvase;
            this.contieneAlcohol = bebida.contieneAlcohol;
            this.contieneTacc = bebida.contieneTacc;
        }

        public override Bebida ClonarConsumision()
        {
            return new Bebida(this);
        }

        //public static Bebida operator +(Bebida bebida, int cantidadASumar)
        //{
        //    if (bebida is not null)
        //    {
        //        Bebida bebidaNueva = bebida.ClonarConsumision();
        //        bebidaNueva.cantidad = bebidaNueva.cantidad + cantidadASumar;
        //        return bebidaNueva;
        //    }

        //    return null;
        //}

        //public static Bebida operator -(Bebida bebida, int cantidadARestar)
        //{
        //    if (bebida is not null)
        //    {
        //        Bebida bebidaNueva = bebida.ClonarConsumision();
        //        bebidaNueva.cantidad = bebidaNueva.cantidad - cantidadARestar;
        //        return bebidaNueva;
        //    }

        //    return null;
        //}
    }
}
