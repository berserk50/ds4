using Laboratorio7;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco   banco1 = new Banco();
        banco1.Operador();
        banco1.DepositosTotales();
        Console.ReadKey();
    }
}