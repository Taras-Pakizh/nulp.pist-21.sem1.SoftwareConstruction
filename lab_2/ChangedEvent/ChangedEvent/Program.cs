using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangedEvent
{
    class Program
    {

        public static event ChangedEventHandler Changed;

        public static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++) {
                Changed = null;
                switch (new Random().Next(2))
                {
                    case 0:
                        Changed += new ChangedEventHandler(m1);
                        break;
                    case 1:
                        Changed += new ChangedEventHandler(m2);
                        break;
                    case 2:
                        Changed += new ChangedEventHandler(m3);
                        break;
                    default:
                        Changed += new ChangedEventHandler(m4);
                        break;
                }
                Changed(null, new Args());
                Console.ReadKey();
            }
        }

        private static void m1(object sender, Args args)
        {
            Console.WriteLine("1");
        }

        private static void m2(object sender, Args args)
        {
            Console.WriteLine("2");
        }

        private static void m3(object sender, Args args)
        {
            Console.WriteLine("3");
        }

        private static void m4(object sender, Args args)
        {
            Console.WriteLine("4");
        }
    }

}
