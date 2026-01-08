using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

internal class Program
{
    List<int> calificacion = new List<int> { 85, 90, 78, 92, 88 };

    int suma = 0;

    foreach (int calificacion int calificaciones)
     {
        
            suma+= calificacion;
     }

    double promedio = suma/(double)calificaciones.count;

    Console.WriteLine($"El promedio de las calificaciones es:"{ promedio});
}