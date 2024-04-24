using System;
using System.Collections;
using System.Linq;


namespace MetroCardManagemnet
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        //field for count ,initial value is 0
        private int _count;
        //it is like size 
        private int _capacity;
        
        public int Count { get { return _count; } set { _count = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        //declaring array 
        private Type[] _array;
        
        //indexers-when we use object as array
        public Type this[int index]
        {
            get {return _array[index]; }
            set { _array[index]=value; }
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        //add method
        public void Add(Type value)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = value;
            _count++;
        }

        public void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

    }
}