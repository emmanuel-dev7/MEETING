using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Conference
    {
        [Key]
        public int idConf { get; set; }
        public String nomConf { get; set; }
        public String theme { get; set; }
        public String sigle { get; set; }
        public DateTime debSoumission { get; set; }
        public DateTime finSoumission { get; set; }
        public DateTime debResultat { get; set; }
        public DateTime finResultat { get; set; }
        public DateTime debInscription { get; set; }
        public DateTime finInscription { get; set; }
        public DateTime debConference { get; set; }
        public DateTime finConference { get; set; }




    }
}
