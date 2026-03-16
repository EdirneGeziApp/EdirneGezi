using EdirneGeziAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritabanı bağlantımızı ve Harita (NetTopologySuite) ayarımızı sisteme tanıtıyoruz
builder.Services.AddDbContext<GeziDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    o => o.UseNetTopologySuite()));

// Kontrolcüleri sisteme dahil ediyoruz
builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Gelen istekleri ilgili kontrolcülere yönlendiriyoruz
app.MapControllers();

app.Run();