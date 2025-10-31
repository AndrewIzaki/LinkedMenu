using ingredient.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using product.Models;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


namespace mysqlefcore
{
  class Program
  {
    static void Main(string[] args)
    {
      InsertData();
    //   PrintData();
    }

    private static void InsertData()
    {
      using(var context = new ProductContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();

        // Adds a publisher
        var ingredient = new Ingredient
        {
          name = "Pepperoni"
        };
        context.ingredient.Add(ingredient);

        // Adds some books
        context.product.Add(new Product
        {
            name = "CALABREDZAAAA",
            price = 19.99f,
            Ingredients = new List<Ingredient> { ingredient }
        });
        context.product.Add(new Product
        {
            name = "Peperoneee",
            price = 29.99f,
            Ingredients = new List<Ingredient> { ingredient }
        });

        // Saves changes
        context.SaveChanges();
      }
    }

    // private static void PrintData()
    // {
    //   // Gets and prints all books in database
    //   using (var context = new ProductContext())
    //   {
    //     var products = context.product
    //       .Include(p => p.Ingredients);
    //     foreach(var product in products)
    //     {
    //       var data = new StringBuilder();
    //       data.AppendLine($"ISBN: {product.id}");
    //       data.AppendLine($"Title: {product.name}");
    //       Console.WriteLine(data.ToString());
    //     }
    //   }
    // }
  }
}