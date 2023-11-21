using System;

namespace Programa_Operaciones__Switch_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            float num1 = 0, num2 = 0, suma = 0, resta = 0, mult = 0, div = 0, opc = 0;

            //LEER DATOS

            Console.Write("dame numero 1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("dame numero 2: ");
            num2 = float.Parse(Console.ReadLine());

            // DESPLEGAR MENÚ

            Console.WriteLine("Que operación desea realizar: \n 1.suma \n 2.resta \n 3.multiplicación \n 4.división");
            opc = float.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    {
                        suma = num1 + num2;
                        Console.WriteLine("El resultado de su suma es {0}", suma);
                        break;
                    }
                case 2:
