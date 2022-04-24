'EN VBA LAS CLASES STATICAS SE DENOMINAN MODULE'

Module Gerente  
   

    'Creacion de atributos propios


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

    Private _salario As Double 
        
    'Metodos set y get de las variable
    Public Property Salario() As Double
        
        Get

            Return _salario
        End Get
        Set(value)
        
            _salario = value
        End Set 

    End Property  




        'CREAMOS UN ATRIBUTO COMPARTIDO'

        'Quiere decir que esta variable  y el metodo getset 
         'son compartidos con todos los objetos'
        'De esta clase'
        Private Shared _recuento As Double 
        
        'Metodos set y get de las variable
        Public Shared Property Recuento()  As Integer
                    
            Get
    
                Return _recuento
            End Get
            Set(value)
            
                _recuento = value
            End Set 
    
        End Property  

    'Creacion de constructores propios


    Public Sub New(ByVal nombre As String, ByVal edad As Integer)

      
        _nombre = nombre 
        _edad = edad     
        _salario = 1200
        _recuento += 1
               
    End Sub

  



     ' Metodos


     
        Public Sub hablar()

            Console.WriteLine("La persona esta hablando")
    
        End Sub


End Module