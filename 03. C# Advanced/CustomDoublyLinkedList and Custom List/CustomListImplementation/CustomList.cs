using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CustomListImplementation
{
    public class CustomList
    {
        private int[] elements;
        private int internalCounter;
        // Constructor
        public CustomList()
        {
            elements = new int[2];
            internalCounter = 0;
        }
        public int Count => internalCounter;

        public int this[int i]  // indexer
        {
            get
            {
                EnsureIsInRange(i);
                return elements[i];
            }
            set
            {
                EnsureIsInRange(i);
                elements[i] = value;
            }
        }

        private void EnsureIsInRange(int i)
        {
            if (i<0 || i >= internalCounter)
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Methods
        public void Add(int element)
        {
            Resize();
            elements[internalCounter] = element;
            internalCounter++;
        }
        public void Shrink()
        {
            int[] newArray = new int[internalCounter];

            for (int i = 0; i < internalCounter; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
        public int RemoveAt(int index)
        {
            EnsureIsInRange(index);
            int number = elements[index];
            internalCounter--;
            for (int i = index; i < internalCounter; i++)
            {
                elements[i] = elements[i + 1];
            }
            return number;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            EnsureIsInRange(firstIndex);
            EnsureIsInRange(secondIndex);

            int firstElement = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = firstElement;
        }

        private void Resize() 
        {
            if (elements.Length == internalCounter) // this means that array is full and we need to double it
            {
                int[] copyArray = new int[elements.Length*2];
                for (int i = 0; i < elements.Length; i++)
                {
                    copyArray[i] = elements[i];
                }
                elements = copyArray;
            }
        }
    }
}
