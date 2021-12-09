using Microsoft.EntityFrameworkCore;
using ContactManager.BL.Models;


namespace ContactManager.BL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            //purposeful to be empty - Necessary for Scaffold 
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //purposeful to be empty - sets appropriate options

        }

        //dbset of the tables
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailAddresses> EmailAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(x =>

            {
                _ = x.HasData(
                       new Contact() { EmailAddress = "mn@nerdymail.com", FirstName = "Michelle", LastName = "Nesbitt" },
                       new Contact() { EmailAddress = "men@nerdymail.com", FirstName = "Michelle", LastName = "Nesbitt" }
                   ); 
            });

            modelBuilder.Entity<EmailAddresses>(x =>

            {
                _ = x.HasData(
                       new EmailAddresses() { EmailID = 1,  EmailAddress = "mn@nerdymail.com", EmailType = EmailTypeEnum.Business },
                       new EmailAddresses() { EmailID = 2, EmailAddress = "men@nerdymail.com", EmailType = EmailTypeEnum.Personal }
                   ); ;
            });
        }

    }
}
