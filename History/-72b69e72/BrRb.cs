using System;

namespace Evaluación_unidad_2y3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int Ne = 0, opc = 0, opc1 = 0, opc2 = 0, opc3 = 0, Empleados = 0; string name = " ", salida1 = " "; float ahorro = 0, suma = 0, salida2 = 0;
            //Declarar Vector
            Console.Write("Ingresa el número de empleados:");
            Ne = int.Parse(Console.ReadLine());
            string[] Empleado = new string[Ne];
            do
            { 
                //Declarar Matriz 
                float[,] Ahorro = new float[Ne, 12];
                Console.Clear();
                for (int i = 0; i < Ne; i++)
                {
                    Console.Write("Ingresa nombre del empleado {0}:", i + 1);
                    name = Console.ReadLine();
                    Empleado[i] = name;
                    for (int j = 0; j < 12; j++)
                    {
                        Console.Write("Ingresa el ahorro del mes {0} del Empleado {1}:", j + 1, name);
                        ahorro = float.Parse(Console.ReadLine());
                        Ahorro[i, j] = ahorro;
                    }
                    Console.Clear();
                }
                do
                {
                    suma = 0;
                    salida1 = " ";
                    salida2 = 0;
                    //Mostrar lista de empleados
                    Console.WriteLine("LISTA DE EMPLEADOS");
                for (int i = 0; i < Ne; i++)
                {
                    name = Empleado[i];
                    Console.WriteLine("{0}. {1}", i + 1, Empleado[i]);
                }
                Console.WriteLine("A que empleado desea consultar: ");
                Empleados = int.Parse(Console.ReadLine());
                Console.Clear();
                salida1 = Empleado[Empleados - 1];
                    //Desplegar menu
                    Console.WriteLine("Que tipo de ahorro desea consulatar: \n1. Ahorro Anual \n2. Ahorro de un mes especifico");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1)
                    {
                        for (int i = 0; i < Ne; i++)
                        {
                            for (int j = 0; j < 12; j++)
                            {
                                ahorro = Ahorro[Empleados - 1, i];
                                suma = suma + ahorro;
                            }
                        }
                        Metodos_ahorro.Ahorro_anual(suma, salida1);
                    }
                    else if (opc == 2)
                    {
                        Console.WriteLine("Que mes desea consultar: \n1. Enero \n2. Febrero \n3. Marzo \n4. Abril \n5. Mayo \n6. Junio \n7. Julio \n8. Agosto \n9. Septiembre \n10. Octubre \n11. Noviembre \n12. Diciembre ");
                        opc1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < Ne; i++)
                        {
                            for (int j = 0; j < opc1; j++)
                            {
                                ahorro = Ahorro[Empleados - 1, i];
                            }
                        }
                        salida2 = Ahorro[Empleados, opc1];
                        Metodos_ahorro.Ahorro_Mensual(opc1, salida1, salida2);
                    }
                    else
                    {
                        Console.WriteLine("Opción No valida");
                    }
                    Console.Write("Desea hacer otra consulta 1. si / 2. no : ");
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        Console.Clear();
                    }
                } while (opc2 == 1);
                Console.Write("Desea Registrar mas datos: 1. si / 2. no ");
                opc2 = int.Parse(Console.ReadLine());
                if (opc2 == 1)
                {
                    Console.WriteLine("Hasta pronto");
                    Console.Clear();
                }
            } while (opc3 == 0);
        }
        //Metodos
        class Metodos_ahorro
        {
            public static void Ahorro_anual(float sum, string emp)//Imprimir ahorro anual
            {
                Console.WriteLine("TIPO DE AHORRO: ANUAL \nEl Empleado solicitado es: {0}", emp);
                Console.WriteLine("El Ahorro Anual del Empleado solicitado es: {0} ", sum);
                Console.ReadKey();
                Console.Clear();
            }
            public static void Ahorro_Mensual(int mes, string emp, float aho) // Imprimir ahorro de un mes elegido
            {
                Console.WriteLine("TIPO DE AHORRO: SEMANAL \nEl Empleado solicitado es: {0}", emp);
                if (mes == 1)
                {
                    Console.WriteLine("Su ahorro del mes de Enero es: {0}", aho);
                }
                else if (mes == 2)
                {
                    Console.WriteLine("Su ahorro del mes de Febrero es:{0}", aho);
                }
                else if (mes == 3)
                {
                    Console.WriteLine("Su ahorro del mes de Marzo es:{0}", aho);
                }
                else if (mes == 4)
                {
                    Console.WriteLine("Su ahorro del mes de Abril es:{0}", aho);
                }
                else if (mes == 5)
                {
                    Console.WriteLine("Su ahorro del mes de Mayo es:{0}", aho);
                }
                else if (mes == 6)
                {
                    Console.WriteLine("Su ahorro del mes de Junio es:{0}", aho);
                }
                else if (mes == 7)
                {
                    Console.WriteLine("Su ahorro del mes de Julio es:{0}", aho);
                }
                else if (mes == 8)
                {
                    Console.WriteLine("Su ahorro del mes de Agosto es:{0}", aho);
                }
                else if (mes == 9)
                {
                    Console.WriteLine("Su ahorro del mes de Septiembre es:{0}", aho);
                }
                else if (mes == 10)
                {
                    Console.WriteLine("Su ahorro del mes de Octubre es:{0}", aho);
                }
                else if (mes == 11)
                {
                    Console.WriteLine("Su ahorro del mes de Noviembre es:{0}", aho);
                }
                else if (mes == 12)
                {
                    Console.WriteLine("Su ahorro del mes de Diciembre es:{0}", aho);
                }
                else
                {
                    Console.WriteLine("Opción No valida");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}