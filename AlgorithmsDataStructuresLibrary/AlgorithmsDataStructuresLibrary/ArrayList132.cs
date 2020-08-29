using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using AlgorithmsDataStructuresLibrary.TypeOfSort132;

namespace AlgorithmsDataStructuresLibrary
{
    public class ArrayList132<T> : IEnumerable<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private int _size;
        private T[] _items;
        private int _count;
        private ITypeSort<T> _typeSort;

        public ArrayList132(int capacity = DEFAULT_CAPACITY)
        {
            _count = 0;
            _size = capacity;
            _items = new T[_size];
            
            if (typeof(T) == typeof(int))
            {
                _typeSort = (ITypeSort<T>) new SortInt();
            }
            else if (typeof(T) == typeof(string))
            {
                _typeSort = (ITypeSort<T>) new SortString();
            }
            else
            {
                throw new ArgumentException("string or int");
            }
        }

        public int Count => _count;
        public bool IsFull => _count == _size;

        public T Last => _items[Count - 1];

        // Методы
        public void Add(T item)
        {
            if (_count > _size) throw new IndexOutOfRangeException();
            _typeSort.Sort(ref _items, item, _count);
            _count++;
        }
        
        public void Remove(T item)
        {
            int tempCount = -1;
            for(int i = 0; i < _items.Length; i++)
            {
                if(Equals(_items[i], item)) tempCount = i;
            }
            if (tempCount == - 1) throw  new InvalidDataException();
            
            RemoveAt(tempCount);
        }

        public bool Contains(T item)
        {
            foreach (var data in _items)
            {
                if(Equals(data, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            T[] newItems = new T[_items.Length];
            Array.Copy(_items, 0, newItems, 0, index);
            Array.Copy(_items, index + 1, newItems, index, _items.Length - 1 - index);
            _count--;
            _items = newItems;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for(int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }
    }
}