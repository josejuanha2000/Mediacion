Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Litigio
    Private Sub Litigio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MediacionDataSet.Litigio' Puede moverla o quitarla según sea necesario.
        
        Me.LitigioTableAdapter.Fill(Me.MediacionDataSet.Litigio)
        
        'TODO: esta línea de código carga datos en la tabla 'MediacionDataSet.Litigio' Puede moverla o quitarla según sea necesario.
        Me.LitigioTableAdapter.Fill(Me.MediacionDataSet.Litigio)

        Call buscar_ultimo_folio()
        Call cargar_dgv_litigio()
    End Sub

    Sub Agregar_Solicitante_Litigio()
        Dim agregardatos_litigio As String
        agregardatos_litigio = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos_litigio = vbYes Then
                Call buscar_ultimo_folio_ocupado()
                Me.SqlConnection1.Open()
                Dim Insdatosa As String = "INSERT INTO Litigio (Fecha_Asesoria_L,Nombre_Solicitante_L,Domicilio_L,Colonia_L,Mpio_L,Edo_L,Tel_Oficina_L,Tel_Celular_L,E_mail_L,Edo_Civil_L,Ocupacion_L,Asunto_L,Mediador_L) values(@Fecha_Asesoria_L,@Nombre_Solicitante_L,@Domicilio_L,@Colonia_L,@Mpio_L,@Edo_L,@Tel_Oficina_L,@Tel_Celular_L,@E_mail_L,@Edo_Civil_L,@Ocupacion_L,@Asunto_L,@Mediador_L)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdatosa, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Fecha_Asesoria_L", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Solicitante_L", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitante_Litigio.Text
                conex1.Parameters.Add(New SqlParameter("@Domicilio_L", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilio.Text
                conex1.Parameters.Add(New SqlParameter("@Colonia_L", SqlDbType.NChar, 50)).Value = Me.TBColonia.Text
                conex1.Parameters.Add(New SqlParameter("@Mpio_L", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_L", SqlDbType.NVarChar, 50)).Value = Me.TBEdo.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Oficina_L", SqlDbType.NVarChar, 50)).Value = Me.TBOficina.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Celular_L", SqlDbType.NVarChar, 50)).Value = Me.TBCelular.Text
                conex1.Parameters.Add(New SqlParameter("@E_mail_L", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_Civil_L", SqlDbType.NChar, 50)).Value = Me.CBEdo_Civil.Text
                conex1.Parameters.Add(New SqlParameter("@Ocupacion_L", SqlDbType.NVarChar, 50)).Value = TBOcupacion.Text
                conex1.Parameters.Add(New SqlParameter("@Asunto_L", SqlDbType.NVarChar, -1)).Value = TBAsuntoLitigio.Text
                conex1.Parameters.Add(New SqlParameter("@Mediador_L", SqlDbType.NVarChar, 50)).Value = TBMediadorL.Text
                conex1.CommandText = Insdatosa
                conex1.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            End If

        Catch es As Exception
            MsgBox(es.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub

    Sub Actualizar_Datos_Litigio()
        Try
            Dim Actualizar_Li As String
            Me.SqlConnection1.Open()
            Actualizar_Li = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Li = vbYes Then
                'Dim Actualizar_Datos_Litigio As String = ("UPDATE Solicitud SET Aprobo=@Aprobo,Reprobo=@Reprobo,No_presento=@No_presento,Motivo=@Motivo,Calificacion=@Calificacion,Fecha_Publicacion=@Fecha_Publicacion,Maestro_Revision=@Maestro_Revision,Fecha_Examen=@Fecha_Examen,Fecha_Sig_Oport=@Fecha_Sig_Oport,Fecha_Revision=@Fecha_Revision,Alumno_asistio_Modificacion=@Alumno_asistio_Modificacion,Alumno_Asistio_Acuerdo_NoModificacion=@Alumno_Asistio_Acuerdo_NoModificacion,Alumno_NoAsiste_Desacuerdo=@Alumno_NoAsiste_Desacuerdo,Observaciones=@Observaciones where Matricula= '" & TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "and ID = '" & Frm_Solicitud.TBID.Text & "'")
                Dim Actualizar_Datos_Litigio As String = ("UPDATE Litigio SET Fecha_Asesoria_L=@Fecha_Asesoria_L,Nombre_Solicitante_L=@Nombre_Solicitante_L,Domicilio_L=@Domicilio_L,Colonia_L=@Colonia_L,Mpio_L=@Mpio_L,Edo_L=@Edo_L,Tel_Oficina_L=@Tel_Oficina_L,Tel_Celular_L=@Tel_Celular_L,E_mail_L=@E_mail_L,Edo_Civil_L=@Edo_Civil_L,Ocupacion_L=@Ocupacion_L,Asunto_L=@Asunto_L,Mediador_L=@Mediador_L where Folio_Litigio= '" & TBFolioLitigio.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Litigio, Me.SqlConnection1)
                conex2.Parameters.Add(New SqlParameter("@Fecha_Asesoria_L", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex2.Parameters.Add(New SqlParameter("@Nombre_Solicitante_L", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_Solicitante_Litigio.Text
                conex2.Parameters.Add(New SqlParameter("@Domicilio_L", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilio.Text
                conex2.Parameters.Add(New SqlParameter("@Colonia_L", SqlDbType.NChar, 50)).Value = Me.TBColonia.Text
                conex2.Parameters.Add(New SqlParameter("@Mpio_L", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio.Text
                conex2.Parameters.Add(New SqlParameter("@Edo_L", SqlDbType.NVarChar, 50)).Value = Me.TBEdo.Text
                conex2.Parameters.Add(New SqlParameter("@Tel_Oficina_L", SqlDbType.NVarChar, 50)).Value = Me.TBOficina.Text
                conex2.Parameters.Add(New SqlParameter("@Tel_Celular_L", SqlDbType.NVarChar, 50)).Value = Me.TBCelular.Text
                conex2.Parameters.Add(New SqlParameter("@E_mail_L", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio.Text
                conex2.Parameters.Add(New SqlParameter("@Edo_Civil_L", SqlDbType.NChar, 50)).Value = Me.CBEdo_Civil.Text
                conex2.Parameters.Add(New SqlParameter("@Ocupacion_L", SqlDbType.NVarChar, 50)).Value = TBOcupacion.Text
                conex2.Parameters.Add(New SqlParameter("@Asunto_L", SqlDbType.NVarChar, -1)).Value = TBAsuntoLitigio.Text
                conex2.Parameters.Add(New SqlParameter("@Mediador_L", SqlDbType.NVarChar, 50)).Value = TBMediadorL.Text
                conex2.CommandText = Actualizar_Datos_Litigio
                conex2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub buscar_ultimo_folio()
        Try
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Litigio order by folio_Litigio desc")
            Dim DRFolio As SqlClient.SqlDataReader
            DRFolio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolio.Read()
            TBFolioLitigio.Text = DRFolio("Folio_Litigio") + 1
            DRFolio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_ultimo_folio_ocupado()
        Try
            Dim NUEVO_FOLIO As Integer = 0
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Litigio order by folio_Litigio desc")
            Dim DRFolio As SqlClient.SqlDataReader
            DRFolio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolio.Read()
            If TBFolioLitigio.Text = DRFolio("Folio_litigio") Then
                'If DRFolio("Folio_Litigio") = TBFolioLitigio.Text Then
                'SW = 1
                MsgBox("El folio ya fue ocupado!", , " Folio")
                'TBFolioLitigio.Text = DRFolio("Folio_Litigio") + 1
                NUEVO_FOLIO = DRFolio("Folio_Litigio") + 1
                'MsgBox("El nuevo Folio es :" & CStr(TBFolioLitigio.Text) & " Nuevo Folio")
                MsgBox("El nuevo Folio es :" & NUEVO_FOLIO & " Nuevo Folio")
            End If
            DRFolio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub Limpiar_datos_litigacion()
        TBFolioLitigio.Text = ""
        TBNombre_Solicitante_Litigio.Text = ""
        TBDomicilio.Text = ""
        TBColonia.Text = ""
        TBMunicipio.Text = ""
        TBEdo.Text = ""
        TBOficina.Text = ""
        TBCelular.Text = ""
        TBE_mail.Text = ""
        CBEdo_Civil.Text = ""
        TBOcupacion.Text = ""
        TBAsuntoLitigio.Text = ""
        'INVITADOS
        'Me.DateTimePickerMediacion.Text = TimeOfDay()
        Me.TBNombre_Solicitante_Litigio.Focus()
    End Sub
    Sub cargar_dgv_litigio()
        Me.SqlConnection1.Open()
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM Litigio order by Folio_Litigio desc", SqlConnection1)
        Dim DS As New DataSet
        DA.Fill(DS, "Litigio")
        DataGridViewLitigio.DataSource = DS.Tables("Litigio")
        'TBFolioLitigio.Text = DA.Fill(DS, "Folio_Litigio")
        'TBNombre_Solicitante_Litigio.Text = DA.Fill(DS, "Nombre_Solicitante_Litigio")
        Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Dim seleccion As Integer
    'Dim cmdbl As New SqlCommandBuilder
    'Dim ds As New DataSet
    Sub bucar_datos_dgv_litigio()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda = ("SELECT * FROM Litigio WHERE " & TBFolioLitigio.Text & "LIKE" & seleccion & "'ORDER BY FOLIO_LITIGIO'")
            'sqlmatricula_resultado.CommandText = ("Select * from solicitud where solicitud.matricula = '" & Frm_Solicitud.TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "AND ID = '" & Frm_Solicitud.TBID.Text & "'")
            sqlbusqueda = ("SELECT * FROM Litigio WHERE Folio_Litigio = '" & Me.CBFolio_Litigio.Text & "'")
            'ds = New System.Data.DataSet()
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            'D_ADAPTER.Fill(ds, "Litigio")
            D_ADAPTER.Fill(D_TABLE)
            DataGridViewLitigio.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                DateTimePicker1.Text = D_TABLE.Rows(0)("Fecha_Asesoria_L")
                TBFolioLitigio.Text = D_TABLE.Rows(0)("folio_litigio")
                TBNombre_Solicitante_Litigio.Text = D_TABLE.Rows(0)("Nombre_Solicitante_L")
                TBDomicilio.Text = D_TABLE.Rows(0)("Domicilio_L")
                TBColonia.Text = D_TABLE.Rows(0)("Colonia_L")
                TBMunicipio.Text = D_TABLE.Rows(0)("Mpio_L")
                TBEdo.Text = D_TABLE.Rows(0)("Edo_L")
                TBOficina.Text = D_TABLE(0)("Tel_Oficina_L")
                TBCelular.Text = D_TABLE(0)("Tel_Celular_L")
                TBE_mail.Text = D_TABLE(0)("E_MAIL_L")
                CBEdo_Civil.Text = D_TABLE(0)("Edo_Civil_L")
                TBOcupacion.Text = D_TABLE(0)("Ocupacion_L")
                TBAsuntoLitigio.Text = D_TABLE(0)("Asunto_L")
                TBMediadorL.Text = D_TABLE(0)("Mediador_L")
                BtnActualizar.Enabled = True
                BtnImprimir.Enabled = True
                'cmdbl = New SqlCommandBuilder(D_ADAPTER)
                'D_ADAPTER.Update(ds, "Litigio")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub TBFolioLitigio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBFolioLitigio.TextChanged
        'seleccion = TBFolioLitigio.Text
        ''seleccion = "%" & seleccion & "%"
        'Call bucar_datos_dgv_litigio()
    End Sub

    Private Sub BtnVerLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerLista.Click
        Call buscar_ultimo_folio()
        Call cargar_dgv_litigio()
        'TBFolioBusquedaLitigio.Text = " "
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        CBFolio_Litigio.Enabled = True
    End Sub

    Private Sub CBFolio_Litigio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFolio_Litigio.SelectedIndexChanged
        'seleccion = (CBFolio_Litigio.Text)
        ''seleccion = "%" & seleccion & "%"
        'Me.BtnGuardar.Enabled = False
        Call bucar_datos_dgv_litigio()
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Call Agregar_Solicitante_Litigio()
        Call Limpiar_datos_litigacion()
        Call buscar_ultimo_folio()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        CBFolio_Litigio.Enabled = True
        DataGridViewLitigio.Refresh()
    End Sub
    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Call Actualizar_Datos_Litigio()
        Call Limpiar_datos_litigacion()
        Call buscar_ultimo_folio()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        CBFolio_Litigio.Enabled = True
        BtnActualizar.Enabled = False
        DataGridViewLitigio.Refresh()
    End Sub
    
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Call buscar_ultimo_folio()
        Call cargar_dgv_litigio()
        Me.BtnGuardar.Enabled = True
        DateTimePicker1.Text = ""
        'TBFolioLitigio.Text = ""
        TBNombre_Solicitante_Litigio.Text = ""
        TBDomicilio.Text = ""
        TBColonia.Text = ""
        TBMunicipio.Text = ""
        TBEdo.Text = ""
        TBOficina.Text = ""
        TBCelular.Text = ""
        TBE_mail.Text = ""
        CBEdo_Civil.Text = ""
        TBOcupacion.Text = ""
        TBAsuntoLitigio.Text = ""
        TBMediadorL.Text = ""
        TBNombre_Solicitante_Litigio.Focus()
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
        CBFolio_Litigio.Enabled = False
        BtnActualizar.Enabled = False
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim sqldatagrid_litigio As String
        Me.SqlConnection1.Open()
        sqldatagrid_litigio = ("SELECT * FROM Litigio where Litigio.Folio_Litigio = '" & Val(TBFolioLitigio.Text) & "'")
        ORDER_BD = New SqlCommand(sqldatagrid_litigio, Me.SqlConnection1)
        ORDER_BD.CommandType = CommandType.Text
        ORDER_BD.ExecuteNonQuery()
        D_ADAPTER = New SqlDataAdapter(ORDER_BD)
        D_TABLE = New DataTable
        D_ADAPTER.Fill(D_TABLE)
        DataGridViewLitigio.DataSource = D_TABLE
        Dim CR As New CR_LITIGIO
        CR.SetDataSource(D_TABLE)
        Dim RF As New REP_LITIGIO
        RF.CR_LITIGIO .ReportSource = CR
        RF.ShowDialog()
        Me.SqlConnection1.Close()
    End Sub
End Class