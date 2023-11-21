using System;

namespace P5_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            Persona Carlos = new Persona();//Creamos objeto sin datos
            Persona Abraham = new Persona("Abraham", 18) ;//Creamos objeto con datos
            //Capturar datos de los atributos del objeto

            //Por asignación directa
            Carlos.name = "Carlos";
            Carlos.age = 18;

            Console.WriteLine("Hola {0}, tu edad es {1}", Carlos.name, Carlos.age);
            Console.ReadKey();

            Console.WriteLine("Ingresa tu nombre: ");
            Carlos.name = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            Carlos.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola {0}, tu edad es {1}", Carlos.name, Carlos.age);
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Persona
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
