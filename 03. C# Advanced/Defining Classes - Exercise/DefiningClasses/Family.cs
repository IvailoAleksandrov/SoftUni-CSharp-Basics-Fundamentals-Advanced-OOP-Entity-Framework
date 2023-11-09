using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        // Constructor
        public Family()
        {
            People = new List<Person>();
        }
        // Properties
        public List<Person> People { get; private set; }
        // Methods
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
