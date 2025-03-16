var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  // ✅ Add Controllers
var app = builder.Build();

app.MapControllers();  // ✅ Enable Controller Routing

app.Run();
