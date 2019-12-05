Module Module1

    Sub Main()
        Dim str As String = ""
        Dim chr1 As Char = ""
        Dim x As Integer = 0
        Dim loop1 As Integer = 0
        Dim loop2 As Integer = 0
        Dim str2 As String = ""
        Dim y As Boolean = False
        Dim ascii As Integer = 0



        Console.Write("Enter the string: ")
        str = Console.ReadLine

        Console.Write("Enter the string to check anagram: ")
        str2 = Console.ReadLine

        For loop1 = 1 To Len(str)
            chr1 = Mid(str, loop1, 1)
            ascii = Asc(chr1)

            x = InStr(str2, ascii)
            If x < 1 Then
                y = False

            Else
                y = True
            End If

            If y = False Then Exit For

        Next

        If y = False Then
            Console.Write("The given strings are not anagram")
            Console.ReadKey()
        ElseIf y = True Then

            Console.Write("the given strings are anagram")
            Console.ReadKey()


        End If



    End Sub

End Module
