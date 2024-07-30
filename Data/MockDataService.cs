using KonnClient.Data.Dto;
using KonnClient.Data.Models;

namespace KonnClient.Data;

public class MockDataService
{
    public static readonly List<Workspace> Workspaces = new List<Workspace>
    {
        new Workspace
        {
            Id = 1,
            UserId = 101,
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
            UserId = 102,
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
            UserId = 103,
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
            UserId = 104,
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
            UserId = 105,
            Name = "Workspace Epsilon",
            Description = "This is the fifth workspace.",
            Image = "https://example.com/image5.jpg",
            IsDeleted = false,
            CreatedAt = new DateTime(2023, 9, 1),
            UpdatedAt = null // No update date
        }
    };

    public static readonly List<Contact> Contacts = new List<Contact>
            {
                new Contact
                {
                    Id = 1,
                    WorkspaceId = 1,
                    Name = "John Doe",
                    Pronounciation = "John Doe",
                    Email = "john.doe@example.com",
                    Phone = "123-456-7890",
                    Telephone = "123-456-7890",
                    Image = "john_doe_image.png",
                    Notes = "Important contact",
                    IsFavorite = true,
                    IsBlocked = false,
                    IsEmergency = false,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Id = 1,
                            ContactId = 1,
                            FullName = "John Doe Address",
                            IsDefault = true,
                            CreatedAt = DateTime.Now
                        }
                    },
                    ContactCategories = new List<ContactCategory>
                    {
                        new ContactCategory
                        {
                            Id = 1,
                            ContactId = 1,
                            CategoryId = 1,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "Work",
                                Color = "#2800ff",
                            }
                        }, new ContactCategory
                        {
                            Id = 1,
                            ContactId = 1,
                            CategoryId = 1,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "Emergency",
                                Color = "#ff00db",
                            }
                        }, new ContactCategory
                        {
                            Id = 1,
                            ContactId = 1,
                            CategoryId = 1,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "School",
                                Color = "#40be34",
                            }
                        }, new ContactCategory
                        {
                            Id = 1,
                            ContactId = 1,
                            CategoryId = 1,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "Government",
                                Color = "#373c45",
                            }
                        }
                    },
                    Workspace = Workspaces.First(w => w.Id == 1)
                },
            };

    // Mock Categories
    public static readonly List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    WorkspaceId = 1,
                    Name = "Important",
                    Description = "Important contacts",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Workspace = Workspaces.First(w => w.Id == 1),
                    ContactCategories = new List<ContactCategory>
                    {
                        new ContactCategory
                        {
                            Id = 1,
                            ContactId = 1,
                            CategoryId = 1,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "Family",
                                Color = "#2800ff",
                            }
                        }
                    }
                },
                new Category
                {
                    Id = 2,
                    WorkspaceId = 2,
                    Name = "Colleague",
                    Description = "Colleagues",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Workspace = Workspaces.First(w => w.Id == 2),
                    ContactCategories = new List<ContactCategory>
                    {
                        new ContactCategory
                        {
                            Id = 2,
                            ContactId = 2,
                            CategoryId = 2,
                            Category = new Category
                            {
                                Id = 1,
                                Name = "Family",
                                Color = "#2800ff",
                            }
                        }
                    }
                }
            };

    public static Task<ContactGetDto> GetContacts(int startIndex, int count)
    {
        var contacts = Contacts.Skip(startIndex).Take(count).ToList();

        return Task.FromResult(new ContactGetDto
        {
            Contacts = contacts,
            TotalCount = Contacts.Count
        });
    }
}
