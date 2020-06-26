Imports System
Imports System.Runtime.Versioning

Namespace UsefullTools
    Class MathTools
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

        Public Shared Sub AddInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
            answer = (num1 + num2)
        End Sub

        Public Shared Sub AddFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
            answer = (num1 + num2)
        End Sub

        Public Shared Sub SubtractInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
            answer = (num1 - num2)
        End Sub

        Public Shared Sub SubtractFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
            answer = (num1 - num2)
        End Sub

        Public Shared Sub MultiplyInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
            answer = (num1 * num2)
        End Sub

        Public Shared Sub MultiplyFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
            answer = (num1 * num2)
        End Sub

        Public Shared Sub DivideInt(ByVal num1 As Integer, ByVal num2 As Integer, ByVal answer As Integer)
            answer = (num1 / num2)
        End Sub

        Public Shared Sub DivideFloat(ByVal num1 As Single, ByVal num2 As Single, ByVal answer As Single)
            answer = (num1 / num2)
        End Sub

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
