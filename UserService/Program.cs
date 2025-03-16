var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  // ✅ Enable Controllers

var app = builder.Build();

app.MapControllers();  // ✅ Ensure Controllers are Mapped

app.Run();
