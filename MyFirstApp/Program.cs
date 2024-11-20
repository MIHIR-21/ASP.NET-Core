var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DO what are you doing..");
app.MapGet("/", () => "Nice to meet you..");

app.Run();
