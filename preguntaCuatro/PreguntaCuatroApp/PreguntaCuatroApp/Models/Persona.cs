using System;
using System.Collections.Generic;

namespace PreguntaCuatroApp.Models;

public partial class Persona
{
    public int Ci { get; set; }

    public string? NombreCompleto { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string? Departamento { get; set; }
}
