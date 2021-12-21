using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface IBoyanabilir
    {
    }
    abstract class Arac
    {
        public int MaxHiz { get; set; }
        public ConsoleColor Renk { get; set; }
        public virtual void Display()
        {
        }
    }
    class Boyahane
    {
        public void Aracboya(IBoyanabilir arac, ConsoleColor renk)
        {
            if (arac == null)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Boyanamaz...");
            }
            else
                ((Arac)arac).Renk = renk;
        }
    }
    class Ferrari : Arac, IBoyanabilir
    {
        public Ferrari(ConsoleColor renk)
        {
            Renk=renk;
        }
        public int Plaka { get; set; }
        public override void Display()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }
    class Bmx : Arac
    {
        public Bmx(ConsoleColor color)
        {
            Renk = color;
        }
        public override void Display()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Bmx");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari f1 = new Ferrari(ConsoleColor.Red);
            Bmx b1 = new Bmx(ConsoleColor.Blue);

            f1.Display();
            b1.Display();
            Boyahane boyahane = new Boyahane();
            boyahane.Aracboya(f1, ConsoleColor.DarkYellow);

            f1.Display();

            //Bmx Iboyanabilir arayuzunu uygulamadığından hata verir.
            //if(b1 is IBoyanabilir)
                boyahane.Aracboya(b1 as IBoyanabilir, ConsoleColor.Gray);
        }
    }
}
