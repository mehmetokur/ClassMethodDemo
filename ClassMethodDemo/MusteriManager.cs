using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)

        {
            Console.WriteLine("Müşteri Eklendi= " + " "+"ID:" + musteri.Id + "  "+"Adı ve Soyadı:" + musteri.Adi+ " "+ musteri.SoyAdi+" "+"Adres:"+musteri.Adres);
        }

        public void Sil(Musteri musteri)

        {
            Console.WriteLine("Müşteri Silindi=" + " " +"ID:"+ musteri.Id + "  "+"Adı ve Soyadı:" + musteri.Adi+ "  " + musteri.SoyAdi );
        }

        public void Listele(Musteri musteri)

        {
            Console.WriteLine("Müşteri Listesi=" + " " + "ID:" + musteri.Id + "  " + "Adı ve Soyadı:" + musteri.Adi + " " + musteri.SoyAdi + " " + "Adres:" + musteri.Adres);
        }
    }
}
