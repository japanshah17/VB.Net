Imports System.Console

Module MultiArray
    Sub Main()
        Dim array(2, 2) As Integer
        Dim i, j, value As Integer
        Dim count As Integer = 0

        WriteLine()
        For i = 0 To UBound(array, 1)
            For j = 0 To UBound(array, 2)
                WriteLine("enter ({0},{1}):", i, j)
                array(i, j) = CInt(ReadLine())
            Next
        Next
        WriteLine("Enter Key:")
        value = CInt(ReadLine())

        For i = 0 To UBound(array, 1)
            For j = 0 To UBound(array, 2)
                If array(i, j) = value Then
                    WriteLine("{0} is found at ({1},{2}):", value, i, j)
                    count = count + 1
                End If
            Next
        Next
        If count = 0 Then
            WriteLine("Value not found")
        End If
        ReadLine()

    End Sub

End Module
