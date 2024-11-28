using Microsoft.AspNetCore.Builder;  // Necessário para o WebApplication
using Microsoft.Extensions.Hosting; // Necessário para o Builder e Host
using CRUD;

// SystemToDo.RunApp();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "FALA ABROBEDO");

app.Run();

