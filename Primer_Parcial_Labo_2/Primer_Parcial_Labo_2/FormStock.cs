using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormStock : Form
    {
        bool esAdmin;
        FormNuevaComida subFormNuevaComida;
        FormNuevaBebida subFormNuevaBebida;

        public FormStock()
        {
            InitializeComponent();
        }

        public FormStock(bool esAdmin)
        {
            this.esAdmin = esAdmin;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            this.cmb_opciones.Items.Add("Bebidas");
            this.cmb_opciones.Items.Add("Comidas");
            this.cmb_opciones.SelectedIndex = 0;
            Logica.ActualizarDGVCompartido(this.dgv_stock, this.cmb_opciones.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
        }

        private void btn_agregarComida_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(this.pnl_contenedor);
            subFormNuevaComida = new FormNuevaComida(this.dgv_stock, this.cmb_opciones);
            Logica.MostrarFormContenido(this.subFormNuevaComida, this.pnl_contenedor);
        }

        private void btn_agregarBebida_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(this.pnl_contenedor);
            subFormNuevaBebida = new FormNuevaBebida(this.dgv_stock, this.cmb_opciones);
            Logica.MostrarFormContenido(this.subFormNuevaBebida, this.pnl_contenedor);
        }

        private void btn_eliminarConsumicion_Click(object sender, EventArgs e)
        {
            Consumicion consumicionAEliminar;
            int index = dgv_stock.CurrentCell.RowIndex;

            if (this.cmb_opciones.SelectedIndex == 0)
            {
                consumicionAEliminar = Bar.stockBebidas[index];
            }
            else
            {
                consumicionAEliminar = Bar.stockComidas[index];
            }

            string mensaje = $"¿Está seguro que desea eliminar esta consumición?\n{consumicionAEliminar.MostrarInfo()}";
            if (MessageBox.Show(mensaje, "Eliminar consumisión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Consumicion.EliminarStock(consumicionAEliminar);

                Logica.ActualizarDGVCompartido(this.dgv_stock, this.cmb_opciones.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
            }
        }

        private void btn_cambiarPrecio_Click(object sender, EventArgs e)
        {
            Logica.CerrarFormsContenidos(this.pnl_contenedor);
            int index = dgv_stock.CurrentCell.RowIndex;

            if (cmb_opciones.SelectedIndex == 0)
            {
                subFormNuevaBebida = new FormNuevaBebida(this.dgv_stock, this.cmb_opciones, Bar.stockBebidas[index]);
                Logica.MostrarFormContenido(this.subFormNuevaBebida, this.pnl_contenedor);
            }
            else
            {
                subFormNuevaComida = new FormNuevaComida(this.dgv_stock, this.cmb_opciones, Bar.stockComidas[index]);
                Logica.MostrarFormContenido(this.subFormNuevaComida, this.pnl_contenedor);
            }
        }

        private void btn_agregarStock_Click(object sender, EventArgs e)
        {
            int index = dgv_stock.CurrentCell.RowIndex;
            FormIngresarCantidad subFormCantidad = new FormIngresarCantidad(false);
            if (subFormCantidad.ShowDialog() == DialogResult.OK)
            {
                int cantidadIngresada = subFormCantidad.DevolverCantidad();
                subFormCantidad.Dispose();

                Logica.AgregarStockEnFormulario(this.cmb_opciones.SelectedIndex, index, cantidadIngresada,
                    Bar.stockBebidas, Bar.stockComidas);
                Logica.ActualizarDGVCompartido(this.dgv_stock, this.cmb_opciones.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
            }
        }

        private void btn_restarStock_Click(object sender, EventArgs e)
        {
            int index = dgv_stock.CurrentCell.RowIndex;
            FormIngresarCantidad subFormCantidad = new FormIngresarCantidad(false);
            if (subFormCantidad.ShowDialog() == DialogResult.OK)
            {
                int cantidadIngresada = subFormCantidad.DevolverCantidad();
                subFormCantidad.Dispose();

                Logica.RestarStockEnFormulario(this.cmb_opciones.SelectedIndex, index, cantidadIngresada,
                    Bar.stockBebidas, Bar.stockComidas);
                Logica.ActualizarDGVCompartido(this.dgv_stock, this.cmb_opciones.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
            }
        }

        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logica.ActualizarDGVCompartido(this.dgv_stock, this.cmb_opciones.SelectedIndex, Bar.stockBebidas, Bar.stockComidas);
        }

        private void dgv_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgv_stock.CurrentCell.RowIndex;
            if (cmb_opciones.SelectedIndex == 0)
            {
                MessageBox.Show(Bar.stockBebidas[index].MostrarInfo());
            }
            else
            {
                MessageBox.Show(Bar.stockComidas[index].MostrarInfo());
            }
        }

        private void dgv_stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Logica.FormatearCeldasPocoStock(this.dgv_stock, e);
        }
    }
}
