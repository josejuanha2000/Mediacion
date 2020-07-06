Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class SM
    Private Sub SM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bucar_datos_SMySO()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Dim SW_SM As Integer = 0
    Sub guardar_datos_SMySO()
        Dim Agregar_Datos_Solicitud_Mediacion As String
        Agregar_Datos_Solicitud_Mediacion = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregar_datos_solicitud_Mediacion = vbYes Then
                'Call buscar_ultimo_folio_ocupado()
                Me.SqlConnection1.Open()
                Dim Insdato_media_SM As String = "INSERT INTO SM (Folio_Mediacion,Fecha_Solicitud_SM,Area_SM,Referencia_SM,Nombre_Solicitante_SM,Edo_Civil_SM,Domicilio_SM,Colonia_SM,Mpio_SM,Edo_SM,Tel_Casa_SM,Tel_Oficina_SM,Tel_Celular_SM,Estudio_Primaria_SM,Estudio_Secundaria_SM,Uni_Superior_SM,Uni_Posgrado_SM,Otros_SM,Nombre_Solicitado_SO,Edo_Civil_SO,Direccion_SO,Tel_Casa_SO,Tel_Oficina_SO,Tel_Celular_SO,Estudio_Primaria_SO,Estudio_Secundaria_SO,Uni_Superior_SO,Uni_Posgrado_SO,Otros_SO,Hechos_SO,Peticiones_SO,Resultados_SO,Proceso_Judicial_SO,Indicar_Proceso_Judicial_SO,Autoridad_SO,Mediador_Anterior,Indicar_Mediador) values(@Folio_Mediacion,@Fecha_Solicitud_SM,@Area_SM,@Referencia_SM,@Nombre_Solicitante_SM,@Edo_Civil_SM,@Domicilio_SM,@Colonia_SM,@Mpio_SM,@Edo_SM,@Tel_Casa_SM,@Tel_Oficina_SM,@Tel_Celular_SM,@Estudio_Primaria_SM,@Estudio_Secundaria_SM,@Uni_Superior_SM,@Uni_Posgrado_SM,@Otros_SM,@Nombre_Solicitado_SO,@Edo_Civil_SO,@Direccion_SO,@Tel_Casa_SO,@Tel_Oficina_SO,@Tel_Celular_SO,@Estudio_Primaria_SO,@Estudio_Secundaria_SO,@Uni_Superior_SO,@Uni_Posgrado_SO,@Otros_SO,@Hechos_SO,@Peticiones_SO,@Resultados_SO,@Proceso_Judicial_SO,@Indicar_Proceso_Judicial_SO,@Autoridad_SO,@Mediador_Anterior,@Indicar_Mediador)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdato_media_SM, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Fecha_Solicitud_SM", SqlDbType.SmallDateTime)).Value = DateTimePicker_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Area_SM", SqlDbType.NVarChar, 50)).Value = Me.TBArea_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Referencia_SM", SqlDbType.NVarChar, 50)).Value = Me.TBReferencia_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Solicitante_SM", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitante_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_Civil_SM", SqlDbType.NVarChar, 50)).Value = Me.CBEstado_Civil_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Domicilio_SM", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilio_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Colonia_SM", SqlDbType.NVarChar, 50)).Value = Me.TBColonia_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Mpio_SM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_SM", SqlDbType.NVarChar, 50)).Value = Me.TBEdo_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Casa_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Casa_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Oficina_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Oficina_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Celular_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Celular_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Estudio_Primaria_SM", SqlDbType.NChar, 1)).Value = Me.CBPrimaria_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Estudio_Secundaria_SM", SqlDbType.NChar, 1)).Value = Me.CBSecundaria_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Uni_Superior_SM", SqlDbType.NChar, 1)).Value = Me.CBSuperior_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Uni_Posgrado_SM", SqlDbType.NChar, 1)).Value = Me.CBPosgrado_SM.Text
                conex1.Parameters.Add(New SqlParameter("@Otros_SM", SqlDbType.NVarChar, 50)).Value = TBOtros_SM.Text
                'INVITADO()
                'Dim Insdato_invitado_SO As String = "INSERT INTO SM (Nombre_Solicitado_SO,Edo_Civil_SO,Direccion_SO,Tel_Casa_SO,Tel_Oficina_SO,Tel_Celular_SO,Estudio_Primaria_SO,Estudio_Secundaria_SO,Uni_Superior_SO,Uni_Posgrado_SO,Otros_SO) values(@Nombre_Solicitado_SO,@Edo_Civil_SO,@Direccion_SO,@Tel_Casa_SO,@Tel_Oficina_SO,@Tel_Celular_SO,@Estudio_Primaria_SO,@Estudio_Secundaria_SO,@Uni_Superior_SO,@Uni_Posgrado_SO,@Otros_SO)"
                'Dim conex2 As New SqlClient.SqlCommand(Insdato_invitado_SO, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Nombre_Solicitado_SO", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitado_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_Civil_SO", SqlDbType.NChar, 50)).Value = Me.CBEstado_Civil_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Direccion_SO", SqlDbType.NVarChar, -1)).Value = Me.TBDireccion_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Casa_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Casa_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Oficina_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Oficina_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Celular_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Celular_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Estudio_Primaria_SO", SqlDbType.NVarChar, 1)).Value = Me.CBPrimaria_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Estudio_Secundaria_SO", SqlDbType.NVarChar, 1)).Value = Me.CBSecundaria_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Uni_Superior_SO", SqlDbType.NVarChar, 1)).Value = Me.CBSuperior_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Uni_Posgrado_SO", SqlDbType.NVarChar, 1)).Value = Me.CBPosgrado_SM2.Text
                conex1.Parameters.Add(New SqlParameter("@Otros_SO", SqlDbType.NVarChar, 50)).Value = TBOtros_SM2.Text

                conex1.Parameters.Add(New SqlParameter("@Hechos_SO", SqlDbType.NVarChar, -1)).Value = TBHechos.Text
                conex1.Parameters.Add(New SqlParameter("@Peticiones_SO", SqlDbType.NVarChar, -1)).Value = TBPeticiones.Text
                conex1.Parameters.Add(New SqlParameter("@Resultados_SO", SqlDbType.NVarChar, -1)).Value = TBResultados.Text
                conex1.Parameters.Add(New SqlParameter("@Proceso_Judicial_SO", SqlDbType.NChar, 1)).Value = CBProceso_Judicial.Text
                conex1.Parameters.Add(New SqlParameter("@Indicar_Proceso_Judicial_SO", SqlDbType.NVarChar, 50)).Value = TBIndicar_Proceso_Judicial.Text
                conex1.Parameters.Add(New SqlParameter("@Autoridad_SO", SqlDbType.NVarChar, 50)).Value = TBAnte_que_autoridad.Text
                conex1.Parameters.Add(New SqlParameter("@Mediador_Anterior", SqlDbType.NChar, 1)).Value = CBhahabido_Mediador_Anterior.Text
                conex1.Parameters.Add(New SqlParameter("@Indicar_Mediador", SqlDbType.NChar, 50)).Value = TBIndicar_Mediador_Anterior.Text
                conex1.CommandText = Insdato_media_SM
                conex1.ExecuteNonQuery()
                'conex2.CommandText = Insdato_invitado_SO
                'conex2.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Actualizar_Datos_SM()
        Try
            Dim Actualizar_SM As String
            Me.SqlConnection1.Open()
            Actualizar_SM = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_SM = vbYes Then
                'Dim Actualizar_Datos_SM As String = ("UPDATE SM SET Folio_Mediacion=@Folio_Mediacion,Fecha_Solicitud_SM=@Fecha_Solicitud_SM,Area_SM=@Area_SM,Referencia_SM=@Referencia_SM,Nombre_Solicitante_SM=@Nombre_Solicitante_SM,Edo_Civil_SM=@Edo_Civil_SM,Domicilio_SM=@Domicilio_SM,Colonia_SM=@Colonia_SM,Mpio_SM=@Mpio_SM,Edo_SM=@Edo_SM,Tel_Casa_SM=@Tel_Casa_SM,Tel_Oficina_SM=@Tel_Oficina_SM,Tel_Celular_SM=@Tel_Celular_SM,Estudio_Primaria_SM=@Estudio_Primaria_SM,Estudio_Secundaria_SM=@Estudio_Secundaria_SM,Uni_Superior_SM=@Uni_Superior_SM,Uni_Posgrado_SM=@Uni_Posgrado_SM,Otros_SM=@Otos_SM where Folio_Mediacion= '" & Mediar.CBFolio_Mediacion.Text & "'")
                Dim Actualizar_Datos_SM As String = ("UPDATE SM SET Folio_Mediacion=@Folio_Mediacion,Fecha_Solicitud_SM=@Fecha_Solicitud_SM,Area_SM=@Area_SM,Referencia_SM=@Referencia_SM,Nombre_Solicitante_SM=@Nombre_Solicitante_SM,Edo_Civil_SM=@Edo_Civil_SM,Domicilio_SM=@Domicilio_SM,Colonia_SM=@Colonia_SM,Mpio_SM=@Mpio_SM,Edo_SM=@Edo_SM,Tel_Casa_SM=@Tel_Casa_SM,Tel_Oficina_SM=@Tel_Oficina_SM,Tel_Celular_SM=@Tel_Celular_SM,Estudio_Primaria_SM=@Estudio_Primaria_SM,Estudio_Secundaria_SM=@Estudio_Secundaria_SM,Uni_Superior_SM=@Uni_Superior_SM,Uni_Posgrado_SM=@Uni_Posgrado_SM,Otros_SM=@Otros_SM where Folio_Mediacion= '" & Mediar.CBFolio_Mediacion.Text & "'")

                Dim conexSM As New SqlClient.SqlCommand(Actualizar_Datos_SM, Me.SqlConnection1)
                conexSM.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conexSM.Parameters.Add(New SqlParameter("@Fecha_Solicitud_SM", SqlDbType.SmallDateTime)).Value = DateTimePicker_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Area_SM", SqlDbType.NVarChar, 50)).Value = Me.TBArea_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Referencia_SM", SqlDbType.NVarChar, 50)).Value = Me.TBReferencia_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Nombre_Solicitante_SM", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitante_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Edo_Civil_SM", SqlDbType.NVarChar, 50)).Value = Me.CBEstado_Civil_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Domicilio_SM", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilio_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Colonia_SM", SqlDbType.NVarChar, 50)).Value = Me.TBColonia_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Mpio_SM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Edo_SM", SqlDbType.NVarChar, 50)).Value = Me.TBEdo_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Tel_Casa_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Casa_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Tel_Oficina_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Oficina_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Tel_Celular_SM", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Celular_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Estudio_Primaria_SM", SqlDbType.NChar, 1)).Value = Me.CBPrimaria_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Estudio_Secundaria_SM", SqlDbType.NChar, 1)).Value = Me.CBSecundaria_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Uni_Superior_SM", SqlDbType.NChar, 1)).Value = Me.CBSuperior_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Uni_Posgrado_SM", SqlDbType.NChar, 1)).Value = Me.CBPosgrado_SM.Text
                conexSM.Parameters.Add(New SqlParameter("@Otros_SM", SqlDbType.NVarChar, 50)).Value = TBOtros_SM.Text
                'Actualiza datos de invitados
                conexSM.CommandText = Actualizar_Datos_SM
                conexSM.ExecuteNonQuery()

                Dim Actualizar_Datos_SM2 As String = ("UPDATE SM SET Nombre_Solicitado_SO=@Nombre_Solicitado_SO,Edo_Civil_SO=@Edo_Civil_SO,Direccion_SO=@Direccion_SO,Tel_Casa_SO=@Tel_Casa_SO,Tel_Oficina_SO=@Tel_Oficina_SO,Tel_Celular_SO=@Tel_Celular_SO,Estudio_Primaria_SO=@Estudio_Primaria_SO,Estudio_Secundaria_SO=@Estudio_Secundaria_SO,Uni_Superior_SO=@Uni_Superior_SO,Uni_Posgrado_SO=@Uni_Posgrado_SO,Otros_SO=@Otros_SO,Hechos_SO=@Hechos_SO,Peticiones_SO=@Peticiones_SO,Resultados_SO=@Resultados_SO,Proceso_Judicial_SO=@Proceso_Judicial_SO,Indicar_Proceso_Judicial_SO=@Indicar_Proceso_Judicial_SO,Autoridad_SO=@Autoridad_SO,Mediador_Anterior=@Mediador_Anterior,Indicar_Mediador=@Indicar_Mediador  where Folio_Mediacion= '" & Mediar.TBFolioMediacion.Text & "'")
                Dim conexSM2 As New SqlClient.SqlCommand(Actualizar_Datos_SM2, Me.SqlConnection1)
                conexSM2.Parameters.Add(New SqlParameter("@Nombre_Solicitado_SO", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitado_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Edo_Civil_SO", SqlDbType.NChar, 50)).Value = Me.CBEstado_Civil_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Direccion_SO", SqlDbType.NVarChar, -1)).Value = Me.TBDireccion_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Tel_Casa_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Casa_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Tel_Oficina_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Oficina_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Tel_Celular_SO", SqlDbType.NVarChar, 50)).Value = Me.TBTel_Celular_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Estudio_Primaria_SO", SqlDbType.NVarChar, 1)).Value = Me.CBPrimaria_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Estudio_Secundaria_SO", SqlDbType.NVarChar, 1)).Value = Me.CBSecundaria_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Uni_Superior_SO", SqlDbType.NVarChar, 1)).Value = Me.CBSuperior_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Uni_Posgrado_SO", SqlDbType.NVarChar, 1)).Value = Me.CBPosgrado_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Otros_SO", SqlDbType.NVarChar, 50)).Value = TBOtros_SM2.Text
                conexSM2.Parameters.Add(New SqlParameter("@Hechos_SO", SqlDbType.NVarChar, -1)).Value = TBHechos.Text
                conexSM2.Parameters.Add(New SqlParameter("@Peticiones_SO", SqlDbType.NVarChar, -1)).Value = TBPeticiones.Text
                conexSM2.Parameters.Add(New SqlParameter("@Resultados_SO", SqlDbType.NVarChar, -1)).Value = TBResultados.Text
                conexSM2.Parameters.Add(New SqlParameter("@Proceso_Judicial_SO", SqlDbType.NChar, 1)).Value = CBProceso_Judicial.Text
                conexSM2.Parameters.Add(New SqlParameter("@Indicar_Proceso_Judicial_SO", SqlDbType.NVarChar, 50)).Value = TBIndicar_Proceso_Judicial.Text
                conexSM2.Parameters.Add(New SqlParameter("@Autoridad_SO", SqlDbType.NVarChar, 50)).Value = TBAnte_que_autoridad.Text
                conexSM2.Parameters.Add(New SqlParameter("@Mediador_Anterior", SqlDbType.NChar, 1)).Value = CBhahabido_Mediador_Anterior.Text
                conexSM2.Parameters.Add(New SqlParameter("@Indicar_Mediador", SqlDbType.NChar, 50)).Value = TBIndicar_Mediador_Anterior.Text
                conexSM2.CommandText = Actualizar_Datos_SM2
                conexSM2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub bucar_datos_SMySO()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda = ("SELECT * FROM Litigio WHERE " & TBFolioLitigio.Text & "LIKE" & seleccion & "'ORDER BY FOLIO_LITIGIO'")
            'sqlmatricula_resultado.CommandText = ("Select * from solicitud where solicitud.matricula = '" & Frm_Solicitud.TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "AND ID = '" & Frm_Solicitud.TBID.Text & "'")
            sqlbusqueda = ("SELECT * FROM SM WHERE SM.Folio_Mediacion = '" & Mediar.CBFolio_Mediacion.Text & "'")
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            D_ADAPTER.Fill(D_TABLE)
            'DataGridViewMediacion.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                SW_SM = 1
                DateTimePicker_SM.Text = D_TABLE.Rows(0)("Fecha_Solicitud_SM")
                'CBFolio_Mediacion.Text = D_TABLE.Rows(0)("Folio_Mediacion")
                TBArea_SM.Text = D_TABLE.Rows(0)("Area_SM")
                TBReferencia_SM.Text = D_TABLE.Rows(0)("Referencia_SM")
                TBNombre_Solicitante_SM.Text = D_TABLE.Rows(0)("Nombre_Solicitante_SM")
                CBEstado_Civil_SM.Text = D_TABLE(0)("Edo_Civil_SM")
                TBDomicilio_SM.Text = D_TABLE.Rows(0)("Domicilio_SM")
                TBColonia_SM.Text = D_TABLE.Rows(0)("Colonia_SM")
                TBMunicipio_SM.Text = D_TABLE.Rows(0)("Mpio_SM")
                TBEdo_SM.Text = D_TABLE.Rows(0)("Edo_SM")
                TBTel_Casa_SM.Text = D_TABLE(0)("Tel_Casa_SM")
                TBTel_Oficina_SM.Text = D_TABLE(0)("Tel_Oficina_SM")
                TBTel_Celular_SM.Text = D_TABLE(0)("Tel_Celular_SM")
                CBPrimaria_SM.Text = D_TABLE(0)("Estudio_Primaria_SM")
                CBSecundaria_SM.Text = D_TABLE(0)("Estudio_Secundaria_SM")
                CBSuperior_SM.Text = D_TABLE(0)("Uni_Superior_SM")
                CBPosgrado_SM.Text = D_TABLE(0)("Uni_Posgrado_SM")
                TBOtros_SM.Text = D_TABLE(0)("Otros_SM")

                'DATOS DEL INVITADO
                TBNombre_Solicitado_SM2.Text = D_TABLE.Rows(0)("Nombre_Solicitado_SO")
                CBEstado_Civil_SM2.Text = D_TABLE(0)("Edo_Civil_SO")
                TBDireccion_SM2.Text = D_TABLE.Rows(0)("Direccion_SO")
                TBTel_Casa_SM2.Text = D_TABLE(0)("Tel_Casa_SO")
                TBTel_Oficina_SM2.Text = D_TABLE(0)("Tel_Oficina_SO")
                TBTel_Celular_SM2.Text = D_TABLE(0)("Tel_Celular_SO")
                CBPrimaria_SM2.Text = D_TABLE(0)("Estudio_Primaria_SO")
                CBSecundaria_SM2.Text = D_TABLE(0)("Estudio_Secundaria_SO")
                CBSuperior_SM2.Text = D_TABLE(0)("Uni_Superior_SO")
                CBPosgrado_SM2.Text = D_TABLE(0)("Uni_Posgrado_SO")
                TBOtros_SM2.Text = D_TABLE(0)("Otros_SO")
                TBHechos.Text = D_TABLE.Rows(0)("Hechos_SO")
                TBPeticiones.Text = D_TABLE.Rows(0)("Peticiones_SO")
                TBResultados.Text = D_TABLE.Rows(0)("Resultados_SO")
                CBProceso_Judicial.Text = D_TABLE.Rows(0)("Proceso_Judicial_SO")
                TBIndicar_Proceso_Judicial.Text = D_TABLE.Rows(0)("Indicar_Proceso_Judicial_SO")
                TBAnte_que_autoridad.Text = D_TABLE.Rows(0)("Autoridad_SO")
                CBhahabido_Mediador_Anterior.Text = D_TABLE.Rows(0)("Mediador_Anterior")
                TBIndicar_Mediador_Anterior.Text = D_TABLE.Rows(0)("Indicar_Mediador")
                BtnActualizarSM.Enabled = True
            Else
                SW_SM = 2
                TBNombre_Solicitante_SM.Text = Mediar.TBNombre_SolicitanteM.Text
                CBEstado_Civil_SM.Text = Mediar.CBEdo_CivilM.Text
                TBDomicilio_SM.Text = Mediar.TBDomicilioM.Text
                TBColonia_SM.Text = Mediar.TBColoniaM.Text
                TBMunicipio_SM.Text = Mediar.TBMunicipioM.Text
                TBEdo_SM.Text = Mediar.TBEdoM.Text
                TBTel_Oficina_SM.Text = Mediar.TBOficinaM.Text
                TBTel_Celular_SM.Text = Mediar.TBCelularM.Text
                BTNGuardarSM.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub BTNGuardarSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardarSM.Click
        Call guardar_datos_SMySO()
        If SW_SM = 1 Then
            BTNGuardarSM.Enabled = False
            BtnActualizarSM.Enabled = True
        End If
    End Sub
    Private Sub BtnActualizarSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarSM.Click
        Call Actualizar_Datos_SM()
    End Sub
End Class