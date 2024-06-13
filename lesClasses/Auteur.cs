using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Auteur
    {
        [Key]
        public String idAuteur { get; set; }
        public String nomAuteur { get; set; }
        public String prenomAuteur { get; set; }
        public String telephoneAuteur { get; set; }
        public String usernameAuteur { get; set; }
        public String passwordAuteur { get; set; }
        public bool statut { get; set; }
    }
}
