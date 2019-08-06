use BDImelsa

CREATE TABLE MCategoria(
	ID_CATEGORIA int primary key,
	NOMBRE VARCHAR(50),
	DESCRIPCION VARCHAR(50)
)
CREATE TABLE MArticulo(
	ID_ARTICULO int,
	ID_CATEGORIA int foreign key references MCategoria(ID_CATEGORIA),
	PROYECTO char(15) foreign key references MTableProyect(CodProyect),
	NOMBRE varchar(50),
	DESCRIPCION Varchar(150),
	STOCK int
)

