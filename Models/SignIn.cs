﻿using System.ComponentModel.DataAnnotations;

namespace KonnClient.Models;

public class SignIn
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string? Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string? Password { get; set; } = string.Empty;
}