—---------------------------EMPLEADOS—----------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal class Empleados:INomina,IVentas
    /* Atributos
    -Nombre
    -Sueldo
    -Puesto */
    {
        string nombre = " ";
        float sueldos = 0;
        string puesto = " ";

        //generar propiedades para leer y escribir
        public string Name
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Sueldos
        {
            get { return sueldos; }
            set { sueldos = value; }
        }
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        //inicializa constructores
        public Empleados()
        {
        }
        public Empleados(string n, float s,string p)
        {
            nombre = n;
           sueldos = s;
            puesto = p;
        }
        //Metodo(s)
        public virtual void Imprime()
        {
            Console.WriteLine("\t Sus Datos Son los siguientes");
            Console.WriteLine("Empleado: {0} \nSueldo: {1} \nPuesto: {2} ", nombre, sueldos, puesto);
        }
    }
}






—----------------------------------Vendedores—-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal class Vendedores:Empleados
    /*atributos
    -Comisión
    -Auto 
     */
    {
        float comisión = 0;
        string auto = " ";
        //generar propiedades para leer y escribir
        public string Auto
        {
            get { return auto; }
            set { auto = value; }
        }
        public float Comisión
        {
            get { return comisión; }
            set { comisión = value; }
        }
        //inicializa constructores
        public Vendedores():base()
        {
        }
        public Vendedores(string a, float c, string n, float s, string p) :base(n,s,p)
        {
            comisión = c;
            auto = a;
        }
        //Metodo(s)
        public override void Imprime()
        {
            Console.WriteLine("\t VENDEDOR");
            base.Imprime();
            Console.WriteLine("Comisión: {0} \nAuto: {1}",comisión,auto);
        }
    }
}


—------------------------------Administrativos—-------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal class Administrativos:Empleados
        /*
        - Oficina
        - Turno
         */
    {
        string oficina=" ";
        string turno=" ";
        //generar propiedades para leer y escribir
        public string Oficina
        {
            get { return oficina; }
            set { oficina = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        //inicializa constructores
        public Administrativos() : base()
        {
        }
        public Administrativos(string o, string t, string n, float s, string p) : base(n, s, p)
        {
            oficina = o;
            turno = t;
        }
        //Metodo(s)
        public override void Imprime()
        {
            Console.WriteLine("\t ADMINISTRATIVO");
            base.Imprime();
            if(turno == "m")
            {
                turno = "Matutino";
            }
            else if(turno == "v")
            {
                turno = "Vespertino";
            }
            Console.WriteLine("Oficina: {0} \nTurno: {1}", oficina, turno);
        }
    }
}


—-----------------------INomina—-----------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal interface INomina
    {
        void Imprime();
    }
}

—---------------------------Nomina—--------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
/*Atributos
  -Tipo de nomina
*/
{
    internal class Nomina : INomina
    {
        string tpoNom = " ";
        double nomina = 0;

        //Generar propiedades parra leer y escribir
        public string TpoNom
        {
            get { return tpoNom; }
            set { tpoNom = value; }
        }
        public double CNomina
        {
            get { return nomina; }
            set { nomina = value; }
        }
        //Generar constructores vacio y sobrecargado de datos
        public Nomina() { }
        public Nomina(string tn)
        {
            tpoNom = tn;
        }
        //Metodos
        public void Calcular()
        {
            //DECLARAR VARIABLES
            double sdodia = 0, nomina = 0;
            // DECLARAR VECTORES
            int TN = 0;

            if (tpoNom == "semanal")
            {
                TN = 7;
            }
            else if (tpoNom == "quincenal")
            {
                TN = 15;
            }
            double[] Tnomina = new double[TN];

            // ALMACENAR EL VECTOR

            for (int i = 0; i < TN; i++)
            {
                Console.Write("Dame sueldo diario {0}: ", i + 1);
                sdodia = int.Parse(Console.ReadLine());
                Tnomina[i] = sdodia;
                Console.Clear();//Limpiar pantalla
            }

            for (int i = 0; i < TN; i++)
            {
                sdodia = Tnomina[i];
                nomina = nomina + sdodia;
            }
        }
        public void Imprime()
        {
            //IMPRIME DATOS 
            Console.WriteLine("Tipo de nomina: {0}", tpoNom);
            Console.WriteLine("Total de la nomina: {0}", nomina);
        }
    }
}


