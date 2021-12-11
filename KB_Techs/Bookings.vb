Imports MySql.Data.MySqlClient

Public Class Bookings

    Dim index As Integer
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=ocas;Convert Zero Datetime=True;")
    Dim Myconnection As String = "server=localhost;user id=root;password=;database=ocas"
    Dim valueToSearch As String
    Private Sub Bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

    Public Sub FilterData(valueToSearch)
        Dim searchQuery As String = "SELECT * From client WHERE CONCAT(Code, Lname, Fname, Address, Email, PhoneNumber, Concern) like 
        '%" & valueToSearch & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.DataSource = table
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        FilterData(search.Text)
    End Sub
End Class