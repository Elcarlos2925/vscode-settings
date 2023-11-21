using System;

namespace P3.Elementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLE
            int ele = 0, NF = 0, NC = 0;

            //DECLARAR MATRIZ

            Console.Write("dame numero de filas: ");
            NF = int.Parse(Console.ReadLine());
            Console.Write("dame numero de columnas: ");
            NC = int.Parse(Console.ReadLine());
            int[,] elementos = new int[NF, NC];

            //CAPTURAR DATOS

            for (int i = 0; i < NF; i++)
            {
                for (int j = 0; j < NC; j++)
                {
                    Console.Write("dame elemento {0} , {1}: ", i+1, j+1);
                    ele = int.Parse(Console.ReadLine());

                    elementos[i, j] = ele;
                }
            }
            Console.Clear();
            //IMPRIME INFORMACIÖN
            for (int i = 0; i < NF; i++)
            {
                for (int j = 0; j < NC; j++)
                {
                    ele = elementos[i, j];
                    Console.WriteLine("el elemento {0} , {1} es: {2} ", i+1, j+1, ele);
                }
            }
            Console.ReadKey();
        }
    }
}

