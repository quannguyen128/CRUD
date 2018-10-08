using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Bufftechs2
{
    //here, we extend
    public class AppDbContext : DbContext
    {
        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";
                    

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) //optionsBuilder is just a variable name
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Client> Client {get; set;}
        public DbSet<Advisor> Advior {get; set;}

        public DbSet<Project> Project {get; set;}
        public DbSet<Organization> Organization {get; set;}
        public DbSet<Team> Team {get; set;}

    }

}