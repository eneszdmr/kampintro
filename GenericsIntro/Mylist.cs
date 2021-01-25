using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mylist<Tip>
    {
        Tip[] _array;
        Tip[] _tempArray;
        public Mylist() //bu bir constructor yani aslında bir metod. YANİ class new lendiğinde direk bu metod çalışır
        {
            _array = new Tip[0];
        }
        public void Add(Tip item)
        {
            _tempArray = _array;

            _array = new Tip[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length;}
        }

      
    }
}
