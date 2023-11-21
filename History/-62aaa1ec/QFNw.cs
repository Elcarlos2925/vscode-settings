using System;

namespace p6.Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int num = 0, opc = 0; Boolean ban=false;

            do
            {
                do
                {
                    try
                    {
                        Console.Write("Dame un número: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Su número es: " + num);
                        ban = true;
                    }
                    //clausula especifica con id
                    catch (OverflowException id)
                    {
                        Console.WriteLine(id);
                        Console.WriteLine("El error que ocurrio es: {0}", id.Message);
                    }


                    //clausula especifica
                    catch (FormatException)
                    {
                        Console.WriteLine("Lo siento, currio un error de formato");

                    }
                    //clausula general
                    catch
                    {
                        Console.Write("Ocurrio un error");
                    }
                    Console.ReadKey();
                } while (ban == false);
                Console.WriteLine("Desea ejecutar Nuevamente el programa 1.si / 2.no");
                opc = int.Parse(Console.ReadLine());
                if (opc == 0)
                {
                    Console.Clear();
                }
            } while (opc == 1);
        }
    }
}
