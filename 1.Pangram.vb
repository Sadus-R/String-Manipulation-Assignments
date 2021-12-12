Module Module1

    Sub Main()
        'Declaration
        Dim str1, alphabets As String
        Dim I As Integer
        Dim thisChar As Char
        Dim pangram As Boolean

        'Initialization
        str1 = ""
        alphabets = "ABCDEFGHIJKLNOPQRSTUVWXYZ"
        I = 0
        thisChar = ""
        pangram = True

        'Input Prompt
        Console.Write("Enter a Sentence : ")
        str1 = Console.ReadLine

        'Processing Request
        str1 = UCase(str1)

        'Checking if entered String contains all the Alphabets
        For I = 1 To Len(str1)
            thisChar = Mid(str1, I, 1)
            If InStr(str1, thisChar) = 0 Then
                pangram = False
                Exit For
            End If
        Next I

        'Output Desired Results
        If pangram = True Then
            Console.WriteLine("String entered is a Pangram")
        Else : Console.WriteLine("String entered is not a Pangram")
        End If

        Console.ReadKey()
    End Sub

End Module
