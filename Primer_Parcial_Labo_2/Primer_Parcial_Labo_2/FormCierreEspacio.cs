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

        public bool DevolverUsoEstacionamiento()
        {
            foreach (RadioButton item in this.grp_estacionamiento.Controls)
            {
                if (item.Checked && item.Text == "Si")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
