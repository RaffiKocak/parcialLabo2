using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormDetalleEspacioConsumo : Form
    {
        EspacioConsumo espacioConsumo;
        List<Comida> copiaLocalComidas;
        List<Bebida> copiaLocalBebidas;
        bool huboCambios;
        DataGridView dgv_padre;

        public FormDetalleEspacioConsumo()
        {
            InitializeComponent();
        }

        public FormDetalleEspacioConsumo(EspacioConsumo espacioConsumo, DataGridView dgv)
            : this()
        {
            this.espacioConsumo = espacioConsumo.ClonarEspacioConsumo();
            this.dgv_padre = dgv;
            this.copiaLocalComidas = Bar.ClonarListaStock(Bar.stockComidas);
            this.copiaLocalBebidas = Bar.ClonarListaStock(Bar.stockBebidas);
        }

        private void FormDetalleEspacioConsumo_Load(object sender, EventArgs e)
        {
            this.cmb_opciones.Items.Add("Bebidas");
            this.cmb_opciones.Items.Add("Comidas");
            this.cmb_opciones.SelectedIndex = 0;
            ActualizarVistaConsumisionesAgregadasAMesa();
            Logica.ActualizarDGVCompartido(this.dgv_consumisiones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                this.copiaLocalComidas);
            MostrarInfoEspacio();
            if (this.espacioConsumo.Tipo == ETipoEspacio.Barra)
            {
                this.cmb_opciones.Enabled = false;
            }
        }

        private void chk_ocupado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ocupado.Checked)
            {
                this.espacioConsumo.Ocupado = true;
            }
            else
            {
                this.espacioConsumo.Ocupado = false;
            }
        }

        private void dgv_consumisiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.espacioConsumo.Ocupado = true;
            MostrarInfoEspacio();
            int index = dgv_consumisiones.CurrentCell.RowIndex;
            Consumision nuevaConsumision;
            if (cmb_opciones.SelectedIndex == 0)
            {
                nuevaConsumision = this.copiaLocalBebidas[index].ClonarConsumision();
            }
            else
            {
                nuevaConsumision = this.copiaLocalComidas[index].ClonarConsumision();
            }

            FormIngresarCantidad formCantidad = new FormIngresarCantidad(false);

            if (formCantidad.ShowDialog() == DialogResult.OK)
            {
                huboCambios = true;
                int cantidadIngresada = formCantidad.DevolverCantidad();
                formCantidad.Dispose();
                if (this.espacioConsumo.AgregarConsumo(nuevaConsumision, cantidadIngresada))
                {
                    Logica.RestarStockEnFormulario(cmb_opciones.SelectedIndex, index, cantidadIngresada,
                        copiaLocalBebidas, copiaLocalComidas);

                    ActualizarVistaConsumisionesAgregadasAMesa();
                    Logica.ActualizarDGVCompartido(this.dgv_consumisiones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                    this.copiaLocalComidas);
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para esta venta!");
                }
            }
            else if (this.espacioConsumo.Consumisiones.Count == 0)
            {
                this.espacioConsumo.Ocupado = false;
            }
            MostrarInfoEspacio();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (huboCambios && this.espacioConsumo.Ocupado)
            {
                EspacioConsumo.GuardarEspacioConCambios(this.espacioConsumo);
                Consumision.ActualizarTodoStockPermanente(this.copiaLocalComidas, this.copiaLocalBebidas);
                Logica.ActualizarDGV(dgv_padre, Bar.listaEspaciosConsumo);
                huboCambios = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrarMesa_Click(object sender, EventArgs e)
        {
            if (!huboCambios)
            {
                FormCierreEspacio formVenta = new FormCierreEspacio();
                string metodoPagoVenta = string.Empty;
                bool usoEstacionamiento = false;
                if (formVenta.ShowDialog() == DialogResult.OK)
                {
                    metodoPagoVenta = formVenta.DevolverMetodoPago();
                    usoEstacionamiento = formVenta.DevolverUsoEstacionamiento();
                    Venta nuevaVenta = new Venta(this.espacioConsumo.Saldo, metodoPagoVenta, usoEstacionamiento);
                    nuevaVenta.RegistrarVenta();
                    this.espacioConsumo.CerrarMesa();
                    MessageBox.Show($"Venta exitosa\n{nuevaVenta.ToString()}");


                    EspacioConsumo.GuardarEspacioConCambios(this.espacioConsumo);
                    Logica.ActualizarDGV(dgv_padre, Bar.listaEspaciosConsumo);
                    huboCambios = false;
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Venta cancelada");
                }
            }
            else
            {
                MessageBox.Show("Por favor guarde cambios antes de cerrar la mesa.");
            }
        }

        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logica.ActualizarDGVCompartido(this.dgv_consumisiones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                this.copiaLocalComidas);
        }

        private void FormDetalleEspacioConsumo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (huboCambios)
            {
                if (MessageBox.Show("¿Desea salir sin guardar cambios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Dispose();
                }
            }
        }

        private void MostrarInfoEspacio()
        {
            this.lbl_infoId.Text = this.espacioConsumo.IdMesa.ToString();
            this.lbl_infoTipo.Text = this.espacioConsumo.Tipo.ToString();
            this.lbl_infoSaldo.Text = this.espacioConsumo.Saldo.ToString();
            this.lst_consumEspacio.DataSource = this.espacioConsumo.Consumisiones;

            if (this.espacioConsumo.Ocupado)
            {
                this.chk_ocupado.Checked = true;
                this.chk_ocupado.Enabled = false;
                this.btn_cerrarMesa.Enabled = true;
            }
            else
            {
                this.chk_ocupado.Checked = false;
                this.chk_ocupado.Enabled = true;
                this.btn_cerrarMesa.Enabled = false;
            }
        }

        public void ActualizarVistaConsumisionesAgregadasAMesa()
        {
            lst_consumEspacio.DataSource = null;
            lst_consumEspacio.DataSource = this.espacioConsumo.Consumisiones;
        }

        private void dgv_consumisiones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Logica.FormatearCeldasPocoStock(this.dgv_consumisiones, e);
        }
    }
}
