using Scalar.AspNetCore;
using WebApiExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PriceCalculator>();

builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    // Development-specific configuration can go here
    app.MapOpenApi();
    app.MapScalarApiReference();

}

app.MapGet("/health", () => Results.Ok("Healthy"));

app.MapGet("/price/{amount:decimal}", (decimal amount, PriceCalculator calc) => Results.Ok(new { amount, tax = calc.CalcTax(amount) }));

app.Run();
