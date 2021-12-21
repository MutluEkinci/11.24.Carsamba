using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface IYuzebilir
    {
        void Yuz();
    }
    public interface IYuruyebilir
    {
        void Yuru();
    }
    public interface IUcabilir
    {
        void Uc();
    }
    class Karabatak : IYuzebilir, IYuruyebilir, IUcabilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    class Balik : IYuzebilir
    {
        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    class DeveKusu : IYuruyebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUcabilir u1 = new Karabatak();
            IYuruyebilir y1 = new DeveKusu();
            IYuruyebilir y2 = new Karabatak();
            
        }   

    }
}
