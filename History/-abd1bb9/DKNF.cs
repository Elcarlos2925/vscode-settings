using System;

namespace P3.Promedio_de_alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            int cal = 0, NA = 0, alum = 0, opc = 0;
            float prom = 0, suma = 0;
            string name = " ";
            string salida = " ";
            // DECLARAR VECTOR
            Console.Write("Dame numero de alumnos: ");
            NA = int.Parse(Console.ReadLine());
            string[] nombres = new string[NA];
            //DECLARAR MATRIZ
            int[,] calificaciones = new int[NA, 5];
            //ALMACENAR VECTOR Y MATRIZ
            for (int i = 0; i < NA; i++)
            {
                Console.Write("dame nombre {0}: ", i+1);
                name = Console.ReadLine();
                nombres[i] = name;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("dame calificacion {0} de {1}: ", j+1, name);
                    cal = int.Parse(Console.ReadLine());
                    calificaciones[i, j] = cal;
                }
                Console.Clear();
            }
            do
            {
                Console.WriteLine("lista de alumnos");
                for (int i = 0; i < NA; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, nombres[i]);
                }
                Console.Write("A que alumno desea calcular el promedio: ");
                alum = int.Parse(Console.ReadLine());
                // calcula promedio del alumno
                for (int i = 0; i < 5; i++)
                {
                    cal = calificaciones[alum - 1, i];
                    suma = suma + cal;
                }
                prom = suma / 5;
                for (int i = 0; i < alum; i++)
                {
                    salida = nombres[alum - 1];
                }
                //Imprime nombre y  promedio
                Console.WriteLine("El Promedio de {0} es {1}", salida, prom);
                suma = 0;
                Console.ReadKey();
                Console.WriteLine("desea calcular otro promedio 1. SI / 2. NO");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                }
            } while (opc == 1);
        }
    }
}
