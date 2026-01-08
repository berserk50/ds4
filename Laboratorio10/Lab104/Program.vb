Imports System

Module Program
    Public Sub Main(args As String())
        Dim perrito As Perro = New Perro()
        perrito.nombre = "chizu"
        perrito.raza = "Pastor aleman"
        perrito.altura = "0.70 cm"

        Console.WriteLine(perrito.comer("carne"))

        Dim perrito2 As Perro = New Perro()
        perrito.nombre = "Lasy"
        perrito.altura = "0.60 cm"

        Console.WriteLine(perrito2.comer("pollo"))

        Dim perrito3 As Perro = New Perro("Pelucin", "Poodle", "0.50")

        Console.WriteLine(perrito3.comer("Pan"))

    End Sub
End Module
