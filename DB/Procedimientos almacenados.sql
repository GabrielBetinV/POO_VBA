CREATE PROC CREATE_BODEGA

@codigo varchar(10) null,
@nombre varchar(50) null,
@direccion varchar(50) null,
@contacto varchar(50) null,
@fechaCreacion date null

AS
IF EXISTS (SELECT nombre From Bodegas where nombre = @nombre)
		RAISERROR('La bodega ya se encuentra creada',16,1)


ELSE 
    
	INSERT INTO Bodegas values (@codigo,@nombre,@direccion,@contacto,@fechaCreacion);



CREATE PROC EDIT_BODEGA

@id int,
@codigo varchar(10) null,
@nombre varchar(50) null,
@direccion varchar(50) null,
@contacto varchar(50) null,
@fechaCreacion date null


AS

UPDATE Bodegas set codigo=@codigo,nombre=@nombre,direccion=@direccion,contacto=@contacto,fechaCreacion=@fechaCreacion
	where id = @id;



CREATE PROC READ_BODEGA
	
AS

SELECT codigo AS [Codigo],
       nombre AS [Nombre,
	   direccion AS [Direccion],
	   fechaCreacion AS [Fecha de creacion]
FROM Bodegas




CREATE PROC READ_BODEGA_NOMBRE

@Busqueda varchar(50)
	
AS

SELECT codigo AS [Codigo],
       nombre AS [Nombre,
	   direccion AS [Direccion],
	   fechaCreacion AS [Fecha de creacion]
FROM Bodegas where nombre + codigo  LIKE '%'+ @Busqueda +'%'





