using API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();

app.MapGet("api/product", () =>
{
    var products = new List<ProductDto>();
    products.Add(new ProductDto(1, "Product 1", 10.99m));
    products.Add(new ProductDto(2, "Product 2", 15.99m));
    products.Add(new ProductDto(3, "Product 3", 20.99m));

    return Results.Json(products);
});

app.Run();
