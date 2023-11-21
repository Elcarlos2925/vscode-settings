using System;

namespace P1_Leer_numero_menos_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            int num = 0;

            //LEER NUMEROS

            while (num < 100)
            {
                Console.Write("dame un numero: ");
                num = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("su numero es :{0}", num);

                Console.ReadKey();
            }
            Console.WriteLine("su numero es mayor o igual que 100");
            Console.ReadKey();
        }
    }
}
