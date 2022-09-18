using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyMovieDatabase.Data.EFCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyMovieDatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyMovieDatabaseContext") ?? throw new InvalidOperationException("Connection string 'MyMovieDatabaseContext' not found.")));

// Add services to the container.
builder.Services.AddScoped<EfCoreMovieRepository>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
