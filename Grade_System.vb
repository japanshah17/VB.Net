Imports System.Console
Module Grade_System
    Sub Main()

        Dim Total, os, cpp, dbms, ds, malp As Integer
        Dim Avg As Decimal
        Dim Name, En As String

        Write("Name : ")
        Name = ReadLine()
        Write("Enrollment Number : ")
        En = ReadLine()
        WriteLine()
        WriteLine("Please Enter Your Marks From 100")
        WriteLine()
        Write("OS : ")
        os = ReadLine()
        WriteLine()
        Write("C++ : ")
        cpp = ReadLine()
        WriteLine()
        Write("DBMS : ")
        dbms = ReadLine()
        WriteLine()
        Write("DS : ")
        ds = ReadLine()
        WriteLine()
        Write("MALP : ")
        malp = ReadLine()
        WriteLine()

        Total = os + cpp + dbms + ds + malp
        Avg = Total / 5

        WriteLine("Dear {0}, Result for Enrolment Number {1} is : ", Name, En)
        WriteLine()

        If Avg >= 85 Then
            WriteLine("AA")
        ElseIf Avg >= 75 Then
            WriteLine("AB")
        ElseIf Avg >= 65 Then
            WriteLine("BB")
        ElseIf Avg >= 55 Then
            WriteLine("BC")
        ElseIf Avg >= 45 Then
            WriteLine("CC")
        ElseIf Avg >= 40 Then
            WriteLine("CD")
        ElseIf Avg >= 35 Then
            WriteLine("DD")
        Else
            WriteLine("FF")
        End If


        ReadLine()
    End Sub
End Module
