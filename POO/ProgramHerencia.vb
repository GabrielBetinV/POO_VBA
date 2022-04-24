Module ProgramHerencia


    Sub Main(args As String())


       Dim persona1 As New Persona() ' Creamos un objeto de la clase persona
       Dim alumno1 As New Alumno()   ' Creamos un objeto de la clase alumno
       Dim empleado1 As New Emlpeado() ' Creamos un objeto de la clase empleado
      


        ' Utilizacion de los metodos de la clase padre

        persona1.Hablar()' Retorna el metodo hablar de la clase padre
        alumno1.Hablar()' Retorna el metodo hablar de la clase padre
        alumno.Hablar()' Retorna el metodo hablar de la clase padre


        ' Cuando sobre escribimos los metodos la clas ejecutar su metodo antes del
        ' del padre

        alumno1.Hablar()' Retorna el metodo hablar de la clase alumno


        'Creamos un objeto de tipo empleado con todos los parametros del constructor

        Dim empleado2 As New Emlpeado("Gabriel",31,2000000)


    End Sub
    




End Module