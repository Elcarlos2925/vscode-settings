using System;

namespace P1suma2num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int Num1 = 0, Num2 = 0, suma = 0;

            //Leer Datos
            Console.Write("Dame Número 1: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Dame Número 2: ");
            Num2 = int.Parse(Console.ReadLine());

            //Realizar suma
            suma = Num1 + Num2;

            //Imprimir datos
            Console.WriteLine("El resultado de su suma es: {0} ", suma);
            Console.ReadKey();
        }
    }
}
