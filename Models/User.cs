namespace KonnClient.Models;

public class User
{
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Image { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Workspace> Workspaces { get; set; }
}

