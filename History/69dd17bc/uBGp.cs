using System;

namespace P3OPERACIONES_BASICASDOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            int num1 = 0, num2 = 0, opc = 0;
            do
            {
                //desplegar menu
                Console.WriteLine("Que operacion desea realizar : \n 1. suma \n 2. resta \n 3. multiplicacion \n 4. division");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    //leer datos
                    Console.WriteLine("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    MetodosOperaciones.Sumar(num1, num2);
                }
                else if (opc == 2)
                {
                    //leer datos
                    Console.WriteLine("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    MetodosOperaciones.Restar(num1, num2);
                }
                else if (opc == 3)
                {
                    //leer datos
                    Console.WriteLine("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    MetodosOperaciones.multiplicacion(num1, num2);
                }
                else if (opc == 4)
                {
                    //leer datos
                    Console.WriteLine("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    MetodosOperaciones.Dividir(num1, num2);
                }
                else
                {
                    //leer datos
                    Console.WriteLine("opcion no valida");
                    Console.ReadKey();
                }
                Console.WriteLine("Desea calcular otra operción: 1. si / 2. no");
                opc = int.Parse(Console.ReadLine());
                if (opc==1)
                {
                    Console.Clear();
                }
            } while (opc==1);
        }
        class MetodosOperaciones
        {
            public static void Sumar (int n1, int n2)
            {
                int suma= 0;
                suma = n1 + n2;
                Console.WriteLine("El Resultado De {0} + {1} = {2}",n1,n2,suma);
                Console.ReadKey();
            }
            public static void Restar(int n1, int n2)
            {
                int resta = 0;
                resta = n1 - n2;
                Console.WriteLine("El Resultado De {0} - {1} = {2}", n1, n2, resta);
                Console.ReadKey();
            }
            public static void multiplicacion (int n1, int n2)
            {
                int mult = 0;
                mult = n1 * n2;
                Console.WriteLine("El Resultado De {0} * {1} = {2}", n1, n2, mult);
                Console.ReadKey();
            }
            public static void Dividir(int n1, int n2)
            {
                int div = 0;
                div = n1 + n2;
                Console.WriteLine("El Resultado De {0} / {1} = {2}", n1, n2, div);
                Console.ReadKey();
            }
        }
    }
}
