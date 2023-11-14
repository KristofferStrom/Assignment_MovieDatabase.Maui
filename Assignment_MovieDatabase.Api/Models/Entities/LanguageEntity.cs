using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_MovieDatabase.Api.Models.Entities;

[Index(nameof(Language), IsUnique = true)]
public class LanguageEntity
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(50)")]
    public string Language { get; set; } = null!;
}
