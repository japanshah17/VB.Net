Imports System.Console

Module MonthName
    Sub Main()

        Dim Month As Integer
        WriteLine("Enter month Number")
        Month = CInt(ReadLine())

        Select Case Month
            Case 1
                WriteLine("JAN")
            Case 2
                WriteLine("FEB")
            Case 3
                WriteLine("MARCH")
            Case 4
                WriteLine("APRIL")
            Case 5
                WriteLine("MAY")
            Case 6
                WriteLine("JUNE")
            Case 7
                WriteLine("JULY")
            Case 8
                WriteLine("AUG")
            Case 9
                WriteLine("SEPT")
            Case 10
                WriteLine("OCT")
            Case 11
                WriteLine("NOV")
            Case 12
                WriteLine("DEC")
            Case Else
                WriteLine("Please Enter From 1 To 12")
        End Select

        ReadLine()
    End Sub

End Module
