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

        End If

        Dim chr2 As Integer = 0
        Dim loop2 As Integer = 0
        Dim denaryval As Integer = 0
        Dim sum As Integer = 0
        Dim total As Integer = 0


        If validBinaryString = True Then

            total = Len(str1)


            For loop2 = 1 To total
                chr2 = Mid(str1, loop2, 1)
                denaryval = ((2 ^ (total - loop2)) * chr2)
                sum = sum + denaryval


            Next

        End If

        Console.WriteLine(str1 & " = " & sum)

        Console.ReadKey()
    End Sub

End Module
