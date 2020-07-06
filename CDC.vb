Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class CDC
    Private Sub CDC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bucar_datos_CDC()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Dim swbtn As Integer = 0
    Sub guardar_datos_CDC()
        Dim Agregar_Datos_Solicitud_Mediacion As String
        Agregar_Datos_Solicitud_Mediacion = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If Agregar_Datos_Solicitud_Mediacion = vbYes Then
                swbtn = 1
                Me.SqlConnection1.Open()
                Dim Insdato_media_CDC As String = "INSERT INTO CDC(Folio_Mediacion,Dia,Mes,Año,Nombre_M1,Nombre_M2,Nombre_M3,Solicitante,Solicitado,Mediador) values(@Folio_Mediacion,@Dia,@Mes,@Año,@Nombre_M1,@Nombre_M2,@Nombre_M3,@Solicitante,@Solicitado,@Mediador)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdato_media_CDC, Me.SqlConnection1)
                'conex1.Parameters.Add(New SqlParameter("@'echa_Invitacion_ISPM", SqlDbType.SmallDateTime)).Value = DateTimePickerISPM.Text
                conex1.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Dia", SqlDbType.NChar, 2)).Value = CBDia.Text
                conex1.Parameters.Add(New SqlParameter("@Mes", SqlDbType.NChar, 10)).Value = CBMes.Text
                conex1.Parameters.Add(New SqlParameter("@Año", SqlDbType.NChar, 4)).Value = CBAño.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_M1", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M1.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_M2", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M2.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_M3", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M3.Text
                conex1.Parameters.Add(New SqlParameter("@Solicitante", SqlDbType.NVarChar, 50)).Value = Me.TBSolicitante.Text
                conex1.Parameters.Add(New SqlParameter("@Solicitado", SqlDbType.NVarChar, 50)).Value = Me.TBSolicitante.Text
                conex1.Parameters.Add(New SqlParameter("@Mediador", SqlDbType.NVarChar, 50)).Value = Me.TBMediador.Text
                conex1.CommandText = Insdato_media_CDC
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
    Sub Actualizar_Datos_CDC()
        Try
            Dim Actualizar_CDC As String
            Me.SqlConnection1.Open()
            Actualizar_CDC = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_CDC = vbYes Then
                Dim Actualizar_Datos_CDC As String = ("UPDATE CDC SET Folio_Mediacion=@Folio_Mediacion,Dia=@Dia,Mes=@Mes,Año=@Año,Nombre_M1=@Nombre_M1,Nombre_M2=@Nombre_M2,Nombre_M3=@Nombre_M3,Solicitante=@Solicitante,Solicitado=@Solicitado,Mediador=@Mediador where Folio_Mediacion= '" & Mediar.CBFolio_Mediacion.Text & "'")
                Dim conexCDC As New SqlClient.SqlCommand(Actualizar_Datos_CDC, Me.SqlConnection1)
                conexCDC.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conexCDC.Parameters.Add(New SqlParameter("@Dia", SqlDbType.NChar, 2)).Value = CBDia.Text
                conexCDC.Parameters.Add(New SqlParameter("@Mes", SqlDbType.NChar, 10)).Value = CBMes.Text
                conexCDC.Parameters.Add(New SqlParameter("@Año", SqlDbType.NChar, 4)).Value = CBAño.Text
                conexCDC.Parameters.Add(New SqlParameter("@Nombre_M1", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M1.Text
                conexCDC.Parameters.Add(New SqlParameter("@Nombre_M2", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M2.Text
                conexCDC.Parameters.Add(New SqlParameter("@Nombre_M3", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_M3.Text
                conexCDC.Parameters.Add(New SqlParameter("@Solicitante", SqlDbType.NVarChar, 50)).Value = Me.TBSolicitante.Text
                conexCDC.Parameters.Add(New SqlParameter("@Solicitado", SqlDbType.NVarChar, 50)).Value = Me.TBSolicitado.Text
                conexCDC.Parameters.Add(New SqlParameter("@Mediador", SqlDbType.NVarChar, 50)).Value = Me.TBMediador.Text
                conexCDC.CommandText = Actualizar_Datos_CDC
                conexCDC.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub bucar_datos_CDC()
        Try
            Me.SqlConnection1.Open()
            sqlbusqueda = ("SELECT * FROM CDC WHERE CDC.Folio_Mediacion = '" & Mediar.CBFolio_Mediacion.Text & "'")
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            D_ADAPTER.Fill(D_TABLE)
            'DataGridViewMediacion.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                CBDia.Text = D_TABLE.Rows(0)("Dia")
                CBMes.Text = D_TABLE.Rows(0)("Mes")
                CBAño.Text = D_TABLE.Rows(0)("Año")
                TBNombre_M1.Text = D_TABLE.Rows(0)("Nombre_M1")
                TBNombre_M2.Text = D_TABLE.Rows(0)("Nombre_M2")
                TBNombre_M3.Text = D_TABLE(0)("Nombre_M3")
                TBSolicitante.Text = D_TABLE.Rows(0)("Solicitante")
                TBSolicitado.Text = D_TABLE.Rows(0)("Solicitado")
                TBMediador.Text = D_TABLE(0)("Mediador")
                BtnActualizarCDC.Enabled = True
            Else
                'TBCiudadano.Text = Mediar.TBNombre_SolicitanteM.Text
                'CBEstado_Civil_SM.Text = Mediar.CBEdo_CivilM.Text
                'TBDomicilio_SM.Text = Mediar.TBDomicilioM.Text
                'TBColonia_SM.Text = Mediar.TBColoniaM.Text
                'TBMunicipio_SM.Text = Mediar.TBMunicipioM.Text
                BtnGuardarCDC.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub BtnGuardarCDC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarCDC.Click
        Call guardar_datos_CDC()
        If swbtn = 1 Then
            BtnGuardarCDC.Enabled = False
            BtnActualizarCDC.Enabled = True
        End If
    End Sub

    Private Sub BtnActualizarCDC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarCDC.Click
        Call Actualizar_Datos_CDC()
    End Sub

End Class