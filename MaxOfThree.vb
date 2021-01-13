Imports System.Console

Module MaxOfThree
    Sub Main()
        Dim a, b, c As Integer
        Write("Enter the values of a, b and c :")
        a = CInt(ReadLine())
        b = CInt(ReadLine())
        c = CInt(ReadLine())
        If a > b And a > c Then
            WriteLine("Greatest = " + a.ToString())

        ElseIf b > c Then
            WriteLine("Greatest = " + b.ToString())

        Else
            WriteLine("Greatest = " + c.ToString())
        End If

        ReadLine()

    End Sub
End Module
