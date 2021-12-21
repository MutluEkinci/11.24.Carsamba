using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IKaradaGidebilir
    {

    }
    public interface IAracKullanabilir
    {

    }
    public interface IYuzebilir
    {

    }
    public interface IUcabilir
    {

    }
    class U571:IYuzebilir
    {

    }
    class F16:IUcabilir,IKaradaGidebilir
    {

    }
    class Ferrari:IKaradaGidebilir
    {

    }
    class Guvercin:IUcabilir
    {

    }
    class Insan:IAracKullanabilir,IUcabilir,IYuzebilir
    {

    }
    class Tekne:IYuzebilir
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:F16,U-571,Ferrari,Guvercin,Insan,Tekne öyle bir hiyerarşi oluşturun ki sanki programda kullanılacakmış gibi.
        }
    }
}
