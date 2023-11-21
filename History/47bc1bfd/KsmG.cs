
—------------------------------------------------Principal—-------------------------------------------------------
using System;

namespace P8._PolIntPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc2 = 0;
            bool band = false;
            do
            {
                do
                {
                    try
                    {

                        Console.WriteLine(" Capturar datos de: \n 1. Alumno \n 2. Docente \n 3.Proveedor");
                        Console.Write(" Ingrese opcion: ");
                        opc = int.Parse(Console.ReadLine());

                        if (opc == 1) //captura datos del alumo

                        {
                            //Crea Objeto Alumno
                            Alumno Alumno = new Alumno();
                            Console.Write("\n Ingresa nombre: ");
                            //Captura datos de la clase padre (Persona)
                            Alumno.Nom = Console.ReadLine();
                            Console.Write(" Ingresa edad: ");
                            Alumno.Ed = int.Parse(Console.ReadLine());
                            //Captura datos de la clase hija (Alumo)
                            Console.Write(" Semestre cursado: ");
                            Alumno.sem = int.Parse(Console.ReadLine());
                            Console.Write(" Promedio: ");
                            Alumno.prom = float.Parse(Console.ReadLine());

                            Console.Clear();
                            Alumno.Imprime();
                        }

                        else if (opc == 2)
                        {
                            //Crea Objeto Docente
                            Docente imDocente = new Docente();
                            Console.Write("\n Ingresa nombre: ");
                            imDocente.Nom = Console.ReadLine();
                            Console.Write(" Ingresa edad: ");
                            imDocente.Ed = int.Parse(Console.ReadLine());
                            Console.Write(" Ingrese materia que imparte: ");
                            imDocente.mat = Console.ReadLine();
                            Console.Write(" Grupos asignados: ");
                            imDocente.gru = int.Parse(Console.ReadLine());

                            Console.Clear();
                            imDocente.Imprime();
                        }

                        else if (opc == 3)
                        {
                            Proveedores pr = new Proveedores();
                            Console.Write("\n Ingresa nombre de la empresa: ");
                            pr.Pro = Console.ReadLine();
                            Console.Write(" Dirección: ");
                            pr.Dir = Console.ReadLine();
                            Console.ReadKey();
                            Console.Clear();
                            pr.Imprime();



                        }
                        Console.WriteLine("\n\n Desea capturar otros datos?: \n 1. Si \n 2. No");
                        Console.Write(" Ingrese opcion: ");
                        opc2 = int.Parse(Console.ReadLine());
                        if (opc2 == 1)
                        {
                            Console.Clear();
                        }
                        band = true;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\n\t Ocurrio un error de formato:( ");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("\n\t Favor de ingresar un numero valido ");

                    }

                    catch
                    {
                        Console.WriteLine("\n\t Ha ocurrido un error ");

                    }


                } while (band == false);


            } while (opc2 == 1);

            Console.ReadKey();
        }
    }
}
—------------------------------------------------Persona—---------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._PolIntPersona
{
    internal class Persona:IDepliega
    {
        string nombre = "";
        int edad = 0;

        public string Nom
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Ed
        {
            get { return edad; }
            set { edad = value; }
        }

        public Persona()
        {
        }

        public Persona(string n, int e)
        {
            nombre = n;
            edad = e;
        }
        public virtual void Imprime()
        {
            Console.WriteLine("\n Nombre:{0} \n Edad: {1}", nombre, edad);
        }
    }
}
—------------------------------------------------Alumno—-------------------------------------------------------—
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._PolIntPersona
    {
    internal class Alumno:Persona
    {
        int semestre = 0;
        float promedio = 0;

        public int sem
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public float prom
        {
            get { return promedio; }
            set { promedio = value; }
        }



        public Alumno() : base()
        {

        }

        public Alumno(string n, int e, int s, float p) : base(n, e)
        {
            semestre = s;
            promedio = p;
        }
        public override void Imprime()
        {

            Console.WriteLine(" Usuario: ALUMNO \n \tDatos del alumno: ");
            base.Imprime();
            Console.WriteLine(" \n Estudiando el semestre {0} ", semestre);
            Console.WriteLine(" Promedio: {0} ", promedio);
        }
    }
}
----------------------------------------------------Docente—--------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._PolIntPersona
{
    internal class Docente:Persona
    {
        string materia = "";
        int grupos = 0;


        public string mat
        {
            get { return materia; }//leer
            set { materia = value; } //escribir
        }
        public int gru
        {
            get { return grupos; }//leer
            set { grupos = value; } //escribir
        }

        public Docente() : base()
        {

        }

        public Docente(string n, int e, string m, int g) : base(n, e)
        {
            materia = m;
            grupos = g;
        }

        public override void Imprime()
        {

            Console.WriteLine(" Usuario: DOCENTE \n \tDatos del docente ");
            base.Imprime();
            Console.WriteLine("\n Materia impartida: {0} ", materia);
            Console.WriteLine(" Grupos asignados: {0}", grupos);
        }
    }
}
----------------------------------------------------Proveedores—--------------------------------------------------using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._PolIntPersona
{
    internal class Proveedores: IDepliega
    {
        string proveedor = "", direccion = " ";

        public string Pro
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public string Dir
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Proveedores()
        {

        }
        public Proveedores(string p, string d)
        {
            proveedor = p;
            direccion = d;

        }
        public void Imprime()
        {
            Console.WriteLine("\t PROVEEDOR");
            Console.WriteLine("\n Empresa {0}", proveedor);
            Console.WriteLine(" Direccion {0}", direccion);
        }
    }
}
----------------------------------------------------IDespliega------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._PolIntPersona
{
    internal interface IDepliega
    {
        void Imprime();
    }
}