using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Barkın
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Barkın";
            musteri1.Soyadi = "Akpınar";
            musteri1.TcNo = "1245678910";

            // kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "KODLAMA.IO";
            musteri2.VergiNo = "12345678";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);








            //GERÇEK--TÜZEL
        }
    }
}
