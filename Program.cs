using EdirneGeziAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. ADIM: Veritabanı bağlantımızı ve Harita (NetTopologySuite) ayarımızı sisteme tanıtıyoruz
builder.Services.AddDbContext<GeziDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    o => o.UseNetTopologySuite()));

// YENİ EKLENEN 1. SATIR: Kontrolcüleri sisteme dahil ediyoruz
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// YENİ EKLENEN 2. SATIR: Gelen istekleri ilgili kontrolcülere yönlendiriyoruz
app.MapControllers();

app.Run();