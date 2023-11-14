﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_MovieDatabase.Api.Models.Entities;

public class ReviewEntity
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(20)")]
    public string Username { get; set; } = null!;

    [Required, Range(1,10)]
    public int Rating { get; set; }

    [Column(TypeName = "nvarchar(200)")]
    public string? ReviewText { get; set; }

    [Required]
    public MovieEntity Movie { get; set; } = null!;

    [Required]
    public int MovieId { get; set; }
}
