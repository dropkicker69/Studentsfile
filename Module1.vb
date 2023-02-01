Module Module1

    Sub Main()
        Dim name As String
        Dim marks As Integer
        FileOpen(1, My.Application.Info.DirectoryPath & "\StFile.txt", OpenMode.Append)
        For x = 1 To 10
            Console.Write(" Enter Name : ")
            name = Console.ReadLine()
            Console.Write(" Enter marks : ")
            marks = Console.ReadLine()
            If marks < 30 Then
                WriteLine(1, name)
            End If
        Next
        FileClose(1)

    End Sub

End Module
