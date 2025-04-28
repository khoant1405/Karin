using Karin.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServiceExtensions();

var app = builder.Build();

app.ConfigureExtensions();

app.Run();