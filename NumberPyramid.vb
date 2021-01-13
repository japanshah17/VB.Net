Imports System.Console
Module NumberPyramid
    Sub Main()
        Dim i, j, n, number As Integer
        n = 4
        number = 1
        For i = 0 To n Step 1
            For j = 1 To n - i Step 1
                Write(" ")
            Next
            For j = 0 To i Step 1
                Write("{0} ", number)
                number = number + 1
            Next
            WriteLine()
        Next
        ReadLine()
    End Sub
End Module
