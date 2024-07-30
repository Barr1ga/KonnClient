﻿using System.ComponentModel.DataAnnotations;

namespace KonnClient.Data.Models;

public class Workspace
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; } = string.Empty;

    public string? Image { get; set; }

    [Required]
    public bool IsDeleted { get; set; } = false;

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; }

    public virtual ICollection<Category> Categories { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; }
}