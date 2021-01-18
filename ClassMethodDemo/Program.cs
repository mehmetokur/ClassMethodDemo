using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Adi = "Mehmet";
            musteri1.SoyAdi = "Okur";
            musteri1.Adres = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Adi = "Ali";
            musteri2.SoyAdi = "Okur";
            musteri2.Adres = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Adi = "Ayşe";
            musteri3.SoyAdi = "Okur";
            musteri3.Adres = "Ankara";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id :"+ " "+ musteri.Id);
                Console.WriteLine("Müşteri Adı ve Soyadı :"+musteri.Adi+" "+musteri.SoyAdi);
                Console.WriteLine("Müşteri Adresi :"+" "+musteri.Adres);
                Console.WriteLine("  ");
            }
            Console.WriteLine("-----------------------------------------");
           
            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("-----------------------------------------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine("-----------------------------------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
