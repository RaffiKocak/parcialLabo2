using System.Windows.Forms;

namespace Primer_Parcial_Labo_2
{
    internal static class Validacion
    {
        public static bool ValidarTextosNoVacios(Form formAVerificar)
        {
            foreach (Control item in formAVerificar.Controls)
            {
                if (item is TextBox && string.IsNullOrEmpty(item.Text))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidarDni(string numeroTexto, out int dni)
        {
            if (numeroTexto.Length > 6 && numeroTexto.Length < 9)
            {
                return int.TryParse(numeroTexto, out dni);
            }

            dni = 0;

            return false;
        }

        public static bool ValidarNombreOApellido(string textoIngresado, out string textoValidado)
        {
            textoValidado = null;
            foreach (char c in textoIngresado)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            textoValidado = textoIngresado.Trim();

            return true;
        }

        public static bool ValidarPrecio(string numeroIngresado, out decimal precioValidado)
        {
            int contadorComas = 0;
            precioValidado = 0;

            numeroIngresado = numeroIngresado.Replace('.', ',');

            foreach(char c in numeroIngresado)
            {
                if (!char.IsDigit(c))
                {
                    if (c == ',')
                    {
                        contadorComas++;
                        if (contadorComas > 2)
                        {
                            return false;
                        }
                    }else
                    {
                        return false;
                    }
                }
            }

            return decimal.TryParse(numeroIngresado, out precioValidado);
        }
    }
}
