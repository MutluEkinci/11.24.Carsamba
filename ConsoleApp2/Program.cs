using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Depo:IEnumerable
    {
        private ArrayList _depo = new ArrayList();
        public void Ekle(Urun urun)
        {
            _depo.Add(urun);
        }
        public IEnumerator GetEnumerator()
        {
            return _depo.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1:Bir depo sınıfı oluşturun ve içerisine ürün sınıfından nesne girin.foreach ile don.
            Depo depo = new Depo();
            depo.Ekle(new Urun { UrunAdi = "Defter", UrunID = 11, Fiyat = 20 });
            depo.Ekle(new Urun { UrunAdi = "Kalem", UrunID = 14, Fiyat = 25 });





            // normal şartlar altında foreach döngüsü IEnumarable arayüzünü uygulamış olan sınıflarda çalışır.depo sınıfında başlangıçta IEnumerable arayüzü olmadığından haat verir "GetEnumerator()",Interface'i uygulayınca foreach ile bilrikte çalışır.

            foreach (Urun urun in depo)
            {
                // Console.WriteLine(urun.UrunID+urun.UrunAdi+urun.Fiyat);
                Console.WriteLine(urun);//polymorphism ile yapıldı.
            }

            


        }
    }
}
