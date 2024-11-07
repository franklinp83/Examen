using Examen;
using System;

namespace EjercicioNotas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("Ingrese los datos del Alumno:");
            Console.Write("Nombre del Alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Número de Cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Email: ");
            asignatura.Email = Console.ReadLine();

            Console.WriteLine("\nIngrese los datos de la Asignatura:");
            Console.Write("Nombre de la Asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Horario: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Nombre del Docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            try
            {
                Console.WriteLine("\nIngrese las notas parciales:");

                asignatura.N1 = SolicitarNota("Nota del Primer Parcial (Máximo 30): ", 30);

                asignatura.N2 = SolicitarNota("Nota del Segundo Parcial (Máximo 30): ", 30);

                asignatura.N3 = SolicitarNota("Nota del Tercer Parcial (Máximo 40): ", 40);

                Console.WriteLine("\n********************************");

                asignatura.Imprimir();

                Console.WriteLine("********************************");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: La entrada debe ser un número entero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }

        public static int SolicitarNota(string mensaje, int maximo)
        {
            int nota;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out nota))
                {
                    if (nota <= maximo)
                        break;
                    else
                        Console.WriteLine($"La nota ingresada no puede exceder el valor máximo de {maximo}.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
                }
            }
            return nota;
        }
    }
}
