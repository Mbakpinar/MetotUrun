using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager)
        {
            //başvuran bilgilerini değerlendirme
            //
        
            crediManager.Hesapla();

        }


        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
