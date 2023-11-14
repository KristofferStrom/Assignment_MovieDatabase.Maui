﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_MovieDatabase.Api.Models.Entities;

[Index(nameof(Title), IsUnique = true)]
public class MovieEntity
{
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(50)")]
    public string Title { get; set; } = null!;

    [Required, Column(TypeName = "nvarchar(200)")]
    public string Description { get; set; } = null!;

    [Required] public LanguageEntity Language { get; set; } = null!;
    [Required] public int LanguageId { get; set; }

    [Required] public GenreEntity Genre { get; set; } = null!;
    [Required] public int GenreId { get; set; }

    [Required] public DirectorEntity Director { get; set; } = null!;
    [Required] public int DirectorId { get; set; }

    [Required] public AgeLimitEntity AgeLimit { get; set; } = null!;
    [Required] public int AgeLimitId { get; set; }  


}
