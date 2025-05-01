# 🚗 License Plate Recognition System

Bu proje, C# Windows Forms kullanılarak geliştirilmiş bir **Plaka Tanıma Sistemi**dir.  
Proje kapsamında çeşitli görüntü işleme yöntemleri uygulanmakta ve OCR (Optical Character Recognition) teknolojisi ile plakalardaki karakterler okunmaktadır.

---

## 📂 Proje Klasör Yapısı

```plaintext
LicensePlateRecognition/
│
├── 📁 ImageProcessingMethods/       ← Görüntü işleme fonksiyonlarını içeren sınıflar
│   ├── Grayscale.cs
│   ├── BinaryThreshold.cs
│   ├── HistogramEqualization.cs
│   └── ... diğer 12 metod
│
├── 📁 OCR/
│   └── OcrProcessor.cs              ← Tesseract gibi bir kütüphane ile OCR işlemi
│
├── 📁 Resources/
│   ├── SamplePlates/                ← Örnek plaka görüntüleri
│   └── Output/                      ← Çıktı görselleri ve OCR sonuçları
│
├── 📁 Utils/
│   └── ImageHelper.cs               ← Görüntü dönüştürme, kaydetme gibi yardımcı işler
│
├── 📄 MainForm.cs                   ← Dashboard (UI) ve iş akışının merkezi
├── 📄 MainForm.Designer.cs          ← Form tasarımı (otomatik oluşturulan)
├── 📄 Program.cs                    ← Uygulama giriş noktası
├── 📄 App.config                    ← Gerekirse config ayarları
└── 📄 LicensePlateRecognition.csproj
