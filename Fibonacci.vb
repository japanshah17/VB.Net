Imports System.Console
Module Fibonacci
    Sub Main()
        Dim a, b, c, n, i As Integer
        Write("Enter how many elements:-")
        n = CInt(ReadLine())
        a = 0
        b = 1
        Write("0 1 ")
        For i = 1 To n - 1 Step 1
            c = a + b
            Write("{0} ", c)
            a = b
            b = c
            i = i + 1
            ReadLine()
        Next i
    End Sub
End Module
