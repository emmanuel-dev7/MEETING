using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class AuteurProvenance
    {
        [Key] public int idAutoPro { get; set; }
        public Auteur auteur { get; set; }
        public Provenance provenance { get; set; }
    }
}
