var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", (string? name) =>
{
    name ??= "World";
    return $"Hello {name}";
});

app.Run();

app.Run();
