using System;

namespace P3SUMA_SOBRECARGA
{
    class Program
    {
        static void Sumar (int n1, int n2)
        {
            int suma = 0; //declarar suma
            suma = n1 + n2;//realizar suma
            Console.WriteLine("El resultado de {0} + {1} = {2} ",n1,n2,suma);//imprimir
            Console.ReadKey();
        }
        static void Sumar(int n1, int n2, int n3)
        {
            int suma = 0; //declarar suma
            suma = n1 + n2 + n3;//realizar suma
            Console.WriteLine("El resultado de {0} + {1} + {2} = {3} ", n1, n2,n3, suma);//imprimir
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
                //DECLARAR VARIABLES
                int num1 = 0, num2 = 0, num3 = 0, opc = 0, opc1 = 1;
            do
            {
                // Menú opciones 
                Console.WriteLine("Que operación desea realizar: \n 1. Sumar 2 numeros \n 2. Sumar 3 numeros");
                Console.Write("Opcion:");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                { //leer datos
                    Console.Write("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Sumar(num1, num2);
                }
                else if (opc == 2)
                { //leer datos
                    Console.Write("Dame numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Dame numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("Dame numero 3: ");
                    num3 = int.Parse(Console.ReadLine());
                    Sumar(num1, num2, num3);
                }
                else
                { //leer opcion no valida
                    Console.WriteLine("opcion no valida ");
                }
                Console.Clear();
                Console.WriteLine("Desea realiar otra suma:   1.si / 2.no");
                opc1 = int.Parse(Console.ReadLine());
                if (opc1 == 1)
                {
                    Console.Clear();
                }
            } while (opc1==1);
        }
    }
}
