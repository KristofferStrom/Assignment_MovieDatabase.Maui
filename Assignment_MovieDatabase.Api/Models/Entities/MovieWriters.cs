using System.ComponentModel.DataAnnotations;

namespace Assignment_MovieDatabase.Api.Models.Entities;

public class MovieWriters
{
    [Required]
    public int MovieId { get; set; }

    [Required]
    public int WriterId { get; set; }
}
