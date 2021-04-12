using System;
using System.Collections.Generic;
using System.Linq;
using tallersena.Modelo;

namespace tallersena
{
    class Program
    {
        static Validaciones verificar = new Validaciones();
        static List<Estudiantes> Listaestudiantes = new List<Estudiantes>();

        static void Main(string[] args)

        {
            int OpcMen;

            string temporal;

            do
            {
                bool EntradaValida = false;
                Console.Clear();
                gui.logo(20, 22);
                gui.Marco(1, 110, 1, 6);
                gui.Marco(1, 110, 1, 30);
                Console.SetCursorPosition(20, 2); Console.Write("***APP ESTUDIANTES***");



                Console.SetCursorPosition(20, 4); Console.WriteLine("1. Agregar ");
                Console.SetCursorPosition(32, 4); Console.WriteLine("2. Listar ");
                Console.SetCursorPosition(44, 4); Console.WriteLine("3. Buscar ");
                Console.SetCursorPosition(56, 4); Console.WriteLine("4. Editar ");
                Console.SetCursorPosition(68, 4); Console.WriteLine("5. Borrar ");
                Console.SetCursorPosition(80, 4); Console.WriteLine("0. salir ");

                do
                {

                    Console.SetCursorPosition(60, 2); Console.Write("Escoja una opcion:");
                    temporal = Console.ReadLine();
                    if (!verificar.Vacio(temporal))
                        if (verificar.TipoNumero(temporal))
                            EntradaValida = true;
                } while (!EntradaValida);


                OpcMen = Convert.ToInt32(temporal);

                switch (OpcMen)
                {
                    case 1:
                        crearestudiante();
                        break;
                    case 2:
                        listaestudiantes();
                        break;
                    case 3:
                        buscarestudiante();
                        break;
                    case 4:
                        editarestudiante();
                        break;
                    case 5:
                        borrarestudiante();
                        break;
                    case 0:
                        gui.BorrarLinea(20, 22, 80);
                        gui.BorrarLinea(40, 22, 80);
                        Console.SetCursorPosition(35, 12); Console.WriteLine("*************************************");
                        Console.SetCursorPosition(35, 13); Console.WriteLine("**Gracias por usar nuestro programa**");
                        Console.SetCursorPosition(35, 14); Console.WriteLine("*************************************");
                        break;
                    default:
                        gui.BorrarLinea(40, 22, 80);
                        Console.SetCursorPosition(45, 10); Console.WriteLine("Opcion Invalida");
                        break;
                }

                gui.BorrarLinea(40, 23, 80);
                Console.SetCursorPosition(35, 22); Console.WriteLine("*****************************************");
                Console.SetCursorPosition(35, 23); Console.WriteLine("*Presione cualquier tecla para continuar*");
                Console.SetCursorPosition(35, 24); Console.WriteLine("*****************************************");
                Console.SetCursorPosition(2, 31); Console.ReadKey();

            } while (OpcMen > 0);


        }

