using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class Article
    {
        [Key]
        public int idArticle { get;  set; }
        public String titre { get; set; }
        public String description { get; set; }
        public String pathDocPdf { get; set; }
        public String statut { get; set; }
        public String justificatif { get; set; }
        public Auteur auteur { get; set; }
        public Conference conference { get; set; }
    }
}
