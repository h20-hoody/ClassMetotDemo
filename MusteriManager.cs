using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri>();
        public void MusteriListele()
        {
            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(musteri.ad + " " + musteri.soyad + " " + musteri.id + " " + musteri.DogumTarihi);

            }
            Console.WriteLine("**************************");
        }

        public void MusteriEkle()
        {
            Musteri musteri = new Musteri();


            Console.Write("Musterinin ismini giriniz:");
            musteri.ad = Console.ReadLine();
            Console.Write("Musterinin soyadini giriniz:");
            musteri.soyad = Console.ReadLine();
            Console.Write("Musterinin ID'sini giriniz:");
            musteri.id = int.Parse(Console.ReadLine());
            Console.Write("Musterinin Dogum tarihini giriniz:");
            musteri.DogumTarihi = int.Parse(Console.ReadLine());

            Musteriler.Add(musteri);

            Console.WriteLine("Musteri ekleniyor...");
            Task.Delay(3000);
            Console.WriteLine("Musteri basariyla eklandi");
            Console.WriteLine("****************************************");
        }

        public void MusteriSil()
        {
            Musteri musteri = new Musteri();
            Console.WriteLine("silmek istediginiz musterinin ID'isini giriniz:");

            musteri.id = int.Parse(Console.ReadLine());
            foreach (var customer in Musteriler)
            {
                if (customer.id == musteri.id)
                {
                    Musteriler.Remove(customer);
                    break;
                }
            }

            Console.WriteLine("Musteri siliniyor...");
            Task.Delay(3000);
            Console.WriteLine("Musteri basariyla silindi.");
            Console.WriteLine("****************************************");
        }
    }
}
