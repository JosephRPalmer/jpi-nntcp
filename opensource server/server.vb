Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Imports System.Net
Public Class server 'created basic tcp server - 02.11
    Dim status As String = ""
    Sub server1()

        Dim listen As TcpListener
        listen = Nothing
        Dim outport As Integer = 5780
        Dim addresshere As IPAddress = IPAddress.Parse("127.0.0.1")
        listen = New TcpListener(addresshere, outport)
        listen.Start()
        status = "Awaiting connection"

        'Dim inwards As TcpClient = listen.AcceptTcpClient
        'status = "Connection Established"
        'Dim streamer As NetworkStream = inwards.GetStream
        'Dim bytes(inwards.ReceiveBufferSize) As Byte
        'streamer.Read(bytes, 0, CInt(inwards.ReceiveBufferSize))
        'Dim clientdata As String = Encoding.ASCII.GetString(bytes)
        ''write data to text file

    End Sub

    Function getstatus()
        Dim status2 As String
        status2 = "Connection Status " + status
        Return status2
    End Function
    'Function senddata(ByRef streamer As NetworkStream)
    '    Dim finished As String = "done"
    '    Dim responseString As String = "Connected to server."
    '    Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(responseString)
    '    streamer.Write(sendBytes, 0, sendBytes.Length)
    '    Return finished
    'End Function

End Class

