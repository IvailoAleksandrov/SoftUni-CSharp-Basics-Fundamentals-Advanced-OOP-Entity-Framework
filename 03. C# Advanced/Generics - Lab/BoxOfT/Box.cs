using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        //------------------- Fields ---------------------
        private List<T> list;
        //---------------- Constructors ------------------
        public Box()
        {
            list = new List<T>();
        }
        //----------------- Properties -------------------
        public int Count => list.Count;
        //------------------ Methods ---------------------
        public void Add(T element)
        {
            list.Add(element);
        }
        public T Remove()
        {
            T removedElement = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return removedElement;
        }
    }
}
