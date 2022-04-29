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
    public partial class FormDetalleEspacioConsumo : Form
    {
        EspacioConsumo espacioConsumo;
        List<Consumision> copiaLocalConsumisiones;
        bool huboCambios;
        DataGridView dgv_padre;

        public FormDetalleEspacioConsumo()
        {
            InitializeComponent();
        }

        public FormDetalleEspacioConsumo(EspacioConsumo espacioConsumo, DataGridView dgv) 
            : this()
        {
            if (espacioConsumo is Mesa)
            {
                this.espacioConsumo = new Mesa(espacioConsumo);
            }
            else
            {
                this.espacioConsumo = new Barra(espacioConsumo);
            }
            this.dgv_padre = dgv;
            this.copiaLocalConsumisiones = Bar.CopiarListaConsumisiones(Bar.stockConsumisiones);
        }

        private void FormDetalleEspacioConsumo_Load(object sender, EventArgs e)
        {
            ActualizarConsumisionesAgregadas();
            ActualizarConsumisionesDisponibles();
            MostrarInfoEspacio();
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
            Consumision nuevaConsumision = new Consumision(Bar.stockConsumisiones[index]);

            FormIngresarCantidad formCantidad = new FormIngresarCantidad();

            if (formCantidad.ShowDialog() == DialogResult.OK)
            {
                huboCambios = true;
                int cantidadIngresada = formCantidad.DevolverCantidad();
                formCantidad.Dispose();
                if (cantidadIngresada <= nuevaConsumision.Cantidad)
                {
                    this.espacioConsumo.AgregarConsumo(nuevaConsumision, cantidadIngresada);
                    Consumision.RestarStock(nuevaConsumision, this.copiaLocalConsumisiones, cantidadIngresada);
                    ActualizarConsumisionesAgregadas();
                    ActualizarConsumisionesDisponibles();
                    MostrarInfoEspacio();
                } else
                {
                    MessageBox.Show("No hay suficiente stock para esta venta!");
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (huboCambios && this.espacioConsumo.Ocupado)
            {
                EspacioConsumo.GuardarEspacioConCambios(this.espacioConsumo);
                Consumision.ActualizarStock(this.copiaLocalConsumisiones);
                ActualizarTablaPadre();
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
                FormCierreMesa formVenta = new FormCierreMesa();
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
                    Consumision.ActualizarStock(this.copiaLocalConsumisiones);
                    ActualizarTablaPadre();
                    huboCambios = false;
                    this.Dispose();
                    
                } else
                {
                    MessageBox.Show("Venta cancelada");
                }
            }
            else
            {
                MessageBox.Show("Por favor guarde cambios antes de cerrar la mesa.");
            }
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
            this.lbl_infoTipo.Text = this.espacioConsumo.Tipo;
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
                this.btn_cerrarMesa.Enabled = false;
            }
        }

        public void ActualizarConsumisionesAgregadas()
        {
            lst_consumEspacio.DataSource = null;
            lst_consumEspacio.DataSource = this.espacioConsumo.Consumisiones;
        }

        public void ActualizarConsumisionesDisponibles()
        {
            dgv_consumisiones.DataSource = null;
            dgv_consumisiones.DataSource = this.copiaLocalConsumisiones;
        }

        public void ActualizarTablaPadre()
        {
            dgv_padre.DataSource = null;
            dgv_padre.DataSource = Bar.listaEspaciosConsumo;
        }
    }
}
