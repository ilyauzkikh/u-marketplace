using Microsoft.EntityFrameworkCore;
using Products.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var presentationAssembly = typeof(Products.Presentation.AssemblyReference).Assembly;

builder.Services
    .AddControllers()
    .AddApplicationPart(presentationAssembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var testConnectionString = builder.Configuration["Products:ConnectionString"];
builder.Services.AddDbContext<ProductsContext>(x => x.UseNpgsql(testConnectionString));

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