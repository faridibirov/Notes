﻿

using System.ComponentModel.DataAnnotations;

namespace Notes.Identity.Models;

public class RegisterViewModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }


    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    public string ReturnUrl { get; set; }
}
