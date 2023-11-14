using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment_MovieDatabase.Api.Models.Entities;

[Index(nameof(AgeLimit), IsUnique = true)]
public class AgeLimitEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int AgeLimit { get; set;}
}
