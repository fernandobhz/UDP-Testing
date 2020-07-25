Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim U As New UdpClient(65000)

        While True
            Dim Message As UdpReceiveResult = Await U.ReceiveAsync()

            Dim r As Byte() = System.Text.Encoding.UTF8.GetBytes(Message.RemoteEndPoint.ToString)
            Await U.SendAsync(r, r.Length, Message.RemoteEndPoint)
        End While
    End Sub

End Class
