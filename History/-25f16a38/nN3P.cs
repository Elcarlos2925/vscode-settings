using System;

namespace P2_Programa_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = " "; int semestre = 0, cal=0; //declarar variables
            Console.Write("Cual es tu nombre: ");
            name=Console.ReadLine();
            Console.Write("Cual semestre esta cursando: ");
            semestre =int.Parse(Console.ReadLine());
            //declarar vector 
            int[] calificaciones = new int[5];
            // leer vector
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa la calificación {0}:",i+1);
                cal = int.Parse(Console.ReadLine());
                calificaciones[i] = cal;
            }
            //caluclar promedio
            int suma = 0, promedio=0;
            for (int i = 0; i < 5; i++)
            {
                cal = calificaciones[i];
                suma = suma+cal;
            }
            promedio = suma / 5;
            //imprimir
            Console.WriteLine("El promedio del Alumno {0} de {1} semestre es: {2}",name,semestre,promedio);
            Console.ReadKey();
        }
    }
}
