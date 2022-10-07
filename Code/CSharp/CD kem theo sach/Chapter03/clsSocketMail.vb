Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Public Class SocketMail
    'Khai ba1o bien
    Private _subject As String
    Private _to As String
    Private _server As String
    Private _port As Integer = 25
    Private _body As String
    Private _date As Date = Now
    Private _from As String
    Private _cc As String
    Private _bcc As String
    'khai bao bien dong du lieu
    Private ns As NetworkStream
    'dung tcpClient
    Private client As New TcpClient()

    Public Sub New()
    End Sub

    Public Sub New(ByVal server As String, ByVal port As Integer)
        'khoi tao gia tri cua Mail Server va Port
        _server = server
        _port = port
    End Sub

    Public Sub New(ByVal server As String, ByVal port As Integer, _
                    ByVal from As String, ByVal [to] As String, _
                     ByVal subject As String, ByVal message As String)
        ' Gan cac gia tri
        _server = server
        _port = port
        _from = from
        _to = [to]
        _subject = subject
        _body = message
    End Sub
    'cac bien dang public
    Public Property SMTPServer() As String
        Get
            Return _server
        End Get
        Set(ByVal Value As String)
            _server = Value
        End Set
    End Property

    Public Property [To]() As String
        Get
            Return _to
        End Get
        Set(ByVal Value As String)
            _to = Value
        End Set
    End Property

    Public Property From() As String
        Get
            Return _from
        End Get
        Set(ByVal Value As String)
            _from = Value
        End Set
    End Property

    Public Property CarbonCopy() As String
        Get
            Return _cc
        End Get
        Set(ByVal Value As String)
            _cc = Value
        End Set
    End Property

    Public Property BlindCarbonCopy() As String
        Get
            Return _bcc
        End Get
        Set(ByVal Value As String)
            _bcc = Value
        End Set
    End Property


    Public Property Port() As Integer
        Get
            Return _port
        End Get
        Set(ByVal Value As Integer)
            _port = Value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return _body
        End Get
        Set(ByVal Value As String)
            _body = Value
        End Set
    End Property

    Public Property SendDate() As Date
        Get
            Return _date
        End Get
        Set(ByVal Value As Date)
            _date = Value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return _subject
        End Get
        Set(ByVal Value As String)
            _subject = Value
        End Set
    End Property
    'Khai bao ket noi mail server
    Public Function Open()
        client.Connect(_server, _port)

        ns = client.GetStream()

        Dim strMessage As String = "Welcome Mail" & ControlChars.CrLf

        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strMessage)
        ns.Write(sendBytes, 0, sendBytes.Length)
    End Function
    ' khai bao ham dong mail
    Public Function Close() as boolean
        Try
            Dim strMessage As String = "Exit" & ControlChars.CrLf

            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strMessage)
            ns.Write(sendBytes, 0, sendBytes.Length)
        Catch

        End Try

        client.Close()
        Return true
    End Function
    'khai bao ham goi mail
    Public Function Send() As Boolean
        Try
           ' Dim response As Integer
            Dim strMessage As String

            strMessage = "MAIL FROM:" & _from & ControlChars.CrLf & _
                         "RCPT TO:" & _to & ControlChars.CrLf & _
                         "DATA" & ControlChars.CrLf & _
                         "date:" & _date.ToString & ControlChars.CrLf & _
                         "from:" & _from & ControlChars.CrLf & _
                         "to:" & _to & ControlChars.CrLf & _
                         "cc:" & _cc & ControlChars.CrLf & _
                         "bcc:" & _bcc & ControlChars.CrLf & _
                         "subject:" & _subject & ControlChars.CrLf & _
                          _body & ControlChars.CrLf & _
                         "." & ControlChars.CrLf

            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strMessage)
            ns.Write(sendBytes, 0, sendBytes.Length)
            client.Close()
        Finally
            
        End Try
        Return True
    End Function

End Class

