using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine(" {1} isimli müşteri {0} Id no ile eklenmiştir.",musteri.Id,musteri.Adi);
        }
        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(" Id no {0} olan {1} isimli müşteri silinmiştir.", musteri.Id, musteri.Adi);
        }

        public void MusteriListele(Musteri[] musteriler)
        {

            Console.WriteLine("Bütün müşteriler aşağıda listelenmiştir.");
            foreach (Musteri item in musteriler)
            {
                Console.WriteLine("       Id: {0}   Adı: {1}   Soyadı:  {2}",item.Id,item.Adi,item.Soyadi);
            }
        }
    }
}
