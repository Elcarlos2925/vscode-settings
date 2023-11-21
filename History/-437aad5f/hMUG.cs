using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6.Sueldos
{
    internal class Sueldos
    {
        float sueld_men;
        string puesto;
        string nombre;
        float suma;
        //crear propiedades de leer y escribir
        public float SMen
        {
            get { return sueld_men; }
            set { sueld_men = value; }
        }
        public string Name
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Pst
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public float Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        public Sueldos()
        {
        }
            public Sueldos(int SMen, string name)
        {
            sueld_men = SMen;
            nombre = name;

        }
        public void SueldoE()
        {
            float sueldoanual = 0;
            sueldoanual = suma;
            Console.WriteLine(" Empleado: {0} \n Puesto: {1}", nombre, puesto);
        }
    }
}

using System;

namespace p6.Sueldos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear objeto 
            Sueldos sdo = new Sueldos();
            //Declarar bandera
            Boolean ban = false;
            do
            {
                try
                {

                    //Declarar Variables

                    float sueldoanual = 0, suma = 0; int opc = 0;

                    do
                    {
                        //Declarar Datos
                        Console.Write("Ingresa un nombre:");
                        sdo.Name = Console.ReadLine();
                        Console.Write("Ingrese puesto de {0}:",sdo.Name);
                        sdo.Pst = Console.ReadLine();

                        float[] elementos = new float[12];
                        //Almacenar datos
                        for (int i = 0; i < 12; i++)
                        {
                            Console.Write("cual es su sueldo mensual {0}: ", i + 1);
                            sdo.SMen = int.Parse(Console.ReadLine());
                            if (sdo.SMen < 0)
                            {
                                throw new ArgumentException();
                            }
                            else if (sdo.SMen == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            elementos[i] = sdo.SMen;
                            suma = suma + sdo.SMen;
                        }
                        //Imprimir Sueldo anual
                        Console.Clear();
                        sdo.SueldoE();
                        Console.ReadKey();
                        for (int i = 0; i < 12; i++)
                        {
                            sdo.SMen = elementos[i];
                            Console.WriteLine("su sueldo mensual" + " " + i + " " + "es" + " " + sdo.SMen);
                        }
                        Console.WriteLine("su sueldo anual es" + sueldoanual);
                        Console.WriteLine("Desea registrar los datos de otra persona?  1.si / 2.no");
                        Console.Write("Ingrese su respuesta aqui: ");
                        opc = int.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            Console.Clear();
                        }
                    } while (opc == 1);
                    ban = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Ocurrio un error coloque un numero positivo");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Coloque un numero diferente a 0");
                }
            } while(ban==false);
        }
    }
}
