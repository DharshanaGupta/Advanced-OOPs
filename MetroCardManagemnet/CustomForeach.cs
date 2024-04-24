using System;
using System.Collections;


namespace MetroCardManagemnet
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int position = -1;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            if (position < _count)
            {
                return true;
            }
            Reset();
            return false;

        }

        public void Reset()
        {
            position = -1;
        }

        public object Current { get { return _array[position]; } }

    }
}