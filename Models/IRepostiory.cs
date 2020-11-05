using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grid.Models
{
    public interface IRepository
    {
        List<Person> GetPeople();
    }
}
