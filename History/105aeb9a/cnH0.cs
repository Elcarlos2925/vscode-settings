using System;

namespace P3.Tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar matriz
            int[,] Tabla = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i==0)
                    {
                        Tabla[i,j] = j;
                    }
                    else if (i > 0)
                    {
                        if (j == 0)
                        {
                            Tabla[i , j] = i;
                        }
                        else if (j > 0)
                        {
                            Tabla[i , j] = Tabla[i , 0] * Tabla[0 , j];
                        }
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                {
                    Console.Write( Tabla[i , j] + " " );
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
