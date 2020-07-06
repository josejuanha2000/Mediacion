Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Mediar
    Private Sub Mediar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MediacionDataSet1.Mediacion' Puede moverla o quitarla según sea necesario.
        'Me.MediacionTableAdapter.Fill(Me.MediacionDataSet1.Mediacion)
        'TODO: esta línea de código carga datos en la tabla 'MediacionDataSet2.Mediacion' Puede moverla o quitarla según sea necesario.
        'Me.MediacionTableAdapter.Fill(Me.MediacionDataSet2.Mediacion)
        Call buscar_ultimo_folio()
        Call cargar_dgv_mediacion()
    End Sub
    Sub Agregar_Solicitante_Mediacion()
        Dim agregardatos_solicitud As String
        agregardatos_solicitud = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos_solicitud = vbYes Then
                Call buscar_ultimo_folio_ocupado()
                Me.SqlConnection1.Open()
                Dim Insdatomedia As String = "INSERT INTO Mediacion (Fecha_Asesoria_M,Nombre_Solicitante_M,Domicilio_M,Colonia_M,Mpio_M,Edo_M,Tel_Oficina_M,Tel_Celular_M,E_mail_M,Edo_Civil_M,Ocupacion_M,Asunto_M,Nombre_Invitado,Domicilio_I,Colonia_I,Mpio_I,Edo_I,Tel_Oficina_I,Tel_Celular_I,E_mail_I,Edo_Civil_I,Ocupacion_I,Mediador_M,Status_M,Usuario) values(@Fecha_Asesoria_M,@Nombre_Solicitante_M,@Domicilio_M,@Colonia_M,@Mpio_M,@Edo_M,@Tel_Oficina_M,@Tel_Celular_M,@E_mail_M,@Edo_Civil_M,@Ocupacion_M,@Asunto_M,@Nombre_Invitado,@Domicilio_I,@Colonia_I,@Mpio_I,@Edo_I,@Tel_Oficina_I,@Tel_Celular_I,@E_mail_I,@Edo_Civil_I,@Ocupacion_I,@Mediador_M,@Status_M,@Usuario)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdatomedia, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Fecha_Asesoria_M", SqlDbType.SmallDateTime)).Value = DateTimePickerMediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Solicitante_M", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_SolicitanteM.Text
                conex1.Parameters.Add(New SqlParameter("@Domicilio_M", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilioM.Text
                conex1.Parameters.Add(New SqlParameter("@Colonia_M", SqlDbType.NChar, 50)).Value = Me.TBColoniaM.Text
                conex1.Parameters.Add(New SqlParameter("@Mpio_M", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipioM.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_M", SqlDbType.NVarChar, 50)).Value = Me.TBEdoM.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Oficina_M", SqlDbType.NVarChar, 50)).Value = Me.TBOficinaM.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Celular_M", SqlDbType.NVarChar, 50)).Value = Me.TBCelularM.Text
                conex1.Parameters.Add(New SqlParameter("@E_mail_M", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipioM.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_Civil_M", SqlDbType.NChar, 50)).Value = Me.CBEdo_CivilM.Text
                conex1.Parameters.Add(New SqlParameter("@Ocupacion_M", SqlDbType.NVarChar, 50)).Value = TBOcupacionM.Text
                conex1.Parameters.Add(New SqlParameter("@Asunto_M", SqlDbType.NVarChar, -1)).Value = TBAsuntoMediacionM.Text
                ' conex1.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = LoginMediacion.UsernameTextBox.Text

                'INVITADO
                'Dim Insdatoinvitado As String = "INSERT INTO Mediacion (Nombre_Invitado,Domicilio_I,Colonia_I,Mpio_I,Edo_I,Tel_Oficina_I,Tel_Celular_I,E_mail_I,Edo_Civil_I,Ocupacion_I) values(@Nombre_Invitado,@Domicilio_I,@Colonia_I,@Mpio_I,@Edo_I,@Tel_Oficina_I,@Tel_Celular_I,@E_mail_I,@Edo_Civil_I,@Ocupacion_I)"
                'Dim conex2 As New SqlClient.SqlCommand(Insdatoinvitado, Me.SqlConnection1)
                'conex2.Parameters.Add(New SqlParameter("@Fecha_Asesoria_M", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Invitado", SqlDbType.NVarChar, 50)).Value = Me.TBNombreInvitado.Text
                conex1.Parameters.Add(New SqlParameter("@Domicilio_I", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilioI.Text
                conex1.Parameters.Add(New SqlParameter("@Colonia_I", SqlDbType.NChar, 50)).Value = Me.TBColoniaI.Text
                conex1.Parameters.Add(New SqlParameter("@Mpio_I", SqlDbType.NVarChar, 50)).Value = Me.TBMpioI.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_I", SqlDbType.NVarChar, 50)).Value = Me.TBEdoI.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Oficina_I", SqlDbType.NVarChar, 50)).Value = Me.TBOficinaI.Text
                conex1.Parameters.Add(New SqlParameter("@Tel_Celular_I", SqlDbType.NVarChar, 50)).Value = Me.TBCelularI.Text
                conex1.Parameters.Add(New SqlParameter("@E_mail_I", SqlDbType.NVarChar, 50)).Value = Me.TBMpioI.Text
                conex1.Parameters.Add(New SqlParameter("@Edo_Civil_I", SqlDbType.NChar, 50)).Value = Me.CBEdoCivilI.Text
                conex1.Parameters.Add(New SqlParameter("@Ocupacion_I", SqlDbType.NVarChar, 50)).Value = Me.TBOcupacionI.Text
                conex1.Parameters.Add(New SqlParameter("@Mediador_M", SqlDbType.NVarChar, 50)).Value = Me.TBMediadorM.Text
                conex1.Parameters.Add(New SqlParameter("@Status_M", SqlDbType.NVarChar, 50)).Value = Me.CBStatus.Text
                conex1.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = LoginMediacion.UsernameTextBox.Text

                conex1.CommandText = Insdatomedia
                conex1.ExecuteNonQuery()
                'conex2.CommandText = Insdatoinvitado
                'conex2.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Actualizar_Datos_Mediacion()
        Try
            Dim Actualizar_Mi As String
            Me.SqlConnection1.Open()
            Actualizar_Mi = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Mi = vbYes Then
                Dim Actualizar_Datos_Mediacion As String = ("UPDATE Mediacion SET Fecha_Asesoria_M=@Fecha_Asesoria_M,Nombre_Solicitante_M=@Nombre_Solicitante_M,Domicilio_M=@Domicilio_M,Colonia_M=@Colonia_M,Mpio_M=@Mpio_M,Edo_M=@Edo_M,Tel_Oficina_M=@Tel_Oficina_M,Tel_Celular_M=@Tel_Celular_M,E_mail_M=@E_mail_M,Edo_Civil_M=@Edo_Civil_M,Ocupacion_M=@Ocupacion_M,Asunto_M=@Asunto_M,Mediador_M=@Mediador_M,Status_M=@Status_M where Folio_Mediacion= '" & TBFolioMediacion.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Mediacion, Me.SqlConnection1)
                conex2.Parameters.Add(New SqlParameter("@Fecha_Asesoria_M", SqlDbType.SmallDateTime)).Value = DateTimePickerMediacion.Text
                conex2.Parameters.Add(New SqlParameter("@Nombre_Solicitante_M", SqlDbType.NVarChar, 50)).Value = Me.TBNombre_SolicitanteM.Text
                conex2.Parameters.Add(New SqlParameter("@Domicilio_M", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilioM.Text
                conex2.Parameters.Add(New SqlParameter("@Colonia_M", SqlDbType.NChar, 50)).Value = Me.TBColoniaM.Text
                conex2.Parameters.Add(New SqlParameter("@Mpio_M", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipioM.Text
                conex2.Parameters.Add(New SqlParameter("@Edo_M", SqlDbType.NVarChar, 50)).Value = Me.TBEdoM.Text
                conex2.Parameters.Add(New SqlParameter("@Tel_Oficina_M", SqlDbType.NVarChar, 50)).Value = Me.TBOficinaM.Text
                conex2.Parameters.Add(New SqlParameter("@Tel_Celular_M", SqlDbType.NVarChar, 50)).Value = Me.TBCelularM.Text
                conex2.Parameters.Add(New SqlParameter("@E_mail_M", SqlDbType.NVarChar, 50)).Value = Me.TBE_mailM.Text
                conex2.Parameters.Add(New SqlParameter("@Edo_Civil_M", SqlDbType.NChar, 50)).Value = Me.CBEdo_CivilM.Text
                conex2.Parameters.Add(New SqlParameter("@Ocupacion_M", SqlDbType.NVarChar, 50)).Value = TBOcupacionM.Text
                conex2.Parameters.Add(New SqlParameter("@Asunto_M", SqlDbType.NVarChar, -1)).Value = TBAsuntoMediacionM.Text
                conex2.Parameters.Add(New SqlParameter("@Mediador_M", SqlDbType.NVarChar, 50)).Value = TBMediadorM.Text
                conex2.Parameters.Add(New SqlParameter("@Status_M", SqlDbType.NVarChar, 50)).Value = CBStatus.Text
                conex2.CommandText = Actualizar_Datos_Mediacion
                conex2.ExecuteNonQuery()
                'actualiza datos de invitados
                Dim Actualizar_Datos_Invitado As String = ("UPDATE Mediacion SET Nombre_Invitado=@Nombre_Invitado,Domicilio_I=@Domicilio_I,Colonia_I=@Colonia_I,Mpio_I=@Mpio_I,Edo_I=@Edo_I,Tel_Oficina_I=@Tel_Oficina_I,Tel_Celular_I=@Tel_Celular_I,E_mail_I=@E_mail_I,Edo_Civil_I=@Edo_Civil_I,Ocupacion_I=@Ocupacion_I,Usuario=@Usuario where Folio_Mediacion= '" & TBFolioMediacion.Text & "'")
                Dim conex3 As New SqlClient.SqlCommand(Actualizar_Datos_Invitado, Me.SqlConnection1)
                conex3.Parameters.Add(New SqlParameter("@Nombre_Invitado", SqlDbType.NVarChar, 50)).Value = Me.TBNombreInvitado.Text
                conex3.Parameters.Add(New SqlParameter("@Domicilio_I", SqlDbType.NVarChar, 50)).Value = Me.TBDomicilioI.Text
                conex3.Parameters.Add(New SqlParameter("@Colonia_I", SqlDbType.NChar, 50)).Value = Me.TBColoniaI.Text
                conex3.Parameters.Add(New SqlParameter("@Mpio_I", SqlDbType.NVarChar, 50)).Value = Me.TBMpioI.Text
                conex3.Parameters.Add(New SqlParameter("@Edo_I", SqlDbType.NVarChar, 50)).Value = Me.TBEdoI.Text
                conex3.Parameters.Add(New SqlParameter("@Tel_Oficina_I", SqlDbType.NVarChar, 50)).Value = Me.TBOficinaI.Text
                conex3.Parameters.Add(New SqlParameter("@Tel_Celular_I", SqlDbType.NVarChar, 50)).Value = Me.TBCelularI.Text
                conex3.Parameters.Add(New SqlParameter("@E_mail_I", SqlDbType.NVarChar, 50)).Value = Me.TBEmailI.Text
                conex3.Parameters.Add(New SqlParameter("@Edo_Civil_I", SqlDbType.NChar, 50)).Value = Me.CBEdoCivilI.Text
                conex3.Parameters.Add(New SqlParameter("@Ocupacion_I", SqlDbType.NVarChar, 50)).Value = TBOcupacionI.Text
                conex3.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = LoginMediacion.UsernameTextBox.Text

                conex3.CommandText = Actualizar_Datos_Invitado
                conex3.ExecuteNonQuery()
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
            comsql.CommandText = ("select top 1 * from Mediacion order by folio_Mediacion desc")
            Dim DRFolioMediacion As SqlClient.SqlDataReader
            DRFolioMediacion = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolioMediacion.Read()
            TBFolioMediacion.Text = DRFolioMediacion("Folio_Mediacion") + 1
            DRFolioMediacion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_ultimo_folio_ocupado()
        Try
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Mediacion order by Folio_Mediacion desc")
            Dim DRFolioM As SqlClient.SqlDataReader
            DRFolioM = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolioM.Read()
            If TBFolioMediacion.Text = DRFolioM("Folio_Mediacion") Then
                'SW = 1 
                MsgBox("El folio ya fue ocupado!", , " Folio")
                TBFolioMediacion.Text = DRFolioM("Folio_Mediacion") + 1
                MsgBox("El nuevo Folio es :" & (TBFolioMediacion.Text) & " Nuevo Folio")
            End If
            DRFolioM.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub Limpiar_datos_mediacion()
        TBFolioMediacion.Text = ""
        TBNombre_SolicitanteM.Text = ""
        TBDomicilioM.Text = ""
        TBColoniaM.Text = ""
        TBMunicipioM.Text = ""
        TBEdoM.Text = ""
        TBOficinaM.Text = ""
        TBCelularM.Text = ""
        TBE_mailM.Text = ""
        CBEdo_CivilM.Text = ""
        TBOcupacionM.Text = ""
        TBAsuntoMediacionM.Text = ""
        'INVITADOS
        TBNombreInvitado.Text = ""
        TBDomicilioI.Text = ""
        TBColoniaI.Text = ""
        TBMpioI.Text = ""
        TBEdoI.Text = ""
        TBOficinaI.Text = ""
        TBCelularI.Text = ""
        TBEmailI.Text = ""
        CBEdoCivilI.Text = ""
        TBOcupacionI.Text = ""
        CBStatus.Text = ""
        'Me.DateTimePickerMediacion.Text = TimeOfDay()
        Me.TBNombre_SolicitanteM.Focus()
    End Sub
    Sub cargar_dgv_mediacion()
        Me.SqlConnection1.Open()
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM Mediacion order by folio_mediacion desc", SqlConnection1)
        Dim DS As New DataSet
        DA.Fill(DS, "Mediacion")
        DataGridViewMediacion.DataSource = DS.Tables("Mediacion")
        Me.SqlConnection1.Close()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Sub bucar_datos_dgv_Mediacion()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda = ("SELECT * FROM Litigio WHERE " & TBFolioLitigio.Text & "LIKE" & seleccion & "'ORDER BY FOLIO_LITIGIO'")
            'sqlmatricula_resultado.CommandText = ("Select * from solicitud where solicitud.matricula = '" & Frm_Solicitud.TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "AND ID = '" & Frm_Solicitud.TBID.Text & "'")
            sqlbusqueda = ("SELECT * FROM Mediacion WHERE Mediacion.Folio_Mediacion = '" & Me.CBFolio_Mediacion.Text & "'")
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            D_ADAPTER.Fill(D_TABLE)
            DataGridViewMediacion.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                DateTimePickerMediacion.Text = D_TABLE.Rows(0)("Fecha_Asesoria_M")
                TBFolioMediacion.Text = D_TABLE.Rows(0)("Folio_Mediacion")
                TBNombre_SolicitanteM.Text = D_TABLE.Rows(0)("Nombre_Solicitante_M")
                TBDomicilioM.Text = D_TABLE.Rows(0)("Domicilio_M")
                TBColoniaM.Text = D_TABLE.Rows(0)("Colonia_M")
                TBMunicipioM.Text = D_TABLE.Rows(0)("Mpio_M")
                TBEdoM.Text = D_TABLE.Rows(0)("Edo_M")
                TBOficinaM.Text = D_TABLE(0)("Tel_Oficina_M")
                TBCelularM.Text = D_TABLE(0)("Tel_Celular_M")
                TBE_mailM.Text = D_TABLE(0)("E_MAIL_M")
                CBEdo_CivilM.Text = D_TABLE(0)("Edo_Civil_M")
                TBOcupacionM.Text = D_TABLE(0)("Ocupacion_M")
                TBAsuntoMediacionM.Text = D_TABLE(0)("Asunto_M")
                TBMediadorM.Text = D_TABLE(0)("Mediador_M")
                CBStatus.Text = D_TABLE(0)("Status_M")
                'DATOS DEL INVITADO
                TBNombreInvitado.Text = D_TABLE.Rows(0)("Nombre_Invitado")
                TBDomicilioI.Text = D_TABLE.Rows(0)("Domicilio_I")
                TBColoniaI.Text = D_TABLE.Rows(0)("Colonia_I")
                TBMpioI.Text = D_TABLE.Rows(0)("Mpio_I")
                TBEdoI.Text = D_TABLE.Rows(0)("Edo_I")
                TBOficinaI.Text = D_TABLE(0)("Tel_Oficina_I")
                TBCelularI.Text = D_TABLE(0)("Tel_Celular_I")
                TBEmailI.Text = D_TABLE(0)("E_MAIL_I")
                CBEdoCivilI.Text = D_TABLE(0)("Edo_Civil_I")
                TBOcupacionI.Text = D_TABLE(0)("Ocupacion_I")
                BtnActualizacionM.Enabled = True
                BtnSDM.Enabled = True
                BtnISPM.Enabled = True
                BtnCDC.Enabled = True
                BtnCDM.Enabled = True
                Btn_Imprimir.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Call Agregar_Solicitante_Mediacion()
        Call Limpiar_datos_mediacion()
        Call buscar_ultimo_folio()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        CBFolio_Mediacion.Enabled = True
        DataGridViewMediacion.Refresh()
    End Sub
    Private Sub BtnVerLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerLista.Click
        Call buscar_ultimo_folio()
        Call cargar_dgv_mediacion()
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        CBFolio_Mediacion.Enabled = True
        BtnActualizacionM.Enabled = False
        BtnSDM.Enabled = False
        BtnISPM.Enabled = False
        BtnCDC.Enabled = False
        BtnCDM.Enabled = False
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Call buscar_ultimo_folio()
        Call cargar_dgv_mediacion()
        Me.BtnGuardar.Enabled = True
        DateTimePickerMediacion.Text = ""
        'TBFolioMediacion.Text = D_TABLE.Rows(0)("Folio_Mediacion")
        TBNombre_SolicitanteM.Text = ""
        TBDomicilioM.Text = ""
        TBColoniaM.Text = ""
        TBMunicipioM.Text = ""
        TBEdoM.Text = ""
        TBOficinaM.Text = ""
        TBCelularM.Text = ""
        TBE_mailM.Text = ""
        CBEdo_CivilM.Text = ""
        TBOcupacionM.Text = ""
        TBAsuntoMediacionM.Text = ""
        TBMediadorM.Text = ""
        CBStatus.Text = ""
        'DATOS DEL INVITADO
        TBNombreInvitado.Text = ""
        TBDomicilioI.Text = ""
        TBColoniaI.Text = ""
        TBMunicipioM.Text = ""
        TBEdoI.Text = ""
        TBOficinaI.Text = ""
        TBCelularI.Text = ""
        TBE_mailM.Text = ""
        CBEdoCivilI.Text = ""
        TBOcupacionI.Text = ""
        TBNombre_SolicitanteM.Focus()
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
        BtnActualizacionM.Enabled = False
        CBFolio_Mediacion.Enabled = False
    End Sub
    Private Sub CBFolio_Mediacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFolio_Mediacion.SelectedIndexChanged
        Call bucar_datos_dgv_Mediacion()
    End Sub
    Private Sub BtnActualizacionM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizacionM.Click
        Call Actualizar_Datos_Mediacion()
        Call Limpiar_datos_mediacion()
        Call buscar_ultimo_folio()
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        CBFolio_Mediacion.Enabled = True
        BtnActualizacionM.Enabled = False
        BtnSDM.Enabled = False
        DataGridViewMediacion.Refresh()
    End Sub
    Private Sub BtnSDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSDM.Click
        Call SM.Show()
    End Sub

    Private Sub BtnISPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnISPM.Click
        Call ISPM.Show()
    End Sub

    Private Sub BtnCDC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCDC.Click
        Call CDC.Show()
    End Sub
    Private Sub BtnCDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCDM.Click
        Call CDM.Show()
    End Sub

    Private Sub Btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Imprimir.Click
        Dim sqldatagrid_litigio As String
        Me.SqlConnection1.Open()
        sqldatagrid_litigio = ("SELECT * FROM Mediacion where Mediacion.Folio_Mediacion = '" & Val(TBFolioMediacion.Text) & "'")
        ORDER_BD = New SqlCommand(sqldatagrid_litigio, Me.SqlConnection1)
        ORDER_BD.CommandType = CommandType.Text
        ORDER_BD.ExecuteNonQuery()
        D_ADAPTER = New SqlDataAdapter(ORDER_BD)
        D_TABLE = New DataTable
        D_ADAPTER.Fill(D_TABLE)
        DataGridViewMediacion.DataSource = D_TABLE
        Dim CR As New CR_Mediacion
        CR.SetDataSource(D_TABLE)
        Dim RF As New REP_MEDIACION
        RF.CR_Mediacion.ReportSource = CR
        RF.ShowDialog()
        Me.SqlConnection1.Close()
    End Sub
End Class