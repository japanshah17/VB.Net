Imports System.Console

Module Calc
    Sub Main()
        Dim a, b As Integer
        Dim c As String
        WriteLine("Enter + for Addition.")
        WriteLine("Enter - for Subtraction.")
        WriteLine("Enter * for Multiplication.")
        WriteLine("Enter / for Division.")
        WriteLine("Enter % for Modulo.")
        WriteLine("Enter ^ for Square.")
        c = ReadLine()
        Write("Enter the value of a:")
        a = CInt(ReadLine())
        Write("Enter the value of b:")
        b = CInt(ReadLine())
        If c = "+" Then
            WriteLine("Addition is {0}", a + b)
        End If
        If c = "-" Then
            WriteLine("Subtraction is {0}", a - b)
        End If
        If c = "*" Then
            WriteLine("Multiplication is {0}", a * b)
        End If
        If c = "/" Then
            WriteLine("Division is {0}", a / b)
        End If
        If c = "%" Then
            WriteLine("Modulo is {0}", a Mod b)
        End If
        If c = "^" Then
            WriteLine("square is {0}", a * a)
        End If

        ReadLine()

    End Sub
End Module
