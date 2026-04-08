using System;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace SesliAsistanKonsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KONSOL SESLİ ASİSTAN ===");

            // --- 1. AŞAMA: TEXT TO SPEECH (METNİ SESE ÇEVİRME) ---
            Console.WriteLine("\n[METNİ OLUŞTURMA]");
            Console.Write("Lütfen seslendirilmesini istediğiniz bir metin yazın ve Enter'a basın: ");
            string metin = Console.ReadLine();

            // Sesi okutuyoruz
            using (SpeechSynthesizer okuyucu = new SpeechSynthesizer())
            {
                Console.WriteLine("Okunuyor...");
                okuyucu.Speak(metin); // İşlem bitene kadar bekler
            }

            // --- 2. AŞAMA: SPEECH TO TEXT (SESİ METNE ÇEVİRME) ---
            Console.WriteLine("\n[DİNLEME MODU - İNGİLİZCE]");
            Console.WriteLine("Lütfen mikrofona İngilizce kelimeler söyleyin (Örn: Hello, Computer, Apple).");
            Console.WriteLine("(Uygulamadan çıkmak için Enter'a basın)\n");

            try
            {
                // Sesten metne motorunu İngilizce (en-US) olarak kesinleştiriyoruz
                using (SpeechRecognitionEngine dinleyici = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US")))
                {
                    // Serbest konuşma gramerini yüklüyoruz
                    dinleyici.LoadGrammar(new DictationGrammar());

                    // Varsayılan mikrofonu seçiyoruz
                    dinleyici.SetInputToDefaultAudioDevice();

                    // Ses algılandığında (kelime bulunduğunda) tetiklenecek fonksiyon
                    dinleyici.SpeechRecognized += Dinleyici_SpeechRecognized;

                    // Ses duyduğu an ekrana nokta (.) basmasını sağlayan anlık test
                    dinleyici.SpeechHypothesized += (s, e) => { Console.Write("."); };

                    // Dinlemeyi arka planda ve sürekli olarak başlatıyoruz
                    dinleyici.RecognizeAsync(RecognizeMode.Multiple);

                    // Konsol uygulamasının kapanmasını engellemek için kullanıcıdan tuş bekliyoruz
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ses tanıma başlatılamadı. Mikrofonunuz kapalı olabilir.");
                Console.WriteLine("Hata Detayı: " + ex.Message);
                Console.ReadLine();
            }
        }

        // Mikrofon sesi algılayıp kelimeye çevirdiğinde bu metot otomatik çalışır
        static void Dinleyici_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Duyduğu metni ve ne kadar emin olduğunu (0 ile 1 arası oran) ekrana yazar
            Console.WriteLine($"\n>>> Duyulan: {e.Result.Text} (Eminlik Oranı: {e.Result.Confidence})");
        }
    }
}