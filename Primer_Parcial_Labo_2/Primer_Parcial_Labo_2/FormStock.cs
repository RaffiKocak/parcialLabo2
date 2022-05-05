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
    public partial class FormStock : Form
    {
        bool esAdmin;
        FormNuevaConsumision subFormNuevaConsumision;

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
            ActualizarListaStock();
        }

        private void btn_agregarConsumision_Click(object sender, EventArgs e)
        {
            CerrarFormsContenidos();
            subFormNuevaConsumision = new FormNuevaConsumision(this.dgv_stock, this.cmb_opciones);
            subFormNuevaConsumision.TopLevel = false;
            pnl_contenedor.Controls.Add(subFormNuevaConsumision);
            subFormNuevaConsumision.Show();
        }

        private void btn_eliminarConsumision_Click(object sender, EventArgs e)
        {
            int index = dgv_stock.CurrentCell.RowIndex;
            string mensaje = $"¿Está seguro que desea eliminar esta consumisión?\n{Bar.stockComidas[index].ToString()}";
            if (MessageBox.Show(mensaje, "Eliminar consumisión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Consumision.EliminarStock(Bar.stockConsumisiones[index]);

                ActualizarListaStock();
            }
        }

        private void btn_cambiarPrecio_Click(object sender, EventArgs e)
        {
            CerrarFormsContenidos();
            int index = dgv_stock.CurrentCell.RowIndex;

            if (cmb_opciones.SelectedIndex == 0)
            {
                subFormNuevaConsumision = new FormNuevaConsumision(this.dgv_stock, this.cmb_opciones, Bar.stockBebidas[index]);
            } else
            {
                subFormNuevaConsumision = new FormNuevaConsumision(this.dgv_stock, this.cmb_opciones, Bar.stockComidas[index]);
            }
            
            subFormNuevaConsumision.TopLevel = false;
            pnl_contenedor.Controls.Add(subFormNuevaConsumision);
            subFormNuevaConsumision.Show();
        }

        private void btn_agregarStock_Click(object sender, EventArgs e)
        {
            int index = dgv_stock.CurrentCell.RowIndex;
            FormIngresarCantidad subFormCantidad = new FormIngresarCantidad();
            if (subFormCantidad.ShowDialog() == DialogResult.OK)
            {
                int cantidadIngresada = subFormCantidad.DevolverCantidad();
                subFormCantidad.Dispose();

                AgregarStock(index, cantidadIngresada);
                ActualizarListaStock();
            }
        }

        private void btn_restarStock_Click(object sender, EventArgs e)
        {
            int index = dgv_stock.CurrentCell.RowIndex;
            FormIngresarCantidad subFormCantidad = new FormIngresarCantidad();
            if (subFormCantidad.ShowDialog() == DialogResult.OK)
            {
                int cantidadIngresada = subFormCantidad.DevolverCantidad();
                subFormCantidad.Dispose();

                //VERIFICAR QUE NO ME QUEDE MENOR A 0
                RestarStock(index, cantidadIngresada);
                ActualizarListaStock();               
            }
        }

        private void cmb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListaStock();
        }

        private void CerrarFormsContenidos()
        {
            foreach (Form item in pnl_contenedor.Controls)
            {
                item.Dispose();
            }
        }

        private void RestarStock (int index, int cantidadIngresada)
        {
            if (this.cmb_opciones.SelectedIndex == 0)
            {
                if (cantidadIngresada <= Bar.stockBebidas[index].Cantidad)
                {
                    Bar.stockBebidas[index].Cantidad -= cantidadIngresada;
                } else
                {
                    Bar.stockBebidas[index].Cantidad = 0;
                }
            } else
            {
                if (cantidadIngresada <= Bar.stockBebidas[index].Cantidad)
                {
                    Bar.stockComidas[index].Cantidad -= cantidadIngresada;
                } else
                {
                    Bar.stockComidas[index].Cantidad = 0;
                }
            }
        }

        private void AgregarStock(int index, int cantidadIngresada)
        {
            if (this.cmb_opciones.SelectedIndex == 0)
            {
                Bar.stockBebidas[index].Cantidad += cantidadIngresada;
            }
            else
            {
                Bar.stockComidas[index].Cantidad += cantidadIngresada;
            }
        }

        private void ActualizarListaStock()
        {
            this.dgv_stock.DataSource = null;
            if (this.cmb_opciones.SelectedIndex == 0)
            {
                this.dgv_stock.DataSource = Bar.stockBebidas;
            } else
            {
                this.dgv_stock.DataSource = Bar.stockComidas;
            }
        }
    }
}
