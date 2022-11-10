using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssigment
{
    public class GenericArray<T>
    {
        private readonly T[] _items;
        private readonly int _maxSize;

        public GenericArray() 
        {
            _maxSize = 10;
            _items=new T[_maxSize];
        }

        public GenericArray(int maxSize)
        {
            _maxSize = maxSize;
            _items = new T[_maxSize];
        }

     

        public T Get(int index) {

            if (index < _maxSize)
            {
                if (index < 0)
                    throw new Exception("Invalid index");
                return _items[index];
            }
            else throw new Exception("Out of bounds index");
            
            
        }

        public void Set(int index, T item)
        {

            if (index < _maxSize)
            {
                if (index < 0)
                    throw new Exception("Invalid index");
                _items[index] = item;
            }
            else throw new Exception("Out of bounds index");
        }

        public void Swap(int index1, int index2) 
        {
            if (index1 < _maxSize && index2< _maxSize)
            {
                if (index1 < 0 || index2<0)
                    throw new Exception("Invalid index");
                T aux=_items[index1];
                _items[index1] = _items[index2];
                _items[index2] = aux;
            }
            else throw new Exception("Out of bounds index");
        }

        public void Swap(T item1, T item2)
        {
            int index1 = -1;
            int index2 = -1;
            for (int i= 0; i<_maxSize;i++) 
            {
                if (item1.Equals(_items[i]))
                    index1 = i;
                if (item2.Equals(_items[i]))
                    index2 = i;
            }
            if (index1 >= 0 && index2 >= 0)
            {
                T aux = _items[index1];
                _items[index1] = _items[index2];
                _items[index2] = aux;
            }
            else throw new Exception("Items not found!");

        }



    }
}
