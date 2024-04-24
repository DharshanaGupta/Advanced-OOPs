using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
namespace CafeCardmanagement
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
        int position=-1;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }

        public object Current{get{return _arr[position];}}
    }
}