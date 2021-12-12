Module Module1

    Sub Main()
        'Declaration
        Dim str1 As String
        Dim char1, thischar As Char
        Dim i, a, charcount, alphabetCount, digitcount, specialcount As Integer

        'Initialization
        str1 = ""
        char1 = ""
        thischar = ""
        i = 0
        a = 0
        charcount = 0
        alphabetCount = 0
        digitcount = 0
        specialcount = 0

        'Input Prompt
        Console.Write("Enter a String : ")
        str1 = Console.ReadLine()
        Console.Write("Enter character to count in entered string : ")
        char1 = Console.ReadLine()

        'Processing Request
        str1 = LCase(str1)

        For i = 1 To Len(str1)
            thischar = Mid(str1, i, 1)

            'Counting Total Alphabets String Entered
            If thischar >= "a" And thischar <= "z" Then
                alphabetCount = alphabetCount + 1

                'Counting Total Digits in String Entered
            ElseIf thischar >= "0" And thischar <= "9" Then
                digitcount = digitcount + 1

                'Counting Total Special Characters in String Entered
            Else : specialcount = specialcount + 1

            End If
            If thischar = char1 Then
                charcount = charcount + 1
            End If
        Next

        'Output Desired Results
        Console.WriteLine("Total number of Alphabets entered are : " & alphabetCount & " out of which " & charcount & " are " & UCase(char1))
        Console.WriteLine("Total number of Digits entered are : " & digitcount)
        Console.WriteLine("Total number of Special Characters entered are : " & specialcount)

        Console.ReadKey()
    End Sub

End Module
