internal class Program
{
    private static void Main(string[] args)
    {
        double ladoInferior1 = 0;
        double ladoInferior2 = 0;
        double ladoSuperior = 0;
        Boolean verificarSumaInferior = false;

        while (verificarSumaInferior == false)
        {
            Console.WriteLine("Ingrese el lado inferior 1");
            ladoInferior1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado inferior");
            ladoInferior2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado superior");
            ladoSuperior = double.Parse(Console.ReadLine());

            if (ladoInferior1 + ladoInferior2 > ladoSuperior)
            {
                verificarSumaInferior = true;

            }
            else { Console.WriteLine("Vuelva a ingresar los datos"); }
        }
        if ((ladoInferior1 == ladoSuperior) && (ladoInferior2 == ladoInferior1))
        {
            Console.WriteLine("El triangulo es equilatero");
        }
        else if ((ladoInferior1 != ladoInferior2) && (ladoInferior1 != ladoSuperior))
        {
            Console.WriteLine("el triangulo es escaleno");
        }

        else
        {
            Console.WriteLine("El triangulo es isosceles");
        }
    }
}