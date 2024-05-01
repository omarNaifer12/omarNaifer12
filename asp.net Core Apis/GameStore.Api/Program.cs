using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<gameDto>games = new List<gameDto>();
   games.Add(new gameDto(1, "The Witcher 3: Wild Hunt", "Action RPG", 29.99m, new DateOnly(2015, 5, 19)));
        games.Add(new gameDto(2, "Red Dead Redemption 2", "Action-Adventure", 59.99m, new DateOnly(2018, 10, 26)));
        games.Add(new gameDto(3, "The Legend of Zelda: Breath of the Wild", "Action-Adventure", 59.99m, new DateOnly(2017, 3, 3)));
app.MapGet("games",()=> games);
app.MapGet("games/{id}",(int id) => games.Find(game => game.Id == id));
app.Run();
