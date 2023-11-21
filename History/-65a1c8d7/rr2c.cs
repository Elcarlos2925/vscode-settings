using System;

namespace P1saludo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = " ";int edad = 0;//Declarar variable
            Console.WriteLine("Cual es tu nombre");
            name = Console.ReadLine();
            Console.WriteLine("Cual es tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine(" Hola {0}, tu edad es {1}",name,edad);
        }
    }
}
