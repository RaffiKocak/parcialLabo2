﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida : Consumicion
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

        /// <summary>
        /// Copia la instancia de la consumicion y la retorna
        /// </summary>
        /// <returns></returns>
        public override Bebida ClonarConsumicion()
        {
            return new Bebida(this);
        }

        /// <summary>
        /// Retorna un string con la información de instancia de una consumición
        /// </summary>
        /// <returns></returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarInfo());
            sb.AppendLine($"Tipo: {this.tipoBebida.ToString()}");
            sb.AppendLine($"¿Contiene alcohol?: {(this.contieneAlcohol ? "Si" : "No")}");
            sb.AppendLine($"¿Apto para celíacos?: {(this.contieneTacc ? "No" : "Si")}");

            return sb.ToString();
        }
    }
}
