using Lab95;

internal class Program
{
    private static void Main(string[] args)
    {

        Aleatorios aleatorios = new Aleatorios();
        int[] arrayNoRept = aleatorios.GenerarNoRepetido();
        for (int i = 0; i < arrayNoRept.Length; i++) {
            Console.WriteLine(arrayNoRept[i]);
        }
    }
}