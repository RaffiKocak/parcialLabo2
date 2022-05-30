using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    public partial class FormCierreEspacio : Form
    {
        public FormCierreEspacio()
        {
            InitializeComponent();
        }

        private void FormCierreMesa_Load(object sender, EventArgs e)
        {
            this.rdo_efectivo.Checked = true;
            this.rdo_estacionamientoNo.Checked = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Verifica qué método de pago se utiliza para concretar la venta
        /// </summary>
        /// <returns></returns>
        public string DevolverMetodoPago()
        {
            foreach(RadioButton item in this.grp_formaPago.Controls)
            {
                if (item.Checked)
                {
                    return item.Text;
                }
            }

            return String.Empty;
        }

        /// <summary>
        /// Verifica si el espacio de consumo hizo uso del estacionamiento
        /// </summary>
        /// <returns></returns>
        public bool DevolverUsoEstacionamiento()
        {
            if (rdo_estacionamientoSi.Checked)
            {
                return true;
            }

            return false;
        }
    }
}
