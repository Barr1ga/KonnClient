namespace KonnClient.Models;

public class Workspace
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; } = string.Empty;

    public string? Image { get; set; }

    public bool IsDeleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

}
