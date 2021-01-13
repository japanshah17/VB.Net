Imports System.Console
Module Pyramid
   Sub Main()
        Dim i, j, n As Integer
        n = 4
        For i = 0 To n Step 1
            For j = 1 To n - i Step 1
                Write(" ")
            Next
            For j = 0 To i Step 1
                Write("* ")
            Next
            WriteLine()
        Next
        ReadLine()
    End Sub

    End Module