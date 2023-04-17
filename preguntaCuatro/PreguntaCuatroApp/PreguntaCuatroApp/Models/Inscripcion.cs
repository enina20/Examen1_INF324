using System;
using System.Collections.Generic;

namespace PreguntaCuatroApp.Models;

public partial class Inscripcion
{
    public int? Ciestudiante { get; set; }

    public string? Sigla { get; set; }

    public double? Nota1 { get; set; }

    public double? Nota2 { get; set; }

    public double? Nota3 { get; set; }

    public double? NotaFinal { get; set; }

    public virtual Persona? CiestudianteNavigation { get; set; }
}
