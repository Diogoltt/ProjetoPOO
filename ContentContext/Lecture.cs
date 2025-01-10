using ProjetoPOO.ContentContext.Enums;

namespace ProjetoPOO.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}