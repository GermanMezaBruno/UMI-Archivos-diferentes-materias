USE UMI

CREATE TABLE VENTAS(
ID_venta int,
ID_cliente int,
ID_producto int,
Fecha_venta varchar(20),
Cantidad int,
Precio int,
Monto_tota int,
Sucursal varchar(20),
Metodo_de_pago varchar(15),
Tipo_de_entrega varchar(20),
);

CREATE TABLE CLIENTES(
ID_cliente int,
Nombre_cliente varchar(20),
Apellido_paterno varchar(10),
Apellido_materno varchar(10),
Correo_electronico varchar (20),
Telefóno_cliente int,
Ciudad varchar(10),
Dirección_cliente varchar(30),
Datos_biométricos varchar(40),
Sexo varchar(11),
);

CREATE TABLE PROVEEDOR(
ID_proveedor int,
Nombre varchar(25),
Teléfono int,
Correo_electronico varchar(20),
RFC int,
Contacto varchar(20),
QR int, --Puse Int como si fuera un codigo de barras
Descuento int,
Calificación tinyint, /*quí quise cambiar un poco el tipo de dato
suponiendo que der calificación de 1 a 10*/
);

CREATE TABLE PRODUCTOS(
ID_producto int,
Nombre_producto varchar(20),
Precio_producto int,
ID_marca int,
Stock_disponible int,
ID_proveedor int,
Código_de_barras int,
Categoría varchar(15),
Tipo_de_material varchar(10),
Departamento varchar(15),
);

CREATE TABLE MARCAS(
ID_marca int,
Marca_producto varchar(20),
Descripción varchar(30),
Sitio_web varchar(30),
País_origen varchar(20),


ALTER TABLE MARCAS
ADD TABLA_AGREGADA int; --Se agrego una columna como ejemplo con el valor INT

ALTER TABLE MARCAS
DROP COLUMN TABLA_AGREGADA; /*Se eliminó la columna de TABLA_AGREGADA en la
tabla de MARCAS porque cometí el error de ponerle el nombre de tabla en vez de columna*/

ALTER TABLE MARCAS
ADD COLUMNA_EJEMPLO varchar(20); --Aquí agrego correctamente la columna y posteriormente la eliminare

ALTER TABLE MARCAS
DROP COLUMN COLUMNA_EJEMPLO; --La borre para que quedara todo limpio sin columnas inservibles

DROP TABLE MARCAS --ESTE COMANDO NO LO EJECUTE PORQUE NO LA QUERIA BORRAR SOLO DEMOSTRAR EL COMANDO DE BORRADO DE UNA TABLA.

);
