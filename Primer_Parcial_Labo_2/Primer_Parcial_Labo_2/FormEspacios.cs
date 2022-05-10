using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormEspacios : Form
    {
        FormDetalleEspacioConsumo subFormMesa;
        public FormEspacios()
        {
            InitializeComponent();
        }

        private void FormMesas_Load(object sender, EventArgs e)
        {
            Logica.ActualizarDGV(this.dgv_espaciosConsumo, Bar.listaEspaciosConsumo);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_espaciosConsumo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Logica.CerrarFormsContenidos(this.pnl_contenedor);
            int index = dgv_espaciosConsumo.CurrentCell.RowIndex;
            EspacioConsumo nuevoEspacio = Bar.listaEspaciosConsumo[index].ClonarEspacioConsumo();

            subFormMesa = new FormDetalleEspacioConsumo(nuevoEspacio, this.dgv_espaciosConsumo);
            Logica.MostrarFormContenido(this.subFormMesa, this.pnl_contenedor);
        }

        private void dgv_espaciosConsumo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_espaciosConsumo.Columns[e.ColumnIndex].Name == "Ocupado")
            {
                if ((bool)(e.Value) == true)
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

    }
}
