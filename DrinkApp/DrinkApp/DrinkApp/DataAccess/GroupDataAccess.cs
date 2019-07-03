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
    public class GroupDataAccess
    {
        private SQLiteConnection database;
        private static object collitionLock = new object();

        public ObservableCollection<Group> Groups { get; set; }

        public GroupDataAccess()
        {
            database = DependencyService.Get<IDatabaseConnection>().DBConnection();
            database.CreateTable<Group>();

            Groups = new ObservableCollection<Group>(database.Table<Group>());

            if (!database.Table<Group>().Any())
            {
                InsertTempGroup();
            }
        }

        public void InsertGroup(Group g)
        {
            database.Insert(g);
            Groups = new ObservableCollection<Group>(database.Table<Group>());
        }

        public void DeleteGroup(Group group)
        {
            var id = group.Id;
            lock (collitionLock)
            {
                database.Delete<Group>(id);
            }
            Groups.Remove(group);
        }

        public void DeleteGroupTable()
        {
            lock (collitionLock)
            {
                database.DropTable<Group>();
                database.CreateTable<Group>();
            }
            Groups = null;
            Groups = new ObservableCollection<Group>(database.Table<Group>());
        }

        public void InsertTempGroup()
        {
            Groups.Add(new Group
            {
                GroupName = "TempGroup"
            });
        }
    }
}
