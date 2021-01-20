using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            //musteri eklemek
            musteriManager.MusteriEkle();
            musteriManager.MusteriEkle();
            musteriManager.MusteriEkle();

            //musteri silemk
            musteriManager.MusteriSil();

            //musteri siralamak
            musteriManager.MusteriListele();

        }
    }
}
