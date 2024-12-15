using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getinstance();
            s1.print();
            Singleton s2 = Singleton.getinstance();
            if(s1==s2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }    
        }
    }

    class Singleton
    {
        private static Singleton instance = null;
        private Singleton() { }
        public static Singleton getinstance()
        {
            if(instance==null)
            {
                instance = new Singleton();

            }return instance;
        }
        public void print()
        {
            Console.WriteLine("Hello from Singleton");
        }
    }
}
