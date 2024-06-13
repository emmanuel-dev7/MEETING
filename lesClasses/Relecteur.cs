using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Relecteur
    {
        [Key]
        public int idRelec { get; set; }
        public String nomRelec { get; set; }
        public String prenomRelec { get; set; }
        public String telephoneRelec { get; set; }
        public String usernameRelec { get; set; }
        public String passwordRelec { get; set; }
        public String email { get; set; }
        public String specialite { get; set; }
        public bool statut { get; set; }

    }
}
