using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._11Çarşamba
{
    public interface IArayuz//Interface'lere isimlendirme yaparken ilk harfi I ile başlar.yazılı olmayan kuraldır.*****
    {
        void Deneme();
    }
    class Personel : IArayuz
    {
        public void Deneme()
        {
            Console.WriteLine("Deneme Metodu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //microsoft documents
            /*
            
            İNTERFACE(Arayüz) :
            1-Esneklik kazandırır.
            2-Hiyerarşik düzeni kırma imkanı verir*****
            3-Sınıflara yetenek kazandırmak için de kullanılır.
            4-"Contract"
            5-sembolu *-o gibi 
            6-Interface içindeki her şey public olmak zorunda.O yüzden metodların başına public yazmaya gerek yok.
            7-Metodların gövdesi olamaz. 
            8-İçerisie değişken tanımlanamaz ama member tanımlanabilir.
            9-Erişim belirleyicisi olamaz.

            */

            
            



        }
    }
}
