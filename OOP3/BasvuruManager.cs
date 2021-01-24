using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //basvuran bilgilerini değerlendirme

            //bu şekilde yaparsan tüm kredi hesaplama işlemlerini buraya bağlı hale getirmiş olursun
            //yapma
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            //neyi gönderirsen( taşıt kredisi ya konut kredisi) IKrediManager onun referansını tuttuğundan
            //istediğinin işlemini yapabilirsin
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
