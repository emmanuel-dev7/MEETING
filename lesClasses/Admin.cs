using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Admin
    {
        [Key]
        public int idAdmin { get; set; }
        [Required]
        public string nomAdmin { get; set; }
        [Required]
        public string passAdmin { get; set; }

        private readonly greatManagerContext _context;

        public Admin(greatManagerContext context)
        {
            _context = context;
        }

        public async Task<bool> IsValid(string nomAdmin, string passAdmin)
        {
            if (string.IsNullOrEmpty(nomAdmin) || string.IsNullOrEmpty(passAdmin))
            {
                return false;
            }
            var admin = _context.Admin.FirstOrDefault(a => a.nomAdmin == nomAdmin);

            return admin != null && admin.passAdmin == passAdmin;
        }
    }
}