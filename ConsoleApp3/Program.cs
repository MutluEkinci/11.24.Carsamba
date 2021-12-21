using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            //Soru 2: biri int ,diğeri string olan iki dizi tanımlayıp bunların içerisindeki değerleri sıralayınız.
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] isimler = { "Ali", "Mehmet", "Veli" };

            ArrayList list1 = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8 };
            ArrayList list2 = new ArrayList() { "Ali", "Mehmet", "Veli" };

            list1.Sort()
            list2.Sort();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }



        }
    }
}
