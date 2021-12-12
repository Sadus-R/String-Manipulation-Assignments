Module Module1

    Sub Main()
        'Declaration
        Dim str1 As String
        Dim acount, ecount, icount, ocount, ucount, totalCount, i As Integer
        Dim thischar As Char

        'Initialization
        str1 = ""
        thischar = ""
        acount =
        ecount = 0
        icount = 0
        ocount = 0
        ucount = 0
        totalCount = 0
        i = 0

        'Taking input from user
        Console.Write("Enter a string : ")
        str1 = Console.ReadLine


        'Processing Request

        str1 = UCase(str1)

        For i = 1 To Len(str1)
            thischar = Mid(str1, i, 1)
            'Counting 'A's
            If thischar = "A" Then
                acount = acount + 1
                totalCount = totalCount + 1
                'Counting 'E's
            ElseIf thischar = "E" Then
                ecount = ecount + 1
                totalCount = totalCount + 1
                'Counting 'I's
            ElseIf thischar = "I" Then
                icount = icount + 1
                totalCount = totalCount + 1
                'Counting 'O's
            ElseIf thischar = "O" Then
                ocount = ocount + 1
                totalCount = totalCount + 1
                'Counting 'U's
            ElseIf thischar = "U" Then
                ucount = ucount + 1
                totalCount = totalCount + 1
            End If
        Next

        'output desired results
        Console.WriteLine("Total number of vowels in entered string are as " & totalCount & " out of which there are ")
        Console.WriteLine(acount & " A's")
        Console.WriteLine(ecount & " E's")
        Console.WriteLine(icount & " I's")
        Console.WriteLine(ocount & " O's")
        Console.WriteLine(ucount & " U's")

        Console.ReadKey()
    End Sub

End Module
