using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Musteri musteri1 = new Musteri();
            musteri1.Id =  1;
            musteri1.Ad = " Gülnur";
            musteri1.Soyad = " Polat";
            musteri1.KartNo = 3706;
            musteri1.Gelir = 8000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = " Gülsen";
            musteri2.Soyad = " Han";
            musteri2.KartNo = 2727;
            musteri2.Gelir = 6000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = " Filiz Serra";
            musteri3.Soyad = " Temel";
            musteri3.KartNo = 4406;
            musteri3.Gelir = 7000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler) 
            {
                Console.WriteLine("Müşteri Id" + musteri.Id);
                Console.WriteLine("Müşteri Ad" + musteri.Ad);
                Console.WriteLine("Müşteri Soyad" + musteri.Soyad);
                Console.WriteLine("Müşteri KartNo" + musteri.KartNo);
                Console.WriteLine("Müşteri Gelir" + musteri.Gelir);
                Console.WriteLine("----------------");

            }



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Silme(musteri1);

            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri2);
            musteriManager.Silme(musteri2);

            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri3);
            musteriManager.Silme(musteri3);


        }
    }
}
