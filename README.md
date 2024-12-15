# DotNetCore Diary Application

## Proje Hakkında
DotNetCore Diary Application, kullanıcıların günlüklerini yönetmelerini sağlayan basit ve etkili bir web uygulamasıdır. ASP.NET Core teknolojisi kullanılarak geliştirilmiştir ve kullanıcıların günlük kayıtlarını oluşturmasına, düzenlemesine ve silmesine olanak tanır. Bu proje, modern web geliştirme tekniklerini öğrenmek ve pratik yapmak için tasarlanmıştır.

## Teknik Özellikler
- **ASP.NET Core 9.0**: Projenin temel web uygulama çerçevesi.
- **Entity Framework Core**: Veritabanı işlemleri ve ORM (Object Relational Mapping) için kullanılmıştır.
- **Razor Pages ve View Engine**: Kullanıcı arayüzünün oluşturulmasında kullanılmıştır.
- **SQL Server**: Veritabanı olarak yapılandırılmıştır.
- **Migration Yönetimi**: Veritabanı şeması değişiklikleri için Entity Framework Migration kullanılmıştır.
- **Bootstrap 5**: Kullanıcı dostu ve responsive bir arayüz için.
- **Repository Pattern**: Veri erişim katmanını düzenlemek için uygulanmıştır.

## Öne Çıkan Özellikler
1. **CRUD İşlemleri**:
   - Günlük kayıtlarını oluşturma, düzenleme ve silme.
   - Kullanıcıların tüm günlük kayıtlarını görüntüleme.

2. **Seed Data ile Başlangıç Verileri**:
   - Migration sırasında başlangıç verileri otomatik olarak eklenir.

3. **Validation**:
   - Kullanıcıdan alınan verilerde doğrulama (validation) işlemleri yapılır.
   - Zorunlu alanlar için [Required] annotation kullanılmıştır.

4. **Modern Yazılım Mimarisi**:
   - Katmanlı mimari ve temiz kod prensipleri.
   - Dependency Injection ile daha test edilebilir bir yapı.

5. **Responsive Tasarım**:
   - Bootstrap kullanılarak cihaz uyumluluğu sağlanmıştır.

## Kurulum

Projeyi çalıştırmak için aşağıdaki adımları takip edin:

### 1. Gereksinimler
- .NET SDK 9.0 veya üzeri
- Visual Studio / JetBrains Rider veya herhangi bir IDE
- SQL Server

### 2. Projeyi Klonlama
```bash
git clone https://github.com/berkmahim/DotNetCore.git
cd DotNetCore
```

### 3. Veritabanı Ayarları
`appsettings.json` dosyasını açarak veritabanı bağlantı dizgisini kendi ortamınıza göre düzenleyin:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=DiaryAppDb;Trusted_Connection=True;"
}
```

### 4. Veritabanı Oluşturma ve Seed Data
EF Core Migration kullanarak veritabanını oluşturun ve başlangıç verilerini ekleyin:
```bash
dotnet ef database update
```

### 5. Uygulamayı Çalıştırma
Projeyi çalıştırın:
```bash
dotnet run
```
Tarayıcınızda `https://localhost:5001` adresine giderek uygulamayı görüntüleyebilirsiniz.

## Klasör Yapısı
```
DotNetCore/
├── Controllers/         # İş mantığını yöneten kontrolcüler
├── Data/                # Veri erişim ve DBContext
├── Models/              # Veri modelleri
├── Migrations/          # Veritabanı göç dosyaları
├── Views/               # Razor View dosyaları
├── wwwroot/             # Statik dosyalar (CSS, JS, Resimler)
└── Program.cs           # Uygulamanın giriş noktası
```

## Kullanılan Teknolojiler
- **ASP.NET Core**: Microsoft'un modern ve hızlı bir web geliştirme framework'ü.
- **Entity Framework Core**: Veritabanı işlemleri için.
- **Razor View Engine**: Dinamik HTML sayfaları oluşturmak için.
- **Bootstrap**: UI geliştirme.
- **LINQ**: Veri sorguları için güçlü bir araç.

## Gelecek Geliştirmeler
- Kullanıcı yönetimi ve kimlik doğrulama eklenmesi.
- Günlük kayıtları için kategori desteği.
- Günlükler arasında arama ve filtreleme özellikleri.
- Daha fazla test eklenerek uygulamanın stabilitesinin artırılması.

## Katkıda Bulunma
Projeye katkıda bulunmak istiyorsanız, lütfen şu adımları izleyin:
1. Bu repoyu fork edin.
2. Yeni bir dal (branch) oluşturun: `git checkout -b feature/yeniozellik`.
3. Değişikliklerinizi yapın ve commit edin: `git commit -m 'Yeni özellik ekle'`.
4. Dalınıza push edin: `git push origin feature/yeniozellik`.
5. Pull Request gönderin.

## Lisans
Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyin.

---
Proje ile ilgili herhangi bir sorun yaşarsanız lütfen [Issue](https://github.com/berkmahim/DotNetCore/issues) kısmında belirtmekten çekinmeyin.

