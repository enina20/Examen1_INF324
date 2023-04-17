using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    public class Persona
    {
        [Key]
        public string CI { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public virtual ICollection<Inscripcion>? Inscripciones { get; set; } = null;

    }
}
