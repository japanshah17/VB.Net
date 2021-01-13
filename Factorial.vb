Imports System.Console

Module Factorial
    Sub main()
        Dim n, i, f As Integer
        Write("Enter a Number: ")
        n = CInt(ReadLine())
        f = 1
        If n < 0 Then
            WriteLine("Factorial of negative number is not possible")
        ElseIf n = 0 Or n = 1 Then
            WriteLine("Factorial of " + n.ToString() + " is 1")
        Else
            i = 1
            While (i <= n)
                f = f * i
                i = i + 1
            End While
            WriteLine("Factorial of " + n.ToString() + " is " + f.ToString())
        End If
        ReadLine()
    End Sub
End Module
