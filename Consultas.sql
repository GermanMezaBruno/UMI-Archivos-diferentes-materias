USE UMI --SELECCIONAMOS BASE DE DATOS
--EJERCICIOS DE LA ACTIVIDAD 3

--●Contar los registros existentes de una tabla
SELECT COUNT(*) AS Registros FROM CLIENTES 

--●Verificar si existen o no registros duplicados
SELECT DISTINCT Apellido_materno FROM CLIENTES --Muestras los apellidos sin repetirse

--●Ordenar de mayor a menor una tabla
SELECT * FROM PRODUCTOS ORDER BY ID_producto DESC 

--●Seleccionar sólo el campo ID_cliente y ID_producto
SELECT ID_cliente FROM CLIENTES           
SELECT ID_producto FROM PRODUCTOS         

--● Ordenar por orden alfabético el campo Nombre_cliente
SELECT Nombre_cliente FROM CLIENTES ORDER BY Nombre_cliente 

 --●● Mostrar sólo el campo Fecha_venta que tenga registros del año 2022
UPDATE VENTAS                --Borre todos los registros en la tabla de fechas
SET Fecha_venta = NULL;

ALTER TABLE VENTAS            --Cambie su tipo de dato a int para poder buscar por año
ALTER COLUMN Fecha_venta int;

UPDATE VENTAS                  --Cambie manualmente cada registro de fecha    
SET Fecha_venta = 2020 where ID_cliente = 1;
UPDATE VENTAS
SET Fecha_venta = 2022 where ID_cliente = 2;
UPDATE VENTAS
SET Fecha_venta = 2022 where ID_cliente = 3;
UPDATE VENTAS
SET Fecha_venta = 2024 where ID_cliente = 4;
UPDATE VENTAS
SET Fecha_venta = 2024 where ID_cliente = 5;

SELECT * FROM VENTAS      --Aquí te muestra todos los datos del registro con fecha que sea igual a 2022        
where  Fecha_venta = 2022; 

--●Ver los datos de una tabla
SELECT * FROM CLIENTES 

--●Crear un procedimiento almacenado que muestre los clientes que tengan por nombre “Bruno”
EXEC Nombres_Bruno 

--●Crear un ciclo donde sí existe el ID_producto número “3”, deberá mostrar el nombre del mismo (Nombre_producto correspondiente)
IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE ID_producto = 3)
BEGIN
    SELECT Nombre_producto  
    FROM PRODUCTOS
    WHERE ID_producto = 3;
END
ELSE
BEGIN
    PRINT 'No se encontró el producto con ID 3';
END