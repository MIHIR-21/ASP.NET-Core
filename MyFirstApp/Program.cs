var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "KEEP SMILING ..");

app.Run();
