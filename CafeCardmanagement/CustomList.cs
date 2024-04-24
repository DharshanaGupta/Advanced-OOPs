using System;


namespace CafeCardmanagement
{
    public partial  class CustomList<Type>
    {
        //field
        private  int _count;
        private int _capacity;

        //property
        public int Count{get{return _count;}set{_count=value;}}
        public int Capacity{get{return _capacity;}set{_capacity=value;}}

        private Type[] _arr; //store the array values
        //indexers
        public Type this[int index]{get{return _arr[index];}set{_arr[index]=value;}}

        //constructor
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _arr=new Type[_capacity];
        }

        //if size defined
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _arr=new Type[_capacity];
        }

        //to add values to the List
        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _arr[_count]=element;
            _count++;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_arr[i];
            }
            _arr=temp;
        }

        public bool Contains(Type element)
        {
            bool temp=false;
            foreach(Type data in _arr)
            {
                if(data.Equals(element))
                {
                    temp=true;
                    break;
                }
            }
            return temp;
        }

        
    }
}