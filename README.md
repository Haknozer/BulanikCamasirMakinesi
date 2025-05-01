
# Bulanık Mantık ile Çalışan Çamaşır Makinesi

Bu proje, C# programlama dili kullanılarak geliştirilmiş, Mamdani bulanık mantık çıkarımı ile çalışan bir çamaşır makinesi simülasyonudur. 
Kullanıcının verdiği **hassaslık**, **miktar** ve **kirlilik** değerlerine göre; **dönüş hızı**, **süre** ve **deterjan miktarı** bulanık mantık ile hesaplanmaktadır.

## 🔧 Kullanılan Teknolojiler

- C# (.NET Windows Forms)
- DataGridView (kurallar ve giriş/çıkış değerleri yönetimi)
- Chart
  
## 📥 Giriş Değişkenleri

| Giriş        | Üyelik Fonksiyonları     |
|--------------|---------------------------|
| Hassaslık     | Sağlam, Orta, Hassas      |
| Miktar        | Küçük, Orta, Büyük        |
| Kirlilik      | Küçük, Orta, Büyük        |

## 📤 Çıkış Değişkenleri

| Çıkış         | Üyelik Fonksiyonları             |
|----------------|----------------------------------|
| Dönüş Hızı     | Hassas, Normal_Hassas, Orta, Normal_Güçlü, Güçlü |
| Süre           | Kısa, Normal_Kısa, Orta,Normal_Uzun, Uzun |
| Deterjan Miktarı | Çok Az, Az, Orta, Fazla, Çok Fazla |

## 🧠 Bulanık Çıkarım Sistemi

Mamdani yöntemi şu adımlarla uygulanır:

1. **Bulanıklaştırma:** Giriş değerlerine göre üyelik dereceleri hesaplanır.
2. **Kural Uygulama:** IF-THEN kuralları kullanılır. `AND` bağlaçları için `min` operatörü kullanılır.
3. **Çıktı Kesme (Clipping):** Kurala ait çıkış üyelik fonksiyonu, hesaplanan minimum üyelik derecesi ile kesilir.
4. **Birleştirme (Aggregation):** Aynı çıkış için gelen tüm kesilmiş fonksiyonlar `max` operatörü ile birleştirilir.
5. **Durulaştırma (Defuzzification):** Ağırlıklı ortalama (centroid) yöntemi ile net değer hesaplanır.

## 📊 Ekran Görüntüsü

![Ekran görüntüsü 2025-05-01 174349](https://github.com/user-attachments/assets/edb5fd94-7229-4e54-9bed-ca76c773889a)


## 📁 Projeyi Çalıştırma

1. Visual Studio ile projeyi açın.
2. `Form1.cs` üzerinden uygulamayı başlatın.
3. Giriş değerlerini girin ve hesaplama işlemini başlatın.
4. Sonuçları grafiksel olarak izleyin.

## 🔗 Proje Bağlantısı

[GitHub Repository](https://github.com/Haknozer/BulanikCamasirMakinesi)

## 🧩 Geliştirici

- **Ad:** Hakan Özer
- **Üniversite:** Selçuk Üniversitesi
- **Bölüm:** Bilgisayar Mühendisliği
- **Sınıf:** 3. Sınıf

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.
