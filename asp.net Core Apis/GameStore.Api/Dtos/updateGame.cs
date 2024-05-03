namespace GameStore.Api.Dtos;

public record class updateGame( string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);