Module Module1

    Sub Main()
        Dim str As String = " "
        Dim middleword As String = " "
        Dim chr1 As Integer = 0
        Dim chr2 As Integer = 0

        Console.Write(" Enter a 3 word string : ")
        str = Console.ReadLine()

        chr1 = InStr(str, " ")
        chr2 = InStr(chr1 + 1, str, " ")

        middleword = Mid(str, chr1 + 1, chr2 - chr1)

        Console.WriteLine("the middle word in the string is : " & middleword)
        Console.ReadKey()



    End Sub

End Module
