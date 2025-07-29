using System;

class Program
{
    static void Main(string[] args)
    {
        bool devam = true;

        while (devam)
        {
            Console.Clear();
            Console.WriteLine("=== İlker'in Konsol Programı ===");
            Console.WriteLine("1 - Karşılama ve Yaş Hesaplama");
            Console.WriteLine("2 - Hesap Makinesi (4 işlem)");
            Console.WriteLine("3 - Sayı Tahmin Oyunu 🎯");
            Console.WriteLine("0 - Çıkış");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    KarsilamaVeYas();
                    break;

                case "2":
                    HesapMakinesi();
                    break;

                case "3":
                    SayiTahminOyunu();
                    break;

                case "0":
                    devam = false;
                    Console.WriteLine("Program kapatılıyor...");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

            if (devam)
            {
                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }

    static void KarsilamaVeYas()
    {
        Console.Clear();
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        Console.Write("Doğum yılınızı girin: ");
        int dogumYili = Convert.ToInt32(Console.ReadLine());

        int yas = DateTime.Now.Year - dogumYili;
        Console.WriteLine($"\nMerhaba {ad}! 👋");
        Console.WriteLine($"{yas} yaşındasınız! 🎉");
    }

    static void HesapMakinesi()
    {
        Console.Clear();
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nİşlem seçin (+, -, *, /): ");
        string islem = Console.ReadLine();

        double sonuc = 0;

        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                break;
            case "/":
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                    Console.WriteLine("0'a bölme yapılamaz!");
                break;
            default:
                Console.WriteLine("Geçersiz işlem!");
                return;
        }

        Console.WriteLine($"\nSonuç: {sonuc}");
    }

    static void SayiTahminOyunu()
    {
        Console.Clear();
        Console.WriteLine("=== Sayı Tahmin Oyunu 🎯 ===");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım bulabilecek misin?");

        Random rnd = new Random();
        int tutulanSayi = rnd.Next(1, 101); // 1-100 arası sayı
        int tahmin = 0;
        int deneme = 0;

        while (tahmin != tutulanSayi)
        {
            Console.Write("\nTahmininizi girin: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out tahmin))
            {
                deneme++;
                if (tahmin < tutulanSayi)
                    Console.WriteLine("Daha büyük bir sayı deneyin ⬆️");
                else if (tahmin > tutulanSayi)
                    Console.WriteLine("Daha küçük bir sayı deneyin ⬇️");
                else
                    Console.WriteLine($"\n🎉 Tebrikler! {deneme}. denemede doğru bildiniz.");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin!");
            }
        }
    }
}
