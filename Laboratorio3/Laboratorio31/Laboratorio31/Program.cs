internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;



        Console.WriteLine("Introduce el Primer Numero: ");
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero:");
        b=Convert.ToInt32(Console.ReadLine());

        double resultado = CalculosMatematicos.Calcular(a, b);

        Console.WriteLine("Este es el calculo matematico {0}" ,resultado );

    }

    public class CalculosMatematicos
    {

        public static int Calcular(int a, int b) 
        {
            int calcular= (a + b) * (a - b);
            return calcular;
        }    
    
    }

}
