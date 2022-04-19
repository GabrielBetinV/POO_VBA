Public Class Empleado
    Inherits Persona ' La clase Empleado hereda de la clase persona


    'Creacion de atributos propios


    Private _salario As Double 
        
    'Metodos set y get de las variable
    Public Property Salario() As As Double
        
        Get

            Return _salario
        End Get
        Set(value)
        
            _salario = value
        End Set 

    End Property  



    'Creacion de constructores propios


    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal salario As Double)

        _salario = salario
        Me.Nombre = nombre 'Accedemos a la variable heredada
        Me.Edad = edad     'Accedemos a la variable heredada
               
    End Sub




    ' Sobreescribimos el metodo hablar de la clase padre

    Public Overloads Sub hablar()

        MyBase.hablar() ' Retorna el metodo hablar de la clase padre
        Console.WriteLine("El empleado esta hablando")

    End Sub
    


End Class