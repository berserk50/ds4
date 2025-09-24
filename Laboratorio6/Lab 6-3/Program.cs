internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] myNumber = { 1, 2, 3 };
            Console.WriteLine(myNumber[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Algo salio mal, valido el indice del arreglo");

        }
        finally
        {
            Console.WriteLine("Continuacion de la aplicacion, luego del bloque try/catch");
        }
    }
}