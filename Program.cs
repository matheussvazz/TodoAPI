using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //Adicionando suporte aos controllers
builder.Services.AddDbContext<AppDbContext>(); //Adicionando suporte para deixar o AppDbContext como um serviço

var app = builder.Build();

app.MapControllers(); // mapea os controllers

app.Run();
