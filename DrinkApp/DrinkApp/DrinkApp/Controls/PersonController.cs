using DrinkApp.DataAccess;
using DrinkApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkApp.Controls
{
    public class PersonController
    {
        PersonDataAccess pDA;

        public PersonController()
        {
            pDA = new PersonDataAccess();
        }

        public IEnumerable<Person> GetPeopleByGroupId(int id)
        {
            return pDA.GetPeopleByGroupId(id);
        }

        public void InsertPerson(Person p)
        {
            pDA.InsertPerson(p);
        }

        public void DeletePerson(Person p)
        {
            pDA.DeletePerson(p);
        }

        public void DeletePersonByGroupId(int id)
        {
            pDA.DeletePersonByGroupId(id);
        }
    }
}
