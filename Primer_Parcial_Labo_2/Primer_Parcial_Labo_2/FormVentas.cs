using Entidades;
using System;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            Logica.ActualizarDGV(this.dgv_ventas, Bar.registroVentas);
            this.lbl_cantidadVentas.Text = Venta.ContarTotalVentas().ToString();
            this.lbl_totalRecaudado.Text = $"${Venta.CalcularRecaudoTotalVentas()}";
            this.lbl_precioEstacionamiento.Text = $"${Venta.PrecioEstacionamiento}";
        }

        private void btn_modificarPrecioEstacionamiento_Click(object sender, EventArgs e)
        {
            FormIngresarCantidad form = new FormIngresarCantidad(true);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Venta.PrecioEstacionamiento = form.DevolverPrecio();
                this.lbl_precioEstacionamiento.Text = $"${Venta.PrecioEstacionamiento}";
            }
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
