using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Provenance
    {
        [Key]
        public int idPro { get; set; }
        public string nomPro { get; set; }
        public string adressePro { get; set; }
        public int matPro { get; set;}
    }
}
