Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class CDM
    Private Sub CDM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bucar_datos_CDM()
        TBFolio_CDM.Text = Mediar.CBFolio_Mediacion.Text
    End Sub
    Dim FOLIO_CDM As Integer
    Dim sqlbusqueda As String
    Dim sqlbusqueda_convenio As String
    Dim sqlfolio_cdm As New SqlCommand
    Dim sqldrfolio_cdm As SqlDataReader
    Public ORDER_BD As SqlCommand
    Private D_TABLE As DataTable
    Private D_ADAPTER As SqlDataAdapter
    Private DD_TABLE As DataTable
    Private DD_ADAPTER As SqlDataAdapter
    Dim swbtn As Integer = 0
    Sub guardar_datos_CDM()
        Dim Agregar_Datos_Convenio_Mediacion As String
        Agregar_Datos_Convenio_Mediacion = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If Agregar_Datos_Convenio_Mediacion = vbYes Then
                swbtn = 1
                Me.SqlConnection1.Open()
                Dim Insdato_media_CDM As String = "INSERT INTO CDM(Folio_Mediacion,Dia_CDM,Mes_CDM,Comparece_CDM,Domicilio_CDM,Municipio_CDM,Folio_Elector_CDM,Comparece2_CDM,Calle2_CDM,Numero_CDM,Municipio2_CDM,Folio_Elector2_CDM,Antecedentes1_CDM,Antecedentes2_CDM,Clausula_Primera_CDM,Clausula_Segunda_CDM,Clausula_Tercera_CDM,Enterado1_CDM,Enterado2_CDM) values(@Folio_Mediacion,@Dia_CDM,@Mes_CDM,@Comparece_CDM,@Domicilio_CDM,@Municipio_CDM,@Folio_Elector_CDM,@Comparece2_CDM,@Calle2_CDM,@Numero_CDM,@Municipio2_CDM,@Folio_Elector2_CDM,@Antecedentes1_CDM,@Antecedentes2_CDM,@Clausula_Primera_CDM,@Clausula_Segunda_CDM,@Clausula_Tercera_CDM,@Enterado1_CDM,@Enterado2_CDM)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdato_media_CDM, Me.SqlConnection1)
                'conex1.Parameters.Add(New SqlParameter("@'echa_Invitacion_ISPM", SqlDbType.SmallDateTime)).Value = DateTimePickerISPM.Text
                conex1.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Dia_CDM", SqlDbType.NChar, 10)).Value = Mediar.CBFolio_Mediacion.Text
                conex1.Parameters.Add(New SqlParameter("@Mes_CDM", SqlDbType.NVarChar, 50)).Value = TBMes_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Comparece_CDM", SqlDbType.NVarChar, 50)).Value = TBComparece_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Domicilio_CDM", SqlDbType.NVarChar, 50)).Value = TBDomicilio_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Municipio_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Folio_Elector_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBElector_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Comparece2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBComparece_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Calle2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBCalle_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Numero_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBNumero_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Municipio2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio2_cdm.Text
                conex1.Parameters.Add(New SqlParameter("@Folio_Elector2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBElector2_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Antecedentes1_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBAntecedentes1_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Antecedentes2_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBAntecedentes2_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Clausula_Primera_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaPrimera_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Clausula_Segunda_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaSegunda_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Clausula_Tercera_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaTerecera_CDM.Text
                conex1.Parameters.Add(New SqlParameter("@Enterado1_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBEnterado1.Text
                conex1.Parameters.Add(New SqlParameter("@Enterado2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBEnterado2.Text
                conex1.CommandText = Insdato_media_CDM
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
    Sub Actualizar_Datos_CDM()
        Try
            Dim Actualizar_CDM As String
            Me.SqlConnection1.Open()
            Actualizar_CDM = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_CDM = vbYes Then
                Dim Actualizar_Datos_CDM As String = ("UPDATE CDM SET Folio_Mediacion=@Folio_Mediacion,Dia_CDM=@Dia_CDM,Mes_CDM=@Mes_CDM,Comparece_CDM=@Comparece_CDM,Domicilio_CDM=@Domicilio_CDM,Municipio_CDM=@Municipio_CDM,Folio_Elector_CDM=@Folio_Elector_CDM,Comparece2_CDM=@Comparece2_CDM,Calle2_CDM=@Calle2_CDM,Numero_CDM=@Numero_CDM,Municipio2_CDM=@Municipio2_CDM,Folio_Elector2_CDM=@Folio_Elector2_CDM,Antecedentes1_CDM=@Antecedentes1_CDM,Antecedentes2_CDM=@Antecedentes2_CDM,Clausula_Primera_CDM=@Clausula_Primera_CDM,Clausula_Segunda_CDM=@Clausula_Segunda_CDM,Clausula_Tercera_CDM=@Clausula_Tercera_CDM,Enterado1_CDM=@Enterado1_CDM,Enterado2_CDM=@Enterado2_CDM where Folio_Mediacion= '" & Mediar.CBFolio_Mediacion.Text & "'")
                Dim conexCDM As New SqlClient.SqlCommand(Actualizar_Datos_CDM, Me.SqlConnection1)
                conexCDM.Parameters.Add(New SqlParameter("@Folio_Mediacion", SqlDbType.Int, 4)).Value = Mediar.CBFolio_Mediacion.Text
                conexCDM.Parameters.Add(New SqlParameter("@Dia_CDM", SqlDbType.NChar, 10)).Value = Mediar.CBFolio_Mediacion.Text
                conexCDM.Parameters.Add(New SqlParameter("@Mes_CDM", SqlDbType.NVarChar, 50)).Value = TBMes_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Comparece_CDM", SqlDbType.NVarChar, 50)).Value = TBComparece_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Domicilio_CDM", SqlDbType.NVarChar, 50)).Value = TBDomicilio_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Municipio_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Folio_Elector_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBElector_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Comparece2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBComparece_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Calle2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBCalle_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Numero_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBNumero_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Municipio2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBMunicipio2_cdm.Text
                conexCDM.Parameters.Add(New SqlParameter("@Folio_Elector2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBElector2_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Antecedentes1_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBAntecedentes1_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Antecedentes2_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBAntecedentes2_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Clausula_Primera_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaPrimera_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Clausula_Segunda_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaSegunda_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Clausula_Tercera_CDM", SqlDbType.NVarChar, -1)).Value = Me.TBClausulaTerecera_CDM.Text
                conexCDM.Parameters.Add(New SqlParameter("@Enterado1_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBEnterado1.Text
                conexCDM.Parameters.Add(New SqlParameter("@Enterado2_CDM", SqlDbType.NVarChar, 50)).Value = Me.TBEnterado2.Text
                conexCDM.CommandText = Actualizar_Datos_CDM
                conexCDM.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub bucar_datos_CDM()
        Try
            Me.SqlConnection1.Open()
            sqlbusqueda = ("SELECT * FROM CDM WHERE CDM.Folio_Mediacion = '" & Mediar.CBFolio_Mediacion.Text & "'")
            ORDER_BD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD.CommandType = CommandType.Text
            ORDER_BD.ExecuteNonQuery()
            D_ADAPTER = New SqlDataAdapter(ORDER_BD)
            D_TABLE = New DataTable
            D_ADAPTER.Fill(D_TABLE)
            'DataGridViewMediacion.DataSource = D_TABLE
            If D_TABLE.Rows.Count > 0 Then
                TBDia_CDM.Text = D_TABLE.Rows(0)("Dia_CDM")
                TBMes_CDM.Text = D_TABLE.Rows(0)("Mes_CDM")
                TBComparece_CDM.Text = D_TABLE.Rows(0)("Comparece_CDM")
                TBDomicilio_CDM.Text = D_TABLE.Rows(0)("Domicilio_CDM")
                TBMunicipio_CDM.Text = D_TABLE(0)("Municipio_CDM")
                TBElector_CDM.Text = D_TABLE.Rows(0)("Folio_Elector_CDM")
                TBCcomparece2_CDM.Text = D_TABLE.Rows(0)("Comparece2_CDM")
                TBCalle_CDM.Text = D_TABLE(0)("Calle2_CDM")
                TBNumero_CDM.Text = D_TABLE.Rows(0)("Numero_CDM")
                TBMunicipio2_cdm.Text = D_TABLE.Rows(0)("Municipio2_CDM")
                TBElector2_CDM.Text = D_TABLE.Rows(0)("Folio_Elector2_CDM")
                TBAntecedentes1_CDM.Text = D_TABLE.Rows(0)("Antecedentes1_CDM")
                TBAntecedentes2_CDM.Text = D_TABLE.Rows(0)("Antecedentes2_CDM")
                TBClausulaPrimera_CDM.Text = D_TABLE.Rows(0)("Clausula_Primera_CDM")
                TBClausulaSegunda_CDM.Text = D_TABLE.Rows(0)("Clausula_Segunda_CDM")
                TBClausulaTerecera_CDM.Text = D_TABLE.Rows(0)("Clausula_Tercera_CDM")
                TBEnterado1.Text = D_TABLE.Rows(0)("Enterado1_CDM")
                TBEnterado2.Text = D_TABLE.Rows(0)("Enterado2_CDM")
                BtnActualizar_CDM.Enabled = True
                BtnImpCDM.Enabled = True
            Else
                'TBCiudadano.Text = Mediar.TBNombre_SolicitanteM.Text
                'CBEstado_Civil_SM.Text = Mediar.CBEdo_CivilM.Text
                'TBDomicilio_SM.Text = Mediar.TBDomicilioM.Text
                'TBColonia_SM.Text = Mediar.TBColoniaM.Text
                'TBMunicipio_SM.Text = Mediar.TBMunicipioM.Text
                BtnGuardar_CDM.Enabled = True
                BtnImpCDM.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub bucar_datos_CONVENIO()
        Try
            Me.SqlConnection1.Open()
            sqlfolio_cdm.CommandText = CommandType.Text
            sqlfolio_cdm.CommandText = ("Select * from cdm where cdm.Folio_Mediacion = '" & Mediar.CBFolio_Mediacion.Text & "'")
            sqlfolio_cdm.Connection = Me.SqlConnection1
            sqldrfolio_cdm = sqlfolio_cdm.ExecuteReader()
            sqldrfolio_cdm.Read()
            FOLIO_CDM = sqldrfolio_cdm("Folio_Mediacion")
            'Dim Frm_CDM = New FOR_CDM
            ' Frm_CDM.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub BtnGuardar_CDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar_CDM.Click
        Call guardar_datos_CDM()
        If swbtn = 1 Then
            BtnGuardar_CDM.Enabled = False
            BtnActualizar_CDM.Enabled = True
        End If
    End Sub
    Private Sub BtnActualizar_CDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar_CDM.Click
        Call Actualizar_Datos_CDM()
    End Sub
    Private Sub BtnImpCDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpCDM.Click
        Call bucar_datos_CONVENIO()
        Dim Frm_CDM = New FOR_CDM
        Frm_CDM.Show()
    End Sub
End Class