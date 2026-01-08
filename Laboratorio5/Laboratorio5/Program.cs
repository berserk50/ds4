internal class Program
{
    private static void Main(string[] args)
    {
        sueldos = new int[6]; //Inicializamos el vector 5

        for (int f = 0; f < 6; f++)
        {
            Console.WriteLine("Ingrese sueldo del operario" + f + ":");
            string linea;
            linea= Console.ReadLine();
            sueldos[f]; int.Parse(linea);//Asignamos los 5 sueldo al vector
       
        }
    }

    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.WriteLine("[]" + sueldos[f] + "]");
        }

        Console.ReadKey();
    
    }

    static void main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir;
    
    }
}