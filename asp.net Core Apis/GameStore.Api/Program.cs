using GameStore.Api.Dtos;
using GameStore.Api.endPoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.mapGamesEndpoints();
app.Run();