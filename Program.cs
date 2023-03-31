using System;

namespace Observer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk olarak takip edilen nesnemizi oluşturuyoruz
            absUrun kitap = new Urun("kitap", 25);

            // observer listesine nesne ekliyoruz
            kitap.takipList.Add(new Uye());

            // fiyat düşünce observer nesnelerinin ilgili metodu çağırılacak
            kitap.Fiyat = 15;
            kitap.Fiyat = 10;
        }
    }
}
