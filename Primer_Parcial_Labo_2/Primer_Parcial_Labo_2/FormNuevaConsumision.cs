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
    public partial class FormNuevaConsumision : Form
    {
        DataGridView dgvPadre;
        ComboBox cmbPadre;
        Comida comidaAModificar = null;

        public FormNuevaConsumision()
        {
            InitializeComponent();
        }

        public FormNuevaConsumision(DataGridView tablaStock, ComboBox cmbSeleccionado) : this()
        {
            this.dgvPadre = tablaStock;
            this.cmbPadre = cmbSeleccionado;
        }

        public FormNuevaConsumision(DataGridView tablaStock, ComboBox cmbSeleccionado, Consumision comidaAModificar) 
            : this(tablaStock, cmbSeleccionado)
        {
            this.comidaAModificar = (Comida)comidaAModificar;
        }

        private void FormNuevaConsumision_Load(object sender, EventArgs e)
        {
            this.cmb_tipoComida.DataSource = Enum.GetValues(typeof(Comida.ETipoComida));
            CargarDatosModificacion();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(comidaAModificar is null)
            {
                //Hacer validador de todos los textbox del formulario
                //Hacer validador de sólo números (activar con evento keypressed)
                //Hacer validadores que retornen entero/float/etc en vez de hacer todo en un tryparse del orto

                string descripcion = txt_descripcion.Text;
                decimal precioUnitario = decimal.Parse(txt_precioUnitario.Text);
                Comida.ETipoComida tipoComida = (Comida.ETipoComida)cmb_tipoComida.SelectedItem;
                bool esVegano = chk_esVegano.Checked;

                //VALIDAR QUE LA DESCRIPCIÓN DEL PRODUCTO NO EXISTA EN LA LISTA PREVIAMENTE, DESPUÉS HACER EL NEW
                //SI NO, ME AUMENTA EL ID PERO DESPUÉS EL PRODUCTO NO SE AGREGA Y NO TIENE MUCHO SENTIDO A CORTO PLAZO
                Comida nuevaComida = new Comida(descripcion, precioUnitario, 0, tipoComida, esVegano);
                if (!Consumision.VerificarExistenciaEnStock(nuevaComida))
                {
                    Consumision.AgregarNuevoStock(nuevaComida);
                    MessageBox.Show($"Producto agregado:\n{nuevaComida.MostrarInfo()}");
                } else
                {
                    MessageBox.Show("ya existe esta comida.");
                }
            } else
            {
                //Preguntar si está seguro de modificar el precio de consumisión. Verificar que no sea negativo

                this.comidaAModificar.PrecioUnitario = decimal.Parse(txt_precioUnitario.Text);
            }

            ActualizarListaStock();

            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ActualizarListaStock()
        {
            this.dgvPadre.DataSource = null;
            if (this.cmbPadre.SelectedIndex == 0)
            {
                this.dgvPadre.DataSource = Bar.stockBebidas;
            }
            else
            {
                this.dgvPadre.DataSource = Bar.stockComidas;
            }
        }

        private void CargarDatosModificacion()
        {
            if (this.comidaAModificar is not null)
            {
                this.txt_descripcion.Text = this.comidaAModificar.Descripcion;
                this.txt_precioUnitario.Text = this.comidaAModificar.PrecioUnitario.ToString();
                this.cmb_tipoComida.Text = this.comidaAModificar.Tipo.ToString();
                this.chk_esVegano.Checked = this.comidaAModificar.EsVegano;

                this.txt_descripcion.Enabled = false;
                this.cmb_tipoComida.Enabled = false;
                this.chk_esVegano.Enabled = false;
                this.btn_agregar.Text = "Modificar precio";
            }
        }
    }
}
