Module Module1

    Sub Main()
        'Declaration
        Dim donut As Integer

        'Initialization
        donut = 0

        'Input Prompt
        Console.Write("How many Dougnuts did you eat? ")
        donut = Console.ReadLine

        'Processing Request and Output Desired Results
        If donut >= 10 Then
            Console.WriteLine("Number of Donuts : Many")
        Else : Console.WriteLine("Number of Donuts : " & donut)
        End If

        Console.ReadKey()
    End Sub

End Module
