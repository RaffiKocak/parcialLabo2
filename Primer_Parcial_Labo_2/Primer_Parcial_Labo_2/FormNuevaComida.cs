﻿using System;
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
    public partial class FormNuevaComida : Form
    {
        DataGridView dgvPadre;
        ComboBox cmbPadre;
        Comida comidaAModificar = null;

        public FormNuevaComida()
        {
            InitializeComponent();
        }

        public FormNuevaComida(DataGridView tablaStock, ComboBox cmbSeleccionado) : this()
        {
            this.dgvPadre = tablaStock;
            this.cmbPadre = cmbSeleccionado;
        }

        public FormNuevaComida(DataGridView tablaStock, ComboBox cmbSeleccionado, Comida comidaAModificar) 
            : this(tablaStock, cmbSeleccionado)
        {
            this.comidaAModificar = comidaAModificar;
        }

        private void FormNuevaConsumision_Load(object sender, EventArgs e)
        {
            this.cmb_tipoComida.DataSource = Enum.GetValues(typeof(Comida.ETipoComida));
            CargarDatosModificacion();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool banderaModificado = false;
            int retornoOperacion = this.AgregarNuevaComida();

            if (retornoOperacion == -3)
            {
                retornoOperacion = this.ModificarPrecioComida();
                banderaModificado = true;
            }

            switch (retornoOperacion)
            {
                case -2:
                    this.lbl_error.Visible = true;
                    break;

                case -1:
                    MessageBox.Show("Ya existe una comida con esta descripción","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 0:
                    Logica.ActualizarDGVCompartido(dgvPadre, this.cmbPadre.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
                    MessageBox.Show($"{(banderaModificado ? "Precio modificado" : "Comida agregada")}", "Éxito", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    this.Dispose();
                    break;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Completa los datos de la comida a modificar en los componentes que correspondan
        /// </summary>
        private void CargarDatosModificacion()
        {
            if (this.comidaAModificar is not null)
            {
                this.lbl_titulo.Text = "Modificar precio unitario";
                this.txt_descripcion.Text = this.comidaAModificar.Descripcion;
                this.txt_precioUnitario.Text = this.comidaAModificar.PrecioUnitario.ToString();
                this.cmb_tipoComida.Text = this.comidaAModificar.Tipo.ToString();
                this.chk_esVegano.Checked = this.comidaAModificar.EsVegano;

                this.txt_descripcion.Enabled = false;
                this.cmb_tipoComida.Enabled = false;
                this.chk_esVegano.Enabled = false;
                this.btn_agregar.Text = "Modificar";
            }
        }

        /// <summary>
        /// Agrega una nueva comida a la lista general con los datos introducidos en el formulario
        /// </summary>
        /// <returns></returns>
        private int AgregarNuevaComida()
        {
            int retorno = -3;

            if (comidaAModificar is null)
            {
                retorno = -2;
                if (Validacion.ValidarTextosNoVacios(this) &&
                    Validacion.ValidarPrecio(txt_precioUnitario.Text, out decimal precioUnitario))
                {
                    retorno = -1;
                    string descripcion = txt_descripcion.Text;
                    Comida.ETipoComida tipoComida = (Comida.ETipoComida)cmb_tipoComida.SelectedItem;
                    bool esVegano = chk_esVegano.Checked;

                    if (!Consumicion.VerificarDescripcionEnStock(descripcion))
                    {
                        Comida nuevaComida = new Comida(descripcion, precioUnitario, 0, tipoComida, esVegano);
                        Consumicion.AgregarNuevoStock(nuevaComida);
                        retorno = 0;                        
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Modifica el precio original de la comida por el introducido en el formulario
        /// </summary>
        /// <returns></returns>
        private int ModificarPrecioComida()
        {
            int retorno = -2;

            if (Validacion.ValidarPrecio(txt_precioUnitario.Text, out decimal precioUnitario))
            {
                this.comidaAModificar.PrecioUnitario = precioUnitario;
                retorno = 0;
            }

            return retorno;
        }
    }
}
