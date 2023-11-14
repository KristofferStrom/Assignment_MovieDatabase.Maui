using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_MovieDatabase.Api.Models.Entities;

[Index(nameof(Genre), IsUnique = true)]
public class GenreEntity
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(50)")]
    public string Genre { get; set; } = null!;
}
