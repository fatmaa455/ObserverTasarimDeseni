using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    class Uye : IUye
    {
        public void update(absUrun urun)
        {
            Console.WriteLine(urun.urunAd + "   " + urun.Fiyat);
        }
    }
}
