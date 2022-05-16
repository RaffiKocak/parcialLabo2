using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
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
            Logica.ActualizarDGVCompartido(this.dgv_consumiciones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                this.copiaLocalComidas);
            MostrarInfoEspacio();
            if (!this.espacioConsumo.EsMesa)
            {
                this.cmb_opciones.Enabled = false;
            }
        }

        private void dgv_consumisiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarInfoEspacio();
            SoundPlayer sonidoAgregar = new SoundPlayer(Properties.Resources.NotificacionTinderDos);
            int retornoOperacion;
            int index = dgv_consumiciones.CurrentCell.RowIndex;
            Consumicion nuevaConsumicion;
            if (cmb_opciones.SelectedIndex == 0)
            {
                nuevaConsumicion = this.copiaLocalBebidas[index].ClonarConsumicion();
            }
            else
            {
                nuevaConsumicion = this.copiaLocalComidas[index].ClonarConsumicion();
            }

            retornoOperacion = this.AgregarConsumo(nuevaConsumicion, index);

            switch(retornoOperacion)
            {
                case -1:
                    MessageBox.Show("No hay suficiente stock para esta venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 0:
                    sonidoAgregar.Play();
                    ActualizarVistaConsumisionesAgregadasAMesa();
                    Logica.ActualizarDGVCompartido(this.dgv_consumiciones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                    this.copiaLocalComidas);
                    break;
            }
            MostrarInfoEspacio();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (huboCambios)
            {
                EspacioConsumo.GuardarEspacioConCambios(this.espacioConsumo);
                Consumicion.ActualizarTodoStockPermanente(this.copiaLocalComidas, this.copiaLocalBebidas);
                Logica.ActualizarDGV(dgv_padre, Bar.listaEspaciosConsumo);
                huboCambios = false;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrarMesa_Click(object sender, EventArgs e)
        {
            int retornoOperacion = this.CerrarMesa(out Venta nuevaVenta);
            SoundPlayer sonidoVenta = new SoundPlayer(Properties.Resources.NotificacionTinderUno);

            switch(retornoOperacion)
            {
                case -2:
                    MessageBox.Show("Por favor guarde cambios antes de cerrar la mesa.", "Operación inválida", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case -1:
                    MessageBox.Show("Venta cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 0:
                    MessageBox.Show($"Venta exitosa\n{nuevaVenta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EspacioConsumo.GuardarEspacioConCambios(this.espacioConsumo);
                    Logica.ActualizarDGV(dgv_padre, Bar.listaEspaciosConsumo);
                    sonidoVenta.Play();
                    this.huboCambios = false;
                    this.Dispose();
                    break;
            }
        }

        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logica.ActualizarDGVCompartido(this.dgv_consumiciones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
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
                    this.Dispose();
                }
            }
        }

        private void dgv_consumisiones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Logica.FormatearCeldasPocoStock(this.dgv_consumiciones, e);
        }

        private int CerrarMesa(out Venta nuevaVenta)
        {
            int retorno = -2;
            nuevaVenta = null;
            if (!huboCambios)
            {
                retorno = -1;
                FormCierreEspacio formVenta = new FormCierreEspacio();
                string metodoPagoVenta = string.Empty;
                bool usoEstacionamiento = false;
                if (formVenta.ShowDialog() == DialogResult.OK)
                {
                    metodoPagoVenta = formVenta.DevolverMetodoPago();
                    usoEstacionamiento = formVenta.DevolverUsoEstacionamiento();
                    nuevaVenta = new Venta(this.espacioConsumo.Saldo, metodoPagoVenta, usoEstacionamiento);
                    nuevaVenta.RegistrarVenta();
                    this.espacioConsumo.CerrarMesa();
                    retorno = 0;
                }
            }

            return retorno;
        }

        private int AgregarConsumo(Consumicion nuevaConsumicion, int index)
        {
            int retorno = -2;

            FormIngresarCantidad formCantidad = new FormIngresarCantidad(false, false);
            if (formCantidad.ShowDialog() == DialogResult.OK)
            {
                retorno = -1;
                int cantidadIngresada = formCantidad.DevolverCantidad();
                formCantidad.Dispose();
                if (this.espacioConsumo.AgregarConsumo(nuevaConsumicion, cantidadIngresada))
                {
                    huboCambios = true;
                    Logica.RestarStockEnFormulario(cmb_opciones.SelectedIndex, index, cantidadIngresada,
                        copiaLocalBebidas, copiaLocalComidas);

                    retorno = 0;
                }
            }

            return retorno;
        }

        private void MostrarInfoEspacio()
        {
            this.lbl_infoId.Text = this.espacioConsumo.IdEspacio.ToString();
            this.lbl_infoTipo.Text = $"{(this.espacioConsumo.EsMesa ? "Mesa" : "Barra")}";
            this.lbl_infoSaldo.Text = this.espacioConsumo.Saldo.ToString();
            this.lst_consumEspacio.DataSource = this.espacioConsumo.Consumiciones;
            this.lbl_ocupado.Text = $"{(this.espacioConsumo.Ocupado ? "SI" : "NO")}";

            if (this.espacioConsumo.Ocupado)
            {
                this.btn_cerrarMesa.Enabled = true;
            }
            else 
            {
                this.btn_cerrarMesa.Enabled = false;
            }
        }

        public void ActualizarVistaConsumisionesAgregadasAMesa()
        {
            lst_consumEspacio.DataSource = null;
            lst_consumEspacio.DataSource = this.espacioConsumo.Consumiciones;
        }

        private void lst_consumEspacio_DoubleClick(object sender, EventArgs e)
        {
            Consumicion consumicionABorrar = (Consumicion)lst_consumEspacio.SelectedItem;
            FormIngresarCantidad frmCantidad = new FormIngresarCantidad(false, true);

            if (consumicionABorrar is not null && frmCantidad.ShowDialog() == DialogResult.OK)
            {
                this.huboCambios = true;
                int cantidadABorrar = frmCantidad.DevolverCantidad();

                this.espacioConsumo.RestarConsumo(consumicionABorrar, cantidadABorrar);

                if (frmCantidad.VerificarConservaConsumicion())
                {
                    ReponerConsumicion(consumicionABorrar, cantidadABorrar);
                    Logica.ActualizarDGVCompartido(this.dgv_consumiciones, this.cmb_opciones.SelectedIndex, this.copiaLocalBebidas,
                        this.copiaLocalComidas);
                }

                frmCantidad.Dispose();
                
                MostrarInfoEspacio();
                ActualizarVistaConsumisionesAgregadasAMesa();
            }
        }

        private void ReponerConsumicion(Consumicion consumicion, int cantidadAReponer)
        {
            if (consumicion is not null)
            {
                if (consumicion is Bebida)
                {
                    foreach (Bebida item in this.copiaLocalBebidas)
                    {
                        if (item == consumicion)
                        {
                            item.Cantidad += cantidadAReponer;
                        }
                    }
                } else
                {
                    foreach (Comida item in this.copiaLocalComidas)
                    {
                        if (item == consumicion)
                        {
                            item.Cantidad += cantidadAReponer;
                        }
                    }
                }
                
            }
        }
    }
}