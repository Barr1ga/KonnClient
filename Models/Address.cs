namespace KonnClient.Models;

public class Address
{
    public int Id { get; set; }

    public int ContactId { get; set; }

    public string FullName { get; set; } = string.Empty;

    public bool IsDefault { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

    public virtual Contact Contact { get; set; }
}