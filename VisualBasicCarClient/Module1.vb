Imports CarLibrary

Module Module1

    Sub Main()
        Console.WriteLine("***C# CarLibrary Client App ***")

        Dim miniVan As New MiniVan()
        miniVan.TurboBust()

        Dim sportCar As New SportCar()
        sportCar.TurboBust()

        Dim dreamCar As New PerformanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBust()

        Console.ReadLine()
    End Sub

End Module
