using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ISmartPhone
    {
        // we can not declair an interface method Static
        //static void OS(); 
        //static void AppStore();

        void OS();
        void AppStore();

    }


    interface IFeatures
    {
        void TouchID();
    }

    class Apple : ISmartPhone
    {
        // into this apple class we must call/implement two method which we already 
        // initialied into the interface other wise it will show error to this class

        // Also if we initialize the method of interface in access modifier public then will through an error

        //private void OS()
        //{
        //    Console.WriteLine("OS Method: The OS of this Smartphone is iOS8");
        //}

        // we must make public methods

        public void OS()
        {
            Console.WriteLine("OS Method: The OS of this Smartphone is iOS8");
        }


        public void AppStore()
        {
            Console.WriteLine("AppStore Method: The Application Store of this Smartphone is iTunes");
        }
    }

    class Samsung : ISmartPhone, IFeatures
    {

        //---------------------------------- this two method from ISmartPhone Interface -----------------------------------
        //OS Method Implementation    
        public void OS()
        {
            Console.WriteLine("OS Method: The OS of this smartphone is Android");
        }

        //AppStore Method Implementation    
        public void AppStore()
        {
            Console.WriteLine("AppStore Method: The Application Store of this smartphone is Google Play");
        }
        // -------------------------------------------------------------ISmartPhone ----------------------------------------

        // Now we see that we implement two methods from ISmartPhone already , but also we need to IFeature interface methods-----------
        // otherwise it will throw an error
        public void TouchID()
        {
            Console.WriteLine("TouchID Method: This method provides Touch/Gesture Control features.");
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////////// - Interface Demo - //////////////////// \n");
            Console.WriteLine("Apple SmartPhone:");
            Apple apple = new Apple();
            apple.OS();
            apple.AppStore();
            Samsung samsung = new Samsung();
            samsung.TouchID();
            samsung.OS();
            samsung.AppStore();
            Console.ReadKey();
        }
    }
}
