using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class iPhone // Definition of abstract class
    {
        public void Call()
        {
            Console.WriteLine("Call Method: This Method Provides Calling features");
        }

        // if we write this way it will by default called private
        //abstract void Model(); 

        // if we write the abstract method in a public access modifier then there will be no error
        public abstract void Model();

    }

    //sealed abstract class seeel
    //{

    //}

    // we can not make a abstract class sealed or static

    class iphone5s : iPhone
    {
        public override void Model()
        {
            Console.WriteLine("Model: The model of this iPhone is iPhone5s");
        }

        
    }

    class Program 
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("/////////////// - Abstract Class Demo - ///////////////");
            // we can not make a object of a abstract class
            //iPhone ip = new iPhone();  // this line give us error
            iPhone ip;  // but we can create reference of an abstract class
            Program program = new Program();
            iphone5s iphone5s = new iphone5s();
            iphone5s.Model();
            iphone5s.Call();
            Console.ReadKey();
            //iPhone iphone = new iPhone();
        }
    }
}
