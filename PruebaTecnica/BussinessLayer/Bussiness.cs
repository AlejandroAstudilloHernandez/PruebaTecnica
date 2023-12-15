using PruebaTecnica.DataAccesLayer;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.BussinessLayer
{
    public class Bussiness
    {
        private readonly Data _data;
        public Bussiness(Data data)
        {
            _data = data;
        }


        public void AltaProducto(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad)
        {            
            _data.AltaArticulo(sku, articulo, marca, modelo, departamento, clase, familia, stock, cantidad);
        }

        public void BajaArticulo(int sku)
        {
            _data.BajaArticulo(sku);
        }

        public Articulo ConsultaArticulo(int sku)
        {
            return _data.ConsultaArticulo(sku);
        }

        public Articulo CambioProducto(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad, bool descontinuado)
        {
            return _data.CambioProducto(sku, articulo, marca, modelo, departamento, clase, familia, stock, cantidad, descontinuado);
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            return _data.ObtenerDepartamentos();
        }

        public List<Clase> ObtenerClases(int numeroDepartamento)
        {
            return _data.ObtenerClases(numeroDepartamento);
        }

        public List<Familia> ObtenerFamilias(string nombreClase)
        {
            return _data.ObtenerFamilias(nombreClase);
        }

    }
}
