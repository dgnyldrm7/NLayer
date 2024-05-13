namespace NLayer.MVC.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Content { get; set; }


        //Comment property!
        public Product? product { get; set; }
    }
}
