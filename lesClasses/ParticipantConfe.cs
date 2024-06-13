using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class ParticipantConfe
    {
        [Key] 
        public int idParticipantConfe { get; set; }
        public Participant participe { get; set; }
        public Conference confe { get; set;}
        public String commentaire { get; set;}
    }
}
