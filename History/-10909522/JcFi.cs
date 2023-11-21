using System;

namespace P6._SaldoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            int cantidad = 0, saldo = 0; Boolean ban = false;
            do
            {
                try
                {
                    //pedir saldo
                    Console.Write("Ingrese su saldo: ");
                    saldo = int.Parse(Console.ReadLine());
                    if (saldo == 0)
                    {
                        throw new MiExcepsión(" No es posible realizar esta operación \n Su saldo es igual a 0");
                    }
                    //pedir cantidad
                    Console.Write("Que cantidad desea retirar: ");
                    cantidad = int.Parse(Console.ReadLine());
                    if (cantidad > saldo)
                    {
                        throw new OverflowException(" SALDO INSUFICIENTE \n No cuenta con el saldo suficienta para esta operación");
                    }
                    saldo = saldo - cantidad;
                    Console.WriteLine("Su saldo actual es de {0} ", saldo);
                    ban = true;
                }
                catch (OverflowException id)
                {
                    Console.WriteLine(id.Message);
                }
                catch (FormatException id)
                {
                    Console.WriteLine(id.Message);
                }
                catch (MiExcepsión id)
                {
                    Console.WriteLine(id.Msj);
                }
                catch (Exception id)
                {
                    Console.WriteLine(id.Message);
                }
                Console.ReadKey();
            } while (ban==false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6._SaldoBanco
{
    internal class MiExcepsión : Exception
    {
        //atributos
        string mensaje;
        //propiedades
        public string Msj
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public MiExcepsión(string mens)
        {
            mensaje = mens;
        } 
    }
}
