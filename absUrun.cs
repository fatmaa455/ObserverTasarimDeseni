using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    abstract class absUrun
    {
        // takip edilen nesne
        public string urunAd { get; set; }
        private int fiyat;

        // observer nesne listesi
        public List<IUye> takipList;

        public absUrun(string urunAd,int fiyat)
        {
            takipList = new List<IUye>();
            this.urunAd = urunAd;
            this.fiyat = fiyat;
        }
        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                // fiyatı düşmüş ise üyelere haber ver
                if (fiyat > value)
                {
                    notifyUrun();
                }
                fiyat = value;
            }
        }
        public void notifyUrun()
        {
            foreach(IUye item in takipList)
            {
                item.update(this);
            }
        }
    }
}
