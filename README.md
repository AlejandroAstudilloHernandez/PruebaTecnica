# Prueba Técnica Programador Jr.

## Tecnologías Utilizadas

- C# (Windows Forms, .NET 6)
- SQL Server

## Configuración de la Base de Datos

1. Ejecuta el script "Creacion de base de datos y tablas y SP.sql" para crear la base de datos y los procedimientos almacenados necesarios.
2. Ejecuta el script "INSERTS iniciales (Departamentos, Clases, Familias).sql" para insertar datos iniciales en las tablas de Departamentos, Clases y Familias.

## Configuración de la Cadena de Conexión

La base de datos esta alojada en un servidor, no hay necesidad de configurar una cadena de conexión para las pruebas.     
Dado el caso que se necesite hacer pruebas con una base de datos local: asegurese de modificar la cadena de conexión en la carpeta Models, en la clase PruebaTecnicaContext en la linea 28.

```csharp
//Si desea una base de datos local
// Ruta a ajustar en la carpeta Models en la clase PruebaTecnicaContext, línea 28
=> optionsBuilder.UseSqlServer("Server=DESKTOP-AOHL8UE\\SQLEXPRESS;Database=PruebaTecnica;Trusted_Connection=True;TrustServerCertificate=True");
