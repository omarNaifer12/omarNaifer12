using GameStore.Api.Dtos;

namespace GameStore.Api.endPoints;

public static class gamesEndPoints
{

private static readonly List<gameDto> games = [new(1, "The Witcher 3: Wild Hunt", "Action RPG", 29.99m, new DateOnly(2015, 5, 19)),
new(2, "Red Dead Redemption 2", "Action-Adventure", 59.99m, new DateOnly(2018, 10, 26)),
new(3, "The Legend of Zelda: Breath of the Wild", "Action-Adventure", 59.99m, new DateOnly(2017, 3, 3))];
public static RouteGroupBuilder mapGamesEndpoints(this WebApplication app){
    const string getGameEndPointName = "getGame";
    var group=app.MapGroup("games");
    
    group.MapGet("/",()=> games).WithName(getGameEndPointName);
group.MapGet("/{id}",(int id) => {
    gameDto?game=    games.Find(game => game.Id == id);
    return game is null?Results.NotFound():Results.Ok(game);
        });
//ADD//
group.MapPost("/",(createGameDto newGame)=>{
        gameDto game=new(games.Count+1,newGame.Name,newGame.Genre,newGame.Price,newGame.ReleaseDate);
        games.Add(game);
return Results.CreatedAtRoute(getGameEndPointName,new{id=game.Id},game);
});
//EDIT
group.MapPut("/{id}",(int id,updateGame upGame)=>{
        var index=games.FindIndex(game => game.Id == id);
        if(index==-1){
                return Results.NotFound();
        }
        games[index]=new gameDto(id,upGame.Name,upGame.Genre,upGame.Price,upGame.ReleaseDate);
return Results.NoContent();
});
app.Run();

// DELETE 
group.MapDelete("games",(int id)=>{
        games.RemoveAll(game => game.Id == id);
        return Results.NoContent();
});
return group;
}
}
