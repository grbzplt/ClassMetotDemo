using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} ", musteri.Ad, musteri.Soyad + " eklendi...");
            
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("{0} {1} {2}", musteri.Ad, musteri.Soyad,musteri.HesapNo);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} {1} ", musteri.Ad, musteri.Soyad + " silindi...");
        }

    }
}
