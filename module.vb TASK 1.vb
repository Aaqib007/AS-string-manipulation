Module Module1

    Sub Main()
        Dim Str1 As String = " "
        Dim Str2 As String = " "
        Dim newstr As String = " "
        Dim X As Integer = 0
        Dim name1 As String = " "
        Dim name2 As String = " "

        Console.Write(" Enter the first string : ")
        Str1 = Console.ReadLine

        Console.Write(" Enter the second string : ")
        Str2 = Console.ReadLine


        X = InStr(Str1, " ")
        name1 = Left(Str1, X - 1)

        X = InStr(Str2, " ")
        name2 = Right(Str2, Len(Str2) - X)

        newstr = name1 & " " & name2


        Console.WriteLine("the new string is :" & newstr)
        Console.ReadKey()









    End Sub

End Module
