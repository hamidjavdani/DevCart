namespace DevCart.Models
{
    public  class Article
    {
        public long Id { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }

        public Article(long id, string titel, string description)
        {
            Id = id;
            Titel = titel;
            Description = description;
        }
    }

   
}
