
using System;

namespace P2.Sueldos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES 

            int SdoMen = 0, suma = 0;
            string name = " ", puesto = " ";

            // LEER DATOS 
            Console.Write("cual es tu nombre: ");
            name = Console.ReadLine();
            Console.Write("cual es tu puesto: ");
            puesto = Console.ReadLine();

            // DECLARAR VECTOR

            int[] elementos = new int[12];

            // ALMACENAR VECTOR 

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Cual es tu sueldo mensual {0}: ", i+1);
                SdoMen = int.Parse(Console.ReadLine());
                elementos[i] = SdoMen;
                suma = suma + SdoMen;
            }
            Console.Clear();

            // IMPRIMIR NOMBRE Y PUESTO
            Console.WriteLine("Nombre: {0} \nPuesto: {1}",name,puesto);

            // IMPRIMIR VECTOR

            for (int i = 0; i < 12; i++)
            {
                SdoMen = elementos[i];
                Console.WriteLine("Su sueldo mensual del Mes {0} es de: {1}",i+1,SdoMen);
            }

            //Imprimir sueldo anual
            Console.WriteLine("Su sueldo Anual es del total: {0}",suma);
            Console.ReadKey();

        }
    }
}
