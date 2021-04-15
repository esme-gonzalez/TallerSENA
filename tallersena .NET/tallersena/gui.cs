using System;
using System.Collections.Generic;
using System.Text;

namespace tallersena
{
    class gui
    {
        public static void Marco(int Xmin, int Xmax, int Ymin, int Ymax)
        {
            for (int x = Xmin; x <= Xmax; x++)
            {
                Console.SetCursorPosition(x, Ymin); Console.Write("═");
                Console.SetCursorPosition(x, Ymax); Console.Write("═");
            }

            for (int y = Ymin; y <= Ymax; y++)
            {
                Console.SetCursorPosition(Xmin, y); Console.Write("║");
                Console.SetCursorPosition(Xmax, y); Console.Write("║");
            }

            Console.SetCursorPosition(Xmin, Ymin); Console.Write("╔");
            Console.SetCursorPosition(Xmax, Ymin); Console.Write("╗");
            Console.SetCursorPosition(Xmin, Ymax); Console.Write("╚");
            Console.SetCursorPosition(Xmax, Ymax); Console.Write("╝");

        }

        public static void Linea(int Xmin, int Xmax, int y)
        {
            for (int x = Xmin; x <= Xmax; x++)
            {
                Console.SetCursorPosition(x, y); Console.Write("-");

            }



        }

        public static void BorrarLinea(int Xmin, int y, int Xmax)
        {
            for (int x = Xmin; x <= Xmax; x++)
            {
                Console.SetCursorPosition(x, y); Console.Write(" ");

            }



        }

        public static void logo(int x, int y) 
        {
            Console.SetCursorPosition(20, 22); Console.WriteLine("******* ******* ***    **  ***** ");
            Console.SetCursorPosition(20, 23); Console.WriteLine("**      **      ****   ** **   **");
            Console.SetCursorPosition(20, 24); Console.WriteLine("******* *****   ** **  ** ******* ");
            Console.SetCursorPosition(20, 25); Console.WriteLine("     ** **      **  ** ** **   **");
            Console.SetCursorPosition(20, 26); Console.WriteLine("******* ******* **   **** **   **");
            Console.SetCursorPosition(20, 27); Console.WriteLine("Aprendiz: Esmeralda Gonzalez Moreno");
            Console.SetCursorPosition(20, 28); Console.WriteLine("Ficha: 2184588");
            Console.SetCursorPosition(20, 29); Console.WriteLine("Centro de Gestion de Mercados y Logistica de la Informacion");
        }
    }
}
