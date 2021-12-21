using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IArayuz1
    {
        string Ack { get; set; }
    }
    public interface IArayuz2
    {
        void MetodA();
    }
    class Deneme : IArayuz1, IArayuz2
    {
        public string Ack { get; set; }
        public void MetodA()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme();
            
        }
    }
}
