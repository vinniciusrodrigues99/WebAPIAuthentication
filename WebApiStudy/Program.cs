using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using WebApiStudy;
using WebApiStudy.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Injetando dependência para que a classe AppDbContext passe corretamente para a classe pai DbContext quais configurações devem ser utilizadas quando a aplicação for inicializada. 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //Define o middleware do swagger.
    app.UseSwaggerUI();
    app.ConfigureApiExceptionMiddleware();
}

app.UseHttpsRedirection(); //Middleware para redirecionar chamadas http para https. 

app.UseAuthentication(); //Middleware para autenticação.

app.UseAuthorization();

app.MapControllers();

app.Run();
