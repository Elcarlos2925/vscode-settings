using System;

namespace P5.Alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            Alumnos Alum = new Alumnos ();

            //Ingresar datos
            Console.Write("Ingrese su número de control: ");
            Alum.Num_control = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su nombre: ");
            Alum.Nombre= Console.ReadLine();

            Console.Write("Ingrese el semestre que esta cursando: ");
            Alum.Semestre=int.Parse(Console.ReadLine());

            Console.Write("Ingrese su carrera: ");
            Alum.Carrera= Console.ReadLine();

            //Almacenar vector
            for (int i=0;i<Alum.cal.Length;i++)
            {
                Console.Write("Ingrese su calificación {0}: ",i+1);
                Alum.cal[i] = float.Parse(Console.ReadLine());
            }

            Console.Clear();

            //Imprimir datos
            Console.WriteLine("DATOS\n");

            Console.WriteLine("Carrera: {0} \t Semestre: {1} ",Alum.Carrera,Alum.Semestre);
            Console.WriteLine("NumControl: {0} \t Nombre: {1}", Alum.Num_control, Alum.Nombre);
            for (int i = 0; i < Alum.cal.Length; i++)
            {
                Console.WriteLine("Calificación {0}: {1} ", i + 1, Alum.cal[i]);
            }
            Alum.Promedio();
            Console.ReadKey();

            /*declare la clase Alumnos, tendrá como atributos numero de control, nombre, semestre, carrera,
     * calificaciones (vector de 3 calificaciones), debe de calcular promedio*/
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5.Alumnos
{
    internal class Alumnos
    {
        int num_cont;
        int semestre;
        string nombre;
        string carrera;
        float[] calificaciones = new float[3];

        //Define propiedades para leer y escribir
        public int Num_control
        {
            get { return num_cont; }
            set { num_cont = value; }
        }
        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public float[] cal
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }

        // inicializa constructores
        public Alumnos()
        {
        }
        //constructor sobrecargado con datos
        public Alumnos(int NC, int sem, string carr, string name, float[] calif)
        {
            Num_control = NC;
            Semestre = sem;
            Carrera = carr;
            Nombre = name;
            calificaciones = calif;
        }
        //Definir metodos
        public void Promedio()
        {
            float prom = 0, suma = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                suma = suma + calificaciones[i];
            }
            prom = suma / 3;
            Console.WriteLine("Promedio: {0}", prom);
        }
    }
}
