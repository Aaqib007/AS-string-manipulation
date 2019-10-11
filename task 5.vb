Module Module1

    Sub Main()
        Dim str As String = ""
        Dim chr1 As Char = ""
        Dim range As Integer = 0
        Dim invstr As String = ""

        Console.Write("enter the string that needs to be inversed: ")
        str = Console.ReadLine

        For range = Len(str) To 1 Step -1
            chr1 = Mid(str, range, 1)
            invstr = invstr & chr1
        Next
        Console.WriteLine("The inverse of the string is : " & invstr)
        Console.ReadKey()
    End Sub

End Module
