GO
CREATE DATABASE PruebaTecnica
GO
USE PruebaTecnica
GO
CREATE TABLE Articulos(
ArticuloID INT primary key identity(1,1),
Sku numeric(6,0) UNIQUE,
Articulo NVARCHAR(15),
Marca NVARCHAR(15),
Modelo NVARCHAR(15),
Departamento numeric(1,0),
Clase numeric(2,0),
Familia numeric (3,0),
FechaAlta DATE,
Stock numeric(9,0),
Cantidad numeric(9,0),
Descontinuado bit not null,
FechaBaja DATE
)
GO
CREATE TABLE Departamentos(
DepartamentoID INT primary key identity(1,1),
NumeroDepartamento numeric(1,0),
NombreDepartamento varchar(50)
)
GO
CREATE TABLE Clases(
ClaseId INT primary key identity(1,1),
NumeroClase numeric (2,0),
NombreClase varchar(50),
NumeroDepartamento numeric(1,0)
)
GO
CREATE TABLE Familias(
FamiliaID INT primary key identity(1,1),
NumeroFamilia numeric(3,0),
NombreFamilia varchar(50),
NumeroClase numeric(2,0),
NombreClase varchar(50)
)

GO
CREATE PROCEDURE sp_AltaProducto
    @Sku NUMERIC(6,0),
    @Articulo NVARCHAR(15),
    @Marca NVARCHAR(15),
    @Modelo NVARCHAR(20),
    @Departamento NUMERIC(1,0),
    @Clase NUMERIC(2,0),
    @Familia NUMERIC(3,0),
    @Stock NUMERIC(9,0),
    @Cantidad NUMERIC(9,0)
AS
BEGIN
    INSERT INTO Articulos(Sku, Articulo, Marca, Modelo, Departamento, Clase, Familia, FechaAlta, Stock, Cantidad, Descontinuado, FechaBaja)
    VALUES (@Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, GETDATE(), @Stock, @Cantidad, 0, '1900-01-01');
END;
GO

CREATE PROCEDURE sp_BajaProducto
    @Sku NUMERIC(6,0)
AS
BEGIN
    DELETE FROM Articulos WHERE Sku = @Sku;
END;

GO

CREATE PROCEDURE sp_CambioProducto
    @Sku NUMERIC(6,0),
    @Articulo NVARCHAR(15),
    @Marca NVARCHAR(15),
    @Modelo NVARCHAR(20),
    @Departamento NUMERIC(1,0),
    @Clase NUMERIC(2,0),
    @Familia NUMERIC(3,0),
    @Stock NUMERIC(9,0),
    @Cantidad NUMERIC(9,0),
    @Descontinuado BIT
AS
BEGIN
    UPDATE Articulos
    SET
        Articulo = @Articulo,
        Marca = @Marca,
        Modelo = @Modelo,
        Departamento = @Departamento,
        Clase = @Clase,
        Familia = @Familia,
        Stock = @Stock,
        Cantidad = @Cantidad,
        Descontinuado = @Descontinuado,
        FechaBaja = CASE WHEN @Descontinuado = 1 THEN GETDATE() ELSE '1900-01-01' END
    WHERE Sku = @Sku;

    -- Después de realizar la actualización, selecciona el artículo actualizado
    SELECT * FROM Articulos WHERE Sku = @Sku;
END;

GO

CREATE PROCEDURE sp_ConsultaProducto
    @Sku NUMERIC(6,0)
AS
BEGIN
    SELECT *
    FROM Articulos
    WHERE Sku = @Sku;
END;
