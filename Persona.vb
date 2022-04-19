Public Class Persona


    'Variables encapsuladas o campos de clases
    Private _nombre As String 
    
    'Metodos set y get de las variable
    Public Property Nombre() As As String
          
        Get

            Return _nombre
        End Get
        Set(value)
        
            _nombre = value
        End Set 
    
    End Property    

    'Variables encapsuladas o campos de clases
    Private _edad As Integer
    'Metodos set y get de las variable
    Public Property Edad() As Integer         
        Get

            Return _edad
        End Get
        Set(value)
        
            _edad= value
        End Set 

    End Property  

   'CONSTRUCTORES

   ' Constructor vacio
    Public Sub New()
    End Sub


    ' Constructores con parametros  


    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
               
    End Sub

    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
       _nombre = "Gabriel betin"
       _edad = 31
               
    End Sub    

    Public Sub New(ByVal nombre As String)
        _nombre = nombre  
        _edad = 31                   
    End Sub  
        
        
    Public Sub New(ByVal edad As Integer)
        _nombre = "Gabriel betin"
       _edad = edad                    
    End Sub     
    

    
    'Metdodos de la clase persona


    Public Sub hablar()

        Console.WriteLine("La persona esta hablando")

    End Sub


    Public Sub comer()

        Console.WriteLine("La persona comiendo")

    End Sub
    


End Class