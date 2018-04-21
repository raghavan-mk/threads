using System;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("just adding a line so file is modified");            
            // Console.WriteLine("Git ssh test");

            Enumerators enums = new Enumerators();
            foreach(int i in enums.GetEnumerator()){
               Console.WriteLine(i);
           }            
        }
    }
}
