using System;

namespace P1_Promedio__For_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarar variables
            int NC = 0, opc = 0, Cal = 0, suma = 0;
            double prom = 0;

            //CALCULAR PROMEDIO
            do
            {
                Console.Write("Cuantas calificaciones desea registrar: ");
                NC = int.Parse(Console.ReadLine());
                for (int i = 0; i < NC; i++)
                {
                    Console.Write("Dame Calificación {0}: ", i + 1);
                    Cal = int.Parse(Console.ReadLine());
                    suma = suma + Cal;
                }
                prom = suma / NC;
                Console.WriteLine("Promedio = " + prom);

                //FINALIZAR PROGRAMA

                Console.WriteLine("Desea calcular otro promedio  1.Si / 2.No ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                    suma = 0;
                }
            } while (opc == 1);
        }
    }
}
