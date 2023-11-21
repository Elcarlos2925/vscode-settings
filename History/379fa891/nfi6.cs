using System;

namespace Sueldos_Ejercicio_de_reforzamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0; Boolean ban = false;
            //crear objeto
            Empleado sdos = new Empleado();
            do
            {
                do
                {
                    try
                    {

                        Console.Write("Ingrese el nombre del empleado: ");
                        sdos.Name = Console.ReadLine();
                        Console.WriteLine("Que tipo de nomina desea consultar \n      - Si desea consultar un tipo de nomina semanal " +
                          "\n            (Ingrese sem)\n      -Si desea consultar un tipo de nomina quincenal \n         (ingrese quin)");
                        sdos.TNomina = Console.ReadLine();
                        if (sdos.TNomina == "sem")
                        {
                            sdos.Gana();
                        }
                        else if (sdos.TNomina == "quin")
                        {
                            sdos.Gana();
                        }
                        else
                        {
                            throw new ArgumentException("Argumento no valido \t vuelva a intentarlo ingresando una opción valida");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        ban = true;
                    }
                    //excepciones
                    catch (FormatException)
                    {
                        Console.WriteLine("Ocurrio un error de formato");
                    }
                    catch (ArgumentException id)
                    {
                        Console.WriteLine(id.Message);
                    }
                    catch
                    {
                        Console.Write("Ocurrio un error");
                    }

                } while (ban == false);
                Console.WriteLine("Desea consultar a otro empleado? \n 1.Si \n 2.No");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                }
            } while (opc == 1);
        }
    }
}

Clase Empleado
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldos_Ejercicio_de_reforzamiento
{
    internal class Empleado
    {
        string Nombre;
        float Sueldo;
        string TNom;

        public string Name
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public float Sdo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        public string TNomina
        {
            get { return TNom; }
            set { TNom = value; }
        }
        //inicializa constructores
        public Empleado()
        {
        }
        //constructor sobrecargado de datos
        public Empleado(string n, float S, string TN)
        {
            Nombre = n;
            Sueldo = S;
            TNom = TN;
        }
        //definir metodo gana
        public void Gana()
        {
            float suma = 0;
            if (TNomina == "sem")
            {
                float[] Total_nomina = new float[7];
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("ingrese sueldo diario {0}", i + 1);
                    Sueldo = float.Parse(Console.ReadLine());
                    Total_nomina[i] = Sueldo;
                }
                for (int i = 0; i < 7; i++)
                {
                    Sueldo = Total_nomina[i];
                    suma = Sueldo + suma;
                }
                Console.WriteLine("El total de la nomina semanal de {0} es de : {1}",Name, suma);
            }
            else if (TNomina == "quin")
            {
                float[] Total_nomina = new float[15];
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("ingrese sueldo diario {0}", i + 1);
                    Sueldo = float.Parse(Console.ReadLine());
                    Total_nomina[i] = Sueldo;
                }
                for (int i = 0; i < 7; i++)
                {
                    Sueldo = Total_nomina[i];
                    suma = Sueldo + suma;
                }
                Console.WriteLine("El total de la nomina quincenal de {0} es de : {1}",Name,suma);
            }
        }
    }
}
