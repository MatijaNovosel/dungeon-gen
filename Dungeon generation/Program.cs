using Dungeon_generation.Generator;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("cors", builder => {
  builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Dependency injections
builder.Services.AddScoped<IGenerator, Generator>();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors("cors");
app.Run();
