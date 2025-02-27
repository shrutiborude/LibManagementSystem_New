using System.Data.Common;
using System.Data.Entity;

namespace LibManagementSystem_Updated.Models
{
    public class MyDbContext : DbContext
    {
        // Constructor for production (Uses Connection String from Configuration)
        public MyDbContext() : base("name=MyDBConnectionString")
        {

        }

        // Constructor for Dependency Injection (Allows Passing a Database Connection)
        public MyDbContext(DbConnection connection) : base(connection, true)
        {

        }

        // Define DbSet properties for entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<IssuedBook> IssuedBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
