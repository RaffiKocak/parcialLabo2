using Entidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Primer_Parcial_Labo_2
{
    internal static class Logica
    {
        public static void MostrarFormContenido(Form formAMostrar, Panel panelContenedor)
        {
            formAMostrar.TopLevel = false;
            panelContenedor.Controls.Add(formAMostrar);
            formAMostrar.Show();
        }

        public static void CerrarFormsContenidos(Panel panelContenedor)
        {
            foreach (Form item in panelContenedor.Controls)
            {
               item.Dispose();
            }
        }

        public static void ActualizarDGV<T>(DataGridView dgv, List<T> listaIngresada)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaIngresada;
        }

        public static void ActualizarDGVCompartido(DataGridView dgv, int indiceComboBox, List<Bebida> listaBebidas,
            List<Comida> listaComidas)
        {
            if (indiceComboBox == 0)
            {
                ActualizarDGV(dgv, listaBebidas);
            }
            else
            {
                ActualizarDGV(dgv, listaComidas);
            }
        }

        public static bool PedirConfirmacion(string mensaje)
        {
            if (MessageBox.Show($"¿Está seguro que desea realizar la siguiente acción?\n{mensaje}",
                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        public static void RestarStockEnFormulario(int indiceComboBox, int index, int cantidadIngresada,
            List<Bebida> listaBebidas, List<Comida> listaComidas)
        {
            if (indiceComboBox == 0)
            {
                if (listaBebidas[index].Cantidad >= cantidadIngresada)
                {
                    listaBebidas[index].Cantidad -= cantidadIngresada;
                }
                else
                {
                    listaBebidas[index].Cantidad = 0;
                }
            }
            else
            {
                if (listaComidas[index].Cantidad >= cantidadIngresada)
                {
                    listaComidas[index].Cantidad -= cantidadIngresada;
                }
                else
                {
                    listaComidas[index].Cantidad = 0;
                }
            }
        }

        public static void AgregarStockEnFormulario(int indiceComboBox, int index, int cantidadIngresada,
            List<Bebida> listaBebidas, List<Comida> listaComidas)
        {
            if (indiceComboBox == 0)
            {
                listaBebidas[index].Cantidad += cantidadIngresada;
            }
            else
            {
                listaComidas[index].Cantidad += cantidadIngresada;
            }
        }

        public static void FormatearCeldasPocoStock(DataGridView dgv, DataGridViewCellFormattingEventArgs evento)
        {
            if (dgv.Columns[evento.ColumnIndex].Name == "Cantidad")
            {
                if ((int)(evento.Value) <= 5)
                {
                    evento.CellStyle.BackColor = Color.Red;
                }
                else if ((int)(evento.Value) <= 15)
                {
                    evento.CellStyle.BackColor = Color.Orange;
                }
                else if ((int)(evento.Value) <= 30)
                {
                    evento.CellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
