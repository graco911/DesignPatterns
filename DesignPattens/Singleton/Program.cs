using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonObject ObjSingleton = SingletonObject.getInstance();

            ObjSingleton.ShowMessage();

            Console.ReadLine();
        }
    }
}
