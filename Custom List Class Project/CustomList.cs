using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Class_Project
{
    public class CustomList<T> : IEnumerator   
    {
        T[] _items;
        T[] _newItems;
        int _capacity;
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        public T this [int i]
        {
            get 
            {
                if (i >= _count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return _items[i];
                }
            }
            set
            {
                _items[i] = value;
            }
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }
        public void Add(T item)
        {
            if (_count == _capacity)
            {
                T[] _newItems = new T[_capacity *= 2];
                T[] _items = _newItems;

                for (int i = 0; i <= _count; i++)
                {
                    if (_count == i)
                    {
                         _newItems[i] = item;
                    }
                    else
                    {
                        _newItems[i] = _items[i];
                    }
                }
                _items[_count] = item;
                _count++;
                
            }
        }





        public bool Remove(T item)
        {
            //remove item from list
            //first is the item in the list - make bool
            //
            T[] _newItems = new T[_capacity];
            bool isItemInList = false;
            for (int i = 0; i <= _count; i++)
            {
                if (_items[i].Equals(item) || isItemInList == true)
                {
                    isItemInList = true;

                    if (_items[i].Equals(item))
                    {
                        _count--;
                        continue;
                    }
                    else
                    {
                        _newItems[i - 1] = _items[i];
                    }
                }
                else
                {
                    _newItems[i] = _items[i];
                }
            }
            _items = _newItems;
            return isItemInList;

        }
        public static CustomList<T> operator -(CustomList<T> customList, CustomList<T> customList2)
        {
            CustomList<T> removedList = new CustomList<T>();

            for (int i = 0; i < customList._count; i++)
            {
                removedList.Add(customList._items[i]);

                for (int j = 0; j < customList2._count; j++)
                {
                    if (customList._items[i].Equals(customList2._items[j]))
                    {
                        removedList.Remove(customList._items[i]);
                    }
                }
            }

            return removedList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                yield return _items[i];
            }
        }
    }
}
