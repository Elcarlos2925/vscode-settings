—-------------------------------------------------PRINCIPAL------------------------------------------------------
using System;

namespace P7.__Autos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc1=0;
            do
            {
                try
                {
                    // Menu de Opciones

                    Console.WriteLine("Que tipo de vehiculo desea registrar: \n 1. Carga \n 2. Transporte \n 3. Personal");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1) //captura datos
                    {
                        // Crea Objeto 
                        Carga Cg = new Carga();
                        Console.Write("Ingrese nombre : ");
                        // Captura datos de la clase padre
                        Cg.Name = Console.ReadLine();
                        Console.Write("Cual es el numero de llantas que utiliza su vehiculo: ");
                        Cg.Llantas = int.Parse(Console.ReadLine());
                        Console.Write("Cual es la marca de su vehiculo: ");
                        Cg.Marca = Console.ReadLine();
                        Console.Write("Cuantas personas pueden ingresar dentro de su vehiculo: ");
                        Cg.No_per = int.Parse(Console.ReadLine());
                        // Captura datos de la clase hija 
                        Console.Write("Cual es la capacidad maxima que puede cargar su vehiculo en kg: ");
                        Cg.Capacidad = int.Parse(Console.ReadLine());
                        Console.Write("Cuanto mide lo largo de su vehiculo en metros: ");
                        Cg.Mlargo = int.Parse(Console.ReadLine());
                        Cg.DatosCarga();//imprime metodo
                    }
                    else if (opc == 2) //captura datos
                    {
                        // Crea Objeto 
                        Transporte Tpt = new Transporte();
                        Console.Write("Ingrese nombre : ");
                        // Captura datos de la clase padre
                        Tpt.Name = Console.ReadLine();
                        Console.Write("Cual es el numero de llantas que utiliza su vehiculo: ");
                        Tpt.Llantas = int.Parse(Console.ReadLine());
                        Console.Write("Cual es la marca de su vehiculo: ");
                        Tpt.Marca = Console.ReadLine();
                        Console.Write("Cuantas personas pueden ingresar dentro de su vehiculo: ");
                        Tpt.No_per = int.Parse(Console.ReadLine());
                        // Captura datos de la clase hija 
                        /*  */
                        int opc2 = 0;
                        Console.WriteLine("Su vehiculo de transporte permite pasajeros parados \n   1. si \n    2.no");
                        opc2 = int.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            Tpt.Parados = true;
                        }
                        else if (opc == 2)
                        {
                            Tpt.Parados = false;
                        }
                        Console.WriteLine("Que tipo de gasolina usa su vehiculo de transporte: \n 1.Magna\n 2.  Premium\n   3.Disel");
                        Tpt.Tgasolina = int.Parse(Console.ReadLine());
                        Tpt.Datostransporte();//imprime metodo
                    }
                    else if (opc == 3) //captura datos
                    {
                        // Crea Objeto 
                        Personales Prs = new Personales();
                        Console.Write("Ingrese nombre : ");
                        // Captura datos de la clase padre
                        Prs.Name = Console.ReadLine();
                        Console.Write("Cual es el numero de llantas que utiliza su vehiculo: ");
                        Prs.Llantas = int.Parse(Console.ReadLine());
                        Console.Write("Cual es la marca de su vehiculo: ");
                        Prs.Marca = Console.ReadLine();
                        Console.Write("Cuantas personas pueden ingresar dentro de su vehiculo: ");
                        Prs.No_per = int.Parse(Console.ReadLine());
                        // Captura datos de la clase hija 
                        Console.Write("Cuantos cilindros tiene tu auto personal: ");
                        Prs.Cilindros = int.Parse(Console.ReadLine());
                        Console.Write("Tu auto personal es: \n 1. Automatico \n 2. Estandar");
                        Prs.MDM = int.Parse(Console.ReadLine());
                        Prs.Datospersonales();//imprime metodo
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
                if (opc1 == 0)
                {
                    Console.Clear();
                }
            } while (opc1 == 1);
        }
    }
}
—-------------------------------------------------AUTOS—---------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.__Autos
{
    internal class Autos
    {
        string nombre = "";
        int llantas = 0;
        string marca = "";
        int NumPer = 0;
        public string Name
        {
            get
            {
                return nombre;

            }
            set
            {
                nombre = value;
            }

        }
        public int Llantas
        {
            get
            {
                return llantas;

            }
            set
            {
                llantas = value;
            }

        }
        public string Marca
        {
            get
            {
                return marca;

            }
            set
            {
                marca = value;
            }

        }
        public int No_per
        {
            get
            {
                return NumPer;

            }
            set
            {
                NumPer = value;
            }

        }

        public Autos()
        {

        }
        public Autos(string nom, int llan, string mar, int NP)
        {
            nombre = nom;
            llantas = llan;
            marca = mar;
            NumPer = NP;
        }
        public void ImprimeDatos()
        {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Numero es llantas: {0}", llantas);
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Capacidad de personas dentro del vehiculo: {0}", NumPer);
        }
    }
}
—-------------------------------------------------CARGA—---------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.__Autos
{
    internal class Carga:Autos
    {
        int capacidad;
        int metrosdelargo;

        public int Capacidad
        {
            get
            {
                return capacidad;

            }
            set
            {
                capacidad = value;
            }

        }
        public int Mlargo
        {
            get
            {
                return metrosdelargo;

            }
            set
            {
                metrosdelargo = value;
            }

        }
        public Carga() : base()
        {

        }
        public Carga(string nom, int llan, string mar, int NP, int Car1, int Car2) : base(nom, llan, mar, NP)
        {
            capacidad = Capacidad;
            metrosdelargo = Mlargo;
        }
        public void DatosCarga()
        {
            ImprimeDatos();
            Console.WriteLine("Su capacidad de carga es: {0}", capacidad);
            Console.WriteLine("El metro de largo del vehiculo de carga es: {0}", metrosdelargo);
        }
    }
}
—-------------------------------------------------PERSONALES--------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.__Autos
{
    internal class Personales : Autos
    {
        int cilindros = 0;
        int ModoDeManejo = 0;

        public int Cilindros
        {
            get { return cilindros; }
            set
            {
                cilindros = value;
            }
        }
        public int MDM
        {
            get { return ModoDeManejo; }
            set { ModoDeManejo = value; }
        }
        public Personales() : base()
        {

        }
        public Personales(string n, int ll, string m, int Np, int c, int mm) : base(n, ll, m, Np)
        {
            cilindros = c;
            ModoDeManejo = mm;
        }
        public void Datospersonales()
        {
            ImprimeDatos();//imprimir datos
            Console.WriteLine("Cilindros: {0} ", cilindros);
            if (ModoDeManejo == 1)
            {
                Console.WriteLine("Modo de Manejo: Automatico");
            }
            else if (ModoDeManejo == 2)
            {
                Console.WriteLine("Modo de Manejo: Estandar");
            }
        }
    }
}
—-------------------------------------------------TRANSPORTE--------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.__Autos
{
    internal class Transporte : Autos
    {
        Boolean parados = false;
        int tgasolina = 0;

        public Boolean Parados
        {
            get { return parados; }
            set
            {
                parados = value;
            }
        }
        public int Tgasolina
        {
            get { return tgasolina; }
            set { tgasolina = value; }
        }
        public Transporte() : base()
        {

        }
        public Transporte(string n, int ll, string m, int Np, Boolean p, int tg) : base(n, ll, m, Np)
        {
            parados=p;
            tgasolina = tg;
        }
        public void Datostransporte()
        {
            ImprimeDatos();
            if(parados==false)
            {
                Console.WriteLine("Su auto de transporte no admite pasajeros parados");
            }
            else if (parados==true)
            {
                Console.WriteLine("Su auto de transporte admite pasajeros parados");
            }

            if (tgasolina == 1)
            {
                Console.WriteLine("Su tipo de gasolina es: Magna");
            }
            else if (tgasolina == 2)
            {
                Console.WriteLine("Su tipo de gasolina es: Premium");
            }
            else if (tgasolina == 3)
            {
                Console.WriteLine("Su tipo de gasolina es: Disel");
            }
        }
    }
}
