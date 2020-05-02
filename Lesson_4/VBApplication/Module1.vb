Imports MathUtil
Module Module1
    Sub Main()
        Dim r As New RandomNumber() With {
        .MinValue = 0,
        .MaxValue = 500
        }
        Console.WriteLine(r.[Get]())
    End Sub
End Module