/* ROLLBACK */

   DROP TABLE  MTableBeneficioEscolaridad;
   ALTER TABLE MTableEMP DROP COLUMN Tipo_Escolaridad;
   DROP TABLE MTableNominaEmpleado;
   DROP TABLE MTableNominaDetalle;