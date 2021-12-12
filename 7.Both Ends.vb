Module Module1

    Sub Main()
        'Declaration
        Dim s, str1 As String

        'Initialization
        s = ""
        str1 = ""

        'Input Prompt
        Console.Write("Enter a string : ")
        s = Console.ReadLine

        'Processing Request
        If Len(s) > 2 Then
            str1 = Left(s, 2) & Right(s, 2)
        Else : Console.WriteLine(s)
        End If

        'Output Desired Results
        Console.WriteLine(str1)

        Console.ReadKey()
    End Sub

End Module
