using System;
using System.Collections.Generic;

namespace PruebaTecnica.Models;

public partial class Articulo
{
    public int ArticuloId { get; set; }

    public decimal? Sku { get; set; }

    public string? Articulo1 { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public decimal? Departamento { get; set; }

    public decimal? Clase { get; set; }

    public decimal? Familia { get; set; }

    public DateTime? FechaAlta { get; set; }

    public decimal? Stock { get; set; }

    public decimal? Cantidad { get; set; }

    public bool Descontinuado { get; set; }

    public DateTime? FechaBaja { get; set; }
}
