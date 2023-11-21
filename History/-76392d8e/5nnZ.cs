using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Operaciones_Basicas_Exc
{
    internal class OperaciónesBasicas
    {
        int Num1;
        int Num2;
        //Define propiedades para leer y escribir

        public int Numero1
        {
            get { return Num1; }
            set { Num1 = value; }
        }
        public int Numero2
        {
            get { return Num2; }
            set { Num2 = value; }
        }

        // inicializa constructores
        public OperaciónesBasicas()
        {
        }
        //constructor sobrecargado con datos
        public OperaciónesBasicas(int n1, int n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
        //Definir metodos de la clase
        public void Suma()
        {
            int suma = 0;
            suma = Num1 + Num2;
            Console.WriteLine("El resultado de su suma es {0}", suma);
        }
        public void Resta()
        {
            int resta = 0;
            resta = Num1 - Num2;
            Console.WriteLine("El resultado de su resta es {0}", resta);
        }
        public void Multiplicación()
        {
            int multiplicación = 0;
            multiplicación = Num1 * Num2;
            Console.WriteLine("El resultado de su multiplicación es {0}", multiplicación);
        }
        public void División()
        {
            int división = 0;
            división = Num1 / Num2;
            Console.WriteLine("El resultado de su división es {0}", división);
                      
        }
    
        public void Mayor()
        {
            if (Num1 > Num2)
            {
                Console.WriteLine("El mayor es {0}", Num1);

            }
            else
            {
                Console.WriteLine("El mayor es {0}", Num2);
            }
            
        }
    }
}


using System;

namespace P6_Operaciones_Basicas_Exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            OperaciónesBasicas Operación = new OperaciónesBasicas();
            Boolean ban = false;
            int opc1 = 0;
            do
            {
                do
                {
                    try
                    {
                        //Capturar datos de los atributos del objeto

                        Console.Write("Ingrese el valor de número 1: ");//Dar valor a numero 1
                        Operación.Numero1 = int.Parse(Console.ReadLine());//almacenar numero 1

                        Console.Write("Ingrese el valor de número 2: ");//Dar valor a numero 2
                        Operación.Numero2 = int.Parse(Console.ReadLine());//almacenar numero 2


                        Console.Clear();//limpiar pantalla

                        int opc = 0;//declarar opc 
                                    //Desplegar menú 
                        Console.WriteLine("Que operación desea realizar: \n 1.suma \n 2.resta \n 3.multiplicación \n 4.división\n 5. desplegar el mayor");
                        opc = int.Parse(Console.ReadLine());

                        Console.Clear();//limpiar pantalla

                        //Ejecutar operación
                        if (opc == 1)
                        {
                            Operación.Suma();
                        }
                        else if (opc == 2)
                        {
                            Operación.Resta();
                        }
                        else if (opc == 3)
                        {
                            Operación.Multiplicación();
                        }
                        else if (opc == 4)
                        {
                            if (Operación.Numero1 == 0)
                            {
                                throw new DivideByZeroException("Ocurrio un error");
                            }
                            else if (Operación.Numero2 == 0)
                            {
                                throw new DivideByZeroException("Ocurrio un error");
                            }
                            Operación.División();
                        }
                        else if (opc == 5)
                        {
                            Operación.Mayor();
                        }
                        else
                        {
                            Console.WriteLine("opción no valida");
                        }
                        ban = true;
                    }
                    catch (DivideByZeroException)//clausula division entre 0
                    {
                        Console.WriteLine("Ocurrio un error, coloque un número diferente a 0");
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
                    Console.Clear();
                } while (ban == false);
                Console.WriteLine("Desea ejecutar Nuevamente el programa 1.si / 2.no");
                opc1=int.Parse(Console.ReadLine());
                if (opc1==0)
                {
                    Console.Clear();
                }
            } while(opc1==0);
        }
    }
}
