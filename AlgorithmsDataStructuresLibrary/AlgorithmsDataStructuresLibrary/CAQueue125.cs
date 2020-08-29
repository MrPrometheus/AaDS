using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsDataStructuresLibrary
{
    public class CAQueue125<T> : IEnumerable<T>
    {
        private const int DEFAULT_CAPACITY = 8;
        private T[] _array;
        private int _size;  
        private int _capacity;
        private int _head;
        private int _tail;
        public CAQueue125(int size = DEFAULT_CAPACITY)
        {
            _capacity = size;
            _size = 0;
            _tail = 0;
            _head = -1;
            _array = new T[_capacity];
        }

        public int Count => _size;
        public bool IsEmpty() => _size == 0;
        public bool IsFull() => _size == _capacity;

        public void Enqueue(T newElement)
        {
            if (_size == _capacity) throw new InvalidOperationException();
            if (_tail >= _capacity) _tail = 0;

            _size++;
            _array[_tail++] = newElement;
        }

        public T Dequeue()
        {
            if (_size == 0) throw new InvalidOperationException();
            if (_head >= _capacity - 1) _head = -1;

            _size--;
            return _array[++_head];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var i = _head;
            while (i < _size + _head)
            {
                yield return _array[++i % _capacity];
            }
        }
    }
}