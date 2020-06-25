using System;
using System.Collections.Generic;
using NetCore.AutoSort.Example.Model;

namespace NetCore.AutoSort.Example.InMemoryData
{
    public class PeopleCollection : List<Person>
    {
        public PeopleCollection()
        {
            Add(new Person("Chris", "Evans", new DateTime(1981, 6, 13)));
            Add(new Person("Robert", "Downey", new DateTime(1965, 4, 4)));
            Add(new Person("Jennifer", "Lawrence", new DateTime(1990, 8, 15)));
            Add(new Person("Channing", "Tatum", new DateTime(1965, 4, 4)));
            Add(new Person("Will", "Smith", new DateTime(1968, 9, 25)));
            Add(new Person("Alan", "Alda", new DateTime(1936, 1, 28)));
        }
    }
}