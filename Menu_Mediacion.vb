Public Class Menu_Mediacion

    Private Sub BtnMediacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMediacion.Click
        Mediar.Show()
    End Sub

    Private Sub BtnLitigio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLitigio.Click
        Call Litigio.Show()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

End Class
