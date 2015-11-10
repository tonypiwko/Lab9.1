Module Module1

    Sub Main()
        Dim number As Integer = 0
        Dim increment As Integer = 10
        Sum(number, increment)
        Console.WriteLine("Your number with 10 added to it is " & number)
        Console.WriteLine("")
        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

    Function Sum(ByRef number As Integer, ByVal increment As Integer) As Integer

        'number entry prompt
        Console.WriteLine("Please enter the number you wish to start with.")
        number = Console.ReadLine()

        'calculation to increment by increment value declared in Global
        number = number + increment
        Return number

    End Function

End Module


