using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment3Tests
{
    public class GenericList<X> :  IGenericList<X>
    {
        public IEnumerator<X> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(X item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(X item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public X GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(X item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(X item)
        {
            throw new NotImplementedException();
        }
    }
}
