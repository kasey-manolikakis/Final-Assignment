using FinalAssignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment.Data
{
    public class BookStoreContext : IdentityDbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        //dotnet ef migrations add CreateBookTable
        //dotnet ef database update
        //dotnet ef migrations add ChangePriceToInt

    }
}
