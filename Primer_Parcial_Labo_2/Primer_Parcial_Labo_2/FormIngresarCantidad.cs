using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Primer_Parcial_Labo_2
{
    public partial class FormIngresarCantidad : Form
    {
        bool ingresaPrecio;
        bool mostrarCheckbox;
        int numeroEntero;
        decimal numeroDecimal;

        public FormIngresarCantidad()
        {
            InitializeComponent();
        }

        public FormIngresarCantidad(bool ingresaPrecio, bool mostrarCheckbox) : this()
        {
            this.ingresaPrecio = ingresaPrecio;
            this.mostrarCheckbox = mostrarCheckbox;
        }

        private void FormIngresarCantidad_Load(object sender, EventArgs e)
        {
            this.txt_numeroIngresado.Focus();
            this.txt_numeroIngresado.Text = "1";
            if (ingresaPrecio)
            {
                this.lbl_cantidad.Text = "Ingrese precio:";
            }
            if (mostrarCheckbox)
            {
                this.chk_conservarConsumicion.Visible = true;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ingresaPrecio)
            {
                if (Validacion.ValidarPrecio(txt_numeroIngresado.Text, out numeroDecimal) && numeroDecimal >= 1) 
                {
                    this.DialogResult = DialogResult.OK;
                }
            } else
            {
                _ = int.TryParse(txt_numeroIngresado.Text, out numeroEntero);
                if (numeroEntero >= 1)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            this.lbl_error.Visible = true;
        }

        /// <summary>
        /// Retorna la cantidad ingresada dentro del formulario
        /// </summary>
        /// <returns></returns>
        public int DevolverCantidad()
        {
            return numeroEntero;
        }

        /// <summary>
        /// Retorna el precio ingresado dentro del formulario
        /// </summary>
        /// <returns></returns>
        public decimal DevolverPrecio()
        {
            return numeroDecimal;
        }

        /// <summary>
        /// Verifica si la consumición a eliminar vuelve a formar parte del stock
        /// </summary>
        /// <returns></returns>
        public bool VerificarConservaConsumicion()
        {
            return chk_conservarConsumicion.Checked;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