—----------------IVentas—----------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal interface IVentas
    {
        void Imprime();
    }
}

—-------------Ventas—---------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaU5Objetos
{
    internal class Ventas : IVentas
    {
        // Atributo Ventas
         string tpventas = " ";
        double ventas = 0;
        //Propiedades Para leer y escribir
        public string TVnts
        {
            get { return tpventas; }
            set { tpventas = value; }
        }
        public double CVentas
        {
            get { return ventas; }
            set { ventas = value; }
        }
        //inicializar constructores
        //por defecto
        public Ventas(){}
        //Sobrecargado de datos
        public Ventas(string v)
        {
            tpventas = v;
        }
        //metodo
        public void Calcular()
        {
            //DECLARAR VARIABLES
            double vntdia = 0;
            // DECLARAR VECTORES
            int TV = 0;

            if (tpventas == "semanal")
            {
                TV = 7;
            }
            else if (tpventas == "quincenal")
            {
                TV = 15;
            }
            double[] Tventas = new double[TV];

            // ALMACENAR EL VECTOR

            for (int i = 0; i < TV; i++)
            {
                Console.Write("Ingresa ventas diarias {0}: ", i + 1);
                vntdia = int.Parse(Console.ReadLine());
                Tventas[i] = vntdia;
                Console.Clear();//Limpiar pantalla
            }
            for (int i = 0; i < TV; i++)
            {
                vntdia = Tventas[i];
                ventas = ventas + vntdia;
            }
        }
        public void Imprime() 
        {
            //IMPRIME DATOS 
            Console.WriteLine("Tipo de nomina: {0}", tpventas);
            Console.WriteLine("Total de la nomina: {0}", ventas);
        }
    }
}


—---------------------------------Program—------------------------------------------------

using System;

