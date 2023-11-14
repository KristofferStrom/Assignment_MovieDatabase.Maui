using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_MovieDatabase.Api.Models.Entities;

public class ActorEntity
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;

    [Required, Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;
}
