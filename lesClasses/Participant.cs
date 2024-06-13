using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Participant
    {
        [Key]
        public String idParti { get; set; }
        public String nomParti { get; set; }
        public String prenomParti { get; set; }
        public String telephoneParti { get; set; }
        public String usernameParti { get; set; }
        public String passwordParti { get; set; }
        public bool statut { get; set; }
    }
    }
