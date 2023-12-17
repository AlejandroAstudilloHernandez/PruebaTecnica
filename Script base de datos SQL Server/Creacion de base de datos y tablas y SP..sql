USE [master]
GO
/****** Object:  Database [PruebaTecnica]    Script Date: 17/12/2023 08:33:40 a. m. ******/
CREATE DATABASE [PruebaTecnica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaTecnica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PruebaTecnica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PruebaTecnica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PruebaTecnica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PruebaTecnica] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaTecnica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaTecnica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebaTecnica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebaTecnica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebaTecnica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebaTecnica] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebaTecnica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PruebaTecnica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebaTecnica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaTecnica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebaTecnica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebaTecnica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebaTecnica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebaTecnica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebaTecnica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebaTecnica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PruebaTecnica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebaTecnica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebaTecnica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebaTecnica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebaTecnica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebaTecnica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebaTecnica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebaTecnica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PruebaTecnica] SET  MULTI_USER 
GO
ALTER DATABASE [PruebaTecnica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebaTecnica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebaTecnica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebaTecnica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PruebaTecnica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PruebaTecnica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PruebaTecnica] SET QUERY_STORE = ON
GO
ALTER DATABASE [PruebaTecnica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PruebaTecnica]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[ArticuloID] [int] IDENTITY(1,1) NOT NULL,
	[Sku] [numeric](6, 0) NULL,
	[Articulo] [nvarchar](15) NULL,
	[Marca] [nvarchar](15) NULL,
	[Modelo] [nvarchar](15) NULL,
	[Departamento] [numeric](1, 0) NULL,
	[Clase] [numeric](2, 0) NULL,
	[Familia] [numeric](3, 0) NULL,
	[FechaAlta] [date] NULL,
	[Stock] [numeric](9, 0) NULL,
	[Cantidad] [numeric](9, 0) NULL,
	[Descontinuado] [bit] NOT NULL,
	[FechaBaja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Sku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases](
	[ClaseId] [int] IDENTITY(1,1) NOT NULL,
	[NumeroClase] [numeric](2, 0) NULL,
	[NombreClase] [varchar](50) NULL,
	[NumeroDepartamento] [numeric](1, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[DepartamentoID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDepartamento] [numeric](1, 0) NULL,
	[NombreDepartamento] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familias]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familias](
	[FamiliaID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroFamilia] [numeric](3, 0) NULL,
	[NombreFamilia] [varchar](50) NULL,
	[NumeroClase] [numeric](2, 0) NULL,
	[NombreClase] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[FamiliaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerClases]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerClases]
    @NumeroDepartamento INT
AS
BEGIN
    SELECT *
    FROM Clases
    WHERE NumeroDepartamento = @NumeroDepartamento
END

GO
/****** Object:  StoredProcedure [dbo].[ObtenerDepartamentos]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerDepartamentos]
AS
BEGIN
    SELECT *
    FROM Departamentos
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AltaProducto]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AltaProducto]
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
/****** Object:  StoredProcedure [dbo].[sp_BajaProducto]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BajaProducto]
    @Sku INT
AS
BEGIN
    DELETE FROM Articulos WHERE Sku = @Sku;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_CambioProducto]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CambioProducto]
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
/****** Object:  StoredProcedure [dbo].[sp_ConsultaProducto]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultaProducto]
    @Sku INT
AS
BEGIN
    SELECT *
    FROM Articulos
    WHERE Sku = @Sku;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerClase]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerClase]
    @NumeroDepartamento INT,
    @NumeroClase INT
AS
BEGIN
    SELECT *
    FROM Clases
    WHERE NumeroDepartamento = @NumeroDepartamento AND NumeroClase = @NumeroClase
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerDepartamento]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerDepartamento]
    @NumeroDepartamento INT
AS
BEGIN
    SELECT *
    FROM Departamentos
    WHERE NumeroDepartamento = @NumeroDepartamento
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerFamilia]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerFamilia]
    @NumeroFamilia INT,
    @NombreClase NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Familias
    WHERE NumeroFamilia = @NumeroFamilia AND NombreClase = @NombreClase
END


GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerFamilias]    Script Date: 17/12/2023 08:33:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerFamilias]
    @NombreClase NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Familias
    WHERE NombreClase = @NombreClase
END
GO
USE [master]
GO
ALTER DATABASE [PruebaTecnica] SET  READ_WRITE 
GO
