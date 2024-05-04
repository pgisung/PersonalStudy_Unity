using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleGame
{
    class CustomLinkedListNode<T>
    {
        public T Data;
        public CustomLinkedListNode<T> Next;
        public CustomLinkedListNode<T> Prev;
    }

    internal class CustomLinkedList<T>
    {
        public CustomLinkedListNode<T> Head = null;
        public CustomLinkedListNode<T> Tail = null;
        public int Count = 0;

        public CustomLinkedListNode<T> AddLast(T data)
        {
            CustomLinkedListNode<T> newNode = new CustomLinkedListNode<T>();
            newNode.Data = data;

            if (Head == null)
                Head = newNode;

            if (Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
            }

            Tail  = newNode;
            Count++;

            return newNode;
        }

        public void Remove(CustomLinkedListNode<T> node)
        {
            if (Head == node)
                Head = Head.Next;

            if (Tail == node)
                Tail = Tail.Prev;

            if (node.Prev != null)
                node.Prev.Next = node.Next;

            if (node.Next != null)
                node.Next.Prev = node.Prev;

            Count--;
        }
    }
}
