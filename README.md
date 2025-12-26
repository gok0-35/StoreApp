# 🛒 StoreApp - E-Ticaret Platformu

Modern ve kullanıcı dostu bir e-ticaret web uygulaması. Ürün listeleme, sepet yönetimi ve güvenli ödeme işlemleri sunar.

## 📋 İçindekiler

- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Kurulum](#-kurulum)

## ✨ Özellikler

- 🔍 **Ürün Listeleme ve Filtreleme**: Kategorilere göre ürün arama
- 🛒 **Sepet Yönetimi**: Ürün ekleme, çıkarma ve miktar güncelleme
- 💳 **Güvenli Ödeme**: Iyzico entegrasyonu ile güvenli ödeme işlemleri
- 🎨 **Modern UI**: Bootstrap 5 ile şık ve kullanıcı dostu tasarım
- 🔐 **Session Yönetimi**: Kullanıcı sepetlerinin güvenli saklanması

## 🛠 Teknolojiler

### Backend
- **ASP.NET Core 8.0** - Web framework
- **Entity Framework Core** - ORM
- **SQLite** - Veritabanı
- **Iyzico Payment Gateway** - Ödeme entegrasyonu
- **AutoMapper** - Object mapping

### Frontend
- **Razor Pages & MVC** - View engine
- **Bootstrap 5** - CSS framework
- **jQuery** - JavaScript library
- **Tag Helpers** - Custom HTML helpers

### Mimari
- **Repository Pattern** - Veri erişim katmanı
- **Dependency Injection** - Loose coupling
- **View Components** - Reusable UI components
- **Session Management** - Cart persistence

## 🚀 Kurulum

### Gereksinimler

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- Bir kod editörü (Visual Studio, VS Code, Rider)

### Adım Adım Kurulum

1. **Projeyi Klonlayın**
```bash
git clone https://github.com/kullanici-adi/StoreApp.git
cd StoreApp
```

2. **Bağımlılıkları Yükleyin**
```bash
dotnet restore
```

3. **Libman Kurulumu**
```bash
# Mevcut libman versiyonunu kontrol edin
dotnet tool list -g

# Varsa eski versiyonu kaldırın
dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli

# Libman'i yükleyin
dotnet tool install --global Microsoft.Web.LibraryManager.Cli --version 2.1.175
```

4. **Libman Configuration File**
```bash
cd StoreApp.Web
libman init -p cdnjs
```

5. **Kütüphane Kurulumu**
```bash
libman install bootstrap@5.3.2 -d wwwroot/lib/bootstrap
```

6. **CSS Kütüphanesinin Dahil Edilmesi**

`_Layout.cshtml` dosyasına aşağıdaki satırı ekleyin:
```html
<link href="/lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
```

7. **Veritabanını Oluşturun**
```bash
dotnet ef database update
```

8. **Uygulamayı Çalıştırın**
```bash
dotnet run
```
