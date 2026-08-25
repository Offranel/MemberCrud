using Microsoft.EntityFrameworkCore;
using MemberCrud.Models;

namespace MemberCrud.Data
{
    public class MemberCrudDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<MemberMinistry> MemberMinistries { get; set; }
        public DbSet<VolunteerMessage> VolunteerMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Ministries
            modelBuilder.Entity<Ministry>().HasData(
                new Ministry { Id = 1, Name = "Worship", Description = "Leads worship and music for services." },
                new Ministry { Id = 2, Name = "Children", Description = "Programs and care for children during services." },
                new Ministry { Id = 3, Name = "Outreach", Description = "Community outreach and service projects." }
            );

            // Seed Members
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Phone = "555-0100",
                    Email = "alice.johnson@example.com",
                    MembershipStatus = "Active",
                    Street = "123 Maple St",
                    City = "Springfield",
                    PostalCode = "12345",
                    DateOfBirth = new DateOnly(1988, 4, 12),
                    CreatedAt = new DateTime(2023, 1, 10, 9, 0, 0)
                },
                new Member
                {
                    Id = 2,
                    FirstName = "Brian",
                    LastName = "Martinez",
                    Phone = "555-0111",
                    Email = "brian.martinez@example.com",
                    MembershipStatus = "Active",
                    Street = "45 Oak Ave",
                    City = "Springfield",
                    PostalCode = "12345",
                    DateOfBirth = new DateOnly(1995, 7, 3),
                    CreatedAt = new DateTime(2023, 2, 5, 14, 30, 0)
                },
                new Member
                {
                    Id = 3,
                    FirstName = "Carla",
                    LastName = "Nguyen",
                    Phone = "555-0122",
                    Email = "carla.nguyen@example.com",
                    MembershipStatus = "Pending",
                    Street = "78 Pine Rd",
                    City = "Rivertown",
                    PostalCode = "67890",
                    DateOfBirth = new DateOnly(2000, 11, 20),
                    CreatedAt = new DateTime(2024, 3, 1, 8, 15, 0)
                },
                new Member
                {
                    Id = 4,
                    FirstName = "Daniel",
                    LastName = "Smith",
                    Phone = "555-0133",
                    Email = "daniel.smith@example.com",
                    MembershipStatus = "Inactive",
                    Street = "9 Cedar Blvd",
                    City = "Lakeside",
                    PostalCode = "24680",
                    DateOfBirth = new DateOnly(1979, 2, 28),
                    CreatedAt = new DateTime(2022, 11, 20, 16, 45, 0)
                }
            );

            // Seed MemberMinistries (assign members to ministries)
            modelBuilder.Entity<MemberMinistry>().HasData(
                new MemberMinistry { Id = 1, MemberId = 1, MinistryId = 1 },
                new MemberMinistry { Id = 2, MemberId = 1, MinistryId = 3 },
                new MemberMinistry { Id = 3, MemberId = 2, MinistryId = 1 },
                new MemberMinistry { Id = 4, MemberId = 3, MinistryId = 2 }
            );

            // Seed VolunteerMessages
            modelBuilder.Entity<VolunteerMessage>().HasData(
                new VolunteerMessage { Id = 1, MemberId = 1, MessageText = "Available to lead worship on Sundays.", SentAt = new DateTime(2024, 6, 1, 10, 0, 0) },
                new VolunteerMessage { Id = 2, MemberId = 3, MessageText = "Interested in volunteering with the children's program.", SentAt = new DateTime(2024, 6, 5, 12, 30, 0) }
            );
        }
    }
}