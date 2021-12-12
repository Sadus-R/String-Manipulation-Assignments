Module Module1

    Sub Main()
        'Declaration
        Dim str1, str2, end1, end2, myend As String
        Dim i As Integer

        'Initialization
        str1 = ""
        str2 = ""
        end1 = "ing"
        end2 = "ly"
        myend = ""
        i = 0

        'Input Prompt
        Console.Write("Input a string : ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        'Processing Request
        If Len(str1) > 2 Then
            For i = 1 To Len(str1)
                myend = Right(str1, 3)
                If myend = end1 Then
                    str2 = str1 & end2
                Else : str2 = str1 & end1
                End If
            Next
        End If

        'Output Desired Result
        If Len(str1) < 3 Then
            Console.WriteLine("String : " & str1)
        Else : Console.WriteLine("String : " & str2)
        End If

        Console.ReadKey()

    End Sub

End Module
