Module Module1

    Sub Main()
        Dim number As Integer = 0
        Dim increment As Integer = 10
        Dim myNumber As Double = 0
        Dim squareRoot As Double = 0
        addTen(number, increment)
        Console.WriteLine("Your number with 10 added to it is " & number)
        Console.WriteLine("")
        sqrt(myNumber, squareRoot)
        Console.WriteLine("The square root of your number is " & squareRoot)
        Console.WriteLine("")
        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

    Function addTen(ByRef number As Integer, ByVal increment As Integer) As Integer

        'number entry prompt
        Console.WriteLine("Please enter the number you wish to start with.")
        number = Console.ReadLine()

        'calculation to increment by increment value declared in Global
        number = number + increment
        Return number

    End Function

    Function sqrt(ByRef myNumber As Double, ByRef squareRoot As Double)

        'square root entry prompt
        Console.WriteLine("Please enter the number you wish to find the square root of.")
        myNumber = Console.ReadLine()
        squareRoot = System.Math.Sqrt(myNumber)
        Return squareRoot
    End Function
End Module


