using System.Collections.Generic;

namespace threads
{
    public class Enumerators
    {
        public static IEnumerable<int> GetEnumerator(){
            for(int i=0;i<10;i++){
                yield return i;
            }
        }

        public static IEnumerable<long> EnumerateFibonacci()
        {
            long current = 1;
            long previous = 0;

            while (true)
            {
                yield return current;

                long temp = previous;
                previous = current;
                current += temp;
            }
        }
      
    }
}