Module Module1

    Sub Main()
        Dim str As String = ""
        Dim newstr As String = ""
        Dim chr1 As Char = ""
        Dim loop1 As Integer = 0
        Dim Rchr As String = ""

        Console.Write("Enter the string : ")
        str = Console.ReadLine
        
        Console.Write("Enter the character to be removed : ")
        Rchr = Console.ReadLine

        For loop1 = 1 To Len(str)
            chr1 = Mid(str, loop1, 1)
            If chr1 <> Rchr Then
                newstr = newstr & chr1
            End If
        Next
        Console.WriteLine("New string with character truncated is " & NewStr)
        Console.ReadKey()
    End Sub

End Module
