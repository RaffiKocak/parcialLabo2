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
            bool operacionExitosa = false;
            if(comidaAModificar is null)
            {
                if (Validacion.ValidarTextosNoVacios(this))
                {
                    txt_precioUnitario.Text = txt_precioUnitario.Text.Replace('.', ',');
                    if (Validacion.ValidarPrecio(txt_precioUnitario.Text))
                    {
                        string descripcion = txt_descripcion.Text;
                        decimal precioUnitario = decimal.Parse(txt_precioUnitario.Text);
                        Comida.ETipoComida tipoComida = (Comida.ETipoComida)cmb_tipoComida.SelectedItem;
                        bool esVegano = chk_esVegano.Checked;

                        if (!Consumision.VerificarDescripcionEnStock(descripcion))
                        {
                            Comida nuevaComida = new Comida(descripcion, precioUnitario, 0, tipoComida, esVegano);
                            Consumision.AgregarNuevoStock(nuevaComida);
                            MessageBox.Show($"Producto agregado:\n{nuevaComida.MostrarInfo()}");
                            operacionExitosa = true;
                        }
                        else
                        {
                            MessageBox.Show("ya existe esta comida.");
                        }
                    } else
                    {
                        this.lbl_error.Visible = true;
                    } 
                } else
                {
                    this.lbl_error.Visible = true;
                } 
            } else
            {
                txt_precioUnitario.Text = txt_precioUnitario.Text.Replace('.', ',');
                if (Validacion.ValidarPrecio(txt_precioUnitario.Text))
                {
                    this.comidaAModificar.PrecioUnitario = decimal.Parse(txt_precioUnitario.Text);
                    operacionExitosa = false;
                }
                else
                {
                    this.lbl_error.Visible = true;
                }
            }
   
            if (operacionExitosa)
            {
                Logica.ActualizarDGVCompartido(dgvPadre, this.cmbPadre.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
                this.Dispose();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
    }
}
