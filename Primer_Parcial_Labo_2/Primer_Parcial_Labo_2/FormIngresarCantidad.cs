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
    public partial class FormIngresarCantidad : Form
    {
        public FormIngresarCantidad()
        {
            InitializeComponent();
        }

        private void FormIngresarCantidad_Load(object sender, EventArgs e)
        {
            this.nud_cantidadIngresada.Value = 1;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public int DevolverCantidad()
        {
            return (int)nud_cantidadIngresada.Value;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
