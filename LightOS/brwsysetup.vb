﻿Public Class brwsysetup
    Private Sub brwsysetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SE = "Google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SE = "Bing" Then
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.SE = "Google"
        ElseIf RadioButton2.Checked = True Then
            My.Settings.SE = "Bing"

        End If
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()

    End Sub
End Class