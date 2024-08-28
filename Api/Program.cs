using Api.Entities;
using Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var appSetting = builder.Configuration.Get<AppSetting>();

var app = builder.Build();

// Configure the HTTP request pipeline.

var books = new List<Book>
    {
        new() {
            Id = 1,
            Title = "Atomic Habits",
            Author = "James Clear",
            YearPublished = 2018,
            Pages = 320,
            IsAvailable = true
        }
    };

app.MapGet("/books", () => books);

app.Run();
