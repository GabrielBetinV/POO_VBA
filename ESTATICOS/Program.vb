Module Program


    Sub Main(args As String())


        ' Instanciamos un objeto de la clase empleado
        Dim trabajador1 As New Empleado("Juan",39)
        Dim trabajador2 As New Empleado("Luis", 25)

       
        ' Escribimos en consola los atributos de cada objeto instanciado.
        Console.WriteLine(trabajador1.Nombre)
        Console.WriteLine(trabajador1.Edad)


        'Esta linea imprime el valor que tiene salario, ya la variable'
        'no es independiente por objetos '
        Console.WriteLine(Empleado.Salario)
        Empleado.Salario = 50

        Console.WriteLine(trabajador2.Nombre)
        Console.WriteLine(trabajador2.Edad)
        Console.WriteLine(Empleado.Salario)



        'PARA UTILIZAR LA CLASE ESTATICA LLAMADA GERENTE'
        
        'Metodo
        Console.WriteLine(Gerente.hablar())


        ' Atributo

        Console.WriteLine(Gerente.Nombre)

    End Sub


End Module