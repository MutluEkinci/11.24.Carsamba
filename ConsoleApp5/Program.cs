using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Araba
    {
        public string DisBoya { get; set; }
        public string IcBoya { get; set; }
    }
    class Boyahane
    {
        private ArrayList List = new ArrayList();
        public void Boya(Araba araba)
        {
            araba.DisBoya = Console.ReadLine();
            araba.IcBoya = Console.ReadLine();
            if(araba.DisBoya== "Kırmızı" && araba.IcBoya=="Kırmızı")
            Console.WriteLine("Arabanız Kırmızıya Boyanmıştır İyi Günler..."+ConsoleColor.Red);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 3: GTA veya benzeri NFS Hot Pursuit,Mafia vb gibi oyunlarda olan birilerinden kaçarken boyahaneye girip aracın rengini degistiren kodu yaziniz.
            Boyahane b = new Boyahane();
            b.Boya(new Araba { DisBoya = "Kırmızı", IcBoya = "Kırmızı" });



        }
    }
}
