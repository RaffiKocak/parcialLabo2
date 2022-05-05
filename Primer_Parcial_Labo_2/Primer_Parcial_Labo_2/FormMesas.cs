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
    public partial class FormMesas : Form
    {
        FormDetalleEspacioConsumo subFormMesa;
        public FormMesas()
        {
            InitializeComponent();
        }

        private void FormMesas_Load(object sender, EventArgs e)
        {
            dgv_espaciosConsumo.DataSource = Bar.listaEspaciosConsumo;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_espaciosConsumo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subFormMesa is not null)
            {
                subFormMesa.Dispose();
            }
            
            int index = dgv_espaciosConsumo.CurrentCell.RowIndex;
            EspacioConsumo nuevoEspacio = Bar.listaEspaciosConsumo[index].ClonarEspacioConsumo();

            subFormMesa = new FormDetalleEspacioConsumo(nuevoEspacio, this.dgv_espaciosConsumo);
            subFormMesa.TopLevel = false;
            pnl_contenedor.Controls.Add(subFormMesa);
            subFormMesa.Show();
        }

        public void ActualizarTabla()
        {
            dgv_espaciosConsumo.DataSource = null;
            dgv_espaciosConsumo.DataSource = Bar.listaEspaciosConsumo;
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
