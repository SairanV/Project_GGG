using Microsoft.EntityFrameworkCore;
using Project_GGG;

var builder = WebApplication.CreateBuilder(args);


string defaultConnection = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ProjectGGGContext>(
    options => options.UseSqlServer(defaultConnection));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();