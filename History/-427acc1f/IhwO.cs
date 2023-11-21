—------------------------------------------------Principal—--------------------------------------------------------
using System;

namespace P7.Herencia_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0,opc1=0;
            do
            {
                try
                {
                    // Menu de Opciones

                    Console.WriteLine("Desea trabajar con \n 1.Alumnos \n 2. docente \n 3. salir");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1) //captura datos del alumno
                    {
                        // Crea Objeto Alumno
                        Alumno alumno = new Alumno();
                        Console.Write("Cual es su nombre : ");
                        // Captura datos de la clase padre (Persona)
                        alumno.Name = Console.ReadLine();
                        Console.Write("Cual es su edad : ");
                        alumno.Age = int.Parse(Console.ReadLine());
                        // Captura datos de la clase hija (Alumno)
                        Console.Write("Que semestre esta cursando: ");
                        alumno.Semestre = int.Parse(Console.ReadLine());
                        Console.Write("Cual es su Promedio : ");
                        alumno.Promedio = float.Parse(Console.ReadLine());
                        alumno.Alum();//imprime metodo
                    }
                    if (opc == 2) //captura datos del alumno
                    {
                        // Crea Objeto Alumno
                        Docente docente = new Docente();
                        Console.Write("Cual es su nombre : ");
                        // Captura datos de la clase padre (Persona)
                        docente.Name = Console.ReadLine();
                        Console.Write("Cual es su edad : ");
                        docente.Age = int.Parse(Console.ReadLine());
                        // Captura datos de la clase hija (Alumno)
                        Console.Write("Que materia esta impartiendo: ");
                        docente.Materia = Console.ReadLine();
                        Console.Write("que grupo atiende: ");
                        docente.Grupos = int.Parse(Console.ReadLine());
                        docente.Docent();//imprime metodo
                    }
                }
                catch (IndexOutOfRangeException id)
                {
                    Console.WriteLine(id.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lo siento, currio un error de formato");

                }
                catch (OverflowException id)
                {
                    Console.WriteLine(id);
                    Console.WriteLine("El error que ocurrio es: {0}", id.Message);
                }
                Console.WriteLine("Desea repetir el programa : 1.si / 2.no  ");
                opc1 = int.Parse(Console.ReadLine());
                if (opc1==0)
                {
                    Console.Clear();
                }
            } while(opc1==1);
        }
    }
}

—---------------------------------------------Persona---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.Herencia_Persona
{
    internal class Persona
    {
        string nombre=" ";
        int edad=0;

        //define propiedades para poder leer y escribir

        public string Name
        {
            get { return nombre; }//Propiedad leer

            set { nombre = value; }//Propiedad escribir
        }
        public int Age
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
        public void pers()
        {
            Console.WriteLine("Nombre:{0} \nEdad: {1}",nombre, edad);
        }

    }
}

—-------------------------------------------------Estudiante-------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.Herencia_Persona
{
    internal class Alumno:Persona
    {
        //atributos (privados por default )
        int semestre = 0;
        float promedio =0;

        //define propiedades para poder leer y escribir

        public int Semestre
        {
            get { return semestre; }//Propiedad leer

            set { semestre = value; }//Propiedad escribir
        }
        public float Promedio
        {
            get { return promedio; }//propiedad leer

            set { promedio = value; }//Propiedad Escribir
        }
        // Inicializa Constructores

        //Por defecto
        public Alumno():base()
        {
        }
        //constructor sobrecargado con datos
        public Alumno (string n, int e, int s, float p) : base (n,e)
        {
            semestre = s;
            promedio = p;
        }
        //Definir metodos de la clase
        public void Alum()
        {
            Console.WriteLine("usted es alumno y sus datos son los siguientes");
            pers();
            Console.WriteLine("Semestre:{0} \nPromedio: {1}", semestre, promedio);
        }

    }
}

—-------------------------------------------Docente------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.Herencia_Persona
{
    internal class Docente : Persona
    {
        string materia=" ";
        int grupos=0;

        //define propiedades para poder leer y escribir

        public string Materia
        {
            get { return materia; }//Propiedad leer

            set { materia = value; }//Propiedad escribir
        }
        public int Grupos
        {
            get { return grupos; }//propiedad leer

            set { grupos = value; }//Propiedad Escribir
        }
        // Inicializa Constructores

        //Por defecto
        public Docente() : base()
        {
        }
        //constructor sobrecargado con datos
        public Docente(string n,int e ,string m, int g) : base(n,e)
        {
            materia = m;
            grupos = g;
        }
        //Definir metodos de la clase
        public void Docent()
        {
            Console.WriteLine("usted es docente y sus datos son los siguientes");
            pers();
            Console.WriteLine("Materia:{0} \nGrupos: {1}", materia, grupos);
        }
    }
}
