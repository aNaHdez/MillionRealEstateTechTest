using Microsoft.EntityFrameworkCore;
using MillionRealEstateTechTest.Infrastructure.Data;
using MillionRealEstateTechTest.Application.Interfaces;
using MillionRealEstateTechTest.Infrastructure.Repositories;
using System.Reflection;
using MediatR;
using FluentValidation.AspNetCore;
using FluentValidation;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.Load("MillionRealEstateTechTest.Application"));
});

// Aquí el código correcto para FluentValidation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(Assembly.Load("MillionRealEstateTechTest.Application"));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
