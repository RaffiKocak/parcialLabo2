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
            bool banderaModificado = false;
            int retornoOperacion = this.AgregarNuevaBebida();

            if (retornoOperacion == -3)
            {
                retornoOperacion = this.ModificarPrecioBebida();
                banderaModificado = true;
            }

            switch(retornoOperacion)
            {
                case -2:
                    this.lbl_error.Visible = true;
                    break;

                case -1:
                    MessageBox.Show("Ya existe una bebida con esta descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 0:
                    Logica.ActualizarDGVCompartido(dgvPadre, this.cmbPadre.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
                    MessageBox.Show($"{(banderaModificado ? "Precio modificado" : "Bebida agregada")}", "Éxito", MessageBoxButtons.OK,
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
        /// Completa los datos de la bebida a modificar en los componentes que correspondan
        /// </summary>
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

        /// <summary>
        /// Agrega una nueva bebida a la lista general con los datos introducidos en el formulario
        /// </summary>
        /// <returns></returns>
        private int AgregarNuevaBebida()
        {
            int retorno = -3;

            if (bebidaAModificar is null)
            {
                retorno = -2;
                if (Validacion.ValidarTextosNoVacios(this) &&
                    Validacion.ValidarPrecio(txt_precioUnitario.Text, out decimal precioUnitario))
                {
                    retorno = -1;
                    string descripcion = txt_descripcion.Text;
                    Bebida.ETipoBebida tipoBebida = (Bebida.ETipoBebida)cmb_tipoBebida.SelectedItem;
                    Bebida.EEnvase envase = (Bebida.EEnvase)cmb_envase.SelectedItem;
                    bool tieneTacc = chk_tieneTacc.Checked;
                    bool tieneAlcohol = chk_tieneAlcohol.Checked;

                    if (!Consumicion.VerificarDescripcionEnStock(descripcion))
                    {
                        Bebida nuevaBebida = new Bebida(descripcion, precioUnitario, 0, tipoBebida, envase, tieneAlcohol, tieneTacc);
                        Consumicion.AgregarNuevoStock(nuevaBebida);
                        retorno = 0;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Modifica el precio original de la bebida por el introducido en el formulario
        /// </summary>
        /// <returns></returns>
        private int ModificarPrecioBebida()
        {
            int retorno = -2;

            if (Validacion.ValidarPrecio(txt_precioUnitario.Text, out decimal precioUnitario))
            {
                this.bebidaAModificar.PrecioUnitario = precioUnitario;
                retorno = 0;
            }

            return retorno;
        }
    }
}
