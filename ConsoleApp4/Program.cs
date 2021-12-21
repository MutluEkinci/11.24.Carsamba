using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public enum Sirala { IDyeGore,AdaGore,FiyataGore}
    class Karsilastir : IComparer
    {
        public Sirala NeyeGore { get; set; }

        public int Compare(object x, object y)
        {
            Urun u1 = (Urun)x;
            Urun u2 = (Urun)y;

            if (NeyeGore == Sirala.IDyeGore)
                return u1.UrunID.CompareTo(u2.UrunID);
            else if (NeyeGore == Sirala.AdaGore)
                return u1.UrunAdi.CompareTo(u2.UrunAdi);
            //else if (NeyeGore = Sirala.FiyataGore)
            return u1.Fiyat.CompareTo(u2.Fiyat);
        }
    }
    class Depo:IEnumerable
    {
        private ArrayList _depo = new ArrayList();
        public void Ekle(Urun urun)
        {
            _depo.Add(urun);
        }
        public void Sirala(Sirala sirala)
        {

            _depo.Sort(new Karsilastir { NeyeGore = sirala });
        }
        public IEnumerator GetEnumerator()
        {
            return _depo.GetEnumerator();
        }
    }
    class Urun:IComparable
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return this.UrunID.CompareTo(urun.UrunID);//*-1
        }
        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            depo.Ekle(new Urun { UrunID = 15, UrunAdi = "Mouse", Fiyat = 230 });
            depo.Ekle(new Urun { UrunID = 7, UrunAdi = "Keyboard", Fiyat = 125 });
            depo.Ekle(new Urun { UrunID = 1, UrunAdi = "Zımba", Fiyat = 105 });

            depo.Sirala(Sirala.IDyeGore);
            foreach(Urun urun in depo)
                Console.WriteLine(urun);
        }
    }
}
