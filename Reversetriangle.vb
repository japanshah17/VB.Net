Imports System.Console
Module Reversetriangle
    Sub Main()
        Dim i, j As Integer
        For i = 0 To 4 Step 1
            For j = 0 To 4 - i Step 1
                Write("*")
            Next
            WriteLine()
        Next
        ReadLine()
    End Sub

End Module
