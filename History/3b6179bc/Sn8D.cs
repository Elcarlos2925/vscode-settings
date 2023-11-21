using System;

namespace P3_SUELDOS_PARAMETROSVLR
{
    class Program
    {
        static void Sueldo_Sem(float Sdo_dia)
        {
            float sdo_sem = 0;
            sdo_sem = Sdo_dia * 7;
            Console.Write("Su Sueldo Semanal Es: {0}", sdo_sem);
        }
        static void Sueldo_Quin(float Sdo_dia)
        {
            float sdo_quin = 0;
            sdo_quin = Sdo_dia * 15;
            Console.Write("Su Sueldo Quincenal Es: {0}", sdo_quin);
        }
        static void Main(string[] args)
        {
            float Sdo_dia = 0; int opc = 0, opc1 = 1;//declarar variables
            //leer datos
            do
            {
                Console.Write("dame un sueldo diario: ");
                Sdo_dia = float.Parse(Console.ReadLine());
                //menu y calcular tipo de sueldo 
                Console.WriteLine("Que sueldo desea calcular 1.sueldo semanal / 2.sueldo quincenal");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Sueldo_Sem(Sdo_dia);
                }
                else if (opc == 2)
                {
                    Sueldo_Quin(Sdo_dia);
                }
                else
                {
                    Console.Write("opción no valida");
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Desea calcular otro suedo 1. si/ 2. no");
                opc1 = int.Parse(Console.ReadLine());
                if (opc1 == 1) ;
                {
                    Console.Clear();
                }
            } while (opc1 == 1);
        }
    }
}
