using KonnClient.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KonnClient.Data.Contexts.Seed;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Email = "john.doe@example.com",
                Name = "John Doe",
                Image = "",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsDeleted = false
            }
        );

        modelBuilder.Entity<Workspace>().HasData(
            new Workspace
            {
                Id = 1,
                UserId = 1,
                Name = "Workspace Alpha",
                Description = "This is the first workspace.",
                Image = "https://example.com/image1.jpg",
                IsDeleted = false,
                CreatedAt = new DateTime(2023, 5, 1),
                UpdatedAt = new DateTime(2023, 5, 15)
            },
            new Workspace
            {
                Id = 2,
                UserId = 1,
                Name = "Workspace Beta",
                Description = "This is the second workspace.",
                Image = "https://example.com/image2.jpg",
                IsDeleted = false,
                CreatedAt = new DateTime(2023, 6, 1),
                UpdatedAt = new DateTime(2023, 6, 10)
            },
            new Workspace
            {
                Id = 3,
                UserId = 1,
                Name = "Workspace Gamma",
                Description = "This is the third workspace.",
                Image = "https://example.com/image3.jpg",
                IsDeleted = true,
                CreatedAt = new DateTime(2023, 7, 1),
                UpdatedAt = new DateTime(2023, 7, 5)
            },
            new Workspace
            {
                Id = 4,
                UserId = 1,
                Name = "Workspace Delta",
                Description = "This is the fourth workspace.",
                Image = "https://example.com/image4.jpg",
                IsDeleted = false,
                CreatedAt = new DateTime(2023, 8, 1),
                UpdatedAt = new DateTime(2023, 8, 20)
            },
            new Workspace
            {
                Id = 5,
                UserId = 1,
                Name = "Workspace Epsilon",
                Description = "This is the fifth workspace.",
                Image = "https://example.com/image5.jpg",
                IsDeleted = false,
                CreatedAt = new DateTime(2023, 9, 1),
                UpdatedAt = null // No update date
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                WorkspaceId = 1,
                Name = "Important",
                Description = "My own personal important contacts",
                IsDeleted = false,
                Color = "#60abe3",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Category
            {
                Id = 2,
                WorkspaceId = 1,
                Name = "Emergency",
                Description = "My own personal important contacts",
                IsDeleted = false,
                Color = "#60abe3",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            }
        );

        modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                Id = 1,
                WorkspaceId = 1,
                Name = "John Doe",
                Pronounciation = "John Doe",
                Email = "john.doe@example.com",
                Phone = "123-456-7890",
                Telephone = "123-456-7890",
                Image = "",
                Notes = "Important contact",
                IsFavorite = true,
                IsEmergency = false,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Contact
            {
                Id = 2,
                WorkspaceId = 1,
                Name = "Ben Affleck",
                Pronounciation = "Ben Affleck",
                Email = "ben.affleck@example.com",
                Phone = "123-456-7890",
                Telephone = "123-456-7890",
                Image = "",
                Notes = "Important contact",
                IsFavorite = true,
                IsEmergency = false,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Contact
            {
                Id = 3,
                WorkspaceId = 1,
                Name = "Hosea Mendez Barriga",
                Pronounciation = "Hosea Mendez Barriga",
                Email = "hosea@example.com",
                Phone = "123-456-7890",
                Telephone = "123-456-7890",
                Image = "",
                Notes = "Important contact",
                IsFavorite = true,
                IsEmergency = false,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );

        modelBuilder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                ContactId = 1,
                FullName = "University of San Carlos Talamban, Cebu",
                IsDefault = true,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 2,
                ContactId = 1,
                FullName = "Liloan, Cebu",
                IsDefault = true,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 3,
                ContactId = 1,
                FullName = "Villa Marina, Lapu-Lapu City",
                IsDefault = true,
                CreatedAt = DateTime.Now
            },
            new Address
            {
                Id = 4,
                ContactId = 2,
                FullName = "Guinacot, Danao, Cebu",
                IsDefault = true,
                CreatedAt = DateTime.Now
            }
        );

        modelBuilder.Entity<ContactCategory>().HasData(
            new ContactCategory { Id = 1, ContactId = 1, CategoryId = 1 },
            new ContactCategory { Id = 2, ContactId = 2, CategoryId = 2 }
        );
    }
}