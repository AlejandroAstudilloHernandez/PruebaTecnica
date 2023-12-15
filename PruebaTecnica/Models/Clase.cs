using System;
using System.Collections.Generic;

namespace PruebaTecnica.Models;

public partial class Clase
{
    public int ClaseId { get; set; }

    public decimal? NumeroClase { get; set; }

    public string? NombreClase { get; set; }

    public decimal? NumeroDepartamento { get; set; }
}
