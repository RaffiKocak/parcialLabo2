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
    public partial class FormNuevaBebida : Form
    {
        DataGridView dgvPadre;
        ComboBox cmbPadre;
        Bebida bebidaAModificar = null;

        public FormNuevaBebida()
        {
            InitializeComponent();
        }

        public FormNuevaBebida(DataGridView tablaStock, ComboBox cmbSeleccionado) : this()
        {
            this.dgvPadre = tablaStock;
            this.cmbPadre = cmbSeleccionado;
        }

        public FormNuevaBebida(DataGridView tablaStock, ComboBox cmbSeleccionado, Bebida bebidaAModificar)
            : this(tablaStock, cmbSeleccionado)
        {
            this.bebidaAModificar = bebidaAModificar;
        }

        private void FormNuevaBebida_Load(object sender, EventArgs e)
        {
            this.cmb_tipoBebida.DataSource = Enum.GetValues(typeof(Bebida.ETipoBebida));
            this.cmb_envase.DataSource = Enum.GetValues(typeof(Bebida.EEnvase));
            CargarDatosModificacion();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool operacionExitosa = false;
            if (bebidaAModificar is null)
            {
                if (Validacion.ValidarTextosNoVacios(this))
                {
                    txt_precioUnitario.Text = txt_precioUnitario.Text.Replace('.', ',');
                    if (Validacion.ValidarPrecio(txt_precioUnitario.Text))
                    {
                        string descripcion = txt_descripcion.Text;
                        decimal precioUnitario = decimal.Parse(txt_precioUnitario.Text);
                        Bebida.ETipoBebida tipoBebida = (Bebida.ETipoBebida)cmb_tipoBebida.SelectedItem;
                        Bebida.EEnvase envase = (Bebida.EEnvase)cmb_envase.SelectedItem;
                        bool tieneTacc = chk_tieneTacc.Checked;
                        bool tieneAlcohol = chk_tieneAlcohol.Checked;

                        if (!Consumision.VerificarDescripcionEnStock(descripcion))
                        {
                            Bebida nuevaBebida = new Bebida(descripcion, precioUnitario, 0, tipoBebida, envase, tieneAlcohol, tieneTacc);
                            Consumision.AgregarNuevoStock(nuevaBebida);
                            MessageBox.Show($"Producto agregado:\n{nuevaBebida.MostrarInfo()}");
                            operacionExitosa = true;
                        }
                        else
                        {
                            MessageBox.Show("Ya existe una bebida con esta descripción");
                        }
                    } else
                    {
                        this.lbl_error.Visible = true;
                    }
                } else
                {
                    this.lbl_error.Visible = true;
                }
            }
            else
            {
                //Preguntar si está seguro de modificar el precio de consumisión. Verificar que no sea negativo
                txt_precioUnitario.Text = txt_precioUnitario.Text.Replace('.', ',');
                if (Validacion.ValidarPrecio(txt_precioUnitario.Text))
                {
                    this.bebidaAModificar.PrecioUnitario = decimal.Parse(txt_precioUnitario.Text);
                    operacionExitosa = true;
                } else
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
            if (this.bebidaAModificar is not null)
            {
                this.lbl_titulo.Text = "Modificar precio unitario";
                this.txt_descripcion.Text = this.bebidaAModificar.Descripcion;
                this.txt_precioUnitario.Text = this.bebidaAModificar.PrecioUnitario.ToString();
                this.cmb_tipoBebida.Text = this.bebidaAModificar.Tipo.ToString();
                this.cmb_envase.Text = this.bebidaAModificar.Envase.ToString();
                this.chk_tieneAlcohol.Checked = this.bebidaAModificar.Alcohol;
                this.chk_tieneTacc.Checked = this.bebidaAModificar.Tacc;

                this.txt_descripcion.Enabled = false;
                this.cmb_tipoBebida.Enabled = false;
                this.cmb_envase.Enabled = false;
                this.chk_tieneAlcohol.Enabled = false;
                this.chk_tieneTacc.Enabled = false;
                this.btn_agregar.Text = "Modificar";
            }
        }
    }
}
