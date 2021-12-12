Module Module1

    Sub Main()
        Dim str1 As String
        Dim char_1, char_2, char_3 As Char
        Dim Highestcount, charCount, a, b As Integer

        str1 = ""
        char_1 = ""
        char_2 = ""
        char_3 = ""
        Highestcount = 0
        charCount = 0
        a = 0
        b = 0

        Console.Write("Enter a Sentence : ")
        str1 = Console.ReadLine

        str1 = LCase(str1)

        For a = 1 To Len(str1)
            char_1 = Mid(str1, a, 1)
            crcount = 0
            For b = 1 To Len(str1)
                char_2 = Mid(str1, b, 1)
                If char_2 = char_1 Then
                    charCount = charCount + 1
                End If
            Next
            If charCount > Highestcount Then
                Highestcount = charCount
                char_3 = char_1
            End If
        Next

        Console.WriteLine("Highest Character occurence is of " & char_3 & " " & Highestcount & " times")
        Console.ReadKey()
    End Sub

End Module

