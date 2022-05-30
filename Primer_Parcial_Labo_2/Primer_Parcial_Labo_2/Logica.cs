using Entidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Primer_Parcial_Labo_2
{
    internal static class Logica
    {
        /// <summary>
        /// Muestra un formulario en un panel, ambos ingresados por parámetro 
        /// </summary>
        /// <param name="formAMostrar"></param>
        /// <param name="panelContenedor"></param>
        public static void MostrarFormContenido(Form formAMostrar, Panel panelContenedor)
        {
            formAMostrar.TopLevel = false;
            panelContenedor.Controls.Add(formAMostrar);
            formAMostrar.Show();
        }

        /// <summary>
        /// Cierra todos los formularios contenidos en el panel ingresado por parámetro
        /// </summary>
        /// <param name="panelContenedor"></param>
        public static void CerrarFormsContenidos(Panel panelContenedor)
        {
            foreach (Form item in panelContenedor.Controls)
            {
               item.Dispose();
            }
        }

        /// <summary>
        /// Actualiza la información de un DataGridView con lo que haya en la lista ingresada por parámetro
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgv"></param>
        /// <param name="listaIngresada"></param>
        public static void ActualizarDGV<T>(DataGridView dgv, List<T> listaIngresada)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaIngresada;
        }

        /// <summary>
        /// Actualiza la información de un DataGridView compartido por 2 listas distintas, diferenciando a través
        /// del índice de un Combo Box qué información se actualiza en el momento
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="indiceComboBox"></param>
        /// <param name="listaBebidas"></param>
        /// <param name="listaComidas"></param>
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

        /// <summary>
        /// Muestra un mensaje introducido por parámetro y pide confirmación para realizar una acción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool PedirConfirmacion(string mensaje)
        {
            if (MessageBox.Show($"¿Está seguro que desea realizar la siguiente acción?\n{mensaje}",
                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Resta stock de una consumición dentro de un DataGridView compartido por 2 listas, 
        /// diferenciando a través del índice de un Combo Box qué tipo de consumición
        /// se afecta en el momento
        /// </summary>
        /// <param name="indiceComboBox"></param>
        /// <param name="index"></param>
        /// <param name="cantidadIngresada"></param>
        /// <param name="listaBebidas"></param>
        /// <param name="listaComidas"></param>
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

        /// <summary>
        /// Agrega stock de una consumición dentro de un DataGridView compartido por 2 listas, 
        /// diferenciando a través del índice de un Combo Box qué tipo de consumición
        /// se afecta en el momento
        /// </summary>
        /// <param name="indiceComboBox"></param>
        /// <param name="index"></param>
        /// <param name="cantidadIngresada"></param>
        /// <param name="listaBebidas"></param>
        /// <param name="listaComidas"></param>
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

        /// <summary>
        /// Da formato a las celdas que contienen datos correspondientes a la cantidad de stock de una consumición
        /// Menor o igual a 30: Amarillo
        /// Menor o igual a 15: Naranja
        /// Menor o igual a 5: Rojo
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="evento"></param>
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
