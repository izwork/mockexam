using Humanizer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MockExam.Models;

namespace MockExam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MockExam.Models.Rooms> Rooms { get; set; } = default!;
        public DbSet<MockExam.Models.Staff> Staff { get; set; } = default!;
        public DbSet<MockExam.Models.Bookings> Bookings { get; set; } = default!;
    }
}

