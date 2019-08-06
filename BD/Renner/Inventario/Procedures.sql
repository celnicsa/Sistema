/*IF OBJECT_ID('SPInsertCategoria') IS NOT NULL
BEGIN 
DROP PROC SPInsertCategoria
END*/

/*CREATE PROCEDURE SPInsertCategoria(@IDCategoria int,
	@Nombre varchar(50),
	@Descripcion varchar(50)
	)
	as
	BEGIN
	INSERT INTO MTableCategoria VALUES(
		@IDCategoria,
		@Nombre,
		@Descripcion
	)
	END*/

/*CREATE PROCEDURE SPLoadCategoria
as
BEGIN
select* from MTableCategoria
END*/


/*CREATE PROCEDURE SPUpdateCategoria(@IDCategoria int,
@Nombre varchar(50),
@Descripcion varchar(50))
as
BEGIN
UPDATE MTableCategoria
SET NOMBRE=@Nombre,
	DESCRIPCION = @Descripcion
where ID_CATEGORIA = @IDCategoria
END*/

/*CREATE PROCEDURE SPDeleteCategoria(@IDCategoria int)
as
BEGIN
Delete from MTableCategoria
where ID_CATEGORIA = @IDCategoria
end*/