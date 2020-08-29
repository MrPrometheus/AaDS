using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsDataStructuresLibrary
{
    public class Stack124<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private int _count;
        public bool IsEmpty => _count == 0;
        public int Count => _count;
        public void PushNode(Node<T> node)
        {
            var previousNode = _head;
            _head = node;
            _head.Next = previousNode;
            _count++;
        }
        public void PushNodeRange(Node<T>[] nodes)
        {
            foreach (var node in nodes)
            {
                PushNode(node);
            }
        }
        public void Push(T item)
        {
            // увеличиваем стек и переустанавливаем верхушку стека на новый элемент
            var node = new Node<T>(item) {Next = _head};
            _head = node;
            _count++;
        }
        
        public void PushRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
        public Node<T> Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            
            Node<T> temp = _head;
            _head = _head.Next; // переустанавливаем верхушку стека на следующий элемент
            _count--;
            temp.Next = null;
            return temp;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            return _head.Data;
        }
 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}