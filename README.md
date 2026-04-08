# 🎙️ C# Konsol Sesli Asistan (TTS & STT)

Bu proje, C# ve `.NET Framework` kullanılarak geliştirilmiş, konsol tabanlı basit bir **Metinden Sese (Text-to-Speech)** ve **Sesten Metne (Speech-to-Text)** uygulamasıdır. Windows'un dahili `System.Speech` kütüphanesini kullanarak çevrimdışı (internetsiz) olarak çalışır.

## ✨ Özellikler

* **Metinden Sese (TTS):** Kullanıcının konsola yazdığı metinleri bilgisayarın varsayılan sesiyle okur.
* **Sesten Metne (STT):** Kullanıcının mikrofona söylediği İngilizce kelimeleri algılar, anlık olarak ekrana yazar ve kelimeyi ne kadar net anladığını (güvenilirlik oranı) gösterir.
* **Asenkron Dinleme:** Uygulama dinleme yaparken donmaz, arka planda sürekli olarak sesi algılamaya devam eder.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Framework / Console Application
* **Kütüphane:** `System.Speech` (`System.Speech.Synthesis` ve `System.Speech.Recognition`)

## ⚙️ Gereksinimler ve Kurulum

Bu projenin bilgisayarınızda sorunsuz çalışması için bazı donanımsal ve yazılımsal gereksinimler bulunmaktadır:

1. **İşletim Sistemi:** Windows (System.Speech kütüphanesi Windows API'lerine dayanır).
2. **Donanım:** Çalışır durumda bir mikrofon ve hoparlör.
3. **Dil Paketi:** Ses tanıma (STT) motorunun İngilizce kelimeleri algılayabilmesi için Windows **Ayarlar > Zaman ve Dil > Dil ve Bölge** menüsünden **English (United States)** dilinin ve **Konuşma Tanıma (Speech Recognition)** paketinin yüklü olması gerekir.

### Projeyi Çalıştırma

1. Bu depoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/KULLANICI_ADIN/sesli-asistan-konsol.git](https://github.com/KULLANICI_ADIN/sesli-asistan-konsol.git)
