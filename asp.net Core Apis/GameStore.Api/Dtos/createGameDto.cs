using System.ComponentModel.DataAnnotations;
namespace GameStore.Api.Dtos;

public record class createGameDto(  
    
  [Required][StringLength(50)]  string Name,
   [Required][StringLength(15)] string Genre,
  [Range(1,100)]  decimal Price,
    DateOnly ReleaseDate);
