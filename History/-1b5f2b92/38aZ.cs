—-------------------------------------------------Principal----------------------------------------------------------
using System;

namespace P8._Polimorfismo_figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc1 = 0;
            do
            {
                try
                {
                    // Menu de Opciones

                    Console.WriteLine("Que figura desea registrar \n 1. Rectangulo \n 2. Cuadrado");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1) //captura datos
                    {
                        // Crea Objeto 
                        Rectangulo rect = new Rectangulo();
                        Console.WriteLine("Desea calucular: \n 1. Area (ingrese area) \n 2. Perimetro (ingrese perimetro)");
                        rect.Name = Console.ReadLine();
                        // Captura datos de la clase padre 
                        Console.WriteLine("Ingrese el color de la figura: ");
                        rect.Color = Console.ReadLine();
                        //capturar datos de la clase hija
                        Console.Write("Ingrese la medida de base en cm: ");
                        rect.Lbase = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la medida de altura en cm: ");
                        rect.Laltura = int.Parse(Console.ReadLine());
                        rect.Imprime();
                    }
                    else if (opc == 2) //captura datos
                    {
                        // Crea Objeto 
                        Cuadrado cdrd = new Cuadrado();
                        Console.WriteLine("Desea calucular: \n 1. Area (ingrese area) \n 2. Perimetro (ingrese perimetro)");
                        cdrd.Name = Console.ReadLine();
                        // Captura datos de la clase padre 
                        Console.WriteLine("Ingrese el color de la figura: ");
                        cdrd.Color = Console.ReadLine();
                        //capturar datos de la clase hija
                        Console.Write("Ingrese la medida de un lado en cm: ");
                        cdrd.Lado = int.Parse(Console.ReadLine());
                        cdrd.Imprime();
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
                if (opc1 == 1)
                {
                    Console.Clear();
                }
            } while (opc1 == 1);
        }
    }
}
—-------------------------------------------------Figuras-------------------------------------------------------—--
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._Polimorfismo_figuras
{
    internal class Figuras
    {
        string nombre = " ";
        string color = " ";
        //propiedades para leer y escribir
        public string Name
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        // Inicializa Constructores

        //Por defecto
        public Figuras()
        {
        }
        //constructor sobrecargado con datos
        public Figuras(string n, string c)
        {
            nombre = n;
            color = c;
        }
        //Definir metodos de la clase
        public virtual void Imprime()
        {
            Console.WriteLine("Los datos de su figura son");
            Console.WriteLine("Nombre:{0} \ncolor: {1}", nombre, color);
        }
    }
}
-----------------------------------------------Cuadrado-------------------------------------------------------—----
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._Polimorfismo_figuras
{
    internal class Cuadrado : Figuras
    {
        int lado = 0;
        //propiedades para leer y escribir
        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        // Inicializa Constructores

        //Por defecto
        public Cuadrado() : base()
        {
        }
        //constructor sobrecargado con datos
        public Cuadrado(string n, string c, int l) : base(n, c)
        {
            lado = l;
        }
        //Definir metodos de la clase
        public override void Imprime()
        {
            if (Name == "area")
            {
                int pc = 0;
                pc = lado * 4;
                base.Imprime();
                Console.WriteLine("El perimetro de su cuadrado es: {0}", pc);
            }
            else if (Name == "perimetro")
            {
                int Ac = 0;
                Ac = lado * lado;
                base.Imprime();
                Console.WriteLine("El Area de su cuadrado es: {0}", Ac);
            }
        }
    }
}
---------------------------------------------Rectangulo-------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8._Polimorfismo_figuras
{
    internal class Rectangulo:Figuras
    {
        int lbase = 0;
        int laltura = 0;
        //propiedades para leer y escribir
        public int Lbase
        {
            get { return lbase; }
            set { lbase = value; }
        }
        public int Laltura
        {
            get { return laltura; }
            set { laltura = value; }
        }
        // Inicializa Constructores

        //Por defecto
        public Rectangulo() : base()
        {
        }
        //constructor sobrecargado con datos
        public Rectangulo(string n, string c, int lb, int la) : base(n, c)
        {
            lbase = lb;
            laltura = la;
        }
        //Definir metodos de la clase
        public override void Imprime()
        {
            if (Name == "area")
            {
                int pr = 0;
                pr = (lbase + laltura) * 2;
                base.Imprime();
                Console.WriteLine("El perimetro de su rectangulo es: {0}", pr);
            }
            else if (Name == "perimetro")
            {
                int Ar = 0;
                Ar = lbase * laltura;
                base.Imprime();
                Console.WriteLine("El Area de su rectangulo es: {0}", Ar);
            }
        }
    }
}
