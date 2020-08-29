using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsDataStructuresLibrary
{
    public class Queue127<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;
        
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = _tail;
            _tail = node;
            if (_count == 0)
            {
                _head = _tail;
            }
            else
            {
                tempNode.Next = _tail;
            }
            _count++;
        }
        
        public Node<T> Dequeue()
        {
            if (_count == 0) throw new InvalidOperationException();

            Node<T> output = _head;
            _head = _head.Next;
            _count--;
            return output;
        }

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}