


# ListasVb
Proyecto que muestra el funcionamiento de las listas como colecciones 
y de Combobox como contenedores de objetos.

 # Actualizacion: 29/12/2024
 # Hora: 21:34

 Se agrego una actualizacion en la rama master para contar con dos 
 versiones del proyecto.

Detalles Tecnicos del Proyecto:
Lenguaje: Visual Basic.NET
Version del Framawork: 4.7.2

# ListasVb
Project that shows how lists work as collections
and Combobox as object containers.

# Update: 12/29/2024
# Time: 21:34

An update was added to the master branch to have two
versions of the project.

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/b26708d3-13b0-4104-81e6-30396dc26809)

Code of the Project:

    Public Class frmListas
    Private Sub btnAgregarCancion_Click(sender As Object, e As EventArgs) Handles btnAgregarCancion.Click
        Dim intIndice As Integer = lstCancionesChemicalEcho.Items.Add("Orbit")
    End Sub

    Private Sub btnBorrarCancion_Click(sender As Object, e As EventArgs) Handles btnBorrarCancion.Click
        lstCancionesChemicalEcho.Items.Remove("Orbit") 'Remueve por valor
        'lstCancionesChemicalEcho.Items.RemoveAt(0) 'Remueve por índice
    End Sub

    Private Sub btnBorrarLista_Click(sender As Object, e As EventArgs) Handles btnBorrarLista.Click
        lstCancionesChemicalEcho.Items.Clear()
        'Limpia la lista
    End Sub

    Private Sub btnMostrarElemento_Click(sender As Object, e As EventArgs) Handles btnMostrarElemento.Click
        MessageBox.Show("Ha seleccionado " & lstCancionesChemicalEcho.SelectedItem & ", con el indice " & lstCancionesChemicalEcho.SelectedIndex)
    End Sub


End Class
