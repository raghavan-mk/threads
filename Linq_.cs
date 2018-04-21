using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace threads
{
    public class Linq_ : IEnumerable, IEnumerator
    {
        public Linq_()
        {
        }

        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    public class Enumerators
    {
        public IEnumerable<int> GetEnumerator(){
            for(int i=0;i<10;i++){
                yield return i;
            }
        }
      
    }
}