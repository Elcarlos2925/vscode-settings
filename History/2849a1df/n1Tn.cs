using System;

namespace P2._Programa_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARAR VARIABLES

            int ele = 0, NE = 0;

            // DECLARAR VECTOR

            Console.Write("cuantos elementos desea ingresar: ");
            NE = int.Parse(Console.ReadLine());
            int[] elementos = new int[NE];

            // ALMACENAR EL VECTOR

            for (int i = 0; i < NE; i++)
            {
                Console.Write("Dame elemento {0}: ", i+1);
                ele = int.Parse(Console.ReadLine());
                elementos[i] = ele;
            }

            // IMPRIMIR VECTOR

            Console.Clear();
            for (int i = 0; i < NE; i++)
            {
                ele = elementos[i];
                Console.WriteLine("El elemento {0} es: {1} ", i + 1, ele);
            }
            Console.ReadKey();

            //LOGITUD DEL VECTOR

            Console.WriteLine("Longitud del Vector = " + elementos.Length);

            //FUNCIÓN SORT

            Array.Sort(elementos);

            //FUNCIÓN REVERSE

            Array.Reverse(elementos);

            for (int i = 0; i < elementos.Length; i++)
            {
                ele = elementos[i];
                Console.WriteLine("elemento {0} es {1}", i + 1, ele);

            }
            Console.ReadKey();
        }
    }
}
