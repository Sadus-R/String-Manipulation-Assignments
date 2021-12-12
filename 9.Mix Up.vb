Module Module1

    Sub Main()
       'Declaration
        Dim a, b, word1, word2 As String

        'Initialization
        a = ""
        b = ""
        word1 = ""
        word2 = ""

        'Input Prompt
        Console.Write("Enter First Word : ")
        a = Console.ReadLine()

        Console.Write("Enter Second String : ")
        b = Console.ReadLine()

        'Proccesing Request
        word1 = Left(b, 2) & Mid(a, 3, Len(a))
        word2 = Left(a, 2) & Mid(b, 3, Len(b))

        'Output Desired Result
        Console.WriteLine("New String is : " & word1 & " " & word2)
        Console.ReadKey()

    End Sub

End Module
