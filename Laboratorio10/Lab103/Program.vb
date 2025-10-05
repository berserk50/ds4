Imports System

Module peso
    Sub Main()
        'Declaracion de variables
        Dim M As Double
        Dim g As Double
        Dim P As Double

        'ingresar varlores para las variables

        g = 9.8
        Console.Write("Ingrese la masa del objeto:")
        M = Console.ReadLine

        'Realizar procesos

        P = M * g

        'mostrar los resultados
        Console.WriteLine("Peso del objeto:{0}", P)
        Console.ReadKey()
    End Sub
End Module
