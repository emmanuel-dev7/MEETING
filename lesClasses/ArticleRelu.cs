using System.ComponentModel.DataAnnotations;

namespace MEETING.lesClasses
{
    public class ArticleRelu
    {
        [Key] public int idArticleRelu { get; set; }
        public Relecteur relecteur { get; set; }
        public Article article { get; set; }
        public int critereFond { get; set; }
        public int critereForme { get; set; }
        public int criterePertinence { get; set; }
    }
}
