using Microsoft.EntityFrameworkCore;
using YouCode.Models.Entity;

namespace YouCode.Models.Context
{
    public class YouCodeContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASUS_TUF;Database=DbYouCode;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
