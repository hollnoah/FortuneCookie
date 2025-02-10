Option Strict On
Option Compare Text
Option Explicit On
'Noah Holloway  
'RCET 2265
'Spring 2025
'Fortune Cookie
Module FortuneCookie

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function
    Sub Main()
        Dim userInput As String
        Dim wisdom1 As String = "The journey of a thousand miles begins with a single step!"
        Dim wisdom2 As String = "Fake it till you make it!"
        Dim wisdom3 As String = "You miss all the shots you don't take!"


        Do
            Dim randomChoice As Integer = RandomNumberBetween(1, 3)
            Console.WriteLine("Press enter for your daily dose of wisdom")
            Console.WriteLine("Press Q at any time to quit")
            Console.WriteLine()

            userInput = Console.ReadLine()

            If randomChoice = 1 Then
                Console.WriteLine(wisdom1)
                Console.WriteLine()

            ElseIf randomChoice = 2 Then
                Console.WriteLine(wisdom2)
                Console.WriteLine()

            Else randomChoice = 3
                Console.WriteLine(wisdom3)
                Console.WriteLine()
            End If

        Loop Until userInput = "Q"
    End Sub

End Module
