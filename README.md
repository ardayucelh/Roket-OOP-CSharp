# Roket OOP - C# Windows Forms

Bu depo, daha önce üzerinde çalışılan C# Nesne Yönelimli Programlama (OOP) roket simülasyonu çalışmasının, mevcut konuşma notlarına dayanarak yeniden oluşturulmuş sürümüdür. Orijinal proje dosyaları formatlama nedeniyle kaybolduğu için bu sürüm birebir kopya değildir.

## Projenin amacı

C# ile sınıf ve nesne kavramlarını; özellikler (fields/properties), metotlar, nesne oluşturma ve koşul kontrolleri üzerinden uygulamak.

## Kullanılan teknolojiler

- C#
- .NET 8
- Windows Forms

## Projede bulunan roketler

- SpaceX Falcon (2010)
- NASA Saturn V (1967)

Her roket nesnesinde hız, maksimum hız ve yakıt deposunun boşaltılıp boşaltılmadığını belirten bilgiler tutulur.

## Özellikler

- İki farklı roket nesnesi oluşturma
- Roket hızını kontrollü artırma
- Maksimum hız sınırını aşmayı engelleme
- Yakıt deposunu boşaltma durumunu takip etme
- Arayüz üzerinden roket seçimi ve durum görüntüleme

## Çalıştırma

1. Windows üzerinde .NET 8 SDK ve .NET masaüstü geliştirme bileşenlerinin kurulu olduğundan emin olun.
2. Projeyi Visual Studio ile açın veya terminalde proje klasörüne gidin.
3. Şu komutları çalıştırın:

```bash
dotnet restore
dotnet run
```

## Proje yapısı

```
Roket-OOP-CSharp/
├── Roket-OOP-CSharp.csproj
├── Program.cs
├── Roket.cs
├── MainForm.cs
└── README.md
```

## Not

Bu depo, geçmiş çalışmanın elde kalan teknik notlarıyla yeniden hazırlanmıştır. Orijinal ödevdeki tüm arayüz ayrıntıları ve hesaplama kuralları mevcut olmadığı için uygulama, OOP konularını gösteren çalışır bir örnek olarak düzenlenmiştir.
