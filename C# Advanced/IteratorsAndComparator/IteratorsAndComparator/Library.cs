using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book> 
    {
        //----------------- Constructors ------------------
        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }
        //------------------ Properties -------------------
        public List<Book> Books { get; set; }
        //------------------- Methods ---------------------
        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                yield return Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
        //----------------- Nested Class ------------------
        private class LibraryIterator : IEnumerator<Book>
        {
            //-------------- Fields ----------------
            private int currentIndex = -1;
            private readonly List<Book> books;
            //----------- Constructors -------------
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }
            //------------ Properties --------------
            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex >= books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
               currentIndex = -1;
            }
        }
    }
}
