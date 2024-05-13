using Microsoft.AspNetCore.Identity;

namespace NLayer.MVC.Models.Entities
{
    public class Customer : IdentityUser<string>
    {
        public int CustomerId { get; set; }
        public string? LastName { get; set; }
        public List<string>? Adress { get;  set; }
    }
}
