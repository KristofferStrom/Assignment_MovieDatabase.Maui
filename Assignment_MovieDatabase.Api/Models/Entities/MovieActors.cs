using System.ComponentModel.DataAnnotations;

namespace Assignment_MovieDatabase.Api.Models.Entities;

public class MovieActors
{
    [Required]
    public int MovieId { get; set; }

    [Required]
    public int ActorId { get; set; }
}