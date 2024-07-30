using KonnClient.Data.Models;

namespace KonnClient.Data.Dto;


public class ContactDto
{
    public int Id { get; set; }
    public int WorkspaceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Pronounciation { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public bool IsFavorite { get; set; } = false;
    public bool IsBlocked { get; set; } = false;
    public bool IsEmergency { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public class ContactCreateDto
{
    public int WorkspaceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Pronounciation { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? Phone { get; set; } = string.Empty;
    public string? Telephone { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public string? Notes { get; set; } = string.Empty;
    public bool? IsFavorite { get; set; } = false;
    public bool? IsBlocked { get; set; } = false;
    public bool? IsEmergency { get; set; } = false;
    public List<AddressCreateDto>? Addresses { get; set; }
    public List<int>? CategoryIds { get; set; }
}

public class ContactGetDto
{
    public List<Contact> Contacts { get; set; } = [];
    public int TotalCount { get; set; }
}
