using Lab94;

internal class Program
{
    private static void Main(string[] args)
    {

        Aleatorios aleatorio = new Aleatorios();
        int numeroGenerado = aleatorio.GenerarNumero();
        Console.WriteLine(numeroGenerado);


        int[] arreglo= aleatorio.GenerarArreglo();
        Console.WriteLine(arreglo.Length);
    }
}