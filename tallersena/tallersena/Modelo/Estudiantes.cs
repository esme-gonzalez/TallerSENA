using System;
using System.Collections.Generic;
using System.Text;

namespace tallersena.Modelo
{
    public partial class Estudiantes
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double? Nota1 { get; set; }
        public double? Nota2 { get; set; }
        public double? Nota3 { get; set; }

        public double NotaFinal(int N1, int N2, int N3)
        {
            double NF = (N1 + N2 + N3) / 3;
            return NF;
        }

        public string concepto(double nota)
        {
            if (nota >= 3.5)
                return "APROBAD0";
            else
                return "REPROBADO";
        }

        
    }
}
