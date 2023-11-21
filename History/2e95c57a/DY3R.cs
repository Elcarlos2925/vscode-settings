using System;

namespace P3_EJEMPLO_DE_METODOS_POR_REFERENCIA
{
    class Program
    {
        static void sumar (ref int n1, ref int n2)
        {
            int suma = 0;
            //modifica los valores originales
            n1 = n1 + 5;
            n2 = n2 + 2;
            suma = n1 + n2;//realizar suma
            Console.WriteLine("El Resultado De Suma Es: {0}", suma);//imprimir 
        }

        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;//declarar varibles
            //leer datos
            Console.Write("dame numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("dame numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            sumar(ref num1, ref num2);//realizar proceso de suma
            //imprimir valores originales 
            Console.WriteLine("El Valor De Numero 1 Es {0} Y De Numero 2 Es: {1} ",num1,num2);
            Console.ReadKey();
        }
    }
}
