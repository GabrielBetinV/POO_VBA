Module Program


    Sub Main(args As String())


        'Instanciamos un objeto tipo persona para utilizar el constructor con datos

        Dim per1 As New Persona()
        Console.WriteLine(per1.Nombre)
        Console.WriteLine(per1.Edad)



        'Instanciamos un objeto tipo persona para utilizar el constructor y setear los datos

         Dim per2 As New Persona("Angel Betin" , 7)
         Console.WriteLine(per2.Nombre)
         Console.WriteLine(per2.Edad)

        'Instanciamos un objeto tipo persona para utilizar el constructor con edad

            Dim per3 As New Persona(7)
            Console.WriteLine(per3.Nombre)
            Console.WriteLine(per3.Edad)

        'Instanciamos un objeto tipo persona para utilizar el constructor con nombre

             Dim per4 As New Persona("Angel David")
             Console.WriteLine(per4.Nombre)
             Console.WriteLine(per4.Edad)    









    End Sub
    




End Module