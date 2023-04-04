using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
     public class Family
    {
        private List<Person> people;
        private List<Person> peopleOverThirty;

        public Family()
        {
            this.people = new List<Person>();
        }

        public Family(List<Person> peopleOverThirty)
        {
            this.peopleOverThirty = new List<Person>();
        }

        public void AddMember(Person member)
        {
            if (member.Age < 30)
            {
                this.people.Add(member);
            }
            //if (member.Age)
            //{
            //    this.peopleOverThirty.Add(member);
            //}
            if (member.Age >= 30)
            {
                this.peopleOverThirty.Add(member);
            }
        }

        //public void AddMember(Person memberOlder)
        //{
        //    //if (member.Age < 30)
        //    //{
        //    //    this.people.Add(member);
        //    //}
        //    if (memberOlder.Age >= 30)
        //    {
        //        this.peopleOverThirty.Add(memberOlder);
        //    }
        //}

        //public Person GetOldestMember() 
        //{
        //    return this.people.OrderBy();
        //}

        public Person OverThirty()
        {
            return (Person)this.peopleOverThirty.OrderBy(p => p.Name);
        }
    }
}
