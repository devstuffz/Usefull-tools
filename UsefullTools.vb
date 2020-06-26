Imports System

Namespace UsefullTools
    Class MiscTools
        Public Shared Sub SayHi(ByVal Username As String)
            Console.WriteLine("Hello " & Username)
        End Sub
    End Class

    Class Devstuffz
        Public Shared Sub Discord()
            Console.WriteLine("https://discord.gg/vDG4Bz3")
        End Sub

        Public Shared Sub Website()
            Console.WriteLine("indiegamedevs.co.page")
        End Sub
    End Class

    Class AI
        Public Shared Sub ChatBotEnd(ByVal isMean As Boolean)
            If isMean Then
                Console.WriteLine("screw this and screw you, im out")
            Else
                Console.WriteLine("battery low, sorry, gtg")
            End If
        End Sub

        Public Shared Sub ChatBotStart(ByVal isMean As Boolean)
            If isMean Then
                Console.WriteLine("What do you want")
            Else
                Console.WriteLine("Hello!!! My name is DevBot! i was created by devstuffz")
            End If
        End Sub

        Public Shared Sub ChatBotRespond(ByVal lastPlayerInput As String, ByVal response As String, ByVal isMean As Boolean)
            If isMean Then

                If lastPlayerInput = "hello" OrElse lastPlayerInput.ToLower() = "hi" Then
                    response = "no"
                    Console.WriteLine(response)
                ElseIf lastPlayerInput.ToLower() = "i hate you" OrElse lastPlayerInput.ToLower() = "screw you" OrElse lastPlayerInput.ToLower() = "i hate u" OrElse lastPlayerInput.ToLower() = "frick u" Then
                    response = "i hate u 2 and so does devstuffz"
                    Console.WriteLine(response)
                ElseIf lastPlayerInput.ToLower() = "wasd" Then
                    response = "Ahh a gamer, more liek gaymer"
                    Console.WriteLine(response)
                ElseIf lastPlayerInput.ToLower() = "who are you" OrElse lastPlayerInput.ToLower() = "j" Then
                    response = "I am devbot kid"
                    Console.WriteLine(response)
                Else
                    response = "My creator, DevStuffz, hasnt programmed that far yet bc hes stupid and using if statements"
                    Console.WriteLine(response)
                End If
            Else

                If lastPlayerInput.ToLower() = "hi" OrElse lastPlayerInput.ToLower() = "hello" OrElse lastPlayerInput.ToLower() = "hellow" Then
                    response = "Why hello there"
                    Console.WriteLine(response)
                ElseIf lastPlayerInput.ToLower() = "wasd" Then
                    response = "OMG YOUR A GAMER TOO"
                    Console.WriteLine(response)
                ElseIf lastPlayerInput.ToLower() = "i hate you" OrElse lastPlayerInput.ToLower() = "screw you" OrElse lastPlayerInput.ToLower() = "i hate u" OrElse lastPlayerInput.ToLower() = "frick u" Then
                    response = "oh im sorry, anything i need to do?"
                    Console.WriteLine(response)
                Else
                    response = "my creator, DevStuffz, hasnt programmed me that far yet bc he has a life and is new to programming and using if statements and already spent 4 hours on me "
                End If
            End If
        End Sub
    End Class

    Class MathTools
        Module Basic
            Sub AddInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
                answer = (num1 + num2)
            End Sub

            Sub AddFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
                answer = (num1 + num2)
            End Sub

            Sub SubtractInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
                answer = (num1 - num2)
            End Sub

            Sub SubtractFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
                answer = (num1 - num2)
            End Sub

            Sub MultiplyInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
                answer = (num1 * num2)
            End Sub

            Sub MultiplyFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
                answer = (num1 * num2)
            End Sub

            Sub DivideInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
                answer = (num1 / num2)
            End Sub

            Sub DivideFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
                answer = (num1 / num2)
            End Sub
        End Module

        Public Shared Sub RoundInt(ByVal num As Integer)
            MathF.Round(num)
        End Sub

        Public Shared Sub RoundFloat(ByVal num As Single)
            MathF.Round(num)
        End Sub

        Module Square
            Sub sqrdInt(ByVal Num As Integer)
                Num = Num * Num
            End Sub

            Sub sqrdFloat(ByVal Num As Single)
                Num = Num * Num
            End Sub

            Sub sqrtInt(ByVal Num As Integer)
                Num = Num / Num
            End Sub

            Sub sqrtFloat(ByVal num As Single)
                MathF.Sqrt(num)
            End Sub
        End Module

        Module RandomNum
            Sub Float(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
                Dim random As Random = New Random()
                Dim intNumOne As Integer = Convert.ToInt32(num1)
                Dim intNumTwo As Integer = Convert.ToInt32(num2)
                answer = random.[Next](intNumOne, intNumTwo + 1)
            End Sub

            Sub Int(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
                Dim random As Random = New Random()
                answer = random.[Next](num1, num2)
            End Sub
        End Module
    End Class

    Class ForegroundColors
        Public Shared Sub Red()
            Console.ForegroundColor = ConsoleColor.Red
        End Sub

        Public Shared Sub Blue()
            Console.ForegroundColor = ConsoleColor.Blue
        End Sub

        Public Shared Sub Black()
            Console.ForegroundColor = ConsoleColor.Black
        End Sub

        Public Shared Sub White()
            Console.ForegroundColor = ConsoleColor.White
        End Sub

        Public Shared Sub Reset()
            Console.ResetColor()
        End Sub
    End Class

    Class ConsoleTools
        Module Fun
            Sub Troll(ByVal length As Integer)
                For i As Integer = 0 To length - 1
                    Console.WriteLine("Never Gonna Give You Up")
                    Console.WriteLine("Never Gonna Let You Down")
                    Console.WriteLine("Never Gonna Run Around")
                    Console.WriteLine("Or Desert You")
                    Console.WriteLine("Never Gonna make you cry")
                    Console.WriteLine("Never Gonna say goodbye")
                    Console.WriteLine("Never gonna tell a lie")
                    Console.WriteLine("Or Hurt You")
                Next
            End Sub

            Sub Trianle(ByVal length As Integer)
                Dim i, j, k As Integer

                For i = 1 To length

                    For j = 1 To i
                        Console.Write("")
                    Next

                    For k = 1 To i
                        Console.Write("*")
                    Next

                    Console.WriteLine("")
                Next

                Console.ReadLine()
            End Sub
        End Module

        Public Shared Sub SkipLines(ByVal Skips As Integer)
            For i As Integer = 0 To Skips - 1
                Console.WriteLine("")
            Next
        End Sub
    End Class
End Namespace
