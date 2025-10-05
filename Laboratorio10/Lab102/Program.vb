Imports System

Module area
    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim circunfwerencia As Single
        Const pi = 3.1415926

        Console.WriteLine("Ingreese el radio")
        radio = Console.ReadLine;

        area = pi * radio ^ 2

        Console.WriteLine("El area es : {0}", area)
        Console.WriteLine("La circunferencia es : {0}", circunfwerencia);

        Console.ReadKey()

    End Sub
End Module
