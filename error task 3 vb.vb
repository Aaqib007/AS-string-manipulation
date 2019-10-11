Module Module1

    Sub Main()
        Dim str As String = " "
        Dim range As Integer = 0
        Dim spacepos As Integer = 0
        Dim word As String = " "
        Dim chr As Char = " "
        Dim x As Integer = 0
        Const space = " "
        Dim y As Integer = 0


        Console.Write("Enter the string : ")
        str = Console.ReadLine

        spacepos = InStr(str, " ")
        word = Left(str, spacepos - 1)
        Console.WriteLine(word)


        For range = spacepos To Len(str)
            chr = Mid(str, range, 1)
            If chr = space Then
                x = InStr(spacepos + 1, str, " ")
                word = Mid(str, range + 1, x - range - 1)
                Console.WriteLine(word)
            End If
        Next


        End If

    End Sub

End Module
