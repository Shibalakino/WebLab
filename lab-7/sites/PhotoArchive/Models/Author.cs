using System.Collections.Generic;

namespace PhotoArchive.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ContactPhone { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
