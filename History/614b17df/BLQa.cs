using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Persona
{
    internal class Persona
    {
        string nombre;
        int edad;

        //define propiedades para poder leer y escribir

        public string name
        {
            get { return nombre; }//Propiedad leer

            set { nombre = value; }//Propiedad escribir
        }
        public int age
        {
            get { return edad; }//propiedad leer

            set { edad = value; }//Propiedad Escribir
        }
        // Inicializa Constructores

        //Por defecto
        public Persona()
        {
        }
        //constructor sobrecargado con datos
        public Persona(String n, int e)
        {
            nombre = n;
            edad = e;
        }
        //Definir metodos de la clase
        public void cumple()
        {
            //puede utilizar el nombre del atributo o de la propiedad
            edad++;//incrementa la edad en 1
        }
    }
}

using System;

namespace P6_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            Persona Nombre = new Persona();//Creamos objeto sin datos
            Persona edad = new Persona("Abraham", 18);//Creamos objeto con datos
            Boolean ban = false; int opc = 0;
            do
            {
                do
                {
                    //Capturar datos de los atributos del objeto
                    try
                    {
                        Console.Write("Ingresa tu nombre: ");
                        Nombre.name = Console.ReadLine();
                        Console.Write("Ingresa tu edad: ");
                        edad.age = int.Parse(Console.ReadLine());
                        if (edad.age < 0)
                        {
                            throw new OverflowException("El programa no procesa números negativos \n ingrese un número mayor a 0");
                        }
                        Console.WriteLine("Hola {0}, tu edad es {1}", Nombre.name, edad.age);
                        Console.ReadKey();
                        ban = true;
                    }
                    //clausula especifica con id
                    catch (OverflowException id)
                    {
                        Console.WriteLine("\n\n" + id);
                        Console.WriteLine("El error que ocurrio es: \n {0}", id.Message);
                    }
                    //clausula especifica
                    catch (FormatException)
                    {
                        Console.WriteLine("Lo siento, currio un error de formato \n Vuelva a intentarlo e ingrese un número entero");

                    }
                    //clausula general
                    catch (Exception id)
                    {
                        Console.Write(id.Message);
                    }
                    Console.ReadKey();
                } while (ban == false);
                Console.WriteLine("Desea volver a ejecutar el programa: 1.si / 2.no");
                opc = int.Parse(Console.ReadLine());
                if (opc == 0)
                {
                    Console.Clear();
                } 
            } while (opc == 0);
        }
    }
}
