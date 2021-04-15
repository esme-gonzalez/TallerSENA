using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace tallersena
{
    class Validaciones
    {

        public bool Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                gui.BorrarLinea(20, 22, 80);
                gui.BorrarLinea(20, 23, 80);
                gui.BorrarLinea(20, 24, 80);
                gui.BorrarLinea(20, 25, 80);
                gui.BorrarLinea(20, 26, 80);
                gui.BorrarLinea(20, 27, 80);
                gui.BorrarLinea(20, 28, 80);
                gui.BorrarLinea(20, 29, 80);
                Console.SetCursorPosition(43, 25); Console.Write("***************************");
                Console.SetCursorPosition(43, 26); Console.Write("El texto no puede ser vacio");
                Console.SetCursorPosition(43, 27); Console.Write("***************************");
                return true;
            }
            else
                return false;
        }

        public bool TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            if (regla.IsMatch(texto))
                return true;

            else
            {
                gui.BorrarLinea(20, 22, 80);
                gui.BorrarLinea(20, 23, 80);
                gui.BorrarLinea(20, 24, 80);
                gui.BorrarLinea(20, 25, 80);
                gui.BorrarLinea(20, 26, 80);
                gui.BorrarLinea(20, 27, 80);
                gui.BorrarLinea(20, 28, 80);
                gui.BorrarLinea(20, 29, 80);
                Console.SetCursorPosition(43, 25); Console.Write("****************************");
                Console.SetCursorPosition(43, 26); Console.Write("La Entrada debe ser numerica");
                Console.SetCursorPosition(43, 27); Console.Write("****************************");
                return false;
            }
        }
        public bool TipoNota(string texto)
        {
            String regla = @"^[0-9]{1,2}(\.[0-9]{0,4})?$";
            bool aux = false;
            double temp1;

            if (!Vacio(texto))
            {
                if (Regex.IsMatch(texto, regla, RegexOptions.CultureInvariant | RegexOptions.ECMAScript))
                {
                    CultureInfo usCulture = new CultureInfo("en-US");
                    NumberFormatInfo numberFormat = usCulture.NumberFormat;
                    temp1 = Double.Parse(texto);

                    if (temp1 >= 0 && temp1 <= 5)
                    {
                        aux = true;
                    }
                    Console.SetCursorPosition(43, 25); Console.Write("****************************");
                    Console.SetCursorPosition(43, 26); Console.Write("Tiene que tener punto o coma");
                    Console.SetCursorPosition(43, 27); Console.Write("****************************");
                }



            }
            return aux;

        }

        public bool TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.SetCursorPosition(43, 25); Console.Write("*************************");
                Console.SetCursorPosition(43, 26); Console.Write("La Entrada debe ser texto");
                Console.SetCursorPosition(43, 27); Console.Write("*************************");
                return false;
            }
        }
        public bool TipoCorreo(string correo)
        {
            Regex regla = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

            if (regla.IsMatch(correo))
                return true;
            else
            {
                Console.SetCursorPosition(43, 25); Console.Write("**************************");
                Console.SetCursorPosition(43, 26); Console.Write("La Entrada debe ser correo");
                Console.SetCursorPosition(43, 27); Console.Write("**************************");
                return false;
            }
        }
    }
}
