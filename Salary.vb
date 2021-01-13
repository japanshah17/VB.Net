Imports System.Console

Module Salary
    Sub Main()

        Dim sal As Integer
        WriteLine("Enter Your Salary")
        sal = CInt(ReadLine())

        Select Case sal
            Case 40000, 42000, 44000
                sal = sal + (sal * 0.07)
            Case 5000 To 15000
                sal = sal + (sal * 0.15)
            Case 15001 To 25000
                sal = sal + (sal * 0.1)
            Case 25001 To 35000
                sal = sal + (sal * 0.5)
            Case Is > 35000
                sal = sal + (sal * 0.3)

            Case Else
                WriteLine("Please Enter valid Salary")
        End Select
        WriteLine("Salary after Increment is {0}", sal)
        ReadLine()
    End Sub

End Module
