Imports System.Security.Cryptography
Imports System.Text

Module Module1

    Sub Main()

        Dim testtext As String
        Console.Write("Enter any text: ")
        testtext = Console.ReadLine()
        'Generate Hash
        Dim strToHash As String
        strToHash = testtext.ToString
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Console.WriteLine("")
        Console.WriteLine("Your Encrypted Text: " + strResult)
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Main()

    End Sub

End Module
