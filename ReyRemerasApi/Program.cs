using Microsoft.EntityFrameworkCore;
using ReyRemerasApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ReyRemerasDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDb")));



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    ReyRemerasDbContext context = scope.ServiceProvider.GetRequiredService<ReyRemerasDbContext>();
    context.Database.Migrate();
}

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
