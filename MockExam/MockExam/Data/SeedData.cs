using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MockExam.Models;

namespace MockExam.Data
{
    public class SeedData
    {
        public static async Task mockexamAsync(ApplicationDbContext context)
        {
            if (await context.Rooms.AnyAsync() == false) // checks if there are any rooms already in the database
            {
                var Rooms = new List<Rooms>
                {
                    new Rooms
                    {
                        RoomName = "Room1",
                        Description = "Nice room",
                        Price = 40,
                        Rating = 4,
                        MaxGuests = 10,
                        IsAvailable = true
                    },
                    new Rooms
                    {
                        RoomName = "Room2",
                        Description = "Normal room",
                        Price = 65,
                        Rating = 3,
                        MaxGuests = 30,
                        IsAvailable = false // this room is unavailible
                    },

                };
                await context.AddRangeAsync(Rooms);
                await context.SaveChangesAsync();
            }
            
        }
        public static async Task SeedRoles(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string[] roleNames = { "Admin", "Manager", "Staff", "User" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    var role = new IdentityRole(roleName);
                    await roleManager.CreateAsync(role);
                }
                var adminUser = await userManager.FindByEmailAsync("admin@example.com");
                if (adminUser != null)
                {
                    adminUser = new IdentityUser {  UserName = "admin@example.com", Email = "admin@example.com", EmailConfirmed = true };
                    await userManager.CreateAsync(adminUser, "Admin123!");
                }
            }

        }
    }
}
