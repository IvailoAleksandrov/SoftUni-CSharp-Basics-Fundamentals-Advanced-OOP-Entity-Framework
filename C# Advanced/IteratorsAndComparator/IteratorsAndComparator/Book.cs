using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private List<string> authors;
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            this.authors = new List<string>(authors);
        }

        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors
        {
            get { return authors.AsReadOnly(); }
        }

        public int CompareTo(Book other)
        {
            if (Year.CompareTo(other.Year) != 0)
            {
                return Year.CompareTo(other.Year);
            }
            return Title.CompareTo(other.Title);
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
