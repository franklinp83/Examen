using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
                return "Reprobado";
            else if (notaFinal < 80)
                return "Bueno";
            else if (notaFinal < 90)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            double notaFinal1 = CalcularNotaFinal();
            double notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine("Datos del Alumno:");
            Console.WriteLine($"Nombre: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine();

            Console.WriteLine("Datos de la Asignatura:");
            Console.WriteLine($"Nombre de la Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine();

            Console.WriteLine("Resultado:");
            Console.WriteLine($"Nota Final (sin parámetros): {notaFinal1} - {MensajeNotaFinal(notaFinal1)}");
            Console.WriteLine($"Nota Final (con parámetros): {notaFinal2} - {MensajeNotaFinal(notaFinal2)}");
        }
    }
}
