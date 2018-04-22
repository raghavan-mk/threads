using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

            Enumerators.EnumerateFibonacci().Take(5);
            var sequence = Enumerators.GetEnumerator().GetEnumerator();        
            
            while(sequence.MoveNext())
            {
                Console.WriteLine(sequence.Current);                          
           }                      

        }   
    }
}
