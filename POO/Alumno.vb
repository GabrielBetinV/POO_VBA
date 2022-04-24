Public Class Alumno
    Inherits Persona ' La clase Alumno hereda de la clase persona


    'Creacion de atributos propios


    Private _notaMedia As Double 
        
    'Metodos set y get de las variable
    Public Property NotaMedia() As As Double
        
        Get

            Return _notaMedia
        End Get
        Set(value)
        
            _notaMedia = value
        End Set 

    End Property  




    'Creacion de constructores propios


    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal notaMedia As Double)

        _notaMedia = NotaMedia
        Me.Nombre = nombre 'Accedemos a la variable heredada
        Me.Edad = edad     'Accedemos a la variable heredada
            
        End Sub    



        
    ' Sobreescribimos el metodo hablar de la clase padre

        Public Overloads Sub hablar()

            MyBase.hablar() ' Retorna el metodo hablar de la clase padre
            Console.WriteLine("El alumno esta hablando")

        End Sub



End Class