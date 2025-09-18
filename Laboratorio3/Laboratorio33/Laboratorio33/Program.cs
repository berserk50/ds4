internal class Program
{
    private static void Main(string[] args)
    {
        int altura, ancho,perimetro;

        Console.WriteLine("Ingrese la altura del rectangulo ");
        altura = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del rectangulo");
        ancho= Convert.ToInt32(Console.ReadLine());

        perimetro = CalculoMatematico.CalcularPerimetro(altura, ancho);

        Console.WriteLine("El perimetro del rectangulo es {0}", perimetro);
    }

    public class CalculoMatematico
    {

        public static int CalcularPerimetro(int altura, int ancho) 
        {

            return 2 * (altura + ancho);
        
        
        }
    
    
    }
}