using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DrinkApp.Interfaces;
using DrinkApp.iOS;
using Foundation;
using SQLite;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DBConnection_iOS))]
namespace DrinkApp.iOS
{
    public class DBConnection_iOS : IDatabaseConnection
    {
        public SQLiteConnection DBConnection()
        {
            var dbName = "PeopleDb.db3";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}