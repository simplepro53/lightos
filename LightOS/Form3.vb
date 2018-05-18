﻿Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Sub checkaddress() Handles WebBrowser1.DocumentCompleted
        txbAddress.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        Label1.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(txbAddress.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + txbSearch.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + txbSearch.Text)
        End If
    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.Click
        If txbSearch.Text = "Search" Then
            txbSearch.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        brwsysetup.Show()
    End Sub
End Class