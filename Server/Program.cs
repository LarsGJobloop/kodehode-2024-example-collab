var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () => "Server running!");

app.UseStaticFiles();

app.Run();
