using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double precio;
        string tipoPago;
        string numeroTarjeta;
        bool digitos = false;

        Console.WriteLine("Introduzca el precio del producto:");
        precio = double.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuál será su medio de pago: tarjeta o efectivo?");
        tipoPago = Console.ReadLine();

        if (tipoPago == "Tarjeta" || tipoPago == "TARJETA" || tipoPago == "tarjeta")
        {
            Console.WriteLine("Escriba los dígitos de su tarjeta, tomando en cuenta que deben ser 16:");
            numeroTarjeta = Console.ReadLine();

            while (digitos == false)
            {
                if (numeroTarjeta.Length == 16)
                {
                    Console.WriteLine($"{precio} {tipoPago} {numeroTarjeta}");
                    digitos = true;
                }
                else
                {
                    Console.WriteLine("El número de la tarjeta debe ser de 16 dígitos, ingrese nuevamente los dígitos:");
                    numeroTarjeta = Console.ReadLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Gracias por su compra");
        }
    }
}
