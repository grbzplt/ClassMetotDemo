using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
                    
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.HesapNo = 68456;

            musteri2.Ad = "Kerem";
            musteri2.Soyad = "Varış";
            musteri2.HesapNo = 74521;

            musteri3.Ad = "Berkay";
            musteri3.Soyad = "Bilgin";
            musteri3.HesapNo = 90123;
                  
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("---------------Müşteri Listesi------------------");
            musteriManager.MusteriListele(musteriler);
            Console.WriteLine("-------------------------------------------------");

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Murat";
            musteri4.Soyad = "Kurtboğan";
            musteri4.HesapNo = 104560;

            musteriManager.MusteriEkle(musteri4);

            Console.WriteLine("---------------------------------");

            musteriManager.MusteriSil(musteri2);

        }
    }
}
