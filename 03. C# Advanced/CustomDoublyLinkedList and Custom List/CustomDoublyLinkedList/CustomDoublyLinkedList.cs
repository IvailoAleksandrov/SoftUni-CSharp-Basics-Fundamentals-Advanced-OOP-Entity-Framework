using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        //-------------- Private Class ---------------
        private class ListNode
        {
            //----------- Constructors ------------
            public ListNode(T value)
            {
                Value = value;
            }
            //------------ Propertirs -------------
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public T Value { get; set; }

        }
        //----------------- Fields -------------------
        private ListNode head;
        private ListNode tail;

        //--------------- Properties -----------------
        public int Count { get;private set; }

        //------------ Public Methods ----------------
        public void AddFirst(T element)
        {
            ListNode node = new ListNode(element);
            if (Count==0)
            {
                head = tail = node;
            }
            else
            {
                node.NextNode = head;
                head.PreviousNode = node;
            }
            Count++;
        }
        public void AddLast(T element)
        { 
            ListNode node = new ListNode(element);
            if (Count == 0)
            {
                head = tail = node;
            }
            else
            {
                node.PreviousNode = tail;
                tail.NextNode = node;
                tail = node;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count==0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }
            T removedElement = head.Value;
            ListNode node = head.NextNode;
            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                node.PreviousNode = null;
                head = node;
            }
            Count--;
            return removedElement;
        }

        public T RemoveLast()
        {
            if (Count==0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T removedElement = tail.Value;
            ListNode node = tail.PreviousNode;
            if (Count==1)
            {
                tail = head = null;
            }
            else
            {
                node.NextNode = null;
                tail = node;
            }
            Count--;
            return removedElement;
        }
        public void ForEach(Action<T> action, bool shouldStartHromHead)
        {
            ListNode node = head;
            if (!shouldStartHromHead)
            {
                node = head;
            }

            while (node != null)
            {
                action(node.Value);
                if (!shouldStartHromHead)
                {
                    node = node.PreviousNode;
                }
                else
                {
                    node = node.NextNode;
                }
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            ListNode node = head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = node.Value;
                node = node.NextNode;
            }
            return array;
        }
        
    }
}
