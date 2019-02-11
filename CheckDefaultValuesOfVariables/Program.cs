using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQusChecking
{
    class Program
    {
        private int x;  //here x default value is  0

        private Boolean booll;  // here boolean default value is False

        private string str;  // here str by default value is Null

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.x);

            if(p.booll)
            {
                Console.WriteLine("Boolll default value is true");
            }
            else
            {
                Console.WriteLine("Booolll default value is false");
            }

            if (p.x == null)
            {
                // This expression is always true......
            }

            if (p.str == null)
            {
                Console.WriteLine("str default is Null");
            }
            else
            {
                Console.WriteLine("str has values");
            }
            //Console.WriteLine(p.str);
            Console.ReadKey();
        }
    }
}
