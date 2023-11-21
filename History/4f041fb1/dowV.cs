using System;

namespace P2.Elementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            int ele = 0, NE=0;
            //Declarar vector
            Console.Write("Cuantos elementos desea capturar: ");
            NE=int.Parse(Console.ReadLine());
            int [] elementos = new int[NE];
            //Almacenar vector
            for (int i = 0; i < NE; i++)
            {
                Console.Write("Ingresa elemento {0}: ", i + 1);
                ele = int.Parse(Console.ReadLine());
                elementos[i]=ele;
            }
            //Imprimir vector
            Console.Clear();
            for (int i = 0; i < NE; i++)
            {
                ele=elementos[i];
                Console.WriteLine("El elemento {0} es: {1} ", i+1, ele);
            }
            Console.ReadKey();
        }
    }
}
