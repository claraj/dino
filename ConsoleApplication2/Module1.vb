Module Module1

    Sub Main()
        Console.WriteLine("Dino project")
        Dim myDinosaur As New Dinosaur
        myDinosaur.name = "T-Rex"
        Console.WriteLine(myDinosaur.name)
        Console.ReadKey()

    End Sub



    Class Dinosaur

        Public name As String


    End Class

End Module
