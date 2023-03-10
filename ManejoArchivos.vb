Imports System.IO
Public Class ManejoArchivos
    Private archivo As StreamReader = Nothing
    Private contador As Integer = 0
    Private linea As String

    Public Sub New()
        archivo = New StreamReader("C:\Users\Sarah\OneDrive\Escritorio\data.txt")
        While (InlineAssignHelper(linea, archivo.ReadLine())) IsNot Nothing
            Console.WriteLine(linea)
            contador += 1
        End While
    End Sub

    Public Sub Mensaje()
        Console.WriteLine("Hay {0} lineas", contador)
    End Sub

    Protected Overrides Sub Finalize()
        archivo.Close()
    End Sub

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
