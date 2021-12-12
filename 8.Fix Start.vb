Module Module1

    Sub Main()
        'Declaration
        Dim s, str2, str1 As String
        Dim i As Integer
        Dim replacechar, thischar, fchar As Char

        'Initialization
        s = ""
        str1 = ""
        str2 = ""
        i = 0
        replacechar = "*"
        thischar = ""
        fchar = ""

        'Input Prompt
        Console.Write("Enter a string: ")
        str1 = Console.ReadLine()

        'Processing Request
        str1 = LCase(str1)
        fchar = Left(str1, 1)
        str2 = fchar

        For i = 2 To Len(str1)
            thischar = Mid(str1, i, 1)
            If thischar = fchar Then
                thischar = replacechar
            End If
            str2 = str2 & thischar
        Next

        'Output Desired Result
        Console.WriteLine("New string will be: " & str2)
        Console.ReadKey()
    End Sub

End Module
