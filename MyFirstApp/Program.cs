var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Do what are you doing ..");
app.MapGet("/", () => "Do it Smartly");

app.Run();
