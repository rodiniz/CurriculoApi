using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LiteDbContext>(options =>
{
    var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    string? connStr = env == "Development"
        ? builder.Configuration.GetConnectionString("DefaultConnection")
        : Environment.GetEnvironmentVariable("DATABASE_URL");

    // Parse connection URL to connection string for Npgsql
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    connStr = connStr.Replace("postgres://", string.Empty);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    var pgUserPass = connStr.Split("@")[0];
    var pgHostPortDb = connStr.Split("@")[1];
    var pgHostPort = pgHostPortDb.Split("/")[0];
    var pgDb = pgHostPortDb.Split("/")[1];
    var pgUser = pgUserPass.Split(":")[0];
    var pgPass = pgUserPass.Split(":")[1];
    var pgHost = pgHostPort.Split(":")[0];
    var pgPort = pgHostPort.Split(":")[1];
    connStr = env == "Development" ? $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};"
    : $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};SSL Mode=Require;Trust Server Certificate=true";

    options.UseNpgsql(connStr);
});


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
