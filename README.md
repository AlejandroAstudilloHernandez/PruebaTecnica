# Prueba Técnica Programador Jr.

## Tecnologías Utilizadas

- C# (Windows Forms, .NET 6)
- SQL Server

## Configuración de la Base de Datos

1. Ejecuta el script "Creacion de base de datos y tablas y SP.sql" para crear la base de datos y los procedimientos almacenados necesarios.
2. Ejecuta el script "INSERTS iniciales (Departamentos, Clases, Familias).sql" para insertar datos iniciales en las tablas de Departamentos, Clases y Familias.

## Configuración de la Cadena de Conexión

Asegúrate de ajustar la cadena de conexión de la base de datos en la clase `PruebaTecnicaContext` en la línea 28. Esto es crucial para que la aplicación pueda conectarse correctamente a la base de datos.

```csharp
// Ruta a ajustar en la carpeta Models en la clase PruebaTecnicaContext, línea 28
=> optionsBuilder.UseSqlServer("Server=DESKTOP-AOHL8UE\\SQLEXPRESS;Database=PruebaTecnica;Trusted_Connection=True;TrustServerCertificate=True");
