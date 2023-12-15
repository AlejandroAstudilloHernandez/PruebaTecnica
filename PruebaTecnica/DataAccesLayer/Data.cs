using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DataAccesLayer
{
    public class Data
    {
        private readonly PruebaTecnicaContext _pruebaTecnicaContext;

        public Data(PruebaTecnicaContext contexto)
        {
            _pruebaTecnicaContext = contexto;
        }

        public void AltaArticulo(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad)
        {
            var parametros = new[]
            {
                new SqlParameter("@Sku", SqlDbType.Int) { Value = sku },
                new SqlParameter("@Articulo", SqlDbType.NVarChar, 15) { Value = articulo },
                new SqlParameter("@Marca", SqlDbType.NVarChar, 15) { Value = marca },
                new SqlParameter("@Modelo", SqlDbType.NVarChar, 20) { Value = modelo },
                new SqlParameter("@Departamento", SqlDbType.Int) { Value = departamento },
                new SqlParameter("@Clase", SqlDbType.Int) { Value = clase },
                new SqlParameter("@Familia", SqlDbType.Int) { Value = familia },
                new SqlParameter("@Stock", SqlDbType.Int) { Value = stock },
                new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad }
            };

            _pruebaTecnicaContext.Database.ExecuteSqlRaw("EXEC sp_AltaProducto @Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad", parametros);
        }

        public Articulo ConsultaArticulo(int sku)
        {
            var parametro = new SqlParameter("@Sku", SqlDbType.Int) { Value = sku };

            // Utiliza FromSqlInterpolated para componer la consulta de manera más segura
            FormattableString consulta = $"EXEC sp_ConsultaProducto @Sku = {parametro}";

            // Ejecuta la consulta y obtén el primer resultado
            return _pruebaTecnicaContext.Articulos.FromSqlInterpolated(consulta).AsNoTracking().AsEnumerable().FirstOrDefault();
        }

        public void BajaArticulo(int sku)
        {
            var parametro = new SqlParameter("@Sku", SqlDbType.Int) { Value = sku };

            _pruebaTecnicaContext.Database.ExecuteSqlRaw("EXEC sp_BajaProducto @Sku", parametro);

        }

        public Articulo CambioProducto(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad, bool descontinuado)
        {
            try
            {
                // Crear parámetros para el procedimiento almacenado
                var parametros = new[]
                {
                    new SqlParameter("@Sku", SqlDbType.Int) { Value = sku },
                    new SqlParameter("@Articulo", SqlDbType.NVarChar, 15) { Value = articulo },
                    new SqlParameter("@Marca", SqlDbType.NVarChar, 15) { Value = marca },
                    new SqlParameter("@Modelo", SqlDbType.NVarChar, 20) { Value = modelo },
                    new SqlParameter("@Departamento", SqlDbType.Int) { Value = departamento },
                    new SqlParameter("@Clase", SqlDbType.Int) { Value = clase },
                    new SqlParameter("@Familia", SqlDbType.Int) { Value = familia },
                    new SqlParameter("@Stock", SqlDbType.Int) { Value = stock },
                    new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad },
                    new SqlParameter("@Descontinuado", SqlDbType.Bit) { Value = descontinuado }
                };

                // Formatear la consulta SQL con los nombres de parámetros
                string consulta = "EXEC sp_CambioProducto ";
                consulta += "@Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad, @Descontinuado";

                // Ejecutar el procedimiento almacenado y evitar el seguimiento de entidades (tracking)
                var resultado = _pruebaTecnicaContext.Articulos
                    .FromSqlRaw(consulta, parametros)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



        public List<Departamento> ObtenerDepartamentos()
        {
            return _pruebaTecnicaContext.Departamentos.ToList();
        }

        public List<Clase> ObtenerClases(int numeroDepartamento)
        {
            return _pruebaTecnicaContext.Clases.Where(x => x.NumeroDepartamento == numeroDepartamento).ToList();
        }

        public List<Familia> ObtenerFamilias(string nombreClase)
        {
            return _pruebaTecnicaContext.Familias.Where(x => x.NombreClase == nombreClase).ToList();
        }

    }
}
