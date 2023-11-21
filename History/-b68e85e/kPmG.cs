using System;

namespace P1.Promedio_if_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            float cal1 = 0, cal2 = 0, cal3 = 0, prom = 0, suma = 0;

            //lEER DATOS

            Console.Write("dame calificación 1: ");
            cal1 = float.Parse(Console.ReadLine());
            Console.Write("dame calificación 2: ");
            cal2 = float.Parse(Console.ReadLine());
            Console.Write("dame calificación 3: ");
            cal3 = float.Parse(Console.ReadLine());

            //CALCULAR PROMEDIO

            suma = cal1 + cal2 + cal3;
            prom = suma / 3;

            // CALIFICACIÓN MAYOR A 70

            if (prom > 70)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Requiere curso de asesoría");
            }
            Console.ReadKey();
        }
    }
}
