Module Module1

    Sub Main()
        'Declaration
        Dim str1, str2, mychar, removechar, replacechar As String
        Dim count As Integer

        'Initialization
        str1 = ""
        str2 = ""
        mychar = ""
        removechar = ""
        replacechar = ""
        count = 0

        'Input Prompt
        Console.Write("Enter a String: ")
        str1 = Console.ReadLine()
        Console.Write("Enter letter to be removed: ")
        removechar = Console.ReadLine()
        Console.Write("Enter letter to replace removed character : ")
        replacechar = Console.ReadLine()

        'Processing Request
        For count = 1 To Len(str1)
            mychar = Mid(str1, count, 1)
            'Replacing Character
            If mychar = removechar Then
                mychar = replacechar
            End If
            str2 = str2 & mychar
        Next

        'Output Desired Results
        Console.WriteLine("New string is: " & str2)
        Console.ReadKey()
    End Sub

End Module
