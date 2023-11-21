using System;

namespace P3_casadecambio
{
    internal class Program
    {
        static void Actualizar(ref float compra, ref float venta)
        {
            //cambiar el valor original
            compra = 0; venta = 0;
            Console.Write("cual es el valor de compra: ");
            compra = float.Parse(Console.ReadLine());
            Console.Write("cual es el valor de venta: ");
            venta = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Los Valores Fueron Cambiados Exitosamente A: ");
            Console.WriteLine("Compra: {0}", compra);
            Console.WriteLine("Venta:  {0}", venta);
            Console.ReadKey();
            Console.Clear();
        }
        static void compdll(float com)
        {
            float MX = 0, Ndll = 0;
            Console.Write("cuantos dolares deseas comprar: ");
            Ndll = int.Parse(Console.ReadLine());
            MX = Ndll * com;
            Console.WriteLine("El resultado de la compra es de: {0} pesos mx ", MX);
            Console.ReadKey();
            Console.Clear();
        }
        static void ventdll(float ven)
        {
            float dll = 0, Ndll = 0;
            Console.Write("cuantos dolares deseas vender: ");
            Ndll = float.Parse(Console.ReadLine());
            dll = Ndll * ven;
            Console.WriteLine("El resultado de la venta es de: {0} pesos mx ", dll);
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            float comp = 0, vent = 0; int opc = 0;//declarar variables

            //LEER DATOS

            Console.Write("cual es el valor de compra: ");
            comp = float.Parse(Console.ReadLine());
            Console.Write("cual es el valor de venta:  ");
            vent = float.Parse(Console.ReadLine());

            //DESPLEGAR MENÚ
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Que operacion desea realizar \n 1.actualizar valores \n 2.compra de dolar \n 3.venta de dolar \n 4.salir");
                        opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opc)
                        {
                            case 1:
                                {
                                    Actualizar(ref comp, ref vent);
                                    break;
                                }
                            case 2:
                                {
                                    compdll(comp);
                                    break;
                                }
                            case 3:
                                {
                                    ventdll(vent);
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("opción no valida");
                                    Console.ReadKey();
                                    break;
                                }
                        }
                    } while (opc == 1);
                } while (opc == 2);
            } while (opc == 3);
        }
    }
}
