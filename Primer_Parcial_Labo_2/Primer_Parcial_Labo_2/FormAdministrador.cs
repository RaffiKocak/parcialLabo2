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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            // RELLENAR LISTAS
            // VARIAR COLOR SEGÚN TIPO DE USUARIO
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            FormMesas frmMesas = new FormMesas();
            frmMesas.TopLevel = false;
            pnl_contenedor.Controls.Add(frmMesas);
            frmMesas.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