        static void crearestudiante()
        {
            string nom = "", cor = "", codTxt, no1Txt, no2Txt, no3Txt;
            int cod = 0;



            var db = new tallersena2Context();
            var existe = db.Estudiantes.Find(cod);


            bool EntradaValidaNombre = false;
            bool EntradaValidaCodigo = false;
            bool EntradaValidaCorreo = false;
            bool EntradaValidaNota1 = false;
            bool EntradaValidaNota2 = false;
            bool EntradaValidaNota3 = false;

            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            gui.Marco(1, 110, 1, 5);
            Console.SetCursorPosition(45, 2); Console.WriteLine("************************");
            Console.SetCursorPosition(45, 3); Console.WriteLine("***AGREGAR ESTUDIANTE***");
            Console.SetCursorPosition(45, 4); Console.WriteLine("************************");
            gui.Linea(40, 5, 30);


            if (existe == null)
            {
                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 7); Console.Write("Digite Codigo Estudiante: ");
                    Console.SetCursorPosition(55, 7); codTxt = Console.ReadLine();
                    if (!verificar.Vacio(codTxt))
                        if (verificar.TipoNumero(codTxt))
                            EntradaValidaCodigo = true;

                } while (!EntradaValidaCodigo);

                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 9); Console.Write("Digite Nombre Estudiante:");
                    Console.SetCursorPosition(55, 9); nom = Console.ReadLine();
                    if (!verificar.Vacio(nom))
                        if (verificar.TipoTexto(nom))
                            EntradaValidaNombre = true;
                } while (!EntradaValidaNombre);


                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 11); Console.Write("Digite Correo Estudiante: ");
                    Console.SetCursorPosition(55, 11); cor = Console.ReadLine();
                    if (!verificar.Vacio(cor))
                        if (verificar.TipoCorreo(cor))
                            EntradaValidaCorreo = true;
                } while (!EntradaValidaCorreo);
                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 13); Console.Write("Digite Nota 1 Estudiante: ");
                    Console.SetCursorPosition(55, 13); no1Txt = Console.ReadLine();
                    if (!verificar.Vacio(no1Txt))
                        if (!verificar.TipoNota(no1Txt))
                            if (verificar.TipoNumero(no1Txt))
                            EntradaValidaNota1 = true;
                } while (!EntradaValidaNota1);

                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 15); Console.Write("Digite Nota 2 Estudiante: ");
                    Console.SetCursorPosition(55, 15); no2Txt = Console.ReadLine();

                    if (!verificar.Vacio(no2Txt))
                        if (verificar.TipoNumero(no2Txt))
                            if (!verificar.TipoNota(no2Txt))
                                EntradaValidaNota2 = true;
                } while (!EntradaValidaNota2);
                do
                {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(25, 17); Console.Write("Digite Nota 3 Estudiante: ");
                    Console.SetCursorPosition(55, 17); no3Txt = Console.ReadLine();
                    if (!verificar.Vacio(no3Txt))
                        if (verificar.TipoNumero(no3Txt))
                            if (!verificar.TipoNota(no3Txt))
                                EntradaValidaNota3 = true;
                } while (!EntradaValidaNota3);


                Estudiantes estudiante = new Estudiantes
                {
                    Codigo = int.Parse(codTxt),
                    Nombre = nom,
                    Correo = cor,
                    Nota1 = int.Parse(no1Txt),
                    Nota2 = int.Parse(no2Txt),
                    Nota3 = int.Parse(no2Txt),
                };

                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
                Console.SetCursorPosition(40, 19); Console.WriteLine("Registro agregado Correctamente");

            }
            else
                Console.SetCursorPosition(25, 19); Console.WriteLine("Ya Existe");


        }

        static void listaestudiantes()
        {
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            gui.Marco(1, 110, 1, 5);
            int altura = 9;
            Console.SetCursorPosition(45, 2); Console.WriteLine("***********************");
            Console.SetCursorPosition(45, 3); Console.WriteLine("***LISTAR ESTUDIANTES***");
            Console.SetCursorPosition(45, 4); Console.WriteLine("***********************");


            

            Console.SetCursorPosition(8, 7); Console.Write("CODIGO");
            Console.SetCursorPosition(16, 7); Console.Write("NOMBRE");
            Console.SetCursorPosition(38, 7); Console.Write("CORREO");
            Console.SetCursorPosition(63, 7); Console.Write("NOTA 1");
            Console.SetCursorPosition(71, 7); Console.Write("NOTA 2");
            Console.SetCursorPosition(78, 7); Console.Write("NOTA 3");
            Console.SetCursorPosition(86, 7); Console.Write("NOTA FINAL");

            var db = new tallersena2Context();
            var estudiantes = db.Estudiantes.ToList();

            foreach (var myEstudiantes in estudiantes)
            {
                double NF = myEstudiantes.NotaFinal((int)myEstudiantes.Nota1, (int)myEstudiantes.Nota2, (int)myEstudiantes.Nota3);

                var bd = new tallersena2Context();
                var Estudiantes = db.Estudiantes.ToList();
                
                Console.SetCursorPosition(8, altura); Console.WriteLine($"{myEstudiantes.Codigo}");
                Console.SetCursorPosition(16, altura); Console.WriteLine($"{myEstudiantes.Nombre}");
                Console.SetCursorPosition(38, altura); Console.WriteLine($"{myEstudiantes.Correo}");
                Console.SetCursorPosition(63, altura); Console.WriteLine($"{myEstudiantes.Nota1}");
                Console.SetCursorPosition(71, altura); Console.WriteLine($"{myEstudiantes.Nota2}");
                Console.SetCursorPosition(78, altura); Console.WriteLine($"{myEstudiantes.Nota3}");
                Console.SetCursorPosition(86, altura); Console.WriteLine($"[{string.Format("{0:0}", NF)}]{ myEstudiantes.concepto(NF)}");

                altura++;

                 }



        }
        static void buscarestudiante()
        {
            
            int cod = 0;
            
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            gui.Marco(1, 110, 1, 5);
            Console.SetCursorPosition(45, 2); Console.WriteLine("************************");
            Console.SetCursorPosition(45, 3); Console.WriteLine("***BUSCAR ESTUDIANTES***");
            Console.SetCursorPosition(45, 4); Console.WriteLine("************************");

                Console.SetCursorPosition(25, 7); Console.Write("Digite Codigo Estudiante: ");
                Console.SetCursorPosition(55, 7); cod = int.Parse(Console.ReadLine());
               

            Console.SetCursorPosition(8, 10); Console.Write("CODIGO");
            Console.SetCursorPosition(16, 10); Console.Write("NOMBRE");
            Console.SetCursorPosition(38, 10); Console.Write("CORREO");
            Console.SetCursorPosition(63, 10); Console.Write("NOTA 1");
            Console.SetCursorPosition(71, 10); Console.Write("NOTA 2");
            Console.SetCursorPosition(78, 10); Console.Write("NOTA 3");
            Console.SetCursorPosition(86, 10); Console.Write("NOTA FINAL");
            var db = new tallersena2Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {
                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);
                double NF = myEstudiante.NotaFinal((int)myEstudiante.Nota1, (int)myEstudiante.Nota2, (int)myEstudiante.Nota3);
                Console.SetCursorPosition(8, 12); Console.WriteLine($"{myEstudiante.Codigo}");
                Console.SetCursorPosition(16, 12); Console.WriteLine($"{myEstudiante.Nombre}");
                Console.SetCursorPosition(38, 12); Console.WriteLine($"{myEstudiante.Correo}");
                Console.SetCursorPosition(63, 12); Console.WriteLine($"{myEstudiante.Nota1}");
                Console.SetCursorPosition(71, 12); Console.WriteLine($"{myEstudiante.Nota2}");
                Console.SetCursorPosition(78, 12); Console.WriteLine($"{myEstudiante.Nota3}");
                Console.SetCursorPosition(86, 12); Console.WriteLine($"[{string.Format("{0:0}", NF)}]{ myEstudiante.concepto(NF)}");
            }
            else
                Console.SetCursorPosition(40, 15); Console.WriteLine("No existe registro");



        }

        static void editarestudiante()
        {
            double no1, no2, no3 = 0;
            string nom, cor = "";
            int cod = 0;
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            gui.Marco(1, 110, 1, 5);
            Console.SetCursorPosition(45, 2); Console.WriteLine("***********************");
            Console.SetCursorPosition(45, 3); Console.WriteLine("***EDITAR ESTUDIANTE***");
            Console.SetCursorPosition(45, 4); Console.WriteLine("***********************");
            gui.Linea(40, 5, 30);

            Console.SetCursorPosition(25, 7); Console.WriteLine("Digite Codigo a editar");
            Console.SetCursorPosition(55, 7); cod = int.Parse(Console.ReadLine());


            var db = new tallersena2Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {

                Console.WriteLine("Digite Nombre Estudiante");
                nom = Console.ReadLine();
                Console.WriteLine("Digite Correo Estudiante");
                cor = Console.ReadLine();
                Console.WriteLine("Digite Nota 1");
                no1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite Nota 2");
                no2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite Nota 3");
                no3 = double.Parse(Console.ReadLine());

                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);
                myEstudiante.Nombre = nom;
                myEstudiante.Correo = cor;
                myEstudiante.Nota1 = no1;
                myEstudiante.Nota2 = no2;
                myEstudiante.Nota3 = no2;
                db.SaveChanges();

                Console.SetCursorPosition(40, 20); Console.WriteLine("Registro Editado  Correctamente");

            }

            else
                Console.SetCursorPosition(40, 15); Console.WriteLine("No existe registro");


        }

        static void borrarestudiante()
        {
            int cod = 0;
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            gui.Marco(1, 110, 1, 5);
            Console.SetCursorPosition(45, 2); Console.WriteLine("***********************");
            Console.SetCursorPosition(45, 3); Console.WriteLine("***BORRAR ESTUDIANTE***");
            Console.SetCursorPosition(45, 4); Console.WriteLine("***********************");
            gui.Linea(40, 5, 30);

            
                gui.BorrarLinea(33, 9, 64);
                Console.SetCursorPosition(25, 7); Console.Write("Digite Codigo Estudiante: ");
                Console.SetCursorPosition(55, 7); cod = int.Parse(Console.ReadLine());
              

            var db = new tallersena2Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {
                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);

                string confirmar = "n";
                Console.SetCursorPosition(25, 12); Console.WriteLine($"Realmente desea borrar los datos de {myEstudiante.Nombre} s/n:");
                Console.SetCursorPosition(73, 12); confirmar = Console.ReadLine();
                if (confirmar == "s")
                {
                    db.Estudiantes.Remove(myEstudiante);
                    db.SaveChanges();
                    Console.SetCursorPosition(40, 14); Console.WriteLine("El registro fue borrado correctamente ");

                }
                else
                    Console.SetCursorPosition(45, 15); Console.Write("No eliminado");


            }
            else
                Console.SetCursorPosition(45, 15); Console.WriteLine("No existe");
        }


    }
}