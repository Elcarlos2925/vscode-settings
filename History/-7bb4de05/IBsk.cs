using System;

namespace P2._Programa_nomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            int NE = 0, opc = 0, opc1 = 1;
            string depto = " ", tipnom = " ", name = " ";
            double sdodia = 0, sueldo = 0, nomina = 0;
            //LEER DATOS (DEPARTAMENTO)
            do
            {
                Console.Write("Cual es el departamento que desea registrar: ");
                depto = Console.ReadLine();

                // DECLARAR VECTORES
                Console.Write("cuantos empleados desea capturar: ");
                NE = int.Parse(Console.ReadLine());
                string[] names = new string[NE];
                string[] tipnoms = new string[NE];
                double[] sdodias = new double[NE];

                // ALMACENAR EL VECTOR

                for (int i = 0; i < NE; i++)
                {
                    Console.Write("Dame nombre del empleado {0}: ", i+1);
                    name = Console.ReadLine();
                    names[i] = name;
                    Console.Write("cual es su tipo de nomina 1.semanal / 2. quincenal: ", i);
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1)
                    {
                        tipnoms[i] = "semanal";
                    }
                    else if (opc == 2)
                    {
                        tipnoms[i] = "quinsenal";
                    }
                    else
                    {
                        tipnoms[i] = "opción no valida";
                    }
                    Console.Write("Dame sueldo diario {0}: ", i+1);
                    sdodia = int.Parse(Console.ReadLine());
                    sdodias[i] = sdodia;
                    Console.Clear();//Limpiar pantalla
                }

                //IMPRIMIR DEPARTAMENTO Y REPORTE

                Console.WriteLine("departamento: {0}", depto);
                Console.WriteLine("Empleado          TipoSdo          sueldo");

                //IMPRIMIR DETALLE
                for (int i = 0; i < NE; i++)
                {
                    name = names[i];
                    tipnom = tipnoms[i];
                    sdodia = sdodias[i];
                    if (tipnoms[i] == "semanal")
                    {
                        sueldo = sdodia * 7;
                    }
                    else if (tipnoms[i] == "quinsenal")
                    {
                        sueldo = sdodia * 15;
                    }
                    else
                    {
                        tipnoms[i] = "opción no valida";
                    }

                    //IMPRIME DATOS 

                    Console.WriteLine("{0}          {1}          {2}", name, tipnom, sueldo);

                    //ACUMULAR SUELDOS CAPTURADOS

                    nomina = nomina + sueldo;
                }

                //IMPRIMIR TOTAL DE NOMINA
                Console.WriteLine("TOTAL DE NOMINA: {0}", nomina);
                Console.ReadKey();
                // VOLVER A EJECUTAR EL PROGRAMA
                Console.WriteLine("desea realizar la nomina de otro departamento 1. SI / 2.NO");
                opc1 = int.Parse(Console.ReadLine());
                if (opc1 == 1)
                {
                    Console.Clear();
                }
            } while (opc1 == 1);
        }
    }
}
