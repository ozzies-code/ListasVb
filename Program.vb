Imports System

Module Program
    Sub Main(args As String())

        Dim miLista As New List(Of Integer)

        miLista.Add(8)
        miLista.Add(10)
        miLista.Add(25)
        miLista.Add(40)

        Dim copialista() As Integer = miLista.ToArray 'copia los elementos de la lista a un array
        miLista.Clear() 'borra la lista

        'For i = 0 To miLista.Count - 1 Step 1
        'Console.WriteLine(miLista.Item(i))
        'culaquiera de los dos ciclos For sirve para recorrer la lista
        'Next



        For Each elemento As Integer In miLista
            Console.WriteLine(elemento)
        Next

        For Each elemento As Integer In copialista
            Console.WriteLine(elemento)
        Next

        'API: .net api browser->.net framework 4.8.1->filtros
    End Sub
End Module
