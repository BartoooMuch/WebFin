# WebFin - Job Search Web Application  

## 📌 Proje Açıklaması  
Bu proje, **kariyer.net** benzeri bir iş arama web uygulamasıdır. Kullanıcılar iş ilanlarını arayabilir, detaylarını inceleyebilir ve başvuru yapabilir.  

## 🚀 Kullanılan Teknolojiler  
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQLite**
- **Bootstrap & jQuery**
- **IIS Express & Kestrel**

## 📂 Proje Yapısı  
- **Controllers/** → MVC Controller’ları (`HomeController.cs`, `JobPostController.cs`, `SearchController.cs`)  
- **Models/** → Veritabanı modelleri (`JobPost.cs`, `Company.cs`, `City.cs`)  
- **Views/** → Razor Sayfaları (`Index.cshtml`, `Details.cshtml`, `SearchResults.cshtml`)  
- **wwwroot/** → CSS & JavaScript dosyaları  

## 🔧 **Kurulum ve Çalıştırma**  
📌 Projeyi çalıştırmak için şu komutları kullan:  
```sh
dotnet restore
dotnet ef database update
dotnet run
