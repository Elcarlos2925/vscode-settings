using System;

namespace P1.Sueldos_if_menú_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            float SdoDia = 0, SdoSem = 0, SdoMen = 0, Opc = 0;

            //LEER DATOS

            Console.Write("Dame sueldo diario: ");
            SdoDia = float.Parse(Console.ReadLine());

            //CALCULAR SUELDO

            Console.Write("Que sueldo desea calcular  1.sueldo semanal / 2.sueldo mensual: ");
            Opc = float.Parse(Console.ReadLine());

            if (Opc == 1)
            {
                SdoSem = SdoDia * 7;
                Console.WriteLine("su sueldo semanal es {0}", SdoSem);
            }
            else if (Opc == 2)
            {
                SdoMen = SdoDia * 30;
                Console.WriteLine("su sueldo mensual es {0}", SdoMen);
            }
            else
            {
                Console.WriteLine("opción no valida");
            }
            Console.ReadKey();
        }
    }
}
