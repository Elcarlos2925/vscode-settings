using System;

namespace P3._4._Programa_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            int cal = 0;
            float prom = 0, suma = 0;
            string name = " ";

            // DECLARAR VECTOR
            string[] nombres = new string[5];

            // ALMACENAR VECTOR 
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa nombre {0}:  ", i+1);
                name = Console.ReadLine();
                nombres[i] = name;
            }
            //DECLARAR MATRIZ

            int[,] calificaciones = new int[5, 4];

            for (int i = 0; i < 5; i++)
            {
                name = nombres[i];
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("dame calificacion {0} de {1}: ", j+1, name);
                    cal = int.Parse(Console.ReadLine());
                    calificaciones[i, j] = cal;
                }
            }
            Console.Clear();
            //Imprimir
            for (int i = 0; i < 5; i++)
            {
                name = nombres[i];
                for (int j = 0; j < 4; j++)
                {
                    cal = calificaciones[i, j];
                    suma = suma + cal;
                }
                prom = suma / 4;
                Console.WriteLine("El Promedio de {0} es: {1}", name, prom);
                suma = 0;
            }
            Console.ReadKey();
        }
    }
}
