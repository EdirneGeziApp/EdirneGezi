# Edirne Gezi Rehberi - Backend

Edirne Gezi Rehberi mobil uygulamasının ASP.NET Core Web API backend servisidir.

## Özellikler

* JWT Authentication
* Kullanıcı kayıt ve giriş işlemleri
* Mekan yönetimi
* Favori yönetimi
* Yorum sistemi
* Mekan önerileri
* Rota önerileri
* Admin işlemleri
* İstatistik servisleri
* PostgreSQL ve PostGIS desteği

## Kullanılan Teknolojiler

* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* PostGIS
* JWT Authentication
* BCrypt

## Veritabanı Tabloları

* Users
* Places
* Categories
* Favorites
* Reviews
* PlaceSuggestions
* RouteSuggestions
* RouteSuggestionStops

## Kurulum

```bash
git clone https://github.com/EdirneGeziApp/EdirneGezi.git

cd EdirneGezi

dotnet restore

dotnet ef database update

dotnet run
```

## API Özellikleri

* Authentication
* Places
* Favorites
* Reviews
* Recommendations
* Place Suggestions
* Route Suggestions
* Statistics

## Geliştiriciler

* Pınar Yılmaz
* Proje Ekibi

## Lisans

Bu proje eğitim amaçlı geliştirilmiştir.
