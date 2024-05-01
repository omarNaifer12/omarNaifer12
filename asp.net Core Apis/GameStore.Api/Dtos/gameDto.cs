namespace GameStore.Api.Dtos;

public record class gameDto(
    int Id, 
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);

