using CineApp.Data;
using CineApp.IData;
using CineApp.IServices;
using CineApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Lo configurtamos como el singleton(Una sola instancia de este objeto se comparte)
builder.Services.AddSingleton<IUsuariosSingletonDAO, UsuariosSingletonDAO>();
// Lo configuramos como scoped(Se crea una instancia de este objeto por cada request)
builder.Services.AddScoped<IUsuariosService, UsuariosService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
