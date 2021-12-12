Module Module1

    Sub Main()
        'Declaration
        Dim str1, str2, replacestr, endstr As String
        Dim i, find1, find2 As Integer

        'Initialization
        str1 = ""
        str2 = ""
        replacestr = ""
        endstr = ""
        find1 = 0
        find2 = 0
        i = 0

        'Input Prompt
        Console.Write("Enter a Phrase: ")
        str1 = Console.ReadLine()

        'Processing Request
        str1 = LCase(str1)
        find1 = InStr(str1, "not")
        find2 = InStr(find1 + 3, str1, "bad")
        replacestr = Mid(str1, find1, find2)
        str2 = Mid(str1, 1, find1 - 1)
        endstr = Mid(str1, find2 + 3, Len(str1))

        'Locating "not...bad" string
        For i = 1 To Len(str1)
            If find2 > find1 And find2 > 0 And find1 > 0 Then
                replacestr = "good"
            End If
        Next

        'Replacing "not...bad" with "good"
        If replacestr = "good" Then
            str2 = str2 & replacestr & endstr
        Else : str2 = str1
        End If

        'Output Desired Results
        Console.WriteLine("New Phrase is : " & str2)
        Console.ReadKey()

    End Sub

End Module
