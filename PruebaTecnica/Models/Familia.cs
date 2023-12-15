using System;
using System.Collections.Generic;

namespace PruebaTecnica.Models;

public partial class Familia
{
    public int FamiliaId { get; set; }

    public decimal? NumeroFamilia { get; set; }

    public string? NombreFamilia { get; set; }

    public decimal? NumeroClase { get; set; }

    public string? NombreClase { get; set; }
}
