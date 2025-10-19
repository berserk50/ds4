internal class Program
{
    private static void Main(string[] args) 
    {

        int n = 11;
        int[,] patron = new int[n,n];
        int suma = 0;

        //miarray.length
        //miarray[].length

        Random random = new Random();

        for (int i = 0; i < n ; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i == 0) || (i == n-1) || (j == n/2)){
                    int numeroAleatorio = random.Next(101, 200);
                    patron[i,j] = numeroAleatorio;
                    Console.Write(patron[i, j] + "\t");
                    suma = suma + patron[i, j];
                }
                else
                    Console.Write(patron[i,j] + "\t");
            }

            Console.WriteLine();
        }


        Console.WriteLine(suma);
        
    }
}