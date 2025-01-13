using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
}