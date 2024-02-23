namespace DevCart.Models
{
    public  class Article
    {
        public long Id { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Article(long id, string titel, string description,string image)
        {
            Id = id;
            Titel = titel;
            Description = description;
            Image = image;
        }
    }

   
}
