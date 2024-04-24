using System;
using System.Collections;

namespace QwickFoodz
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}set{_count=value;}}
        public int Capacity{get{return _capacity;}set{_capacity=value;}}
        private Type[] _array;

        public Type this[int index]
        {
            get {return _array[index];  }
            set { _array[index]=value; }
        }

        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Add(Type element)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }

        public void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
    }
}