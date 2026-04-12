using EdirneGeziAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Veritabanı ve Harita (Npgsql + NetTopologySuite) Ayarı
builder.Services.AddDbContext<GeziDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    o => o.UseNetTopologySuite()));

// 2. CORS İzni: Emülatörün (10.0.2.2) senin bilgisayarına bağlanabilmesi için şart!
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Swagger için gerekli explorer
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- ÖNEMLİ SIRALAMA BURADAN BAŞLIYOR ---

// 3. STATİK DOSYA DESTEĞİ (RESİMLER İÇİN EN KRİTİK SATIR!)
// Bu satır wwwroot klasörünü dış dünyaya açar.
app.UseStaticFiles();

// 4. CORS'u aktif et (Statik dosyalardan sonra, Map'lerden önce)
app.UseCors();

// Swagger Ayarları
app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    // Geliştirme ortamında ek detaylar gerekirse buraya gelir
}

// Emülatörle çalışırken HTTPS yönlendirmesi bazen sorun çıkarabilir. 
// Eğer resimler yine gelmezse alttaki satırı başına // koyarak iptal edebilirsin.
app.UseHttpsRedirection();

app.UseAuthorization();

// 5. Kontrolcüleri Haritala
app.MapControllers();

app.Run();