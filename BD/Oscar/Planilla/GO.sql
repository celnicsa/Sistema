CREATE TABLE MTableBeneficioEscolaridad(
	Cod_Escolaridad varchar(5) primary key,
	Nombre_Grado varchar(50),
	Beneficio_Grado money
);


ALTER TABLE MTableEMP 
ADD Tipo_Escolaridad varchar(5) FOREIGN KEY REFERENCES MTableBeneficioEscolaridad(Cod_Escolaridad);


Create Table MTableNominaEmpleado(
	ID_Nomina varchar(10) primary key,
	Año_Nomina Date,
	Mes_Nomina Date,
	Fecha_Generado Date,
	Cod_Empleado_Genero char(15) FOREIGN KEY REFERENCES MTableEMP(CodEmp),
	Total_Bruto money,
	Total_Deducciones money,
	Total_Nomina money
);

Create Table MTableNominaDetalle(
	ID_Nomina varchar(10) FOREIGN KEY REFERENCES MTableNominaEmpleado(ID_Nomina),
	Cod_Empleado char(15) FOREIGN KEY REFERENCES MTableEMP(CodEmp),
	Salario_Bruto money,
	INSS_Laboral money,
	IR_Laboral money,
	Total_Neto money
);

