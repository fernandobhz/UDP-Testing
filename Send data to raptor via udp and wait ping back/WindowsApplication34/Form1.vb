Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    Dim U As New UdpClient(65000)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        U.Send(System.Text.Encoding.UTF8.GetBytes("abc"), 3, New IPEndPoint(IPAddress.Parse("54.88.128.121"), 65000))
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RTask As Task(Of UdpReceiveResult) = U.ReceiveAsync
        U.Send(System.Text.Encoding.UTF8.GetBytes("abc"), 3, New IPEndPoint(IPAddress.Parse("54.88.128.121"), 65000))


        Dim back As UdpReceiveResult = Await RTask
        MsgBox(System.Text.Encoding.UTF8.GetString(back.Buffer))

    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RTask As Task(Of UdpReceiveResult) = U.ReceiveAsync
        Dim back As UdpReceiveResult = Await RTask
        MsgBox(System.Text.Encoding.UTF8.GetString(back.Buffer))

    End Sub

End Class
