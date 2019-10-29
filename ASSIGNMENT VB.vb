Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim chr1 As Integer = 0
        Dim loop1 As Integer = 0
        Dim validBinaryString As Boolean = True

        Console.Write("Enter Binary Number: ")
        str1 = Console.ReadLine

        If Len(str1) > 0 And Len(str1) < 9 Then

            validBinaryString = True
        Else
            validBinaryString = False

        End If

        If validBinaryString = True Then

            For loop1 = 1 To Len(str1)
                chr1 = Mid(str1, loop1, 1)
                If chr1 > 1 Or chr1 < 0 Then
                    validBinaryString = False
                Else
                    validBinaryString = True
                End If
                If validBinaryString = False Then
                    Exit For
                End If
            Next

        End If
        If validBinaryString = False Then
            Console.Write("Invalid binary number")
            Console.ReadLine()
        Else
            Console.Write("Valid binary number")
            Console.ReadKey()

        End If




    End Sub

End Module
