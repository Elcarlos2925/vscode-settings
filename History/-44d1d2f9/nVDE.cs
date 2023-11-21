using System;

namespace P3.El_Número_Mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables 
            int ele=0, NF = 0, NC=0, mayor=0;
            //Declarar Matriz
            Console.Write("Ingrese el número de filas: ");
            NF = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            NC = int.Parse(Console.ReadLine());

            int[,] elementos = new int[NF, NC];

            for(int i = 0; i < NF; i++)
            {
                for(int j = 0; j < NC; j++)
                {
                    Console.Write("Dame elemento {0} de {1}: ",i+1,j+1);
                    ele=int.Parse(Console.ReadLine());
                    elementos[i,j] = ele;
                }
            }
            Console.Clear();
            for(int i = 0; i < NC; i++)
            {
                for (int j = 0; j < NC; j++)
                {
                    ele = elementos[i, j];
                    Console.Write("{0}  ",ele);
                    //Encontraar número mayor
                    if (ele > mayor) ;
                    {
                        mayor = ele;
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("El número mayor de todos los elementos es: {0}", mayor);
            Console.ReadKey();
        }
    }
}
