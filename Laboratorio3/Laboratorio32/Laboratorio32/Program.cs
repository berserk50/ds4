internal class Program
{

    private static void Main(string[] args)
    {
        double a;

        Console.WriteLine("Introduce el Primer Numero: ");
        a = Convert.ToDouble(Console.ReadLine());

        /* Console.WriteLine("Introduce el segundo numero:");
         b = Convert.ToInt32(Console.ReadLine());*/

        double resultado = CalculosMatematicos.CalculoArea(a);

        Console.WriteLine("Este es el calculo matematico {0}", resultado);

    }

    public class CalculosMatematicos
    {

        /* public static int Calcular(int a, int b)
         {
             int calcular = (a + b) * (a - b);
             return calcular;
         }
         */

        public static double CalculoArea(double a)
        {
            const Double PI = 3.14;
            double radio = a;

            return PI * (radio*radio);
        }

    }

}