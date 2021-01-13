Imports System.Console

Module ArraySort
    Sub Main()
        Dim sorting(4), i, j, swap As Integer

        For i = 0 To UBound(sorting) Step 1
            Write("Please Enter value for position {0} : ", i + 1)
            sorting(i) = CInt(ReadLine())
        Next i

        For i = 0 To 5 Step 1
            For j = i + 1 To 4 Step 1
                If sorting(i) > sorting(j) Then
                    swap = sorting(i)
                    sorting(i) = sorting(j)
                    sorting(j) = swap
                End If
            Next
        Next
        WriteLine()

        WriteLine("Ascending: ")
        For i = 0 To 4 Step 1
            WriteLine("The value for position {0} is: {1} ", i + 1, sorting(i))
        Next
        WriteLine()

        WriteLine("descending: ")
        For i = 4 To 0 Step -1
            WriteLine("The value for position {0} is: {1} ", i + 1, sorting(i))
        Next i
        ReadLine()
    End Sub
End Module
