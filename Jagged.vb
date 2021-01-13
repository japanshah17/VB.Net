Imports System.Console
Module Jagged
    Sub Main()
        Dim array As Integer()() = New Integer(4)() {}
        array(0) = New Integer() {0}
        array(1) = New Integer() {1, 2}
        array(2) = New Integer() {3, 4, 5}
        array(3) = New Integer() {6, 7, 8, 9}
        array(4) = New Integer() {10, 11, 12, 13, 14}

        Dim i, j As Integer
        For i = 0 To UBound(array)
            For j = 0 To UBound(array(i))
                WriteLine("array({0},{1})::{2}", i, j, array(i)(j))
            Next
        Next
        ReadLine()
    End Sub
End Module
