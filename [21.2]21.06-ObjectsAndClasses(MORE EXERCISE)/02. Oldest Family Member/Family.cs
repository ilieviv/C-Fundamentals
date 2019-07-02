using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Oldest_Family_Member
{
    class Family
    {
        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public List<Person> familyMembers;
        public void AddMember(Person person)
        {
            this.familyMembers.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.familyMembers.OrderByDescending(p => p.Age).First();
        }
    }
}
