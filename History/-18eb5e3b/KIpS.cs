using System;

namespace P1.__Programa_Mayor__Do_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            int num1 = 0, num2 = 0, opc = 0;

            //LEER DATOS

            do
            {
                Console.Write("dame numero 1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("dame numero 2: ");
                num2 = int.Parse(Console.ReadLine());

                //Ejecutar 

                if (num1 > num2)
                {
                    Console.WriteLine("El mayor es {0}", num1);

                }
                else
                {
                    Console.WriteLine("El mayor es {0}", num2);
                }
                Console.WriteLine("Desea comparar otros números 1.Si / 2.No ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                }
            } while (opc == 1);
        }
    }
}
