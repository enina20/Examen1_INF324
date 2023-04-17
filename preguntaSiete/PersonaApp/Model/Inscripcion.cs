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
    public class Inscripcion
    {
        [Key]
        public int CIestudiante { get; set; }
        public string Sigla { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float NotaFinal { get; set; }

        public string PersonaCI { get; set; }

        [ForeignKey("PersonaCI")]

        [JsonIgnore]
        [XmlIgnore]
        public virtual Persona? Persona { get; set; } = null;

    }

}
