var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //Adicionando suporte aos controllers

var app = builder.Build();

app.MapControllers(); // mapea os controllers

app.Run();
