Public Class Vpersonas
    Dim id As Integer
    Dim nombre, apellido, direccion, telefono As String

    Public Property gid
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String)

        gnombre = nombre
        gapellido = apellido
        gdireccion = direccion
        gtelefono = telefono
        gid = id
    End Sub

End Class
