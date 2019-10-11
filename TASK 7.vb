Module Module1

    Sub Main()

        Dim str As String = ""
        Dim chr1 As Char = ""
        Dim ascvalue As Integer = 0
        Dim range As Integer = 0
        Dim letters As String = ""
        Dim numbers As Integer = 0
        Dim spchr As String = ""

        Console.Write("Enter the string: ")
        str = Console.ReadLine

        For range = 1 To Len(str)
            chr1 = Mid(str, range, 1)
            ascvalue = Asc(chr1)
            If ascvalue >= 65 And ascvalue <= 90 Or ascvalue >= 97 And ascvalue <= 122 Then
                letters = letters & chr1
            ElseIf ascvalue >= 48 And ascvalue <= 57 Then
                numbers = numbers & chr1
            Else : spchr = spchr & chr1

            End If

        Next


        Console.WriteLine("The letters separated are " & letters)
        Console.ReadKey()

        Console.WriteLine("The numbers separated are " & numbers)
        Console.ReadKey()

        Console.WriteLine("The specials separated are " & spchr)
        Console.ReadKey()







    End Sub

End Module
