Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text

Public Class ISPM
    Private Sub ISPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bucar_datos_ISPM()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Dim swbtn As Integer = 0
    Sub guardar_datos_ISPM()
        Dim Agregar_Datos_Solicitud_Mediacion As String
        Agregar_Datos_Solicitud_Mediacion = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If Agregar_Datos_Solicitud_Mediacion = vbYes Then
                swbtn = 1
                Me.SqlConnection1.Open()
                Dim Insdato_media_ISPM As String = "INSERT INTO ISPM(Folio_Mediacion,Fecha_Invitacion_ISPM,Estimado_Señor,Ciudadano,Dia,Hora) values(@Folio_Mediacion,@Fecha_Invitacion_ISPM,@Estimado_Señor,@Ciudadano,@Dia,@Hora)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdato_media_ISPM, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Fecha_Invitacion_ISPM", SqlDbType.SmallDateTime)).Value = DateTimePickerISPM.Text
                conex1.Parameters.Add(New SqlParameter("@Estimado_Señor", SqlDbType.NVarChar, 50)).Value = Me.TBEstimado.Text
                conex1.Parameters.Add(New SqlParameter("@Ciudadano", SqlDbType.NVarChar, 50)).Value = Me.TBCiudadano.Text
                conex1.Parameters.Add(New SqlParameter("@Dia", SqlDbType.NVarChar, 50)).Value = Me.TBDia.Text
                conex1.Parameters.Add(New SqlParameter("@Hora", SqlDbType.NChar, 10)).Value = Me.TBHora.Text
                conex1.CommandText = Insdato_media_ISPM
                conex1.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            Else
                swbtn = 2
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Actualizar_Datos_ISPM()
        Try
            Dim Actualizar_ISPM As String
            Me.SqlConnection1.Open()
            Actualizar_ISPM = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_ISPM = vbYes Then
                Dim Actualizar_Datos_SM As String = ("UPDATE ISPM SET Fecha_Invitacion_ISPM=@Fecha_Invitacion_ISPM,Estimado_Señor=@Estimado_Señor,Ciudadano=@Ciudadano,Dia=@Dia,Hora=@Hora where Folio_Mediacion= '" & Mediar.CBFolio_Mediacion.Text & "'")
                Dim conexISPM As New SqlClient.SqlCommand(Actualizar_Datos_SM, Me.SqlConnection1)
                conexISPM.Parameters.Add(New SqlParameter("@Fecha_Invitacion_ISPM", SqlDbType.SmallDateTime)).Value = DateTimePickerISPM.Text
                conexISPM.Parameters.Add(New SqlParameter("@Estimado_Señor", SqlDbType.NVarChar, 50)).Value = Me.TBEstimado.Text
                conexISPM.Parameters.Add(New SqlParameter("@Ciudadano", SqlDbType.NVarChar, 50)).Value = Me.TBCiudadano.Text
                conexISPM.Parameters.Add(New SqlParameter("@Dia", SqlDbType.NVarChar, 50)).Value = Me.TBDia.Text
                conexISPM.Parameters.Add(New SqlParameter("@Hora", SqlDbType.NChar, 10)).Value = Me.TBHora.Text
                conexISPM.CommandText = Actualizar_Datos_SM
                conexISPM.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub bucar_datos_ISPM()
        Try
            Me.SqlConnection1.Open()
            sqlbusqueda = ("SELECT * FROM ISPM WHERE ISPM.Folio_Mediacion = '" & Mediar.CBFolio_Mediacion.Text & "'")
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            D_ADAPTER.Fill(D_TABLE)
            'DataGridViewMediacion.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                DateTimePickerISPM.Text = D_TABLE.Rows(0)("Fecha_Invitacion_ISPM")
                TBEstimado.Text = D_TABLE.Rows(0)("Estimado_Señor")
                TBCiudadano.Text = D_TABLE.Rows(0)("Ciudadano")
                TBDia.Text = D_TABLE.Rows(0)("Dia")
                TBHora.Text = D_TABLE(0)("Hora")
                BtnActualizarISPM.Enabled = True
            Else
                TBCiudadano.Text = Mediar.TBNombre_SolicitanteM.Text
                'CBEstado_Civil_SM.Text = Mediar.CBEdo_CivilM.Text
                'TBDomicilio_SM.Text = Mediar.TBDomicilioM.Text
                'TBColonia_SM.Text = Mediar.TBColoniaM.Text
                'TBMunicipio_SM.Text = Mediar.TBMunicipioM.Text
                BtnGuardarISPM.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub

    Private Sub BtnGuardarISPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarISPM.Click
        Call guardar_datos_ISPM()
        If swbtn = 1 Then
            BtnGuardarISPM.Enabled = False
            BtnActualizarISPM.Enabled = True
        End If
    End Sub

    Private Sub BtnActualizarISPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarISPM.Click
        Call Actualizar_Datos_ISPM()
    End Sub

End Class