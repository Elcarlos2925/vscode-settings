using System;

namespace P3_SUMA2NUM
{
    class Program
    {
        static void Sumar (int n1, int n2)
        {
            int suma = 0;
            suma = n1 + n2;
            Console.WriteLine("El Resultado De Suma Es: {0} ", suma);
        }

        static void Main(string[] args)
        {
            //declarar variables
            int Num1 = 0, Num2 = 0;
            //leer datos
            Console.Write("dame numero 1: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("dame numero 2: ");
            Num2 = int.Parse(Console.ReadLine());

            Sumar (Num1, Num2);
            Console.ReadKey();
        }
    }
}
