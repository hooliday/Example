using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grid.Models
{
    public class Repository : IRepository
    {
        private List<Person> list;

        public Repository()
        {
            list = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                Person p = new Person();
                p.FirstName = $"First{i}"; p.LastName = $"Last{i}"; p.Age = i + 99;
                list.Add(p);
            }
        }

        public List<Person> GetPeople()
        {
            return list;
        }
    }
}
