Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class LoginMediacion

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Dim sql_login_mediacion As New SqlCommand
    Dim sqldr_login_mediacion As SqlDataReader
    Dim codigoUsuario As String
    Dim codigoContraseña As String
    Public SW_USUARIO As Integer = 0
    Public SW_CONTRASEÑA As Integer = 0
    Public USUARIO_IMPRESIONES As String
    Sub Usuario()
        'Try
        Me.SqlConnection1.Open()
        sql_login_mediacion.CommandType = CommandType.Text
        sql_login_mediacion.CommandText = ("select *  from usuarios where Usuarios.CodUserName= '" & UsernameTextBox.Text & "'")
        '& "and Area= 'I''" & "'")
        sql_login_mediacion.Connection = Me.SqlConnection1
        sqldr_login_mediacion = sql_login_mediacion.ExecuteReader()
        sqldr_login_mediacion.Read()
        If sqldr_login_mediacion.HasRows = 0 Then
            MsgBox("No existe el usuario")
            SW_USUARIO = 2
            UsernameTextBox.Text = ""
            UsernameTextBox.Focus()
        Else
            If sqldr_login_mediacion("Area") = "M" Then
                SW_USUARIO = 1
                'Inventario_hojas.Show()
                'Else
                '   MsgBox("No existe el usuario")
                '   TB_Usuario.Focus()
            Else
                SW_USUARIO = 3
            End If
        End If
        'Catch ex As Exception
        ' MsgBox(ex.ToString)
        ' End Try
        sqldr_login_mediacion.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub password()
        'Try
        Me.SqlConnection1.Open()
        sql_login_mediacion.CommandType = CommandType.Text
        sql_login_mediacion.CommandText = ("select *  from usuarios where Usuarios.CodPassword= '" & PasswordTextBox.Text & "'")
        '& "and Area= 'I''" & "'")
        sql_login_mediacion.Connection = Me.SqlConnection1
        sqldr_login_mediacion = sql_login_mediacion.ExecuteReader()
        sqldr_login_mediacion.Read()
        If sqldr_login_mediacion.HasRows = 0 Then
            MsgBox("No existe contraseña")
            PasswordTextBox.Text = ""
            PasswordTextBox.Focus()
            SW_CONTRASEÑA = 2
        Else
            If sqldr_login_mediacion("Area") = "M" Then
                SW_CONTRASEÑA = 1
                'Inventario_hojas.Show()
                'Else
                '   MsgBox("No existe el usuario")
                '   TB_Usuario.Focus()
            Else
                SW_CONTRASEÑA = 3

            End If
        End If
        sqldr_login_mediacion.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call Usuario()
        Call password()
        If SW_USUARIO = 1 And SW_CONTRASEÑA = 1 Then
            Me.Hide()
            Menu_Mediacion.Show()
        Else
            If SW_USUARIO = 3 And SW_CONTRASEÑA = 3 Then
                MsgBox("Datos no corresponden al area de mediacion")
            End If

        End If

        'Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginMediacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
