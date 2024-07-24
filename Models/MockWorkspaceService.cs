namespace KonnClient.Models;

public class MockWorkspaceService
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
}
