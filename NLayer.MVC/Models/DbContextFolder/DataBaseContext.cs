using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NLayer.MVC.Models.Entities;

namespace NLayer.MVC.Models.DbContextFolder
{
    public class DataBaseContext : IdentityDbContext<Customer , AppRole , string>
    {

    }
}
