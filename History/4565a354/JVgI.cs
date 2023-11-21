using System;

namespace P3._Programa_Sueldos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            int sdomen = 0, NE = 0, opc = 0, nomemp = 0, nomcia = 0, nomdepto = 0;
            string depto = " ", name = " ";
            // PEDIR DEPARTAMENTO Y NUMERO DE EMPLEADOS
            do
            {
                Console.Write("Cual es el departamento de la nomina a realizar: ");
                depto = Console.ReadLine();
                Console.Write("A cuantos empleados se le realizara la nomina: ");
                NE = int.Parse(Console.ReadLine());

                string[] nombres = new string[NE];//DECLARAR VECTOR 
                int[,] sueldos = new int[NE, 6];//DECLARAR VECTOR 

                for (int i = 0; i < NE; i++)
                {
                    Console.Write("dame nombre {0}: ", i+1);
                    name = Console.ReadLine();
                    nombres[i] = name;
                }
                Console.Clear();
                for (int i = 0; i < NE; i++)
                {
                    name = nombres[i];
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write("dame sueldo mensual {0} de {1}: ", j+1, name);
                        sdomen = int.Parse(Console.ReadLine());
                        sueldos[i, j] = sdomen;
                    }
                    Console.Clear();
                }
                for (int i = 0; i < NE; i++)
                {
                    name = nombres[i];
                    for (int j = 0; j < 6; j++)
                    {
                        sdomen = sueldos[i, j];
                        nomemp = nomemp + sdomen;
                    }
                    Console.WriteLine("empleado: {0} \n total nomina de: {1} ", name, nomemp);
                    nomdepto = nomdepto + nomemp;
                    nomemp = 0;
                }
                Console.WriteLine("TOTAL Departamento {0}: {1} ", depto, nomdepto);
                nomemp = 0;
                Console.ReadKey();
                Console.WriteLine("Desea realizar otra nomina de otro departamento 1. si / 2. no");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                }
            } while (opc == 1);
            nomcia = nomcia + nomdepto;
            Console.WriteLine("NOMINA TOTAL DE LA COMPAÑIA: {0} ", nomcia);
        }
    }
