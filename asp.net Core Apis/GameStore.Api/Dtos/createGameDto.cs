namespace GameStore.Api.Dtos;

public record class createGameDto(  
    int Id, 
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);
