//Declarar variables

int Numero = 0;

Console.Write("Ingrese un numero: ");
Numero = int.Parse(Console.ReadLine());
if (Numero >= 1)
{
    Console.WriteLine("Su número {0} es positivo", Numero);
}
else if (Numero <= 0)
{
    Console.WriteLine("Su número {0} es negativo", Numero);
}
Console.ReadKey();
