using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Müşteri eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(" Müşteri listelendi : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Gelir);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(" Müşteri silindi : " + musteri.Ad + "  " + musteri.Soyad);
        }

    }
}
