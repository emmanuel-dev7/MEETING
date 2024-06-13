using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Organisateur
    {
        [Key]
        public String idOrga { get; set; }
        public String nomOrga { get; set; }
        public String prenomOrga { get; set; }
        public String telephoneOrga { get; set; }
        public String usernameOrga { get; set; }
        public String passwordOrga { get; set; }
        public bool statut { get; set; }

    }
}
