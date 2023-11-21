using System;

namespace Colegiaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int Na = 0, alum = 0, opc = 0; string name = " ", datos = " "; float Coleg = 0, suma = 0;
            //Declarar Vector 
            Console.Write("Cuantos alumnos desea Registrar: ");
            Na = int.Parse(Console.ReadLine());
            string[] Alumnos = new string[Na];
            //Declarar matriz
            float[,] Colegiaturas = new float[Na, 6];
            //Almacenar Vector
            for (int i = 0; i < Na; i++)
            {
                Console.Write("Ingresa nombre {0}:  ", i + 1);
                name = Console.ReadLine();
                Alumnos[i] = name;
            }
            Console.Clear();
            //Almacenar matriz
            for (int i = 0; i < Na; i++)
            {
                name = Alumnos[i];
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Ingrese valor de la colegiatura del semestre {0} de {1}: ", j + 1, name);
                    Coleg = float.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            do
            {
                Console.WriteLine("LISTA DE ALUMNOS");
                for (int i = 0; i < Na; i++)
                {
                    name = Alumnos[i];
                    Console.WriteLine("{0}. {1} ", i + 1, name);
                }
                Console.Write("A que alumno le desea revisar colegiatura: ");
                alum = int.Parse(Console.ReadLine());
                Console.Clear();
                //Imprimir datos de colegiatura del alumno
                datos = Alumnos[alum - 1];
                Console.WriteLine("Alumno: {0}", datos);
                for (int i = 0; i < 6; i++)
                {
                    Colegiaturas[alum - 1, i] = Coleg;
                    suma = Coleg + suma;
                }
                Console.WriteLine("El total de la colegiatura de {0} es de {1}", datos, suma);
                suma = 0;
                Console.ReadKey();
                Console.WriteLine("Desea revisar otro alumno: 1. si / 2. no: ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                }
            } while (opc == 1);
        }
    }
}
