using Interitance.Application;
using Interitance.Converters;
using Interitance.Models;
using Interitance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var services = builder.Services;

services
    .AddScoped<IAnimalRepository<Cat>, CatRepository>()
    .AddScoped<IAnimalRepository<Dog>, DogRepository>()
    .AddScoped<IAnimalRepository<Animal>, AnimalRepository>()
    .AddScoped<IAnimalSearch, AnimalRepository>()

    .AddScoped<AnimalService>()

    .RegisterConverterDependencies();


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