namespace EvaU5Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc2 = 0; Boolean ban = false;
            do
            {
                try
                {
                    //Mensaje de bienvenida
                    Console.WriteLine("Bienvenido(a) al programa de registro de empleados");
                    Console.WriteLine("\t Para continuar presione enter");
                    Console.ReadKey();//Esperar que el usuario inicie el programa
                    Console.Clear();//Limpiar pantalla
                    do
                    {
                        Console.WriteLine("Que tipo de empleado desea regsitrar");
                        Console.WriteLine("\t OPCIONES \n\t1.Administrativo \n\t2.Vendedor");
                        Console.Write("------> ");
                        opc = int.Parse(Console.ReadLine());
                        //Registrar tipo de empleado Administrativo
                        if (opc == 1)
                        {
                            int opc1 = 0;
                            Administrativos administrativos = new Administrativos();
                            Console.Write("Ingrese nombre del empleado administrativo: ");//Peedir nombre del empleado admi
                            administrativos.Name = Console.ReadLine();
                            Console.Write("Ingrese sueldo del empleado {0}: ", administrativos.Name);//pedir sueldo del empleado admi
                            administrativos.Sueldos = float.Parse(Console.ReadLine());
                            Console.Write("Ingrese puesto del empleado {0}: ", administrativos.Name);//pedir puesto del empleado administrativo
                            administrativos.Puesto = Console.ReadLine();
                            Console.Write("Ingrese Oficina de {0}: ", administrativos.Name);//pedir oficina del empleado administrativo
                            administrativos.Oficina = Console.ReadLine();
                            Console.Write("Ingrese turno de trabajo del empleado {0}: ", administrativos.Name);//Pedir turno del empleado
                            Console.WriteLine("\n\tOPCIONES \n\t1.Matutino ingrese(m)\n\t2.Vespertino ingrese(v)");
                            Console.Write("------> ");
                            administrativos.Turno = Console.ReadLine();
                            if (administrativos.Turno == "m")
                            {

                            }
                            else if (administrativos.Turno == "v")
                            {

                            }
                            else
                            {
                                throw new ArgumentException();
                            }
                            Console.WriteLine("Desea calcular una nomina del empleado {0} : \n 1. si \n 2. no", administrativos.Name);
                            Console.Write("------> ");
                            opc1 = int.Parse(Console.ReadLine());
                            if (opc1 == 1)
                            {
                                //Crear objeto nomina
                                Nomina nomi = new Nomina();
                                Console.WriteLine("Ingrese tipo de nomina: ");
                                Console.WriteLine("\t OPCIONES\n\t1.Semanal ingrese (semanal)\n\t2.Quincenal ingrese(quincenal)");
                                Console.Write("------> ");
                                nomi.TpoNom = Console.ReadLine();
                                if (nomi.TpoNom == "semanal") { }
                                else if (nomi.TpoNom == "quincenal") { }
                                else
                                {
                                    throw new ArgumentException();
                                }
                                Console.Clear();//limpiar pantalla
                                nomi.Calcular();
                                administrativos.Imprime();
                                nomi.Imprime();
                                Console.ReadKey(); Console.Clear();
                            }
                            else if (opc1 == 2)
                            { administrativos.Imprime(); }
                        }

                        else if (opc == 2)
                        {
                            int opc1 = 0;
                            Vendedores vendedores = new Vendedores();
                            Console.Write("Ingrese nombre del empleado de ventas: ");//Peedir nombre del empleado vnt
                            vendedores.Name = Console.ReadLine();
                            Console.Write("Ingrese sueldo del empleado {0}: ", vendedores.Name);//pedir sueldo del empleado vnt
                            vendedores.Sueldos = float.Parse(Console.ReadLine());
                            Console.Write("Ingrese puesto del empleado {0}: ", vendedores.Name);//pedir puesto del empleado vnt
                            vendedores.Puesto = Console.ReadLine();
                            Console.Write("Ingrese la comisión del empleado {0} :", vendedores.Name);//pedir comision del empleado vnt
                            vendedores.Comisión = float.Parse(Console.ReadLine());
                            Console.Write("Ingrese el auto de trabajo del empleado {0}: ", vendedores.Name);//registrar auto del empleado de vnt
                            vendedores.Auto = Console.ReadLine();
                            Console.WriteLine("Desea calcular las ventas del empleado {0} : \n 1. si \n 2. no", vendedores.Name);
                            Console.Write("------> ");
                            opc1 = int.Parse(Console.ReadLine());
                            if (opc1 == 1)
                            {
                                //Crear objeto ventas
                                Ventas vent = new Ventas();
                                Console.WriteLine("Ingrese tipo de Ventas: ");
                                Console.WriteLine("\t OPCIONES\n\t1.Semanal ingrese (semanal)\n\t2.Quincenal ingrese(quincenal)");
                                Console.Write("------> ");
                                vent.TVnts = Console.ReadLine();
                                Console.Clear();//limpiar pantalla
                                vent.Calcular();
                                vendedores.Imprime();
                                vent.Imprime();
                                Console.ReadKey(); Console.Clear();
                            }
                            else if (opc1 == 2)
                            {
                                vendedores.Imprime();
                            }
                            else { throw new ArgumentException(); }
                        }
                        else { throw new ArgumentException(); }
                        Console.WriteLine("Desea registrar otro empleado: 1. si / 2. no");
                        Console.Write("Ingrese su respuesta aqui: ");
                        opc2 = int.Parse(Console.ReadLine());
                        if (opc2 == 2)
                        {
                            Console.Clear();
                        }
                    } while (opc2 == 1);
                    ban = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\t Lo siento ocurrio un erro, Argumento invalido");
                }
                catch (OverflowException id)
                {
                    Console.WriteLine(id.Message);
                }
                catch (FormatException id)
                {
                    Console.WriteLine(id.Message);
                }
                catch (Exception id)
                {
                    Console.WriteLine(id.Message);
                }
                Console.ReadKey();

            } while (ban == false);

        }
    }
}