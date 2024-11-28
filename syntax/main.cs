using ServicesToDoAPI;
// using CRUD; SystemToDo.RunApp(); // Sistema CRUD ToDo CLI 


// Estabelecer os fundamentos da Applicação (App..) com Definição padrão
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Constroi a App.. a partir dos fundamentos estabelecidos
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Adiciona um Blocos de operação POST, GET, PUT, DELETE a App..
app.MapPost("/ToDo", (ToDo info) => ToDoAPI.CreateToDo(info));
app.MapGet("/ToDo", () => ToDoAPI.ReadToDo());
app.MapPut("/ToDo/{id}", (ToDo info, int id) => ToDoAPI.UpdateToDo(info, id));
app.MapDelete("/ToDo/{id}", (int id) => ToDoAPI.DeleteToDo(id));

// Roda App.. com as configurações
app.Run();

