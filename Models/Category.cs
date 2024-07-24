namespace KonnClient.Models;

public class Category
{
    public int Id { get; set; }

    public int WorkspaceId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsDeleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

    public virtual Workspace Workspace { get; set; }

    public virtual ICollection<ContactCategory> ContactCategories { get; set; }
}
