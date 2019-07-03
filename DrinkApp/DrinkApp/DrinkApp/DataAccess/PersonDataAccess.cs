using DrinkApp.Interfaces;
using DrinkApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DrinkApp.DataAccess
{
    public class PersonDataAccess
    {
        private SQLiteConnection database;
        private static object collitionLock = new object();

        public ObservableCollection<Person> People { get; set; } 

        public PersonDataAccess()
        {
            database = DependencyService.Get<IDatabaseConnection>().DBConnection();
            database.CreateTable<Person>();

            People = new ObservableCollection<Person>(database.Table<Person>());

            if (!database.Table<Person>().Any())
            {
                AddNewPerson();
            }
        }

        public IEnumerable<Person> GetPeopleByGroupId(int id)
        {
            lock (collitionLock)
            {
                var query = from person in database.Table<Person>()
                            where person.GroupId == id
                            select person;
                return query.AsEnumerable();
            }
        }

        public void AddNewPerson()
        {
            People.Add(new Person
            {
                Name = "Temp Name",
                Number = 100,
                GroupId = 1
            });
        }

        public void InsertPerson(Person p)
        {
            lock (collitionLock)
            {
                database.Insert(p);
            }
        }

        public void DeletePerson(Person p)
        {
            int id = p.Id;
            lock (collitionLock)
            {
                database.Delete<Person>(id);
            }
        }

        public void DeletePersonByGroupId(int id)
        {
            foreach(Person p in People)
            {
                if(p.GroupId == id)
                {
                    database.Delete<Person>(p.Id);
                }
            }
        }

        public void DropPersonTable()
        {
            lock (collitionLock)
            {
                database.DropTable<Person>();
                database.CreateTable<Person>();
            }
            People = null;
            People = new ObservableCollection<Person>(database.Table<Person>());
        }
    }
}
