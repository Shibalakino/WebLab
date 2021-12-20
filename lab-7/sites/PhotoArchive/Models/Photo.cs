namespace PhotoArchive.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Name { get; set; }
        public string Ref { get; set; }
        public string Desc { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
    }
}
