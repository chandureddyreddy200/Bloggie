namespace bloggie.web.Models.Domain
{
    public class BlogPost
    {
        public  Guid Id { get; set; }
        public String Heading { get; set; }
        public String PageTitle { get; set; }
        public String Content { get; set; }
        public String ShortDescritption { get; set; }
        public String FeaturedImageUrl { get; set; }
        public String UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public String Author { get; set; }
        public Boolean Visible { get; set; }

        public ICollection<Tag> Tags { get; set; }             //to tell EF Core that this blogpost can have multiple tags  


    }
}
