using System;
using System.Collections.Generic;
using System.Text;

namespace MetotUrun

{
    class sepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) //İşlem tanımlandı (işlemin uygulanacağı parametre)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi); //Tanımlanan işlem yürütüldü.
        }


        //bu şekilde kullanma!! aynı şekilde yazmazsak hata alırız.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunAdi);
        }
    }
}