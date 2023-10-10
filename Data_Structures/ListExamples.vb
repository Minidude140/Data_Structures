'Zachary Christensen
'RCET 2265
'Fall 2023
'List Examples
'https://github.com/Minidude140/Data_Structures.git


Option Explicit On
Option Strict On

Module ListExamples

    Sub Main()
        Dim names As New List(Of String)
        'Add Names to my list
        names.Add("Jimmy")
        names.Add("John")
        names.Add("Jacob")
        names.Add("Jingle")
        names.Add("Heimer")
        names.Add("Schmitt")

        'Print out the whole list
        For Each name As String In names
            Console.WriteLine(name)
        Next
        Console.WriteLine()

        'use and interpolated string to print our the 3rd name and number of names in the list
        Console.WriteLine($"The third name is {names(2)} and there are {names.Count} names in the list.")
        Console.WriteLine()
        'find jingle and print out the in index value
        Console.WriteLine($"Jingle is at the index {names.IndexOf("Jingle")}.")
        Console.WriteLine()

        'sort the list
        names.Sort()

        'reprint the sorted list (enumerated)
        For i As Integer = 0 To names.Count - 1
            Console.WriteLine($"Name: {names(i)}  Index: {i}")
        Next
        Console.WriteLine()

        'insert duplicate names randomly
        For i = 0 To 2
            names.Insert(RandomNumber(names.Count), "Sally")
        Next

        Dim count As Integer = 0
        For Each name As String In names
            If name = "Sally" Then
                count += 1
            End If
        Next

        For Each name As String In names
            Console.WriteLine(name)
        Next

        Console.Read()
    End Sub

    Function RandomNumber(maxNumber As Integer) As Integer
        Randomize()
        Return CInt(Rnd() * maxNumber)
    End Function

End Module
